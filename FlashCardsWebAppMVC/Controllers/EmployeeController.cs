using FlashCardsWebApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace FlashCardsWebApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var employees = _context.Employees.ToList();

            ViewBag.Employees = employees;

            return View();
        }
    }
}
