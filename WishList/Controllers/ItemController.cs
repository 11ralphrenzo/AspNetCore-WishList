using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WishList.Data;
using WishList.Models;

namespace WishList.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            var items = this._context.Items.ToList();
            return View("Index", items);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(Item item)
        {
            this._context.Items.Add(item);
            this._context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var item = this._context.Items.FirstOrDefault(x => x.Id == id);
            this._context.Items.Remove(item);
            this._context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
