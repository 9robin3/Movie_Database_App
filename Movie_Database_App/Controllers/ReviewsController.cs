using System.Linq;
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
        private readonly AppDbContext _dbContext;

        public ReviewsController(AppDbContext context)
        {
            _dbContext = context;
        }

        public string GetLoggedInUser()
        {
            return User.Identity.GetUserName();
        }

        // GET: Reviews
        public async Task<IActionResult> Index()
        {
            //GetLoggedInUser();
            return View(await _dbContext.Reviews.ToListAsync());
        }
        public async Task<IActionResult> ListReviews(int id)
        {
            return PartialView(await _dbContext.Reviews.Where(r => r.MovieID == id).ToListAsync());
        }

        // GET: Reviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _dbContext.Reviews
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
            rev.UserName = GetLoggedInUser();
            rev.MovieID = id;
            return View(rev);
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReviewID,UserName,MovieID,MovieObj,ReviewTitle,Rating,Comment,DatePosted")] Review review)
        {
            if (ModelState.IsValid)
            {
                review.UserName = GetLoggedInUser();
                //Review rev = new Review(id);
                _dbContext.Add(review);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(review);
        }

        // GET: Reviews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //string reviewAuthor = _dbContext.Reviews.Where(r => r.UserName == GetLoggedInUser() && r.ReviewID == id).FirstOrDefault().ToString();
            //if(reviewAuthor.Count() > 0)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var review = await _dbContext.Reviews.FindAsync(id);
                if (review == null)
                {
                    return NotFound();
                }
                return View(review);
            }
            //return RedirectToAction(nameof(Index));
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReviewID,UserName,MovieID,MovieObj,ReviewTitle,Rating,Comment,DatePosted")] Review review)
        {
            if (id != review.ReviewID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _dbContext.Update(review);
                    await _dbContext.SaveChangesAsync();
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
            string reviewAuthor = _dbContext.Reviews.Where(r => r.UserName == GetLoggedInUser() && r.ReviewID == id).FirstOrDefault().ToString();
            if (reviewAuthor.Count() > 0)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var review = await _dbContext.Reviews
                    .FirstOrDefaultAsync(m => m.ReviewID == id);
                if (review == null)
                {
                    return NotFound();
                }

                return View(review);
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var review = await _dbContext.Reviews.FindAsync(id);
            _dbContext.Reviews.Remove(review);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReviewExists(int id)
        {
            return _dbContext.Reviews.Any(e => e.ReviewID == id);
        }
    }
}
