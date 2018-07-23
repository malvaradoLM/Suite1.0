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
    public partial class frmCatalogo : RPSuite.Base.BaseModule
    {
        private List<DataParameter> Params = new List<DataParameter>();
        public DataRowView newRecordRow = null;
          
        public frmCatalogo()
        {
            InitializeComponent();
            State = stEstado.Close;
            gvCatalogo.DataController.MaintainVisibleRowBindingOnFilterChange = true;
        }

        protected void Buscar(string Datos)
        {
            try
            {
                State = stEstado.Close;
                cdsCatalogo.Clear();
                
                Params.Clear();
                Data.DataModule.ParamByName(Params, "Datos", Datos);
                Data.DataModule.FillDataSet(cdsCatalogo, NombreDataSet, Params.ToArray());
                gvCatalogo.BestFitColumns(true);
                State = stEstado.Browse;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateActions();
        }

        public virtual void onNewRecord()
        {
            
        }

        public virtual void onBeforePost()
        {

        }

        public virtual void DoNuevo(object key, object sender, EventArgs e)
        {
            try
            {
                DataSource.AddNew();
                State = stEstado.Append;
                tcCatalogo.SelectedTabPage = tpDatos;
                newRecordRow = (DataRowView)DataSource.Current;
                onNewRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public virtual void DoGuardar(object key, object sender, EventArgs e)
        {
            try
            {
                onBeforePost();
                DataSource.EndEdit();
                if (Data.DataModule.ApplyUpdates(cdsCatalogo))
                {
                    State = stEstado.Browse;
                    newRecordRow = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public virtual void DoCancelar(object key, object sender, EventArgs e)
        {
            try
            {
                DataSource.CancelEdit();
                State = stEstado.Browse;
                newRecordRow = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public virtual void DoPrimer(object key, object sender, EventArgs e)
        {
            gvCatalogo.MoveFirst();
        }
        public virtual void DoUltimo(object key, object sender, EventArgs e)
        {
            gvCatalogo.MoveLast();
        }
        public virtual void DoAnterior(object key, object sender, EventArgs e)
        {
            gvCatalogo.MovePrev();
        }
        public virtual void DoSiguiente(object key, object sender, EventArgs e)
        {
            gvCatalogo.MoveNext();
        }
        public virtual void DoBuscar(object key, object sender, EventArgs e)
        {
            tcCatalogo.SelectedTabPage = tpBuscar;
            txtDatosBusqueda.Select();
        }
        public virtual void DoActualizar(object key, object sender, EventArgs e)
        {
            try
            {
                State = stEstado.Close;
                cdsCatalogo.Clear();
                Data.DataModule.FillDataSet(cdsCatalogo, NombreDataSet, Params.ToArray());
                State = stEstado.Browse;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void RegisterActions()
        {
            base.RegisterActions();
            Actions.AddSupportedAction(ActionKeys.actNuevo, new ActionModuleHandler(DoNuevo));
            Actions.AddSupportedAction(ActionKeys.actGuardar, new ActionModuleHandler(DoGuardar));
            Actions.AddSupportedAction(ActionKeys.actCancelar, new ActionModuleHandler(DoCancelar));
            Actions.AddSupportedAction(ActionKeys.actPrimer, new ActionModuleHandler(DoPrimer));
            Actions.AddSupportedAction(ActionKeys.actUltimo, new ActionModuleHandler(DoUltimo));
            Actions.AddSupportedAction(ActionKeys.actAnterior, new ActionModuleHandler(DoAnterior));
            Actions.AddSupportedAction(ActionKeys.actSiguiente, new ActionModuleHandler(DoSiguiente));
            Actions.AddSupportedAction(ActionKeys.actBuscar, new ActionModuleHandler(DoBuscar));
            Actions.AddSupportedAction(ActionKeys.actActualizar, new ActionModuleHandler(DoActualizar));
        }

        public override void UpdateActions()
        {
            base.UpdateActions();
            Actions[ActionKeys.actNuevo].Enabled = (State == stEstado.Browse);
            Actions[ActionKeys.actGuardar].Enabled = ((State == stEstado.Edit) || (State == stEstado.Append));
            Actions[ActionKeys.actCancelar].Enabled = Actions[ActionKeys.actGuardar].Enabled;
            Actions[ActionKeys.actPrimer].Enabled = ((gvCatalogo.FocusedRowHandle > 0) && (State == stEstado.Browse));
            Actions[ActionKeys.actSiguiente].Enabled = (gvCatalogo.RowCount > 1) && (gvCatalogo.FocusedRowHandle < (gvCatalogo.RowCount - 1) && (State == stEstado.Browse));
            Actions[ActionKeys.actAnterior].Enabled = Actions[ActionKeys.actPrimer].Enabled;
            Actions[ActionKeys.actUltimo].Enabled = Actions[ActionKeys.actSiguiente].Enabled;
            Actions[ActionKeys.actActualizar].Enabled = !Actions[ActionKeys.actGuardar].Enabled;
            Actions[ActionKeys.actBuscar].Enabled = !Actions[ActionKeys.actGuardar].Enabled;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtDatosBusqueda.Text);
        }

        public DataSet cdsCatalogo { get; set; }
        public string NombreDataSet { get; set; }

        private void gvCatalogo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateActions();
        }

        private void gvCatalogo_DoubleClick(object sender, EventArgs e)
        {
            if (gvCatalogo.RowCount > 0)
            {
                tcCatalogo.SelectedTabPage = tpDatos;
            }          
        }
        protected override void DoOnUpdateControl()
        {
            base.DoOnUpdateControl();
            if (State != stEstado.Edit)
            {
                State = stEstado.Edit;
                UpdateActions();
            }
        }
        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            SetBeginEdit(this);
        }

        private void gvCatalogo_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateActions();
        }
    }
}
