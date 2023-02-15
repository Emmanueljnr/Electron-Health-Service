using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElectronAPI.Controllers
{
    public class InstitutionsController : Controller
    {
        // GET: InstitutionsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: InstitutionsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InstitutionsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InstitutionsController/Create
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

        // GET: InstitutionsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InstitutionsController/Edit/5
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

        // GET: InstitutionsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InstitutionsController/Delete/5
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
