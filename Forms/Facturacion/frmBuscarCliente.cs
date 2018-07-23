using RemObjects.DataAbstract.Server;
using RPSuite.Class;
using RPSuite.Forms.Liquidacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Text.RegularExpressions;

//using RemObjects.DataAbstract.Server;



namespace RPSuite.Forms.Facturacion
{
    public partial class frmBuscarCliente : RPSuite.Base.frmPadre

    {

        private List<DataParameter> Params = new List<DataParameter>();
        public DataRowView newRecordRow = null;
        //  private  GlobalVar.Datos datoscliente = new GlobalVar.Datos();
        RPSuiteServer.TClienteNuevo datoscliente = new RPSuiteServer.TClienteNuevo();
        public frmBuscarCliente()
        {
            InitializeComponent();


            //Cargar Datos Iniciales al Grid
            Params.Clear();
            Data.DataModule.ParamByName(Params, "Datos", "~`|`~");
            Data.DataModule.FillDataSet(spBuscarClienteDS, "spBuscarCliente", Params.ToArray());
            gbBuscarcliente.DataSource = spBuscarClienteBindingSource;
            gridView2.BestFitColumns(true);


            lueEstados.Properties.ValueMember = lueEstados.Properties.DisplayMember = "Column";


           //Cargar los Estados a Los Combos
            GlobalVar.CargarEstados();
            lueEstados.Properties.DataSource = GlobalVar.Estados; 
            lueEntidadINE.Properties.DataSource = GlobalVar.Estados;


            txtBuscarCliente.Focus();
        }

        private void frmBuscarCliente_Load(object sender, EventArgs e)
        {

        }



        private void buscar(string Datos)
        {

            spBuscarClienteDS.Clear();
            Params.Clear();
            Data.DataModule.ParamByName(Params, "Datos", Datos);
            Data.DataModule.FillDataSet(spBuscarClienteDS, "spBuscarCliente", Params.ToArray());

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
             this.buscar(txtBuscarCliente.Text);
        }

        private void gbBuscarcliente_DoubleClick(object sender, EventArgs e)
        {

            SeleccionaCliente();

        }

        private void frmBuscarCliente_Load_1(object sender, EventArgs e)
        {
            //Agregar Imagen a TabControl
            tbControl.Images = RPSuite.Data.DataModule.Images16;
            this.tpBuscarCLiente.ImageOptions.ImageIndex = 1;
            this.tpAgregarcliente.ImageOptions.ImageIndex = 8;

            //Agregar Imagen a al TabControl de AgregarCliente nuevo
            tbAgregarClientes.Images = RPSuite.Data.DataModule.Images16;
            this.tbDatosGenerales.ImageOptions.ImageIndex = 8;
            this.tpDatosINE.ImageOptions.ImageIndex = 10;

            //Agrega Imagen al Boton de Buscar
            this.btnBuscarCliente.ImageOptions.ImageList = RPSuite.Data.DataModule.Images16;
            this.btnBuscarCliente.ImageOptions.ImageIndex = 8;
            //Agrega Imagen al Boton de Nuevo
            this.btnNuevo.ImageOptions.ImageList = RPSuite.Data.DataModule.Images16;
            this.btnNuevo.ImageOptions.ImageIndex = 8;
            //Agrega Imagen al Boton de Guardar
            this.btnGuardar.ImageOptions.ImageList = RPSuite.Data.DataModule.Images16;
            this.btnGuardar.ImageOptions.ImageIndex = 8;
            //Agrega Imagen al Boton de Cancelar
            this.btnCancelar.ImageOptions.ImageList = RPSuite.Data.DataModule.Images16;
            this.btnCancelar.ImageOptions.ImageIndex = 8;


            txtBuscarCliente.Focus();
        }

        private void txtAceptar_Click(object sender, EventArgs e)
        {
            SeleccionaCliente();
        }

