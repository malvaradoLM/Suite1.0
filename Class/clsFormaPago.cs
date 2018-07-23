//using DevExpress.DataAccess.Native.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSuite.Class
{
    class clsFormaPago
    {
        public int FormaPagoID
        {
            get;
            set;
        }

        public string Descripcion
        {
            get;
            set;
        }

        public string Codigo
        {
            get;
            set;
        }


        public List<clsFormaPago> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsFormaPago> Fpago = new List<clsFormaPago>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                Fpago.Add(new clsFormaPago() { FormaPagoID = dr.Field<int>("FormaPagoID"), Descripcion = dr.Field<string>("Descripcion"), Codigo = dr.Field<string>("Codigo") });

            }
            return Fpago;


        }


    }
}
