using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPSuite.Forms.Catalogos
{
    public partial class frmCatalogoRegimenFiscal : RPSuite.Base.frmCatalogo
    {
        public frmCatalogoRegimenFiscal()
        {
            InitializeComponent();
            cdsCatalogo = spCatRegimenFiscalDS;
            DataSource = spRegimenFiscalBindingSource;
            NombreDataSet = "spRegimenFiscal";
            Buscar("~`|`~");
        }

        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                newRecordRow["RegimenFiscalID"] = Data.DataModule.DataService.Folio("RegimenFiscalID", "");
                // Nota prueba
            }
        }


    }
}
