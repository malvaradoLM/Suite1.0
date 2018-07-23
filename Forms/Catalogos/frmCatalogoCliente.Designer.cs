namespace RPSuite.Forms.Catalogos
{
    partial class frmCatalogoCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.spCatClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spCatClienteDS = new RPSuite.Datasets.Catalogos.spCatClienteDS();
            ((System.ComponentModel.ISupportInitialize)(this.tcCatalogo)).BeginInit();
            this.tcCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBusqueda)).BeginInit();
            this.gcBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatosBusqueda.Properties)).BeginInit();
            this.tpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatClienteDS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageOptions.ImageIndex = 0;
            // 
            // txtDatosBusqueda
            // 
            // 
            // tpBuscar
            // 
            this.tpBuscar.ImageOptions.ImageIndex = 0;
            this.tpBuscar.ImageOptions.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tpBuscar.Size = new System.Drawing.Size(678, 279);
            // 
            // tpDatos
            // 
            this.tpDatos.ImageOptions.ImageIndex = 1;
            this.tpDatos.ImageOptions.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tpDatos.Size = new System.Drawing.Size(678, 279);
            // 
            // dgcCatalogo
            // 
            this.dgcCatalogo.DataSource = this.spCatClienteBindingSource;
            this.dgcCatalogo.Size = new System.Drawing.Size(678, 179);
            // 
            // gvCatalogo
            // 
            this.gvCatalogo.OptionsBehavior.Editable = false;
            this.gvCatalogo.OptionsFind.AlwaysVisible = true;
            this.gvCatalogo.OptionsFind.SearchInPreview = true;
            this.gvCatalogo.OptionsFind.ShowClearButton = false;
            this.gvCatalogo.OptionsFind.ShowCloseButton = false;
            this.gvCatalogo.OptionsFind.ShowFindButton = false;
            this.gvCatalogo.OptionsSelection.MultiSelect = true;
            this.gvCatalogo.OptionsView.ColumnAutoWidth = false;
            // 
            // spCatClienteBindingSource
            // 
            this.spCatClienteBindingSource.DataMember = "spCatCliente";
            this.spCatClienteBindingSource.DataSource = this.spCatClienteDS;
            this.spCatClienteBindingSource.Sort = "";
            // 
            // spCatClienteDS
            // 
            this.spCatClienteDS.DataSetName = "spCatClienteDS";
            this.spCatClienteDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmCatalogoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(680, 307);
            this.Name = "frmCatalogoCliente";
            this.Text = "Catálogo Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.tcCatalogo)).EndInit();
            this.tcCatalogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBusqueda)).EndInit();
            this.gcBusqueda.ResumeLayout(false);
            this.gcBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatosBusqueda.Properties)).EndInit();
            this.tpBuscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatClienteDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource spCatClienteBindingSource;
        private Datasets.Catalogos.spCatClienteDS spCatClienteDS;
    }
}
