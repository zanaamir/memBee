using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.DAL;

namespace ClassLibrary.BLL
{
    public class ChildService
    {
        private igroup36_prodEntities db; // מביא לי את הדטה

        public ChildService(igroup36_prodEntities _db)
        {
            db = _db;
        }

        public Child Addchild(Child e)
        {
            

            return db.Children.Add(e);

        }

        public Child DeleteChild(Child e)
        {
            return db.Children.Remove(e);
        }

        //public Child UpdateChild(Child e) // לעשוץ שינויים
        //{
        //    //return db.Children.
        //}


        public void save()
        {
            db.SaveChanges();
        }
    }
}

