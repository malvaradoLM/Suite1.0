using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSuite.Class
{
    public static class Misc
    {
        public static object _ID;
        public static object _Nombre;
        public static object _Precio;

    }


    public class Folio
    {
        public int _Folio { get; set; }

        public int FillList(DataTable dt)
        {
            ////creamos una lista de almacenes con la clase almacen
            int Folio = new int();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;


            foreach (DataRow dr in query)
            {
                Folio = dr.Field<int>("Folio");
            }
            return Folio;
        }
    }

    public class Bombas
    {

        public int NumeroBomba { get; set; }

        public List<int> FillList(DataTable dt)
        {
            ////creamos una lista de almacenes con la clase almacen
            List<int> Bombas = new List<int>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;


            foreach (DataRow dr in query)
            {
                Bombas.Add(NumeroBomba = dr.Field<int>("BombaID"));
            }
            return Bombas;
        }

        public int GetNoBomb(DataTable dt)
        {
            int NoBomb = new int();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;
            foreach (DataRow dr in query)
            {
                NoBomb = dr.Field<int>("NoBombas");
            }
            return NoBomb;
        }
    }
    public class FillCombos
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public List<FillCombos> FillListCombo(DataTable dt, string id, string nombre)
        {
            List<FillCombos> combo = new List<FillCombos>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;


            foreach (DataRow dr in query)
            {
                combo.Add(new FillCombos() { ID = dr.Field<int>(id), Nombre = dr.Field<string>(nombre) });
            }
            return combo;
        }
    }

}
