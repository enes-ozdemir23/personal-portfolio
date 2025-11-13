using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T t);
        void TDelete(T t);

        void TUpdate(T t);

        List<T> TGetList();

        T TGetByID(int id);
        // id parametresini al, geriye T tipinde bir nesne döndür.
        // T metodun türüdür. int ve string gibi
        // TGetById Bizim yazdığımz fonksiondur
        // GetList'te bizim yazdığımız bir fonksiyondur
        // List ise bir VeriTipidir. Tabloları içerir. örneğin personel tablosu
        // Bu metot, veritabanındaki tek bir kaydı ID’sine göre getirmek içindir.
        // T → dönecek nesnenin türü
        // int id → aranan nesnenin kimlik numarası
        // T Bir tablodur ürünler siparişler vb...
        // yukarıdaki tüm fonksiyonları biz oluşturduk
    }
}
