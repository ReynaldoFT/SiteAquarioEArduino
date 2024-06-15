using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SiteAquario.Models
{
    public class ValoresController : Controller
    {
        // GET: ValoresController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ValoresController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ValoresController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ValoresController/Create
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

        // GET: ValoresController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ValoresController/Edit/5
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

        // GET: ValoresController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ValoresController/Delete/5
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
