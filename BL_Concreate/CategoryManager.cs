using _1_EntityLayer.Concreate;
using _2_Data_Access_Layer.Concreate.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Business_Layer.Concreate
{
  public  class CategoryManager
    { GenericRepository<Category> repo = new GenericRepository<Category>();
        public  List<Category> GetAllBL()
        {
            return repo.List(); 
                }
        public void CategoryAllBL(Category p)
        {
            if (p.CategoryName==""||p.CategoryName.Length<=3||
                p.CategoryDescription==""||p.CategoryName.Length>=51)
            {
              // hata mesajı
            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
