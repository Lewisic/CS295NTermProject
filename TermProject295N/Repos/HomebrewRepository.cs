using TermProject295N.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TermProject295N.Repos
{
    public class HomebrewRepository : IHomebrewRepository
    {
        private ApplicationDbContext context;

        public HomebrewRepository(ApplicationDbContext c)
        {
            context = c;
        }
        public IQueryable<Homebrew> HomebrewItems
        {
            get
            {
                return context.HomebrewItems;
            }
        }

        public void AddHomebrewItem(Homebrew item)
        {
            context.HomebrewItems.Add(item);
            context.SaveChanges();
        }
    }
}
