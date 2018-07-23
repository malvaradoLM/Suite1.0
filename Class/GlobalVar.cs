using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSuite.Class
{
    class GlobalVar
    {

        public static int _IDEstacion;
        public static bool _BtnNuevo;
        public static string _NombreEstacion;


        public static string[] Estados; 

      
        public static  void CargarEstados()
        {
            Estados = new string[32];
            Estados[0] = "AGUASCALIENTES";
            Estados[1] = "BAJA CALIFORNIA";
            Estados[2] = "BAJA CALIFORNIA SUR";
            Estados[3] = "CAMPECHE";
            Estados[4] = "CHIAPAS";
            Estados[5] = "CHIHUAHUA";
            Estados[6] = "CD DE MEXICO";
            Estados[7] = "COAHUILA";
            Estados[8] = "COLIMA";
            Estados[9] = "DURANGO";
            Estados[10] = "ESTADO DE MEXICO";
            Estados[11] = "GUANAJUATO";
            Estados[12] = "GUERRERO";
            Estados[13] = "HIDALGO";
            Estados[14] = "JALISCO";
            Estados[15] = "MICHOACAN";
            Estados[16] = "MORELOS";
            Estados[17] = "NAYARIT";
            Estados[18] = "NUEVO LEON";
            Estados[19] = "OAXACA";
            Estados[20] = "PUEBLA";
            Estados[21] = "QUERETARO";
            Estados[22] = "QUINTANA ROO";
            Estados[23] = "SAN LUIS POTOSI";
            Estados[24] = "SINALOA";
            Estados[25] = "SONORA";
            Estados[26] = "TABASCO";
            Estados[27] = "TAMAULIPAS";
            Estados[28] = "TAXCALA";
            Estados[29] = "VERACRUZ";
            Estados[30] = "YUCATAN";
            Estados[31] = "ZACATECAS";

        }


       
    }
}
