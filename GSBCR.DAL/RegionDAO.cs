using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace GSBCR.DAL {
    public class RegionDAO {
        public REGION FindById(string code) {

            REGION reg = null;
            using (var context = new GSB_visite_LEGUILLIEREntities()) {
                var request = from r in context.REGION
                              where r.REG_CODE == code
                              select r;

                reg = request.SingleOrDefault<REGION>();
            }

            return reg;
        }

        public List<REGION> FindAll() {

            List<REGION> regs = null;
            using (var context = new GSB_visite_LEGUILLIEREntities()) {
                var request = from r in context.REGION
                              select r;

                regs = request.ToList<REGION>();
            }

            return regs;
        }
    }
}
