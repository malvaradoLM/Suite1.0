using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSuite.Class
{
    public class clsDocumento
    {
        public int DocumentoID
        {
            get;
            set;
        }
        public DateTime Fecha
        {
            get;
            set;
        }
        public string Observaciones
        {
            get;
            set;
        }
        public byte[] Imagen
        {
            get;
            set;
        }
        public int EmpleadoID
        {
            get;
            set;
        }
        public int TipoDocumentoID
        {
            get;
            set;
        }
        public int UsuarioID
        {
            get;
            set;
        }

        public List<clsDocumento> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsDocumento> Documento = new List<clsDocumento>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                Documento.Add(new clsDocumento() {
                    DocumentoID = dr.Field<int>("DocumentoID"),
                    Fecha = dr.Field<DateTime>("Fecha"),
                    Observaciones = dr.Field<string>("Observaciones"),
                    Imagen = dr.Field<byte[]>("Imagen"),
                    EmpleadoID = dr.Field<int>("EmpleadoID"),
                    TipoDocumentoID = dr.Field<int>("TipoDocumentoID"),
                    UsuarioID = dr.Field<int>("UsuarioID")
                });

            }
            return Documento;


        }
    }
}
