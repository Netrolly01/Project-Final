using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolActivityApp.webApp.Controllers
{
    public class SchedulesController : Controller
    {
        // GET: SchedulesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SchedulesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SchedulesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SchedulesController/Create
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

        // GET: SchedulesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SchedulesController/Edit/5
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

        // GET: SchedulesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SchedulesController/Delete/5
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
