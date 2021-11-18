using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Movie_Database_App.Data;
using Movie_Database_App.Models;

namespace Movie_Database_App.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly AppDbContext _DbContext;

        public ReviewsController(AppDbContext context)
        {
            _DbContext = context;
        }

        public string GetUserEmail()
        {
            return User.FindFirst(ClaimTypes.Email).Value;
        }

        // GET: Reviews
        public async Task<IActionResult> Index()
        {
            //GetLoggedInUser();
            return View(await _DbContext.Reviews.ToListAsync());
        }
        public async Task<IActionResult> ListReviews(int id)
        {
            return PartialView(await _DbContext.Reviews.Where(r => r.MovieID == id).ToListAsync());
        }

        // GET: Reviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _DbContext.Reviews
                .FirstOrDefaultAsync(m => m.ReviewID == id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }

        // GET: Reviews/Create
        [Authorize]
        public IActionResult Create(int id)
        {
            //string userName = GetLoggedInUser();
            Review rev = new Review();
            rev.UserName = GetUserEmail();
            rev.MovieID = id;
            return View(rev);
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReviewID,MovieID,MovieObj,UserName,ReviewTitle,Rating,Comment,DatePosted")] Review review)
        {
            if (ModelState.IsValid)
            {
                review.UserName = GetUserEmail();
                //Review rev = new Review(id);
                _DbContext.Add(review);
                await _DbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(review);
        }

        // GET: Reviews/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _DbContext.Reviews.FindAsync(id);
            //AppUser user = await _DbContext.Users.FirstOrDefaultAsync(u => u.Email == review.UserName);
            if(review.UserName == GetUserEmail())
            {
                if (review == null)
                {
                    return NotFound();
                }
                return View(review);
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
            //return RedirectToAction(nameof(Index)); 
       
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReviewID,MovieID,MovieObj,UserName,ReviewTitle,Rating,Comment,DatePosted")] Review review)
        {
            if (id != review.ReviewID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _DbContext.Update(review);
                    await _DbContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReviewExists(review.ReviewID))
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
            return View(review);
        }

        // GET: Reviews/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            //AppUser user = await _DbContext.Users.FirstOrDefaultAsync(u => u.Email == GetUserEmail());
            //string reviewAuthor = _DbContext.Reviews.FirstOrDefaultAsync(r => r.UserName == user.Email).ToString();
            
            if(id == null)
            {
                return NotFound();
            }

            var review = await _DbContext.Reviews.FindAsync(id);
            //var review = await _DbContext.Reviews
            //    .FirstOrDefaultAsync(m => m.ReviewID == id);
            if (review.UserName == GetUserEmail())
            {
                if (review == null)
                {
                    return NotFound();
                 }
                return View(review);
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }

        }

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var review = await _DbContext.Reviews.FindAsync(id);
            _DbContext.Reviews.Remove(review);
            await _DbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReviewExists(int id)
        {
            return _DbContext.Reviews.Any(e => e.ReviewID == id);
        }
    }
}
