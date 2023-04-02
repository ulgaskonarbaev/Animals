using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Animals.Models;
using Animals.Controllers;

namespace Animals.Controllers
{
    public class DogController : Controller
    {
        private DogContext _db;

        public DogController(DogContext db)
        {
            _db = db;
        }

        // GET: DogController
        public IActionResult Index()
        {
            List<Dog> phones = _db.Phones.ToList();
            return View(phones);
        }
        [HttpPost]
        public IActionResult Add(Dog phone)
        {
            if (phone != null)
            {
                _db.Phones.Add(phone);
                _db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            return View();
        }

        // GET: DogController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DogController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DogController/Create
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

        // GET: DogController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DogController/Edit/5
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

        // GET: DogController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DogController/Delete/5
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
