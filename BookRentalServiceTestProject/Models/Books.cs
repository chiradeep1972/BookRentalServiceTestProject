using System;
using System.Collections.Generic;
using System.Numerics;
namespace BookRentalServiceTestProject.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Auther { get; set; } = null!;
        public int ISBN   { get; set; }
        public string Genre { get; set; }
    }
}
