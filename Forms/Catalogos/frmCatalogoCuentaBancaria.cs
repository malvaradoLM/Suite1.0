using RemObjects.DataAbstract.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RPSuite.Class;


namespace RPSuite.Forms.Catalogos
{
    public partial class frmCatalogoCuentaBancaria : RPSuite.Base.frmCatalogo
    {
        public frmCatalogoCuentaBancaria()
        {
            InitializeComponent();
            cdsCatalogo = spCatCuentaBancariaDS;
            DataSource = spCatCuentaBancariaBindingSource;
            NombreDataSet = "spCatCuentaBancaria";
            Buscar("~`|`~");
        }

        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                newRecordRow["CuentaBancariaID"] = Data.DataModule.DataService.Folio("CuentaBancariaID", "");

            }
        }


        private List<DataParameter> Params = new List<DataParameter>();

        #region Banco

        public void getBancos()
        {
            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            List<clsBanco> Banco = new List<clsBanco>();
            clsBanco c = new clsBanco();

            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatBancoDS, "spCatbanco", Params.ToArray());

            dt = spCatBancoDS.Tables["spcatbanco"];
            Banco = c.FillList(dt);
            bs.DataSource = Banco;

            this.lueBanco.Properties.DataSource = bs.List;
            this.lueBanco.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BancoID", "Banco ID"));
            this.lueBanco.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"));
            this.lueBanco.Properties.DisplayMember = "Nombre";
            this.lueBanco.Properties.ValueMember = "BancoID";

            this.lueBanco.Properties.DropDownRows = Banco.Count;



        }


        #endregion


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

            this.lueEstacion.Properties.DataSource = bs.List;
            this.lueEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EstacionID", "Banco ID"));
            this.lueEstacion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"));
            this.lueEstacion.Properties.DisplayMember = "Nombre";
            this.lueEstacion.Properties.ValueMember = "EstacionID";

            this.lueEstacion.Properties.DropDownRows = Estacion.Count;

        }



        #endregion

        private void frmCatalogoCuentaBancaria_Load(object sender, EventArgs e)
        {
            getBancos();
            getEstaciones();

        }
    }
}
