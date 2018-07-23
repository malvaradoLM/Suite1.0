using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSuite.Class
{
    class clsGasolinero
    {
        public int GasolineroID { get; set; }

        public string Descripcion { get; set; }



        public List<clsGasolinero> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsGasolinero> Gasolinero = new List<clsGasolinero>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                Gasolinero.Add(new clsGasolinero() { GasolineroID = dr.Field<int>("GasolineroID"), Descripcion = dr.Field<string>("Descripcion") });

            }
            return Gasolinero;
        }
    }
}
