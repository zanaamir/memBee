using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClassLibrary.BLL;
using ClassLibrary.DAL;
using MemberBee.DTO;

namespace MemberBee.Controllers
{
    public class CategoryChoiceController : ApiController
    {
        CategoryChoiceService newCategoryChoice;

            public CategoryChoiceController()
        {
            igroup36_prodEntities db = new igroup36_prodEntities();

            newCategoryChoice = new CategoryChoiceService(db);
        }

        [HttpGet]
        [Route("api/CategoryChoice")]
        public List<CategoryChoice> GetChoiceCat()
        {
          
            return newCategoryChoice.GetCategoryChoice().ToList();

        
        }
    }
}