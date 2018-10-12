using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.DAL;

namespace ClassLibrary.BLL
{
   public class ClubService
    {
        private igroup36_prodEntities db;

        public ClubService(igroup36_prodEntities _db)
        {
            db = _db;
        }

        public Club GetClub(int _clubId)
        {
            return db.Clubs.SingleOrDefault(x => x.ClubId == _clubId);
        }
        public List<Club> GetClubs()
        {
            return db.Clubs.ToList();
        }

        public Club_Customer AddCustomerToClub(Club_Customer e)
        {
            return db.Club_Customer.Add(e);
        }

        public void save()
        {
            db.SaveChanges();
            // throw new NotImplementedException();
            //***Amit*** dont know what the last line is, saw it in my code. maybe some fix suggest of Visual Studio.

        }
    }
}
