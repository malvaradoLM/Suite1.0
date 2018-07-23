using RPSuite.Datasets.Catalogos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPSuite.Forms.Catalogos
{
    public partial class frmCatalogoCliente : RPSuite.Base.frmCatalogo
    {

      

        public frmCatalogoCliente()
        {
            InitializeComponent();
            cdsCatalogo = spCatClienteDS;
            NombreDataSet = "spCatCliente";
            Buscar("~`|`~");
        }
    }
}
