using TermProject295N.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TermProject295N.Repos
{
    public class FakeHomebrewRepository : IHomebrewRepository
    {
        List<Homebrew> homebrewItems = new List<Homebrew>();

        public IQueryable<Homebrew> HomebrewItems
        {
            get { return homebrewItems.AsQueryable<Homebrew>(); }
        }

        public void AddHomebrewItem(Homebrew item)
        {
            item.ItemID = homebrewItems.Count;
            homebrewItems.Add(item);
        }
    }
}
