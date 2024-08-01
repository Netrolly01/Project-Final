using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolActivityApp.webApp.Controllers
{
    public class EnrollmentsController : Controller
    {
        // GET: EnrollmentsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EnrollmentsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EnrollmentsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EnrollmentsController/Create
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

        // GET: EnrollmentsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EnrollmentsController/Edit/5
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

        // GET: EnrollmentsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EnrollmentsController/Delete/5
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
