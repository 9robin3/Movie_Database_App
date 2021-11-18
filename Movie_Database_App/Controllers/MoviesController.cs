using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
//using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Movie_Database_App.Data;
using Movie_Database_App.Models;

namespace Movie_Database_App.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _DbContext;

        public MoviesController(AppDbContext context)
        {
            _DbContext = context;
        }

        public string GetLoggedInUser()
        {
            return User.FindFirst(ClaimTypes.Email).Value;
        }

        // GET: Movies
        public async Task<IActionResult> Index()
        {
            
            return View(await _DbContext.Movies.ToListAsync());
        }

        public async Task<IActionResult> ListReviews(int? id)
        {
            return PartialView(await _DbContext.Reviews.Where(r => r.MovieID == id).ToListAsync());
        }

        public async Task<IActionResult> ListWatchList()
        {
            AppUser user = _DbContext.Users.FirstOrDefault(u => u.Email == User.FindFirst(ClaimTypes.Email).Value);
            List<Movie> watchList = new List<Movie>();
            watchList = user.WatchList;

            return View(watchList);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> AddToWatchList(int? id, Movie mov)
        {
            AppUser user = _DbContext.Users.FirstOrDefault(u => u.Email == User.FindFirst(ClaimTypes.Email).Value);
            user.WatchList.Add(mov);
            
            System.Diagnostics.Debug.WriteLine(mov);
            System.Diagnostics.Debug.WriteLine(user);
            //return View(ListWatchList());
            //return PartialView(user.WatchList.Where(u => u.Equals(GetLoggedInUser())).ToList());
            return RedirectToAction(nameof(ListWatchList));
            //return RedirectToPage("~/Areas/Pages/Account/Index.cshtml");
        }

        public async Task<IActionResult> RemoveFromWatchList(int? id, Movie mov)
        {
            AppUser user = _DbContext.Users.FirstOrDefault(u => u.Email == User.FindFirst(ClaimTypes.Email).Value);
            user.WatchList.Remove(mov);
            System.Diagnostics.Debug.WriteLine(mov);
            System.Diagnostics.Debug.WriteLine(user);
            //return PartialView(user.WatchList.Where(u => u.Equals(GetLoggedInUser())).ToList());
            return RedirectToAction(nameof(Index));
            //return RedirectToPage("~/Areas/Pages/Account/Index.cshtml");
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            
            if (id == null)
            {
                return NotFound();
            }
            await ListReviews(id);
            //var revs = await _DbContext.Reviews.Where(r => r.MovieID == id).ToListAsync();
            var movie = await _DbContext.Movies.Include(m => m.ReviewsList)
                .FirstOrDefaultAsync(m => m.MovieID == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MovieID,Title,RunningTime,Description")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                _DbContext.Add(movie);
                await _DbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        public async Task<IActionResult> Search(string search)
        {
            //if (String.IsNullOrEmpty(search))
            //{
            //    return PartialView("_Search", await _context.Movies.ToListAsync());
            //}
            //else
            //{
            if (search.Count() == 0)
            {
                return PartialView("NoSearchResult");
            }

            ////Liknande logik för review listan??? Review where movie ID = this?
            return View("_Search", await _DbContext.Movies.
                    Where(mov => mov.Title.Contains(search)).ToListAsync());

        }

        //public ActionResult CreateReview(Movie movie)
        //{
        //    Review rev = new Review(movie);
        //   // return View(movie);
        //    return PartialView("~/Views/Reviews/Create.cshtml", rev);
        //}

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _DbContext.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MovieID,Title,RunningTime,Description")] Movie movie)
        {
            if (id != movie.MovieID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _DbContext.Update(movie);
                    await _DbContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.MovieID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _DbContext.Movies
                .FirstOrDefaultAsync(m => m.MovieID == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _DbContext.Movies.FindAsync(id);
            _DbContext.Movies.Remove(movie);
            await _DbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool MovieExists(int id)
        {
            return _DbContext.Movies.Any(e => e.MovieID == id);
        }
    }
}
