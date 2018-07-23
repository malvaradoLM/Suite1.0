using RemObjects.DataAbstract.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RPSuite.Class;

namespace RPSuite.Forms
{
    public partial class frmCatalogoProducto : RPSuite.Base.frmCatalogo
    {
        public frmCatalogoProducto()
        {
            InitializeComponent();
            cdsCatalogo = spCatProductoDS;
            DataSource = spCatProductoBindingSource;
            NombreDataSet = "spCatProducto";
            Buscar("~`|`~");
        }

        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                newRecordRow["ProductoID"] = Data.DataModule.DataService.Folio("ProductoID", "");
                
            }
        }


        #region Categorias

        private List<DataParameter> Params = new List<DataParameter>();

        public void getCategorias()
        {
            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            List<clsCategoria> Categoria = new List<clsCategoria>();
            clsCategoria c = new clsCategoria();

            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatCategoriaDS, "spCatCategoria", Params.ToArray());

            dt = spCatCategoriaDS.Tables["spcatCategoria"];
            Categoria = c.FillList(dt);
            bs.DataSource = Categoria;

            this.lueCategoria.Properties.DataSource = bs.List;
            this.lueCategoria.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoriaID", "Categoria ID"));
            this.lueCategoria.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Categoria"));
            this.lueCategoria.Properties.DisplayMember = "Nombre";
            this.lueCategoria.Properties.ValueMember = "CategoriaID";

            this.lueCategoria.Properties.DropDownRows = Categoria.Count;



        }


        #endregion

        private void frmCatalogoProducto_Load(object sender, EventArgs e)
        {
            getCategorias();
        }
    }
}
