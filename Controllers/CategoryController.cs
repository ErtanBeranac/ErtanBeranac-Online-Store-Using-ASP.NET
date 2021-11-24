using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly Data.AplicationDbContext _db;
        public CategoryController(Data.AplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Models.Category> objList = _db.Categories;
            return View(objList);
        }
    }
}
