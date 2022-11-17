using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TermProject295N.Models;
using TermProject295N.Repos;

namespace TermProject295N.Controllers
{
    public class HomebrewController : Controller
    {
        IHomebrewRepository repo;
        public HomebrewController(IHomebrewRepository r)
        {
            repo = r;
        }

        public IActionResult Index()
        {
            List<Homebrew> homebrewItems = repo.HomebrewItems.ToList<Homebrew>();
            return View(homebrewItems);
        }

        [HttpPost]
        public IActionResult Index(string itemName, string userName)
        {
            List<Homebrew> homebrewItems = null;

            if(itemName != null)
            {
                homebrewItems = (from r in repo.HomebrewItems where r.ItemName == itemName select r).ToList();
            }
            else if (userName != null)
            {
                homebrewItems = (from r in repo.HomebrewItems where r.UserName == userName select r).ToList();
            }
            return View(homebrewItems);
        }

        public IActionResult Item()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Item(Homebrew model)
        {
            model.DateAdded = DateTime.Now.Date;
            repo.AddHomebrewItem(model);
            return View(model);
        }
    }
}
