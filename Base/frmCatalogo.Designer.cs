namespace RPSuite.Base
{
    partial class frmCatalogo
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
            this.tcCatalogo = new DevExpress.XtraTab.XtraTabControl();
            this.tpBuscar = new DevExpress.XtraTab.XtraTabPage();
            this.dgcCatalogo = new DevExpress.XtraGrid.GridControl();
            this.gvCatalogo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcBusqueda = new DevExpress.XtraEditors.GroupControl();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.txtDatosBusqueda = new DevExpress.XtraEditors.TextEdit();
            this.lblDatosBusqueda = new DevExpress.XtraEditors.LabelControl();
            this.tpDatos = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcCatalogo)).BeginInit();
            this.tcCatalogo.SuspendLayout();
            this.tpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBusqueda)).BeginInit();
            this.gcBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatosBusqueda.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCatalogo
            // 
            this.tcCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCatalogo.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            this.tcCatalogo.Location = new System.Drawing.Point(0, 0);
            this.tcCatalogo.Name = "tcCatalogo";
            this.tcCatalogo.SelectedTabPage = this.tpBuscar;
            this.tcCatalogo.Size = new System.Drawing.Size(680, 307);
            this.tcCatalogo.TabIndex = 0;
            this.tcCatalogo.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpBuscar,
            this.tpDatos});
            // 
            // tpBuscar
            // 
            this.tpBuscar.Controls.Add(this.dgcCatalogo);
            this.tpBuscar.Controls.Add(this.gcBusqueda);
            this.tpBuscar.Name = "tpBuscar";
            this.tpBuscar.Size = new System.Drawing.Size(678, 282);
            this.tpBuscar.Text = "Buscar";
            // 
            // dgcCatalogo
            // 
            this.dgcCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcCatalogo.Location = new System.Drawing.Point(0, 100);
            this.dgcCatalogo.MainView = this.gvCatalogo;
            this.dgcCatalogo.Name = "dgcCatalogo";
            this.dgcCatalogo.Size = new System.Drawing.Size(678, 182);
            this.dgcCatalogo.TabIndex = 2;
            this.dgcCatalogo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCatalogo});
            // 
            // gvCatalogo
            // 
            this.gvCatalogo.GridControl = this.dgcCatalogo;
            this.gvCatalogo.Name = "gvCatalogo";
            this.gvCatalogo.OptionsBehavior.Editable = false;
            this.gvCatalogo.OptionsFind.AlwaysVisible = true;
            this.gvCatalogo.OptionsFind.SearchInPreview = true;
            this.gvCatalogo.OptionsFind.ShowClearButton = false;
            this.gvCatalogo.OptionsFind.ShowCloseButton = false;
            this.gvCatalogo.OptionsFind.ShowFindButton = false;
            this.gvCatalogo.OptionsSelection.MultiSelect = true;
            this.gvCatalogo.OptionsView.ColumnAutoWidth = false;
            this.gvCatalogo.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvCatalogo_FocusedRowChanged_1);
            this.gvCatalogo.DoubleClick += new System.EventHandler(this.gvCatalogo_DoubleClick);
            // 
            // gcBusqueda
            // 
            this.gcBusqueda.Controls.Add(this.btnBuscar);
            this.gcBusqueda.Controls.Add(this.txtDatosBusqueda);
            this.gcBusqueda.Controls.Add(this.lblDatosBusqueda);
            this.gcBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcBusqueda.Location = new System.Drawing.Point(0, 0);
            this.gcBusqueda.Name = "gcBusqueda";
            this.gcBusqueda.Size = new System.Drawing.Size(678, 100);
            this.gcBusqueda.TabIndex = 0;
            this.gcBusqueda.Text = "Busqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageOptions.ImageIndex = 0;
            this.btnBuscar.Location = new System.Drawing.Point(370, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDatosBusqueda
            // 
            this.txtDatosBusqueda.Location = new System.Drawing.Point(13, 52);
            this.txtDatosBusqueda.Name = "txtDatosBusqueda";
            this.txtDatosBusqueda.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDatosBusqueda.Size = new System.Drawing.Size(351, 20);
            this.txtDatosBusqueda.TabIndex = 1;
            // 
            // lblDatosBusqueda
            // 
            this.lblDatosBusqueda.Location = new System.Drawing.Point(13, 33);
            this.lblDatosBusqueda.Name = "lblDatosBusqueda";
            this.lblDatosBusqueda.Size = new System.Drawing.Size(82, 13);
            this.lblDatosBusqueda.TabIndex = 0;
            this.lblDatosBusqueda.Text = "Datos Busqueda:";
            // 
            // tpDatos
            // 
            this.tpDatos.Name = "tpDatos";
            this.tpDatos.Size = new System.Drawing.Size(678, 282);
            this.tpDatos.Text = "Datos";
            // 
            // frmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(680, 307);
            this.Controls.Add(this.tcCatalogo);
            this.Name = "frmCatalogo";
            this.Text = "frmCatalogo";
            this.Load += new System.EventHandler(this.frmCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcCatalogo)).EndInit();
            this.tcCatalogo.ResumeLayout(false);
            this.tpBuscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBusqueda)).EndInit();
            this.gcBusqueda.ResumeLayout(false);
            this.gcBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatosBusqueda.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraTab.XtraTabControl tcCatalogo;
        public DevExpress.XtraEditors.GroupControl gcBusqueda;
        public DevExpress.XtraEditors.SimpleButton btnBuscar;
        public DevExpress.XtraEditors.TextEdit txtDatosBusqueda;
        public DevExpress.XtraEditors.LabelControl lblDatosBusqueda;
        public DevExpress.XtraTab.XtraTabPage tpBuscar;
        public DevExpress.XtraTab.XtraTabPage tpDatos;
        public DevExpress.XtraGrid.GridControl dgcCatalogo;
        public DevExpress.XtraGrid.Views.Grid.GridView gvCatalogo;
    }
}
