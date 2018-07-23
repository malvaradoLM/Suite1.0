using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPSuite.Forms.Catalogos
{
    public partial class frmCatalogoGasolinero : RPSuite.Base.frmCatalogo
    {
        public frmCatalogoGasolinero()
        {
            InitializeComponent();

            cdsCatalogo = spCatGasolineroDS;
            DataSource = spCatGasolineroBindingSource;
            NombreDataSet = "spCatGasolinero";
            Buscar("~`|`~");
        }

        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
             //   newRecordRow["GasolineroID"] = Data.DataModule.DataService.Folio("GasolineroID", "");
                // Nota prueba
            }
        }

    }
}
