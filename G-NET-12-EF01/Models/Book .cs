using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_EF01.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string ISBNnumber { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPage { get; set; }
        public int Year { get; set; }
        public bool InStock { get; set; }
    }
}
