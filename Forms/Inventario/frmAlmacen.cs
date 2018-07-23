using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using RemObjects.DataAbstract.Server;
using RPSuite.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPSuite.Forms.Inventario
{
    public partial class frmAlmacen : RPSuite.Base.frmEstructura
    {
        public DateTime CurrentDateTime { get { return DateTime.Now; } }
        private List<DataParameter> Params = new List<DataParameter>();

        public frmAlmacen()
        {

            InitializeComponent();
            dtFecha.EditValue = CurrentDateTime;

            //Agrega Imagen al Boton de Datos Cliente
            tbControl.Images = RPSuite.Data.DataModule.Images16;
            tpDatos.ImageOptions.ImageIndex = 1;
            GetProveedores();
            GetTipoMovimiento();
            GetEstacion();
        }


        private void GetFolio()
        {
            DataTable dt = new DataTable();
            Folio folio = new Folio();
            Params.Clear();
            Data.DataModule.ParamByName(Params, "Datos", "MovimientoAlmacen");
            Data.DataModule.FillDataSet(spCatFolioDS, "spCatFolio", Params.ToArray());
            dt = spCatFolioDS.Tables["spCatFolio"];
            txtFolio.Text = Convert.ToString(folio.FillList(dt));
        }


        public override void DoNuevo(object key, object sender, EventArgs e)
        {
            base.DoNuevo(key, sender, e);
            GetFolio();
            pcDatosAlmacen.Enabled = true;
            pcgrid.Enabled = true;
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
            pcDatosAlmacen.Enabled = false;
            pcgrid.Enabled = false;

        }
        private void textEdit5_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        //CargarValores a los Combos
        #region CargarValores



        // Se llena el Combo de Las estaciones
        public void GetEstacion()
        {
            //variables
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            List<FillCombos> Estaciones = new List<FillCombos>();
            FillCombos e = new FillCombos();


            ////llenamos DS de Estaciones
            Params.Clear();
            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatEstacionDS, "spCatEstacion", Params.ToArray());
            dt = spCatEstacionDS.Tables["spCatEstacion"];
            Estaciones = e.FillListCombo(dt, "EstacionID", "Nombre");
            bs.DataSource = Estaciones;

            this.lueEstacionDestino.Properties.DataSource = bs.List;
            this.lueEstacionDestino.Properties.Columns.Add(new LookUpColumnInfo("ID", "EstacionID"));
            this.lueEstacionDestino.Properties.Columns.Add(new LookUpColumnInfo("Nombre", "Nombre"));
            this.lueEstacionDestino.Properties.DisplayMember = "Nombre";
            this.lueEstacionDestino.Properties.ValueMember = "ID";
            // Specify the dropdown height.
            this.lueEstacionDestino.Properties.DropDownRows = Estaciones.Count;



        }

        //  Llenamos el Combo de los Proveedores
        public void GetProveedores()
        {
            //variables
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            List<FillCombos> proveedor = new List<FillCombos>();
            FillCombos e = new FillCombos();


            ////llenamos DS de Almacen
            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatProveedorDS, "spCatProveedor", Params.ToArray());
            dt = spCatProveedorDS.Tables["spCatProveedor"];
            proveedor = e.FillListCombo(dt, "ProveedorId", "Nombre");
            bs.DataSource = proveedor;

            this.lueProveedor.Properties.DataSource = bs.List;
            this.lueProveedor.Properties.Columns.Add(new LookUpColumnInfo("ID", "ProveedorId"));
            this.lueProveedor.Properties.Columns.Add(new LookUpColumnInfo("Nombre", "Nombre"));
            this.lueProveedor.Properties.DisplayMember = "Nombre";
            this.lueProveedor.Properties.ValueMember = "ID";
            // Specify the dropdown height.
            this.lueProveedor.Properties.DropDownRows = proveedor.Count;

        }
        public void GetTipoMovimiento()
        {
            //variables
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            List<FillCombos> TipoMovimiento = new List<FillCombos>();
            FillCombos e = new FillCombos();


            ////llenamos DS de TipoMovimiento
            ;
            Data.DataModule.FillDataSet(spCatTipoMovimientoDS, "spCatTipoMovimiento", null);
            dt = spCatTipoMovimientoDS.Tables["spCatTipoMovimiento"];
            TipoMovimiento = e.FillListCombo(dt, "TipoMovimientoAlmacenID", "Nombre");
            bs.DataSource = TipoMovimiento;

            this.lueTipoMovimiento.Properties.DataSource = bs.List;
            this.lueTipoMovimiento.Properties.Columns.Add(new LookUpColumnInfo("ID", "TipoMovimientoAlmacenID"));
            this.lueTipoMovimiento.Properties.Columns.Add(new LookUpColumnInfo("Nombre", "Nombre"));
            this.lueTipoMovimiento.Properties.DisplayMember = "Nombre";
            this.lueTipoMovimiento.Properties.ValueMember = "ID";
            // Specify the dropdown height.
            this.lueTipoMovimiento.Properties.DropDownRows = TipoMovimiento.Count;

        }


        #endregion

        private void lueTipoMovimiento_EditValueChanged(object sender, EventArgs e)
        {
            //Para cuando seleccionamos o cambiamos en el cmd TipoMovimiento
            LookUpEdit edit = sender as LookUpEdit;
            object obj = lueTipoMovimiento.Properties.GetDataSourceRowByKeyValue(edit.EditValue);

            if (TypeDescriptor.GetProperties(obj)["Nombre"].GetValue(obj).ToString() == "Salida por Traspaso")
            {
                lueEstacionDestino.Enabled = true;
                lueAlmacenDestino.Enabled = true;
            }
            else
            {
                lueEstacionDestino.Enabled = false;
                lueAlmacenDestino.Enabled = false;
            }
        }

        private void lueEstacionDestino_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit edit = sender as LookUpEdit;
            object obj = lueEstacionDestino.Properties.GetDataSourceRowByKeyValue(edit.EditValue);

           // GetAlmacen(TypeDescriptor.GetProperties(obj)["ID"].GetValue(obj).ToString());
        }


    }
}
