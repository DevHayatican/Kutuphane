using Kütüphane.entity;

namespace Kütüphane.service.interfaceler
{
    internal interface ICustomerService
    {
        public void Kaydet(string ad, string soyad, string mail, string password);


        List<Customer> kullaniciListele();


    }
}
