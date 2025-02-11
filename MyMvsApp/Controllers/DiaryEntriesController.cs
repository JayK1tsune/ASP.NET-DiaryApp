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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}