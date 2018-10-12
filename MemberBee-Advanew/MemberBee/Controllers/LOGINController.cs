using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClassLibrary.DAL;
using ClassLibrary.BLL;


namespace MemberBee.Controllers
{
    public class LOGINController : ApiController
    {
        CustomerService cCustomer;
        ClubService cClub;

       
        public LOGINController()
        {
            
            igroup36_prodEntities db = new igroup36_prodEntities();
             cCustomer = new CustomerService(db);
             cClub = new ClubService(db);
        }

       [HttpPost]
        [Route("api/LOGIN/{email}/{phone}")]
        // GET: api/Login
        public Customer login(string email, int phone)
        {
            if(cCustomer.isCustomerValid(email, phone))
            {
                return cCustomer.GetCustomer(email);
            }

           

           
           return null;
        }
    }
}

