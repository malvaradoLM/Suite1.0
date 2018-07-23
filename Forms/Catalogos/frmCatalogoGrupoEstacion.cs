using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPSuite.Forms.Catalogos
{
    public partial class frmCatalogoGrupoEstacion : RPSuite.Base.frmCatalogo
    {
        public frmCatalogoGrupoEstacion()
        {
            InitializeComponent();

            cdsCatalogo = spCatGrupoEstacionDS1;
            DataSource = spCatGrupoEstacionBindingSource;
            NombreDataSet = "spCatGrupoEstacion";
            Buscar("~`|`~");
        }

        private void gcDatos_Paint(object sender, PaintEventArgs e)
        {

        }


        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                newRecordRow["GrupoEstacionID"] = Data.DataModule.DataService.Folio("GrupoEstacionID", "");
                // Nota prueba
            }
        }


    }
}
