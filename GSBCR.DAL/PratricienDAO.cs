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
    public class PratricienDAO
    {
        public PRATICIEN FindById(Int16 pranum)
        {

            PRATICIEN pas = null;
            using (var context = new GSB_visite_LEGUILLIEREntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from p in context.PRATICIEN.Include("LeType")
                          where p.PRA_NUM == pranum
                          select p;
                pas = req.SingleOrDefault<PRATICIEN>();

            }

            return pas;
        }

        public List<PRATICIEN> FindAll()
        {
            List<PRATICIEN> pas = null;
            using (var context = new GSB_visite_LEGUILLIEREntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from p in context.PRATICIEN.Include("LeType")
                          select p;
                pas = req.ToList<PRATICIEN>();

            }
            return pas;
        }

        public List<PRATICIEN> FindByType(string code)
        {
            List<PRATICIEN> pas = null;

            using (var context = new GSB_visite_LEGUILLIEREntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from p in context.PRATICIEN.Include("LeType")
                          where p.TYP_CODE == code
                          select p;
                pas = req.ToList<PRATICIEN>();

            }

            return pas;

        }
    }
}
