using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
        // About'tan miras alındığı için GenericService'de ki T=about oluyor
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        // IAboutDal Alanını kullanabilmek için bir nesne(aboutDal) tanımladık
        public List<About> TGetList()
        {
            _aboutDal.Getlist();
            return _aboutDal.Getlist();
        }

        public void TAdd(About t)
        {
            _aboutDal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public About TGetByID(int id)
        {
            return _aboutDal.GetByID(id);
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }

        public List<About> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}




//                      BAĞIMLILIK ENJEKSİYONU
//Business katmanında, veritabanına (ya da DataAccess katmanına) erişebilmek için bu
//IAboutDal arayüzünü kullanıyoruz.
//Ama bunu doğrudan new’leyemediğimiz için(çünkü interface’tir), constructor injection 
//(yani bağımlılık enjeksiyonu) denilen bir yöntem kullanıyoruz.
//Business katmanında, veritabanına dokunmak istemeyiz — sadece iş kuralları yazmak isteriz.
//Yani doğrudan SQL ya da DbContext kodları yazmayız.
//constructor DataAccess katmanını Business’a enjekte eder.
//Böylelikle IGenericDal'daki metodlara buradan da erişebiliyoruz
