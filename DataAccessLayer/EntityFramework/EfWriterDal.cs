using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Hosting;

namespace DataAccessLayer.EntityFramework
{
    public class EfWriterDal:GenericRepository<WriterMessage>,IWriterMessageDal
    {
    }
}
