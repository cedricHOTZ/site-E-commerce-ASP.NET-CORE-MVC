using ProjetAspCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAspCore.Repository
{
    public class MookCategoryRepository : ICategoryRepository
    { 
        public IEnumerable<Category> GetAllCategories()
        {
            return new List<Category>()
            {
               new Category{CategoryId=1,CategoryName = "big data", Description = "livre sur le big data" },
               new Category{CategoryId=2,CategoryName = " Database", Description = "Base de donnée pour les nuls" },
               new Category{CategoryId=3,CategoryName = " Front-end", Description = "front-end expert" },
               new Category{CategoryId=4,CategoryName = " Back-end", Description = "l'art de l'animation" }
             };
          }
        

        public Category GetCategoryById(int id)
        {
        return GetAllCategories().FirstOrDefault(c =>c.CategoryId == id);
        }
    }
}
