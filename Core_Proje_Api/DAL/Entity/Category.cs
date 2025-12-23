using System.ComponentModel.DataAnnotations;

namespace Core_Proje_Api.DAL.Entity
{
    public class Category
    {
        [Key]
        public int CatogoryID { get; set; }
        public string CatogoryName { get; set; }


    }
}
