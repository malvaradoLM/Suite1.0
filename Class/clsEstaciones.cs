using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSuite.Class
{
    class clsEstaciones
    {
        public int EstacionID
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }


        public List<clsEstaciones> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsEstaciones> Estacion = new List<clsEstaciones>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                Estacion.Add(new clsEstaciones() { EstacionID = dr.Field<int>("EstacionId"), Nombre = dr.Field<string>("Nombre") });

            }
            return Estacion;


        }

    }
}
