using System;
using System.ComponentModel.DataAnnotations;

namespace TermProject295N.Models
{
    public class Homebrew
    {
        [Key]
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemRarity { get; set; }
        public string ItemType { get; set; }
        public string ItemEffect { get; set; }
        public bool Attunement { get; set; }
        public string UserName { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
