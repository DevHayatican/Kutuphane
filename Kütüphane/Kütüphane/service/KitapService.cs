using Kütüphane.database;
using Kütüphane.entity;
using Kütüphane.service.interfaceler;


namespace Kütüphane.service
{
    internal class KitapService : IKitapService
    {
        MsDBContext kitapDB = new MsDBContext();

        public void kitapEkle(string name, string author, int pageCount, int stock)
        {
            Kitap kitap = new Kitap(name, author, pageCount, stock);

            kitapDB.kitapKaydet(kitap);
        }

      
        public List<Kitap> kitapListele()
        {
            return kitapDB.kitapListesiniGetir();
        }
    }
}
