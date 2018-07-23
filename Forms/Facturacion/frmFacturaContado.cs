using RemObjects.DataAbstract.Server;
using RPSuite.Base;
using RPSuite.Class;
using RPSuite.Forms.Facturacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPSuite.Forms.Liquidacion
{
    public partial class frmFacturaContado : RPSuite.Base.frmEstructura
    {
        private string Serie;
        public DateTime CurrentDateTime { get { return DateTime.Now; } }

        public frmFacturaContado()
        {
            InitializeComponent();
            //Agrega Imagen al Boton de Datos Cliente
            btnDatosCliente.ImageOptions.ImageList= RPSuite.Data.DataModule.Images16;
            btnDatosCliente.ImageOptions.ImageIndex = 8;

            //AGREGA LOS ICONOS AL TPCONTROL
            this.tbControl.Images = RPSuite.Data.DataModule.Images16;
            this.tpDatos.ImageOptions.ImageIndex = 1;
            this.tpTicktes.ImageOptions.ImageIndex = 8;

            //Leer La Serie con la que se Generan las Facturas de la Estacion
            Serie = "FEAC";

            txtSerie.Text = Serie;
            

            dtFecha.EditValue = CurrentDateTime;
            // rbPrincipal.Images = RPSuite.Data.DataModule.Images16;
            //rbPrincipal.LargeImages = RPSuite.Data.DataModule.Images48;
            getFormaPago();
            getFacturaUso();




        }


        public override void DoNuevo(object key, object sender, EventArgs e)
        {
            base.DoNuevo(key, sender, e);
          
            GlobalVar._BtnNuevo = false;
            UpdateActions();

        }

        public override void DoGuardar(object key, object sender, EventArgs e)
        {
            base.DoGuardar(key, sender, e);
            GlobalVar._BtnNuevo = true;
            UpdateActions();
        }
        public override void DoCancelar(object key, object sender, EventArgs e)
        {
            base.DoCancelar(key, sender, e);
            GlobalVar._BtnNuevo = true;
            UpdateActions();
         

        }


        public override void DoBuscar(object key, object sender, EventArgs e)
        {
            try
            {
                base.DoBuscar(key, sender, e);
                RPSuite.Forms.Facturacion.frmBuscarCliente frmBuscar = new RPSuite.Forms.Facturacion.frmBuscarCliente();

                Misc._ID = "";
                frmBuscar.ShowDialog();
                this.txtClienteID.Text = Misc._ID.ToString();

               
                //frmBuscarCliente  testDialog = new frmBuscarCliente();
                // DataSource.CancelEdit();
                //State = stEstado.Browse;
                // testDialog.ShowDialog();

                // newRecordRow = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private List<DataParameter> Params = new List<DataParameter>();
        //Forma de Pago en Factura
        #region FormaPago 


        public void getFormaPago()
        {
            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            List<clsFormaPago> FormaPago = new List<clsFormaPago>();
            clsFormaPago c = new clsFormaPago();

            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatFormaPagoDS, "spCatFormadePago", Params.ToArray());

            dt = spCatFormaPagoDS.Tables["spCatFormadePago"];
            FormaPago = c.FillList(dt);
            bs.DataSource = FormaPago;

            this.cmdFormaPago.Properties.DataSource = bs.List;
            this.cmdFormaPago.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FormaPagoID", "Forma de Pago"));
            this.cmdFormaPago.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion"));
            this.cmdFormaPago.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo SAT"));

            this.cmdFormaPago.Properties.DisplayMember = "Descripcion";
            this.cmdFormaPago.Properties.ValueMember = "FormaPagoID";

            this.cmdFormaPago.Properties.DropDownRows = FormaPago.Count;

        }

        #endregion
        
        // Para llenar el Combo de Uso de Factura
        #region FacturaUso

        public void getFacturaUso()
        {
            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            List<clsFacturaUso> FacturaUso = new List<clsFacturaUso>();
            clsFacturaUso c = new clsFacturaUso();

            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatFormaUsoDS, "spCatFacturaUso", Params.ToArray());

            dt = spCatFormaUsoDS.Tables["spCatFacturaUso"];
            FacturaUso = c.FillList(dt);
            bs.DataSource = FacturaUso;

            this.cmbUsoFactura.Properties.DataSource = bs.List;
            //this.cmbUsoFactura.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FacturaUsoUD", "Factura Uso"));
            this.cmbUsoFactura.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Descripcion"));
            this.cmbUsoFactura.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo SAT"));

            this.cmbUsoFactura.Properties.DisplayMember = "Nombre";
            this.cmbUsoFactura.Properties.ValueMember = "FacturaUsoID";

            this.cmbUsoFactura.Properties.DropDownRows = FacturaUso.Count;

        }




        #endregion

        private void frmFacturaContado_Load(object sender, EventArgs e)
        {

        }

        private void btnDatosCliente_Click(object sender, EventArgs e)
        {

           // base.DoBuscar(key, sender, e);
            RPSuite.Forms.Facturacion.frmDatosCliente frmDatosCliente = new RPSuite.Forms.Facturacion.frmDatosCliente();

           Misc._ID = txtClienteID.Text;
            frmDatosCliente.ShowDialog();

        }
    }
}
