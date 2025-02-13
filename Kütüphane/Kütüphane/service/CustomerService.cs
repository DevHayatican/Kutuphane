using Kütüphane.database;
using Kütüphane.entity;
using Kütüphane.service.interfaceler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane.service
{
    internal class CustomerService : ICustomerService
    {
        MsDBContext customerDB = new MsDBContext();
      
        public void Kaydet(string ad, string soyad, string mail, string password)
        {          
            Customer customer = new Customer(ad, soyad, mail, password);

            customerDB.kaydet(customer);
        }

        public List<Customer> kullaniciListele()
        {
            return customerDB.müsteriListesiGetir();
        }
    }
}
