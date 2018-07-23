using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RemObjects.DataAbstract.Server;


namespace RPSuite.Base
{
    public partial class frmEstructura : RPSuite.Base.BaseModule
    {
        public frmEstructura()
        {
            InitializeComponent();
        }

        private void frmEstructura_Load(object sender, EventArgs e)
        {
            SetBeginEdit(this);

        }

        //redefinimos controles que se necesitan
        protected override void RegisterActions()
        {
            base.RegisterActions();
            Actions.AddSupportedAction(ActionKeys.actNuevo, new ActionModuleHandler(DoNuevo));
            Actions.AddSupportedAction(ActionKeys.actGuardar, new ActionModuleHandler(DoGuardar));
            Actions.AddSupportedAction(ActionKeys.actCancelar, new ActionModuleHandler(DoCancelar));
            Actions.AddSupportedAction(ActionKeys.actBuscar, new ActionModuleHandler(DoBuscar));
            //Actions.AddSupportedAction(ActionKeys.actBuscar, new ActionModuleHandler(DoBuscar));
            //Actions.AddSupportedAction(ActionKeys.actActualizar, new ActionModuleHandler(DoActualizar));

            //
            Class.GlobalVar._BtnNuevo = true;
        }

        public override void UpdateActions()
        {
            base.UpdateActions();
            Actions[ActionKeys.actNuevo].Enabled = Class.GlobalVar._BtnNuevo;
            Actions[ActionKeys.actGuardar].Enabled = Actions[ActionKeys.actNuevo].Enabled ? false : true;
            Actions[ActionKeys.actCancelar].Enabled = Actions[ActionKeys.actNuevo].Enabled ? false : true;
            // Actions[ActionKeys.actActualizar].Enabled = !Actions[ActionKeys.actGuardar].Enabled;
            Actions[ActionKeys.actBuscar].Enabled = Actions[ActionKeys.actNuevo].Enabled ? false : true;
        }


        //Sobreescribir metodos
        public virtual void DoNuevo(object key, object sender, EventArgs e)
        {

            //try
            //{
            //    DataSource.AddNew();
            //    State = stEstado.Append;
            //    //tcCatalogo.SelectedTabPage = tpDatos;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        public virtual void DoGuardar(object key, object sender, EventArgs e)
        {
            Actions[ActionKeys.actNuevo].Enabled = true;
            UpdateActions();
            //try
            //{
            //    DataSource.EndEdit();
            //    //if (Data.DataModule.ApplyUpdates(cdsCatalogo))
            //    {
            //        State = stEstado.Browse;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        public virtual void DoCancelar(object key, object sender, EventArgs e)
        {
            Actions[ActionKeys.actNuevo].Enabled = true;
            UpdateActions();
            //try
            //{
            //    DataSource.CancelEdit();
            //    State = stEstado.Browse;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        public virtual void DoBuscar(object key, object sender, EventArgs e)
        {
            //tcCatalogo.SelectedTabPage = tpBuscar;
            //txtDatosBusqueda.Select();
        }


    }
}
