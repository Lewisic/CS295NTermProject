using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TermProject295N.Models
{
    public class SeedData
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.HomebrewItems.Any())
            {
                Homebrew item = new Homebrew
                {
                    ItemName = "Ring of Electric Power",
                    ItemRarity = "Uncommon",
                    ItemType = "Ring",
                    ItemEffect = "Allows you to cast Shocking grasp at will.",
                    Attunement = false,
                    UserName = "Ardwen",
                    DateAdded = DateTime.Parse("10/28/2022")
                };
                context.HomebrewItems.Add(item);

                item = new Homebrew
                {
                    ItemName = "Boots of the Frozen Path",
                    ItemRarity = "Uncommon",
                    ItemType = "Wondrous Item",
                    ItemEffect = "You freeze the ground beneath your feet leaving temporary frost behind you additionally this allows you to walk on water as you freeze the water you walk on.",
                    Attunement = true,
                    UserName = "Isaac",
                    DateAdded = DateTime.Parse("10/12/2022")
                };
                context.HomebrewItems.Add(item);

                item = new Homebrew
                {
                    ItemName = "Mace of Rodent Slaying",
                    ItemRarity = "Rare",
                    ItemType = "Weapon",
                    ItemEffect = "This mace has the power to strike vermin from the face of the planet. You deal 1d4 additional damage when fighting rodents or rat men.",
                    Attunement = true,
                    UserName = "Isaac",
                    DateAdded = DateTime.Parse("11/06/2022")
                };
                context.HomebrewItems.Add(item);

                context.SaveChanges();
            }
        }
    }
}
