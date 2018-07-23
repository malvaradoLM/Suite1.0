using RemObjects.DataAbstract.Server;
using RPSuite.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RPSuite.Forms.Catalogos
{
    public partial class frmCatalogoEmpleadocs : RPSuite.Base.frmCatalogo
    {
        RPSuiteServer.TDocumentoNuevo datosDocumento = new RPSuiteServer.TDocumentoNuevo();
        int IDEmpleado=0;
        public frmCatalogoEmpleadocs()
        {
            InitializeComponent();
            cdsCatalogo = spCatEmpleadoDS;
            DataSource = spCatEmpleadoBindingSource;
            NombreDataSet = "spCatEmpleado";
            Buscar("~`|`~");
            getGrupoNomina();
            getEstaciones();
            getTipoDocumento();
            pieImagen.Properties.ShowScrollBars = true;
        }

        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                newRecordRow["EmpleadoID"] = Data.DataModule.DataService.Folio("EmpleadoID", "");
                // Nota prueba
            }
        }

        private List<DataParameter> Params = new List<DataParameter>();


        #region Estacion
        public void getEstaciones()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            List<clsEstaciones> Estacion = new List<clsEstaciones>();
            clsEstaciones c = new clsEstaciones();

            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatEstacionDS, "spCatEstacion", Params.ToArray());

            dt = spCatEstacionDS.Tables["spCatEstacion"];
            Estacion = c.FillList(dt);
            bs.DataSource = Estacion;

            this.lueCambiaEstacion.Properties.DataSource = bs.List;
            this.lueCambiaEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstacionID", "Banco ID"));
            this.lueCambiaEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"));
            this.lueCambiaEstacion.Properties.DisplayMember = "Nombre";
            this.lueCambiaEstacion.Properties.ValueMember = "EstacionID";

            this.lueCambiaEstacion.Properties.DropDownRows = Estacion.Count;

        }
        #endregion

        #region Nomina
        public void getGrupoNomina()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            List<clsNomina> lstNomina = new List<clsNomina>();
            clsNomina objNomina = new clsNomina();

            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatEstacionDS, "spCatGrupoNomina", Params.ToArray());

            dt = spCatEstacionDS.Tables["spCatGrupoNomina"];
            lstNomina = objNomina.FillList(dt);
            bs.DataSource = lstNomina;

            this.lueGrupoNomina.Properties.DataSource = bs.List;
            //this.lueGrupoNomina.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GrupoNominaID", "Nomina ID"));
            this.lueGrupoNomina.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"));
            this.lueGrupoNomina.Properties.DisplayMember = "Nombre";
            this.lueGrupoNomina.Properties.ValueMember = "GrupoNominaID";

            this.lueGrupoNomina.Properties.DropDownRows = lstNomina.Count;

        }
        #endregion

        #region Documento
        List<clsTipoDocumento> lstTipoDocumento = new List<clsTipoDocumento>();
        public void getTipoDocumento()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            
            clsTipoDocumento objDocumento = new clsTipoDocumento();

            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatEstacionDS, "spCatTipoDocumento", Params.ToArray());

            dt = spCatEstacionDS.Tables["spCatTipoDocumento"];
            lstTipoDocumento = objDocumento.FillList(dt);
            bs.DataSource = lstTipoDocumento;

            this.lueTipoDocumento.Properties.DataSource = bs.List;
            //this.lueGrupoNomina.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GrupoNominaID", "Nomina ID"));
            this.lueTipoDocumento.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"));
            this.lueTipoDocumento.Properties.DisplayMember = "Nombre";
            this.lueTipoDocumento.Properties.ValueMember = "TipoDocumentoID";

            this.lueGrupoNomina.Properties.DropDownRows = lstTipoDocumento.Count;
        }
