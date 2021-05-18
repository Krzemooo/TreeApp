using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TreeApp.Core;
using TreeApp.Models;

namespace TreeApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DBCoreContext _context;

        public HomeController(ILogger<HomeController> logger, DBCoreContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<JsonResult> GetTreeItems()
        {
            TreeCore treeCore = new TreeCore(_context);
            List<Core.Models.Tree> _allTree = await treeCore.GetAllTreeAsync();

            return Json(_allTree);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
