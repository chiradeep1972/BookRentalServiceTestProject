using System;
using System.Collections.Generic;

namespace BookRentalServiceTestProject.Models
{
    public partial class TblBook
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public long Isbn { get; set; }
        public string? Genre { get; set; }
    }
}