#endregion

        private void tpExpediente_Paint(object sender, PaintEventArgs e)
        {

        }

        bool Vacio = true;
        private void lueTipoDocumento_EditValueChanged(object sender, EventArgs e)
        {
            FiltrarGridDocumento();      
        }

        private void FiltrarGridDocumento()
        {
            dgcTipoDocumento.DataSource = lstDocumento.FindAll(index => (int)lueTipoDocumento.EditValue == index.TipoDocumentoID && IDEmpleado == index.EmpleadoID);
            if (Vacio)
            {
                btnNuevo.Enabled = true;
                Vacio = false;
            }
            FillControls();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                OpenFileDialog of = new OpenFileDialog();
                //For any other formats
                of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    pieImagen.Image = Image.FromFile(of.FileName);
                    
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnImagen.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
        }

        private void labelControl14_Click(object sender, EventArgs e)
        {

        }

        public DataSet cdsDocumento { get; set; }
        public string NombreDataSetDocumento { get; set; }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if(DoGuardar())
                CargarGridTipoDocumento();
        }

        public bool DoGuardar()
        {
            try
            {
                //newRecordRow["DocumentoID"] = Data.DataModule.DataService.Folio("DocumentoID", "");

                // Se manda Llenar los datos del Cliente a la estructura de los clientes del Servidor
                if(ValidarDatosDocumento())
                {
                    AsignarCamposDocumento();
                    int res;
                    res = Data.DataModule.DataService.GuardaDocumentoNuevo(datosDocumento);
                }
                else
                {
                    throw new Exception("Faltan uno o mas datos");
                }
                return true;
                //se carga a la variable global el cliente nuevo  y se cierra el form
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private bool ValidarDatosDocumento()
        {
            if(pieImagen.Image==null||(int)lueTipoDocumento.EditValue==0)
            {
                return false;
            }
            return true;
        }

        private void AsignarCamposDocumento()
        {
            //datosDocumento.DocumentoId = Data.DataModule.DataService.Folio("DocumentoID", "");
            datosDocumento.EmpleadoId = IDEmpleado;
            datosDocumento.TipoDocumentoId = (int)lueTipoDocumento.EditValue;
            datosDocumento.UsuarioId = -1;
            datosDocumento.Observaciones = memObservaciones.Text;
            datosDocumento.Fecha = System.DateTime.Now;
            string ImageString = Encoding.Default.GetString(convertImagetoByteArray(pieImagen.Image));
            datosDocumento.Imagen = ImageString;
        }

        public static byte[] convertImagetoByteArray(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }
        protected System.Windows.Forms.BindingSource DataSourceDocumento { get; set; }

        private void gvCatalogo_RowCountChanged(object sender, EventArgs e)
        {

        }
        List<clsDocumento> lstDocumento = new List<clsDocumento>();
        private void CargarGridTipoDocumento()
        {
            try
            {
                cdsDocumento.Clear();
                Params.Clear();
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();

                clsDocumento objDocumento = new clsDocumento();

                //Lenamos el DS de Categorias

                Params.Clear();

                Data.DataModule.ParamByName(Params, "Datos", "");
                Data.DataModule.FillDataSet(cdsDocumento, NombreDataSetDocumento, Params.ToArray());

                dt = spDocumentoDS.Tables[NombreDataSetDocumento];
                lstDocumento = objDocumento.FillList(dt);
                bs.DataSource = lstDocumento;
                lueTipoDocumento.EditValue=0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvCatalogo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            IDEmpleado= Convert.ToInt32(gvCatalogo.GetRowCellValue(gvCatalogo.FocusedRowHandle, "DespachadorID"));
            FiltrarGridDocumento();
        }

        private void gvTipoDocumento_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            FillControls();
        }
        private void FillControls()
        {
            if (gvTipoDocumento.DataRowCount > 0)
            {
                byte[] ImageArray = gvTipoDocumento.GetRowCellValue(gvTipoDocumento.FocusedRowHandle, "Imagen") as byte[];
                lblFecha.Text = gvTipoDocumento.GetRowCellValue(gvTipoDocumento.FocusedRowHandle, "Fecha").ToString();
                memObservaciones.Text = gvTipoDocumento.GetRowCellValue(gvTipoDocumento.FocusedRowHandle, "Observaciones").ToString();
                pieImagen.Image = convertByteArraytoImage(ImageArray);
            }
            else
            {
                pieImagen.Image= null;
                lblFecha.Text="";
                memObservaciones.Text ="";
            }
        }
        private Image convertByteArraytoImage(byte[] ByteArray)
        {
            using (MemoryStream mStream = new MemoryStream(ByteArray))
            {
                return Image.FromStream(mStream);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (gvCatalogo.DataRowCount > 0)
            {
                tpExpediente.PageEnabled = true;
                cdsDocumento = spDocumentoDS;
                DataSourceDocumento = spDocumentoBindingSource;
                NombreDataSetDocumento = "spDocumento";

                CargarGridTipoDocumento();
            }
        }
    }
}
