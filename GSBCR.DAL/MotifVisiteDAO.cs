using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


namespace GSBCR.DAL
{
    public class MotifVisiteDAO
    {
        public MOTIF_VISITE FindById(string code)
        {
            MOTIF_VISITE lmv = null;

            using (var context = new GSB_visite_LEGUILLIEREntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.MOTIF_VISITE
                          where m.MOT_CODE == code
                          select m;

                lmv = req.SingleOrDefault<MOTIF_VISITE>();

            }

            return lmv;

        }

        public List<MOTIF_VISITE> FindAll()
        {
            List<MOTIF_VISITE> lmv = null;
            using (var context = new GSB_visite_LEGUILLIEREntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.MOTIF_VISITE
                          select m;
                lmv = req.ToList<MOTIF_VISITE>();

            }
            return lmv;
        }
    }
}
