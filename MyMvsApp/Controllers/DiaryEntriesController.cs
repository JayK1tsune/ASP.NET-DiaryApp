using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyMvsApp.Data;
using MyMvsApp.Models;

namespace MyMvsApp.Controllers
{

    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<DiaryEntriesController> _logger;

        public DiaryEntriesController(ApplicationDbContext context, ILogger<DiaryEntriesController> logger)
        {
            _context = context;
            _logger = logger;
        }


        public IActionResult Index()
        {
            List<DiaryEntry> entries = _context.DiaryEntries.ToList();
            return View(entries);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DiaryEntry obj)
        {
            _context.DiaryEntries.Add(obj); // Add the object to the database
            _context.SaveChanges(); // Save the changes
            return RedirectToAction("Index"); // send the user back to the Index page of current controller
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}