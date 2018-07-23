using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPSuite.Forms.Catalogos
{
    public partial class frmCatalogoTipoDocumento : RPSuite.Base.frmCatalogo
    {
        public frmCatalogoTipoDocumento()
        {
            InitializeComponent();
            cdsCatalogo = spCatTipoDocumentoDS;
            DataSource = spCatTipoDocumentoBindingSource;
            NombreDataSet = "spCatTipoDocumento";
            Buscar("~`|`~");

        }

        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                newRecordRow["TipoDocumentoID"] = Data.DataModule.DataService.Folio("TipoDocumentoID", "");
                
            }
        }

    }
}
