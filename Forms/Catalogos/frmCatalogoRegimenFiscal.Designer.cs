namespace RPSuite.Forms.Catalogos
{
    partial class frmCatalogoRegimenFiscal
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
            this.spRegimenFiscalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spCatRegimenFiscalDS = new RPSuite.Datasets.Catalogos.spCatRegimenFiscalDS();
            this.colRegimenFiscalID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoSAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Datos = new DevExpress.XtraEditors.GroupControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.txtClaveSAT = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tcCatalogo)).BeginInit();
            this.tcCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBusqueda)).BeginInit();
            this.gcBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatosBusqueda.Properties)).BeginInit();
            this.tpBuscar.SuspendLayout();
            this.tpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRegimenFiscalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatRegimenFiscalDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            this.Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClaveSAT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCatalogo
            // 
            this.tcCatalogo.SelectedTabPage = this.tpBuscar;
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageOptions.ImageIndex = 0;
            // 
            // txtDatosBusqueda
            // 
            // 
            // tpDatos
            // 
            this.tpDatos.Controls.Add(this.Datos);
            // 
            // dgcCatalogo
            // 
            this.dgcCatalogo.DataSource = this.spRegimenFiscalBindingSource;
            // 
            // gvCatalogo
            // 
            this.gvCatalogo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRegimenFiscalID,
            this.colDescripcion,
            this.colCodigoSAT});
            this.gvCatalogo.OptionsBehavior.Editable = false;
            this.gvCatalogo.OptionsFind.AlwaysVisible = true;
            this.gvCatalogo.OptionsFind.SearchInPreview = true;
            this.gvCatalogo.OptionsFind.ShowClearButton = false;
            this.gvCatalogo.OptionsFind.ShowCloseButton = false;
            this.gvCatalogo.OptionsFind.ShowFindButton = false;
            this.gvCatalogo.OptionsSelection.MultiSelect = true;
            this.gvCatalogo.OptionsView.ColumnAutoWidth = false;
            // 
            // spRegimenFiscalBindingSource
            // 
            this.spRegimenFiscalBindingSource.DataMember = "spRegimenFiscal";
            this.spRegimenFiscalBindingSource.DataSource = this.spCatRegimenFiscalDS;
            this.spRegimenFiscalBindingSource.Sort = "";
            // 
            // spCatRegimenFiscalDS
            // 
            this.spCatRegimenFiscalDS.DataSetName = "spCatRegimenFiscal";
            this.spCatRegimenFiscalDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colRegimenFiscalID
            // 
            this.colRegimenFiscalID.FieldName = "RegimenFiscalID";
            this.colRegimenFiscalID.Name = "colRegimenFiscalID";
            this.colRegimenFiscalID.Visible = true;
            this.colRegimenFiscalID.VisibleIndex = 0;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // colCodigoSAT
            // 
            this.colCodigoSAT.FieldName = "CodigoSAT";
            this.colCodigoSAT.Name = "colCodigoSAT";
            this.colCodigoSAT.Visible = true;
            this.colCodigoSAT.VisibleIndex = 2;
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.txtDescripcion);
            this.Datos.Controls.Add(this.txtClaveSAT);
            this.Datos.Controls.Add(this.txtID);
            this.Datos.Controls.Add(this.labelControl3);
            this.Datos.Controls.Add(this.labelControl2);
            this.Datos.Controls.Add(this.labelControl1);
            this.Datos.Location = new System.Drawing.Point(35, 30);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(401, 193);
            this.Datos.TabIndex = 0;
            this.Datos.Text = "Datos";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spRegimenFiscalBindingSource, "Descripcion", true));
            this.txtDescripcion.Location = new System.Drawing.Point(24, 156);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(348, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtClaveSAT
            // 
            this.txtClaveSAT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spRegimenFiscalBindingSource, "CodigoSAT", true));
            this.txtClaveSAT.Location = new System.Drawing.Point(24, 104);
            this.txtClaveSAT.Name = "txtClaveSAT";
            this.txtClaveSAT.Size = new System.Drawing.Size(65, 20);
            this.txtClaveSAT.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spRegimenFiscalBindingSource, "RegimenFiscalID", true));
            this.txtID.Location = new System.Drawing.Point(24, 52);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(65, 20);
            this.txtID.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(24, 137);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Descripcion";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Clave SAT";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Regimen ID";
            // 
            // frmCatalogoRegimenFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(680, 307);
            this.Name = "frmCatalogoRegimenFiscal";
            this.Text = "Regimen Fiscal";
            ((System.ComponentModel.ISupportInitialize)(this.tcCatalogo)).EndInit();
            this.tcCatalogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBusqueda)).EndInit();
            this.gcBusqueda.ResumeLayout(false);
            this.gcBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatosBusqueda.Properties)).EndInit();
            this.tpBuscar.ResumeLayout(false);
            this.tpDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRegimenFiscalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatRegimenFiscalDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            this.Datos.ResumeLayout(false);
            this.Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClaveSAT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource spRegimenFiscalBindingSource;
        private Datasets.Catalogos.spCatRegimenFiscalDS spCatRegimenFiscalDS;
        private DevExpress.XtraGrid.Columns.GridColumn colRegimenFiscalID;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoSAT;
        private DevExpress.XtraEditors.GroupControl Datos;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.TextEdit txtClaveSAT;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
