using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPSuite.Forms.Catalogos
{
    public partial class frmCatalogoFormadePago : RPSuite.Base.frmCatalogo
    {
        public frmCatalogoFormadePago()
        {
            InitializeComponent();
            cdsCatalogo = spCatFormaPagoDS;
            DataSource = spCatFormadePagoBindingSource;
            NombreDataSet = "spCatFormadePago";
            Buscar("~`|`~");
        }


        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                newRecordRow["FormaPagoID"] = Data.DataModule.DataService.Folio("FormaPagoID", "");
                // Nota prueba
            }
        }
    }

}
