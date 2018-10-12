using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.DAL;


namespace ClassLibrary.BLL
{
    public class CategoryChoiceService
    {
        private igroup36_prodEntities db; // מביא לי את הדטה

        public CategoryChoiceService(igroup36_prodEntities _db)
        {
            db = _db;
        }

        //public Category AddCategory(Category e)
        //{

        //    return db.Categories.Add(e);

        //}

        public CategoryChoice AddCategoryChoice(CategoryChoice e)
        {

            return db.CategoryChoices.Add(e);

        }

        public List<CategoryChoice> GetCategoryChoice()
        {
            return db.CategoryChoices.ToList();
            //return db.CategoryChoices.Select(x => new CategoryChoice()
            //{
            //    CategoryChoiceNo = x.CategoryChoiceNo,
            //    CategoryChoiceName = x.CategoryChoiceName,


            //}).ToList();
        }

        public void save()
        {
            db.SaveChanges();
        }
    }
}
