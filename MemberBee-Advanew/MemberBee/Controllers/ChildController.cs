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
    public class ChildController : ApiController
    {
        ChildService new_Child;

        public ChildController()
        {
            igroup36_prodEntities db = new igroup36_prodEntities();

            new_Child = new ChildService(db);
        }

        [Route("api/Child")]
        [HttpPost]
        public void PostNewChild(Child e)
        {

            new_Child.Addchild(e);
            //new_Child.save();

        }
    }
}