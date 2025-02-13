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
    internal class AdminService : IAdminService
    {

        MsDBContext adminDB = new MsDBContext();
        public void adminKaydet(string ad, string soyad, string email, string password)
        {
            Admin admin = new Admin(ad,soyad,email,password);

            adminDB.adminKaydet(admin);
        }


        public List<Admin> adminListele()
        {
            return adminDB.adminListesiGetir();

        }

    }
}
