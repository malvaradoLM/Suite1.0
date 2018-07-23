using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPSuite.Forms.Catalogos
{
    public partial class frmCatalogoCategoria : RPSuite.Base.frmCatalogo
    {
        public frmCatalogoCategoria()
        {
            InitializeComponent();
            cdsCatalogo = spCatCategoriaDS;
            DataSource = spCatCategoriaBindingSource;
            NombreDataSet = "spCatCategoria";


           Buscar("~`|`~");
        }

        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                newRecordRow["CategoriaID"] = Data.DataModule.DataService.Folio("CategoriaID", "");
                
            }
        }
    }
}
