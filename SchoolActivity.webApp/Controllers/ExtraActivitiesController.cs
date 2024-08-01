using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolActivityApp.webApp.Controllers
{
    public class ExtraActivitiesController : Controller
    {
        // GET: ExtraActivitiesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ExtraActivitiesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExtraActivitiesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExtraActivitiesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ExtraActivitiesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExtraActivitiesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ExtraActivitiesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExtraActivitiesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
