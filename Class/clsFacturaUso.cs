using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSuite.Class
{
    class clsFacturaUso
    {
        public int FacturaUsoID
        {
            get;
            set;

        }

        public string Codigo
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }

        public List<clsFacturaUso> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsFacturaUso> FacturaUso = new List<clsFacturaUso>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                FacturaUso.Add(new clsFacturaUso() { FacturaUsoID = dr.Field<int>("FacturaUsoID"), Nombre = dr.Field<string>("Nombre"), Codigo = dr.Field<string>("Codigo") });

            }
            return FacturaUso;


        }

    }
}
