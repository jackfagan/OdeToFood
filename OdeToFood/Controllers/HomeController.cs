using OdeToFood.Models;
using OdeToFood.Models.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        OdeToFoodDb _db = new OdeToFoodDb();


        public ActionResult Index()
        {
            var viewModel = new HomeViewModel();
            viewModel.TopRatedReview = _db.Reviews.OrderByDescending(x => x.Rating)/*.ThenBy(x => x.Name)*/.FirstOrDefault();
            viewModel.RecentRatedReview = _db.Restaurants.OrderByDescending(r => r.LastUpdatedDateTime).FirstOrDefault();


            //viewmodel.topratedpub = _db.reviews.max(rating);

            return View(viewModel);
        }

        public ActionResult About()
        {
            var model = new AboutModel();
            model.Name = "Jack";
            model.Location = "London, UK";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}