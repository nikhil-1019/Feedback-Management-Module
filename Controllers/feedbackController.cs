using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using feedback1.Models;

namespace feedback1.Controllers
{
    public class feedbackController : Controller
    {
        // Demonstration storage only. Data is lost when the application restarts.
        private static readonly List<Feedback> feedbackList = new List<Feedback>();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Feedback());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedbackList.Add(feedback);
                return RedirectToAction("ViewFeedback");
            }

            return View(feedback);
        }

        public ActionResult ViewFeedback()
        {
            return View(feedbackList.ToList());
        }
    }
}
