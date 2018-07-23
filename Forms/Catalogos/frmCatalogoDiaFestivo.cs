using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPSuite.Forms.Catalogos
{
    public partial class frmCatalogoDiaFestivo : RPSuite.Base.frmCatalogo
    {
        public frmCatalogoDiaFestivo()
        {
            InitializeComponent();
            cdsCatalogo = spCatDiaFestivoDS;
            DataSource = spCatDiaFestivoBindingSource;
            NombreDataSet = "spCatDiaFestivo";
            Buscar("~`|`~");
        }

        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                newRecordRow["FestivoID"] = Data.DataModule.DataService.Folio("FestivoID", "");

            }
        }

    }
}
