using Microsoft.AspNetCore.Mvc;
using LuminaMvc.Data;
using LuminaMvc.Models;

namespace LuminaMvc.Controllers
{
    public class ServicesController : Controller
    {
        private readonly AppDbContext _context;

        public ServicesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Services (READ Operation)
        public IActionResult Index()
        {
            var services = _context.Services.ToList();
            return View(services);
        }

        // GET: Services/Create (Show the form)
        public IActionResult Create()
        {
            return View();
        }

        // POST: Services/Create (CREATE Operation)
        [HttpPost]
        public IActionResult Create(Service service)
        {
            if (ModelState.IsValid)
            {
                _context.Services.Add(service);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(service);
        }
    }
}