using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


namespace GSBCR.DAL {
    public class TypePraticienDAO {
        public TYPE_PRATICIEN FindById(string code) {

            TYPE_PRATICIEN type = null;
            using (var context = new GSB_visite_LEGUILLIEREntities()) {
                var request = from tp in context.TYPE_PRATICIEN
                              where tp.TYP_CODE == code
                              select tp;

                type = request.SingleOrDefault<TYPE_PRATICIEN>();
            }

            return type;
        }

        public List<TYPE_PRATICIEN> FindAll() {

            List<TYPE_PRATICIEN> types = null;
            using (var context = new GSB_visite_LEGUILLIEREntities()) {
                var request = from tp in context.TYPE_PRATICIEN
                              select tp;

                types = request.ToList<TYPE_PRATICIEN>();
            }

            return types;
        }

    }
}
