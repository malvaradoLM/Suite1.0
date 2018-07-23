using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RPSuite.Base;

namespace RPSuite.Forms.Catalogos
{
    public partial class Form2 : RPSuite.Base.BaseModule
    {
        public Form2()
        {
            
            InitializeComponent();
        }

        private void DoProcesar(object key, object sender, EventArgs e)
        {
            button1.Enabled = !button1.Enabled;
        }
        private void DoEliminar(object key, object sender, EventArgs e)
        {
            button1.Text = "click en eliminar";
        }

        protected override void RegisterActions()
        {
            base.RegisterActions();
            Actions.AddSupportedAction(ActionKeys.actProcesar, new ActionModuleHandler(DoProcesar));
            Actions.AddSupportedAction(ActionKeys.actEliminar, new ActionModuleHandler(DoEliminar));
            Actions.AddSupportedAction(ActionKeys.actImprimir, new ActionModuleHandler(DoProcesar));
        }

        public override void UpdateActions()
        {
            base.UpdateActions();
            Actions[ActionKeys.actProcesar].Enabled = true;
            Actions[ActionKeys.actEliminar].Enabled = Actions[ActionKeys.actProcesar].Enabled;
            Actions[ActionKeys.actImprimir].Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();

            RemObjects.DataAbstract.Server.UserInfo Info;
            try
            {
                if (Data.DataModule.LoginService.Login("super", "cistem", out Info))
                {
                    label1.Text = "Logged";
                }
                else
                {
                    label1.Text = "Login Fail";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
