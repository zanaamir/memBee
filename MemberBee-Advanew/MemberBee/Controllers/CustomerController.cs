using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClassLibrary.BLL;
using ClassLibrary.DAL;

namespace MemberBee.Controllers
{
    public class CustomerController : ApiController
    {
        CustomerService service;

        public CustomerController()
        {
            igroup36_prodEntities db = new igroup36_prodEntities();
            service = new CustomerService(db);
        }





    }
}
