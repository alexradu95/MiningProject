using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiningProject.DataContexts;
using MiningProject.Models;

namespace MiningProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly TruckLocationDbContext _context;

        public HomeController(TruckLocationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["TrucksNumber"] = (from m in _context.Trucks select m).Count();
            ViewData["LocationsNumber"] = (from m in _context.Locations select m).Count();
            ViewData["HistoryEntries"] = (from m in _context.Histories select m).Count();
            return View();
        }

        public IActionResult ShipmentsNumber()
        {
            return View();
        }

        public IActionResult ActiveLocations()
        {
            ViewData["Message"] = "43";

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
