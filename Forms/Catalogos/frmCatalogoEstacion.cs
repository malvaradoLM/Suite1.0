using RemObjects.DataAbstract.Server;
using RPSuite.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPSuite.Forms.Catalogos
{
    public partial class frmCatalogoEstacion : RPSuite.Base.frmCatalogo
    {
        //Lista de Parametros
        private List<DataParameter> Params = new List<DataParameter>();

        public frmCatalogoEstacion()
        {
            InitializeComponent();

            cdsCatalogo = spCatEstacionDS;
            DataSource = spCatEstacionBindingSource;
            NombreDataSet = "spCatEstacion";
            Buscar("~`|`~");

        }


        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                //   newRecordRow["GasolineroID"] = Data.DataModule.DataService.Folio("GasolineroID", "");
                // Nota prueba
            }
        }

        private void textEdit11_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmCatalogoEstacion_Load(object sender, EventArgs e)
        {
            //Cargar los Estados al combo
            GlobalVar.CargarEstados();
            lueEstado.Properties.DataSource = GlobalVar.Estados;
            lueEstado.Properties.DataSource = GlobalVar.Estados;

            //Cargar los Estados al combo Expedido En
           // GlobalVar.CargarEstados();
            lueExEstado.Properties.DataSource = GlobalVar.Estados;
            lueExEstado.Properties.DataSource = GlobalVar.Estados;


            //Cargar RegimenFiscal
            getRegimenFiscal();
            getGrupoEstacion();
            getGasolinero();
        }

        #region RegimenFiscal
        public void getRegimenFiscal()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            List<clsRegimenFiscal> ListadeClase = new List<clsRegimenFiscal>();
            clsRegimenFiscal c = new clsRegimenFiscal();

            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatEstacionDS, "spRegimenFiscal", Params.ToArray());

            dt = spCatEstacionDS.Tables["spRegimenFiscal"];
            ListadeClase = c.FillList(dt);
            bs.DataSource = ListadeClase;

            this.lueRegimenFiscal.Properties.DataSource = bs.List;
            this.lueRegimenFiscal.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoSAT", "Codigo SAT"));
            this.lueRegimenFiscal.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion"));
            this.lueRegimenFiscal.Properties.DisplayMember = "Descripcion";
            this.lueRegimenFiscal.Properties.ValueMember = "RegimenFiscalID";

            this.lueRegimenFiscal.Properties.DropDownRows = ListadeClase.Count;


        }
        #endregion

        #region GrupoGasolinero
        public void getGrupoEstacion()
        {
            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            List<clsGrupoEstacion> ListadeClase = new List<clsGrupoEstacion>();
            clsGrupoEstacion c = new clsGrupoEstacion();

            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatEstacionDS, "spCatGrupoEstacion", Params.ToArray());

            dt = spCatEstacionDS.Tables["spCatGrupoEstacion"];
            ListadeClase = c.FillList(dt);
            bs.DataSource = ListadeClase;

            this.lueGrupoEstacion.Properties.DataSource = bs.List;
            this.lueGrupoEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GrupoEstacionID", "ID"));
            this.lueGrupoEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion"));
            this.lueGrupoEstacion.Properties.DisplayMember = "Descripcion";
            this.lueGrupoEstacion.Properties.ValueMember = "GrupoEstacionID";

            this.lueGrupoEstacion.Properties.DropDownRows = ListadeClase.Count;

        }
        #endregion

        #region Gasolinero
        public void getGasolinero()
        {
            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            List<clsGasolinero> ListadeClase = new List<clsGasolinero>();
            clsGasolinero c = new clsGasolinero();

            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatEstacionDS, "spCatGasolinero", Params.ToArray());

            dt = spCatEstacionDS.Tables["spCatGasolinero"];
            ListadeClase = c.FillList(dt);
            bs.DataSource = ListadeClase;

            this.lueGasolinero.Properties.DataSource = bs.List;
            this.lueGasolinero.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GasolineroID", "ID"));
            this.lueGasolinero.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion"));
            this.lueGasolinero.Properties.DisplayMember = "Descripcion";
            this.lueGasolinero.Properties.ValueMember = "GasolineroID";

            this.lueGasolinero.Properties.DropDownRows = ListadeClase.Count;

        }
        #endregion

        private void tpCertificado_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
