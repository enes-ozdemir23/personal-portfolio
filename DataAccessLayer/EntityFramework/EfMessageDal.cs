using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repository;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
namespace DataAccessLayer.EntityFramework
{
    public class EfMessageDal:GenericRepository<Message>,IMessageDal
    {
    }
}
