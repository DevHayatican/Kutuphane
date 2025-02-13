using Kütüphane.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane.database
{
    internal class MsDBContext
    {
        static List<Customer> customers = new List<Customer>();

        static List<Admin> admins = new List<Admin>();

        static List<Kitap> kitaps = new List<Kitap>();

        internal void kaydet(Customer customer)
        {
            customers.Add(customer);
        }
        public List<Customer> müsteriListesiGetir()
        {
            return customers;
        }

        internal void adminKaydet(Admin admin)
        {
            admins.Add(admin);
        }

        public List<Admin> adminListesiGetir()
        {
            return admins;
        }

        internal void kitapKaydet(Kitap kitap)
        {
            kitaps.Add(kitap);
        }

        public List<Kitap> kitapListesiniGetir()
        {
            return kitaps;
        }
    }
}
