using Microsoft.AspNetCore.Mvc;
using RepairApp.Data;
using RepairApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepairApp.Areas.admin.Controllers
{
    [Area("admin")]
    public class BlogCategoryController : Controller
    {
        private readonly AppDbContext _context;

        public BlogCategoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category model)
        {
            _context.Categories.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
