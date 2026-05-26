using Microsoft.AspNetCore.Mvc;
using ExpenseTracker.Data;
using ExpenseTracker.Models;

namespace ExpenseTracker.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly AppDbContext _context;

        public ExpenseController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var expenses = _context.Expenses.ToList();

            ViewBag.Total =
            expenses.Sum(x => x.Amount);

            return View(expenses);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Expense expense)
        {
            if(ModelState.IsValid)
            {
                _context.Expenses.Add(expense);

                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(expense);
        }

        public IActionResult Edit(int id)
        {
            var expense =
            _context.Expenses.Find(id);

            return View(expense);
        }

        [HttpPost]
        public IActionResult Edit(Expense expense)
        {
            _context.Expenses.Update(expense);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var expense =
            _context.Expenses.Find(id);

            _context.Expenses.Remove(expense);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
