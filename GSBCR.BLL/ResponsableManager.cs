using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using GSBCR.DAL;

namespace GSBCR.BLL
{
    public class ResponsableManager
    {

        /// <summary>
        /// Charge les regions d'un secteur
        /// </summary>
        /// <param name="codeSecteur">Code du secteur des régions</param>
        /// <returns>List<REGION></returns>
        public static List<REGION> ChargerRegionsSecteur(string codeSecteur)
        {
            List<REGION> lReg = new RegionDAO().FindBySecteur(codeSecteur);

            return lReg;
        }

    }
}
