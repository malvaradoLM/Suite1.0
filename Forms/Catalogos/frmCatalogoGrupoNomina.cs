using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPSuite.Forms.Catalogos
{
    public partial class frmCatalogoGrupoNomina : RPSuite.Base.frmCatalogo
    {
        public frmCatalogoGrupoNomina()
        {
            InitializeComponent();
            cdsCatalogo = spCatGrupoNominaDS;
            DataSource = spCatGrupoNominaBindingSource;
            NombreDataSet = "spCatGrupoNomina";
            Buscar("~`|`~");
        }

        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                newRecordRow["GrupoNominaID"] = Data.DataModule.DataService.Folio("GrupoNominaID", "");
                // Nota prueba
            }
        }

    }


}