        private void SeleccionaCliente()
        {
            try
            {
                if (gridView2.SelectedRowsCount > 0)
                {
                    foreach (int r in gridView2.GetSelectedRows())
                    {
                        Misc._ID = this.gridView2.GetRowCellValue(r, "ClienteID");


                    }
                }
                //frmCatalogoInventarioFisico inventario = (frmCatalogoInventarioFisico)Application.OpenForms["frmCatalogoInventarioFisico"];

                frmFacturaContado FacturaC = (frmFacturaContado)Application.OpenForms["frmfacturaContado"];
                //inventario.fillGrid();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            SeleccionaCliente();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            //Manda habilitar todos los Txt para agregar Cliente Nuevo
            habilita(true);


        }

        private void habilita(bool estado)
        {
            try
            {
                //if es true habilita controles
                if (estado)
                {
                    txtNombre.Enabled = true;
                    txtCalle.Enabled = true;
                    txtNoInterior.Enabled = true;
                    txtNoExterior.Enabled = true;
                    txtColonia.Enabled = true;
                    txtCP.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtLocalidad.Enabled = true;
                    txtMunicipio.Enabled = true;
                    lueEstados.Enabled = true;
                    txtRFC.Enabled = true;
                    txtCURP.Enabled = true;
                    txtCuentaBancaria.Enabled = true;
                    txtGrupo.Enabled = true;
                    txtEmail.Enabled = true;
                    chkClienteActivo.Enabled = true;

                }
                //si es falso deshabilita los controles
                else
                {
                    txtNombre.Enabled = false;
                    txtCalle.Enabled = false;
                    txtNoInterior.Enabled = false;
                    txtNoExterior.Enabled = false;
                    txtColonia.Enabled = false;
                    txtCP.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtLocalidad.Enabled = false;
                    txtMunicipio.Enabled = false;
                    lueEstados.Enabled = false;
                    txtRFC.Enabled = false;
                    txtCURP.Enabled = false;

                    txtCuentaBancaria.Enabled = false;
                    txtGrupo.Enabled = false;
                    txtEmail.Enabled = false;
                    chkClienteActivo.Enabled = false;
                }

            }
            catch
            {
                MessageBox.Show("Error al Habilitar los Textbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Manda Limpiar los Text
            LimpiaTXT();
            //Manda inhabilitar los txt de Cliente Nuevos
            habilita(false);
        }

        private void chkDatosINE_CheckedChanged(object sender, EventArgs e)
        {
 
        }


    

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            // Se manda Llenar los datos del Cliente a la estructura de los clientes del Servidor
            this.LlenarStructura();
            int res;
            res = Data.DataModule.DataService.GuardaClienteNuevo(datoscliente);
            //se carga a la variable global el cliente nuevo  y se cierra el form
            Misc._ID = res;
            this.Close();



        }

        private void LlenarStructura()
        {

         
          //  datoscliente.ClienteID = int.Parse(txtClienteID.Text);
            datoscliente.Codigo ="" ;
            datoscliente.Nombre = txtNombre.Text;
            datoscliente.Grupo = txtGrupo.Text;
            datoscliente.Calle = txtCalle.Text;
            datoscliente.Colonia = txtColonia.Text;
            datoscliente.Ciudad = txtLocalidad.Text;
            datoscliente.Telefono = txtTelefono.Text;
            datoscliente.CodigoPostal = txtCP.Text;
            datoscliente.RFC = txtRFC.Text;
            datoscliente.CURP = txtCURP.Text;
            datoscliente.Status = bool.Parse("true"); ;
            datoscliente.AutorizaCheque= bool.Parse("true");
            datoscliente.TicketBoucher= bool.Parse("true"); ;
            datoscliente.AutorizaValeCredito= bool.Parse("true");
             //  datoscliente.Status = chkClienteActivo.EditValue.ToString();
            datoscliente.LimiteCredito = 0;
            datoscliente.Email = txtEmail.Text;
            datoscliente.Localidad = txtLocalidad.Text;
            datoscliente.Estado = lueEstados.Text;
            datoscliente.NoExterior = txtNoExterior.Text;
            datoscliente.NoInterior = txtNoInterior.Text;
           // datoscliente.Actualizado = true;
            datoscliente.CuentaBancaria = txtCuentaBancaria.Text;


        }


        private void LimpiaTXT()
        {
            this.txtClienteID.Text = "";
            txtNombre.Text = "";
            txtCalle.Text = "";
            txtNoInterior.Text = "";
            txtNoExterior.Text = "";
            txtColonia.Text = "";
            txtCP.Text = "";
            txtTelefono.Text = "";
            txtLocalidad.Text = "";
            txtMunicipio.Text = "";
            lueEstados.Text = "Seleccione un Estado";
            txtRFC.Text = "";
            txtCURP.Text = "";
            txtCuentaBancaria.Text = "NO IDENTIFICADA";
            txtGrupo.Text = "";
            txtEmail.Text = "";
            chkClienteActivo.Checked = true;

        }

        private void txtRFC_Leave(object sender, EventArgs e)
        {
 
        }

        private void tbAgregarClientes_Click(object sender, EventArgs e)
        {

        }
    }

}