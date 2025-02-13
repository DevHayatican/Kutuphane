using Kütüphane.controller;
using Kütüphane.database;
using Kütüphane.entity;

namespace Kütüphane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerController customerController = new CustomerController();
            AdminController adminController = new AdminController();
            KitapController kitapController = new KitapController();


            customerController.Kaydet("Can", "öcal", "can@gmail.com", "1657");

            adminController.adminKaydet("Ali", "Koç", "ali@gmail.com", "1907");

            kitapController.kitapEkle("Roman", "Yaşar Kemal", 500, 100);

            customerController.kullaniciListele().ForEach(x => Console.WriteLine(x.Name + " " + x.Surname
                + " " + x.Email + " " + x.Password));

            adminController.adminListele().ForEach(x => Console.WriteLine(x.Name + " " + x.Surname
               + " " + x.Email + " " + x.Password));
            kitapController.kitapListele().ForEach(x => Console.WriteLine(x.Name + " " + x.Author + " " + x.PageCount + " "
                + x.Stock));

        }
    }
}
