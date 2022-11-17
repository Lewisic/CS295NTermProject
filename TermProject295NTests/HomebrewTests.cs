using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TermProject295N.Controllers;
using TermProject295N.Models;
using TermProject295N.Repos;
using Xunit;

namespace TermProject295NTests
{
    public class HomebrewTests
    {
        [Fact]
        public void AddHomebrewItemTest()
        {
            var fakeRepo = new FakeHomebrewRepository();
            var controller = new HomebrewController(fakeRepo);
            var item = new Homebrew()
            {
                ItemName = "Wand of testing",
                ItemRarity = "Legendary",
                ItemType = "Wondrous Item",
                ItemEffect = "Can perform unit tests twice a day",
                Attunement = false,
                UserName = "TheBest"
            };

            controller.Item(item);

            var retrievedItem = fakeRepo.HomebrewItems.ToList()[0];
            Assert.Equal(retrievedItem.ItemName, "Wand of testing");
        }

        [Fact]
        public async void HomebrewItemNameFilterTest()
        {
            var fakeRepo = new FakeHomebrewRepository();
            var controller = new HomebrewController(fakeRepo);
            var item = new Homebrew()
            {
                ItemName = "Wand of testing",
                ItemRarity = "Legendary",
                ItemType = "Wondrous Item",
                ItemEffect = "Can perform unit tests twice a day",
                Attunement = false,
                UserName = "TheBest"
            };

            controller.Item(item);
            item = new Homebrew()
            {
                ItemName = "Wand of resting",
                ItemRarity = "Legendary",
                ItemType = "Wondrous Item",
                ItemEffect = "This wand can sleep for 8 hours a day",
                Attunement = false,
                UserName = "TheBest"
            };
            controller.Item(item);

            item = new Homebrew()
            {
                ItemName = "Wand of besting",
                ItemRarity = "Legendary",
                ItemType = "Wondrous Item",
                ItemEffect = "This wand always wins",
                Attunement = false,
                UserName = "TheWorst"
            };
            controller.Item(item);

            var viewResult = (ViewResult)controller.Index("Wand of resting", null);

            var reviews = (List<Homebrew>)viewResult.ViewData.Model;
            Assert.Equal(1, reviews.Count);
            Assert.Equal(reviews[0].ItemName, "Wand of resting");
        }

        [Fact]
        public async void HomebrewItemUserNameFilterTest()
        {
            var fakeRepo = new FakeHomebrewRepository();
            var controller = new HomebrewController(fakeRepo);
            var item = new Homebrew()
            {
                ItemName = "Wand of testing",
                ItemRarity = "Legendary",
                ItemType = "Wondrous Item",
                ItemEffect = "Can perform unit tests twice a day",
                Attunement = false,
                UserName = "TheBest"
            };

            controller.Item(item);
            item = new Homebrew()
            {
                ItemName = "Wand of resting",
                ItemRarity = "Legendary",
                ItemType = "Wondrous Item",
                ItemEffect = "This wand can sleep for 8 hours a day",
                Attunement = false,
                UserName = "TheBest"
            };
            controller.Item(item);

            item = new Homebrew()
            {
                ItemName = "Wand of besting",
                ItemRarity = "Legendary",
                ItemType = "Wondrous Item",
                ItemEffect = "This wand always wins",
                Attunement = false,
                UserName = "TheWorst"
            };
            controller.Item(item);

            var viewResult = (ViewResult)controller.Index(null, "TheBest");

            var reviews = (List<Homebrew>)viewResult.ViewData.Model;

            Assert.Equal(2, reviews.Count);
            Assert.Equal(reviews[0].ItemName, "Wand of testing");
            Assert.Equal(reviews[0].UserName, "TheBest");
        }
    }
}
