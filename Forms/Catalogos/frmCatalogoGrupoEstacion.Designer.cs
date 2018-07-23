namespace RPSuite.Forms.Catalogos
{
    partial class frmCatalogoGrupoEstacion
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
            this.spCatGrupoEstacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spCatGrupoEstacionDS1 = new RPSuite.Datasets.Catalogos.spCatGrupoEstacionDS();
            this.colGrupoEstacionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDatos = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.txtGrupoEstacion = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.spCatGrupoEstacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatGrupoEstacionDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatos)).BeginInit();
            this.gcDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupoEstacion.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.tpDatos.Controls.Add(this.gcDatos);
            // 
            // dgcCatalogo
            // 
            this.dgcCatalogo.DataSource = this.spCatGrupoEstacionBindingSource;
            // 
            // gvCatalogo
            // 
            this.gvCatalogo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGrupoEstacionID,
            this.colDescripcion});
            this.gvCatalogo.OptionsBehavior.Editable = false;
            this.gvCatalogo.OptionsFind.AlwaysVisible = true;
            this.gvCatalogo.OptionsFind.SearchInPreview = true;
            this.gvCatalogo.OptionsFind.ShowClearButton = false;
            this.gvCatalogo.OptionsFind.ShowCloseButton = false;
            this.gvCatalogo.OptionsFind.ShowFindButton = false;
            this.gvCatalogo.OptionsSelection.MultiSelect = true;
            this.gvCatalogo.OptionsView.ColumnAutoWidth = false;
            // 
            // spCatGrupoEstacionBindingSource
            // 
            this.spCatGrupoEstacionBindingSource.DataMember = "spCatGrupoEstacion";
            this.spCatGrupoEstacionBindingSource.DataSource = this.spCatGrupoEstacionDS1;
            this.spCatGrupoEstacionBindingSource.Sort = "";
            // 
            // spCatGrupoEstacionDS1
            // 
            this.spCatGrupoEstacionDS1.DataSetName = "spCatGrupoEstacionDS";
            this.spCatGrupoEstacionDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colGrupoEstacionID
            // 
            this.colGrupoEstacionID.FieldName = "GrupoEstacionID";
            this.colGrupoEstacionID.Name = "colGrupoEstacionID";
            this.colGrupoEstacionID.Visible = true;
            this.colGrupoEstacionID.VisibleIndex = 0;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // gcDatos
            // 
            this.gcDatos.Controls.Add(this.txtGrupoEstacion);
            this.gcDatos.Controls.Add(this.txtID);
            this.gcDatos.Controls.Add(this.labelControl2);
            this.gcDatos.Controls.Add(this.labelControl1);
            this.gcDatos.Location = new System.Drawing.Point(38, 25);
            this.gcDatos.Name = "gcDatos";
            this.gcDatos.Size = new System.Drawing.Size(408, 206);
            this.gcDatos.TabIndex = 0;
            this.gcDatos.Text = "Datos";
            this.gcDatos.Paint += new System.Windows.Forms.PaintEventHandler(this.gcDatos_Paint);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Grupo Estacion";
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatGrupoEstacionBindingSource, "GrupoEstacionID", true));
            this.txtID.Location = new System.Drawing.Point(26, 61);
            this.txtID.Name = "txtID";
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(57, 20);
            this.txtID.TabIndex = 2;
            // 
            // txtGrupoEstacion
            // 
            this.txtGrupoEstacion.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatGrupoEstacionBindingSource, "Descripcion", true));
            this.txtGrupoEstacion.Location = new System.Drawing.Point(26, 109);
            this.txtGrupoEstacion.Name = "txtGrupoEstacion";
            this.txtGrupoEstacion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGrupoEstacion.Size = new System.Drawing.Size(355, 20);
            this.txtGrupoEstacion.TabIndex = 3;
            // 
            // frmCatalogoGrupoEstacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(680, 307);
            this.Name = "frmCatalogoGrupoEstacion";
            this.Text = "Grupo Estacion";
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
            ((System.ComponentModel.ISupportInitialize)(this.spCatGrupoEstacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatGrupoEstacionDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatos)).EndInit();
            this.gcDatos.ResumeLayout(false);
            this.gcDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupoEstacion.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource spCatGrupoEstacionBindingSource;
        private Datasets.Catalogos.spCatGrupoEstacionDS spCatGrupoEstacionDS1;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupoEstacionID;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraEditors.GroupControl gcDatos;
        private DevExpress.XtraEditors.TextEdit txtGrupoEstacion;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
