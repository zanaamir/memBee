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
    public class AddCustomerToClubController : ApiController
    {

        CustomerService cCustomer;
        ClubService cClub; 
        public AddCustomerToClubController()
        {
            igroup36_prodEntities db = new igroup36_prodEntities();
            cClub = new ClubService(db);
        }
        


            [HttpGet]
        [Route("api/AddCustomerToClub/{Club}/")]
    // GET: api/Login
    public Club getClub(int Club)
        {

          return  cClub.GetClub(Club);
           
        }

        [HttpPost]
        [Route("api/AddCustomerToClub/")]
        public void PostNewClientInClub(Club_Customer e)
        {
            cClub.AddCustomerToClub(e);
            cClub.save();
        }
    }
    
   
}
