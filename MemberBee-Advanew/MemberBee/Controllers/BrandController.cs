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
    public class BrandController : ApiController
    {
        static igroup36_prodEntities db = new igroup36_prodEntities();
        BenefitService BS = new BenefitService(db);
    }
        //[HttpPost]
        //public Club_Benefit_Type showBenefit(int club_id)
        //{

        //    return 
        //}


        //// GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}

    }