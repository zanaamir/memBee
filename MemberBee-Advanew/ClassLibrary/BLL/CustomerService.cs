using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.DAL;


namespace ClassLibrary.BLL
{
   public class CustomerService
    {
        
        private igroup36_prodEntities db;
        //בנאי להבאת DB 
        public CustomerService(igroup36_prodEntities _db)
        {
            db = _db;
        }

        public Customer GetCustomer(string _email)
        {
            return db.Customers.SingleOrDefault(x => x.MainMail == _email);
        }

        public void save()
        {
            db.SaveChanges();
        }

        public bool isCustomerValid(string email, int phone)
        {
            Customer C = this.GetCustomer(email);
            if (C != null)
            {
                if (phone == C.PhoneNo)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
