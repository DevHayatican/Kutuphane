using Kütüphane.entity;


namespace Kütüphane.service.interfaceler
{
    internal interface IKitapService
    {
        public void kitapEkle(string name, string author, int pageCount, int stock);

        
        List<Kitap> kitapListele();
    }
}
