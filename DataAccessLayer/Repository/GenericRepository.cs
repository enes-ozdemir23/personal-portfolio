using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;


// bu interface’i T sınıfına göre kullan demektir.
// entity=tablo demektir.
// Concrete=Somut class
// abstract=Soyut class
// using,oluşturduğumuz nesneyi kullandıktan sonra bellekte tutmaz
// bu da performans açısından önemli bir kavramdır. Aşağıdakiler aynı işi yapar
// using var c = new Context() <-------> Context c=new Context();
// <T> içerisine herhangi bir sınıf tipi (entity, model, tablo sınıfı vs.) gelir.
// Ama primitive tipler (int, string vb.) gelmesin diye where T : class deriz.

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class

    {
        public void Delete(T t)
        {
            using var c = new Context(); //Context c=new Context();
            c.Remove(t);
            c.SaveChanges(); //veritabanından silinmesi bu komut kullanılır.


        }

        public List<T> GetbyFilter(Expression<Func<T, bool>> filter)
        {
            using var c=new Context();
            return c.Set<T>().Where(filter).ToList();
        }

        public T GetByID(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> Getlist()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
