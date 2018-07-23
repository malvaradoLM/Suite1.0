using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSuite.Class
{
    public class clsTipoDocumento
    {
        public int TipoDocumentoID
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }


        public List<clsTipoDocumento> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsTipoDocumento> Documento = new List<clsTipoDocumento>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                Documento.Add(new clsTipoDocumento() { TipoDocumentoID = dr.Field<int>("TipoDocumentoID"), Nombre = dr.Field<string>("Nombre") });

            }
            return Documento;


        }
    }
}
