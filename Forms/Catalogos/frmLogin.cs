using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSuite.Forms
{
    public partial class frmLogin : RPSuite.Base.frmPadre
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RemObjects.DataAbstract.Server.UserInfo Info;
            try
            {
                if (Data.DataModule.LoginService.Login(txtUsuario.Text, txtPassword.Text, out Info))
                {
                    Data.DataModule.Seguridad = Info;
                    
                    Close();
                }
                else
                {
                    MessageBox.Show("Usuario Invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            btnAceptar.Select();
        }
    }
}
