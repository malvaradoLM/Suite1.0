using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace RPSuite.Class
{
    class clsCategoria
    {
        public int CategoriaID
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }

        public List<clsCategoria> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsCategoria> Categoria = new List<clsCategoria>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                Categoria.Add(new clsCategoria() { CategoriaID = dr.Field<int>("CategoriaID"), Nombre = dr.Field<string>("Nombre") });

            }
            return Categoria;


        }
    }
}
