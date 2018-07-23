using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RPSuite.Componentes;


namespace RPSuite.Forms.Catalogos
{
    public partial class frmCatalogoReportes : RPSuite.Base.frmCatalogo
    {
        private bool Editando = false;
        private RPSuiteServer.TRPReporte Reporte = new RPSuiteServer.TRPReporte();
        private void ReporteToDataset()
        {
        
        }
        private void DatasetToReporte()
        {

        }
        public frmCatalogoReportes()
        {
            InitializeComponent();
        }
        public override void DoGuardar(object key, object sender, EventArgs e)
        {
            ReporteToDataset();
            Editando = true;
            base.DoGuardar(key, sender, e);
        }

        private void frmCatalogoReportes_Load(object sender, EventArgs e)
        {
            bmBarras.Images = RPSuite.Data.DataModule.Images16;
        }
    }
}
