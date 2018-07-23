using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSuite.Class
{
    class clsBanco
    {
        public int BancoID
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }

        public List<clsBanco> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsBanco> banco = new List<clsBanco>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                banco.Add(new clsBanco() { BancoID = dr.Field<int>("BancoID"), Nombre = dr.Field<string>("Nombre") });

            }
            return banco;
        }



    }
}
