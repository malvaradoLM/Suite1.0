using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPSuite.Forms.Catalogos
{
    public partial class frmCatalogoBanco : RPSuite.Base.frmCatalogo
    {
        public frmCatalogoBanco()
        {
            InitializeComponent();
            cdsCatalogo = spCatBancoDS;
            DataSource = spCatBancoBindingSource;
            NombreDataSet = "spCatBanco";
            Buscar("~`|`~");
        }

        public override void onBeforePost()
        {           
            if (newRecordRow != null) {  
                newRecordRow["BancoID"] = Data.DataModule.DataService.Folio("BancoID", "");
				// Nota prueba
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
