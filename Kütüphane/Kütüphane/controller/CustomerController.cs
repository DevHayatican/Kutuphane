using Kütüphane.database;
using Kütüphane.entity;
using Kütüphane.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane.controller
{
    internal class CustomerController
    {
        CustomerService customerService = new CustomerService();
        public void Kaydet(string ad, string soyad, string mail, string password)
        {
            customerService.Kaydet(ad, soyad, mail, password);
        }


        public List<Customer> kullaniciListele()
        {
            return customerService.kullaniciListele();
        }
    }
}
