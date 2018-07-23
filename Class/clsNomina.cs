using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSuite.Class
{
    public class clsNomina
    {
        public int GrupoNominaID
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }


        public List<clsNomina> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsNomina> Nomina = new List<clsNomina>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                Nomina.Add(new clsNomina() { GrupoNominaID = dr.Field<int>("GrupoNominaId"), Nombre = dr.Field<string>("Nombre") });

            }
            return Nomina;


        }
    }
}
