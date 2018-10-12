using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.DAL;

namespace ClassLibrary.BLL
{
    public class BenefitService
    {
        private igroup36_prodEntities db;

        public BenefitService(igroup36_prodEntities _db)
        {
            db = _db;
        }

        public List<Club_Benefit_Type> GetBenefits()
        {
            return db.Club_Benefit_Type.ToList();
        }

        public void save()
        {
            db.SaveChanges();
        }
    }
}
