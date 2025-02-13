using Kütüphane.entity;
using Kütüphane.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane.controller
{
    internal class KitapController
    {
        KitapService kitapService = new KitapService();

        public void kitapEkle(string name, string author, int pageCount, int stock)
        {
           kitapService.kitapEkle(name, author, pageCount, stock);
           
        }

        public List<Kitap> kitapListele()
        {
            return kitapService.kitapListele();
        }
    }
}
