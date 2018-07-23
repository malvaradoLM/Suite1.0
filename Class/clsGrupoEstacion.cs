using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSuite.Class
{
    class clsGrupoEstacion
    {
        public int GrupoEstacionID { get; set; }

        public string Descripcion { get; set; }

        public List<clsGrupoEstacion> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsGrupoEstacion> GrupoEstacion = new List<clsGrupoEstacion>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                GrupoEstacion.Add(new clsGrupoEstacion() { GrupoEstacionID = dr.Field<int>("GrupoEstacionID"), Descripcion = dr.Field<string>("Descripcion") });

            }
            return GrupoEstacion;


        }



    }
}
