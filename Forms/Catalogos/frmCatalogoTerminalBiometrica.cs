using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPSuite.Forms
{
    public partial class frmCatalogoTerminalBiometrica : RPSuite.Base.frmCatalogo
    {
        public frmCatalogoTerminalBiometrica()
        {
            InitializeComponent();
            cdsCatalogo = spCatTerminalBiometricaDS;
            DataSource = spCatTerminalBiometricaBindingSource;
            NombreDataSet = "spCatTerminalBiometrica";
            Buscar("~`|`~");
        }

        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                newRecordRow["TerminalBiometricaID"] = Data.DataModule.DataService.Folio("TerminalBiometricaID", "");

            }
        }
    }
}
