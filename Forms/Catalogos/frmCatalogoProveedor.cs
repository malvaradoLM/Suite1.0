using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPSuite.Forms
{
    public partial class frmCatalogoProveedor : RPSuite.Base.frmCatalogo
    {
        public frmCatalogoProveedor()
        {
            InitializeComponent();
            cdsCatalogo = spCatProveedorDS;
            DataSource = spCatProveedorBindingSource;
            NombreDataSet = "spCatProveedor";
            Buscar("~`|`~");
        }

        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                newRecordRow["ProveedorID"] = Data.DataModule.DataService.Folio("ProveedorID", "");
                // Nota prueba
            }
        }
    }
}
