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
    public class ClubController : ApiController
    {
       ClubService service;

        public ClubController()
        {
            igroup36_prodEntities db = new igroup36_prodEntities();
            service = new ClubService(db);
        }



        public List<Club> GetClubs()
        {

            return service.GetClubs().Select(x => new Club()
            {
                ClubId = x.ClubId,
                ClubName = x.ClubName,
                URL_Internet_site = x.URL_Internet_site,
                Image_Logo = x.Image_Logo

            }).ToList();

                
                

            //    return service.GetClubs().select(x => new AddClubForClientDto()
            //    {
            //        ClubId = x.ClubId,
            //        ClubName = x.ClubName,
            //        URL_Internet_site = x.url_site,
            //        Image_Logo = x.img_url
            //    }).ToList();
            //
        }

    }
}
