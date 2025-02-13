using Kütüphane.entity;

namespace Kütüphane.service.interfaceler
{
    internal interface IAdminService
    {
        public void adminKaydet(string ad, string soyad, string email, string password);


        List<Admin> adminListele();

    }
}
