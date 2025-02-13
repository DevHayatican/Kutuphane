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
    internal class AdminController
    {
        AdminService adminService = new AdminService();
        public void adminKaydet(string ad, string soyad, string email, string password)
        {
            adminService.adminKaydet(ad, soyad, email, password);
        }


        public List<Admin> adminListele()
        {
           return adminService.adminListele();
        }

    }
}
