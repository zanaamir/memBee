using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.DAL;


namespace ClassLibrary.BLL
{
    public class Registration
    {
        private igroup36_prodEntities db; // מביא לי את הדטה

        public Registration(igroup36_prodEntities _db)
        {
            db = _db;
        }

        public Customer AddCustomer(Customer e)
        {

            return db.Customers.Add(e);

        }


        public void save()
        {
            db.SaveChanges();
        }
    }
}
