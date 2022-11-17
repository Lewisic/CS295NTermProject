using TermProject295N.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TermProject295N.Repos
{
    public interface IHomebrewRepository
    {
        IQueryable<Homebrew> HomebrewItems { get; }
        void AddHomebrewItem(Homebrew item);
    }
}
