using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane.entity
{
    internal class Kitap
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public int PageCount { get; set; }

        public int Stock { get; set; }

        public Kitap(string Name, string Author, int PageCount, int Stock)
        {
            this.Name = Name;
            this.Author = Author;
            this.PageCount = PageCount;
            this.Stock = Stock;
        
        }

    }
}
