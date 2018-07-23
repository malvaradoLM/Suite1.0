using RPSuite.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPSuite.Forms.Facturacion
{
    public partial class frmDatosCliente : RPSuite.Base.frmPadre
    {
        // se declara la variable datosCliente contendra los datos de la busqueda del cliente
        RPSuiteServer.TCliente datoscliente = new RPSuiteServer.TCliente();
        public frmDatosCliente()
        {
            InitializeComponent();

            //Agrega Imagen al Boton de Datos Cliente
            btnAceptar.ImageOptions.ImageList = RPSuite.Data.DataModule.Images16;
            btnAceptar.ImageOptions.ImageIndex = 8;

            //Agrega Imagen al Boton de Datos Cliente
            btnCancelar.ImageOptions.ImageList = RPSuite.Data.DataModule.Images16;
            btnCancelar.ImageOptions.ImageIndex = 9;


            txtClienteID.Text = Misc._ID.ToString();

            CargarDatosIniciales();

           

        }

        private void CargarDatosIniciales()
        {
            datoscliente = Data.DataModule.DataService.BuscarCliente(int.Parse(txtClienteID.Text));
            if (datoscliente.ClienteID != -1)
            {
                //Asignar a los TXT el Resultado de la busqueda del cliente
                txtClienteID.Text = datoscliente.ClienteID.ToString();
                txtNombre.Text = datoscliente.Nombre;
                txtCalle.Text = datoscliente.Calle;
                txtNoExterior.Text = datoscliente.NoExterior;
                txtNoInterior.Text = datoscliente.NoInterior;
                txtColonia.Text = datoscliente.Colonia;
                txtCP.Text = datoscliente.CodigoPostal;
                txtTelefono.Text = datoscliente.Telefono;
                txtCiudad.Text = datoscliente.Ciudad;
                txtMunicipio.Text = datoscliente.Localidad;
                lueEstado.Text = datoscliente.Estado;
                txtRFC.Text = datoscliente.RFC;
                txtCURP.Text = datoscliente.CURP;
                txtCuentaBancaria.Text = datoscliente.CuentaBancaria;
                txtGrupo.Text = datoscliente.Grupo;
                txtEmail.Text = datoscliente.Email;
                //chkClienteActivo =
                if (datoscliente.Status == true)
                {
                    chkClienteActivo.Checked = true;
                }
                else
                {
                    chkClienteActivo.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Error al Ingresar el Cliente", "RedPacifico", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            

            
        }


        private void frmDatosCliente_Load(object sender, EventArgs e)
        {

        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
           
        }


    }
}
