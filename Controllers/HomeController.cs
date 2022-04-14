using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            ViewBag.X = _context.Leagues.OrderBy(Y => Y.Name).ToList();

            ViewBag.Y = _context.Leagues.OrderByDescending(Y => Y.Name).ToList();

            ViewBag.AllWomensLeagues = _context.Leagues
                .Where(l => l.Name.Contains("Women"))
                .ToList();

            ViewBag.AllLeaguesWhereSportIsAnyTypeOfHockey = _context.Leagues
                .Where(l => l.Name.Contains("Hockey"))
                .ToList();

            ViewBag.AllLeaguesWhereSportIsSomethingOtherThanFootball = _context.Leagues
                .Where(l => l.Sport != "Football")
                .ToList();

            ViewBag.L1_6 = _context.Leagues
                .Where(l => l.Name.Contains("Conference"))
                .ToList();

            ViewBag.SelectLeagues = _context.Leagues.Select(g => g.Sport);

            ViewBag.BSports = _context.Leagues.ToList().Where(x => x.Sport[0] == 'B');

    
            ViewBag.L1_9 = _context.Leagues
                .Where(l => l.Name.Contains("Atlantic"))
                .ToList();
    
            ViewBag.L1_10 = _context.Teams
                .Where(l => l.Location.Contains("Dallas"))
                .ToList();
    
            ViewBag.L1_11 = _context.Teams
                .Where(l => l.TeamName.Contains("Raptors"))
                .ToList();


            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}