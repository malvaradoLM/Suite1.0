namespace RPSuite.Forms.Catalogos
{
    partial class frmCatalogoCategoria
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.spCatCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spCatCategoriaDS = new RPSuite.Datasets.Catalogos.spCatCategoriaDS();
            this.colCategoriaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDatos = new DevExpress.XtraEditors.GroupControl();
            this.txtCategoria = new DevExpress.XtraEditors.TextEdit();
            this.txtCategoriaID = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.spCatCategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatCategoriaDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatos)).BeginInit();
            this.gcDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoriaID.Properties)).BeginInit();
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
            this.dgcCatalogo.DataSource = this.spCatCategoriaBindingSource;
            // 
            // gvCatalogo
            // 
            this.gvCatalogo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCategoriaID,
            this.colNombre});
            this.gvCatalogo.OptionsBehavior.Editable = false;
            this.gvCatalogo.OptionsFind.AlwaysVisible = true;
            this.gvCatalogo.OptionsFind.SearchInPreview = true;
            this.gvCatalogo.OptionsFind.ShowClearButton = false;
            this.gvCatalogo.OptionsFind.ShowCloseButton = false;
            this.gvCatalogo.OptionsFind.ShowFindButton = false;
            this.gvCatalogo.OptionsSelection.MultiSelect = true;
            this.gvCatalogo.OptionsView.ColumnAutoWidth = false;
            // 
            // vpValidador
            // 
            this.vpValidador.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            // 
            // spCatCategoriaBindingSource
            // 
            this.spCatCategoriaBindingSource.DataMember = "spCatCategoria";
            this.spCatCategoriaBindingSource.DataSource = this.spCatCategoriaDS;
            this.spCatCategoriaBindingSource.Sort = "";
            // 
            // spCatCategoriaDS
            // 
            this.spCatCategoriaDS.DataSetName = "spCatCategoriaDS";
            this.spCatCategoriaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colCategoriaID
            // 
            this.colCategoriaID.FieldName = "CategoriaID";
            this.colCategoriaID.Name = "colCategoriaID";
            this.colCategoriaID.Visible = true;
            this.colCategoriaID.VisibleIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            // 
            // gcDatos
            // 
            this.gcDatos.Controls.Add(this.txtCategoria);
            this.gcDatos.Controls.Add(this.txtCategoriaID);
            this.gcDatos.Controls.Add(this.labelControl2);
            this.gcDatos.Controls.Add(this.labelControl1);
            this.gcDatos.Location = new System.Drawing.Point(34, 24);
            this.gcDatos.Name = "gcDatos";
            this.gcDatos.Size = new System.Drawing.Size(449, 194);
            this.gcDatos.TabIndex = 0;
            this.gcDatos.Text = "Datos";
            // 
            // txtCategoria
            // 
            this.txtCategoria.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatCategoriaBindingSource, "Nombre", true));
            this.txtCategoria.Location = new System.Drawing.Point(38, 104);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCategoria.Properties.MaxLength = 30;
            this.txtCategoria.Size = new System.Drawing.Size(350, 20);
            this.txtCategoria.TabIndex = 3;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Falta agregar Categoria";
            this.vpValidador.SetValidationRule(this.txtCategoria, conditionValidationRule1);
            // 
            // txtCategoriaID
            // 
            this.txtCategoriaID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatCategoriaBindingSource, "CategoriaID", true));
            this.txtCategoriaID.Location = new System.Drawing.Point(38, 59);
            this.txtCategoriaID.Name = "txtCategoriaID";
            this.txtCategoriaID.Properties.ReadOnly = true;
            this.txtCategoriaID.Size = new System.Drawing.Size(100, 20);
            this.txtCategoriaID.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(38, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Categoria";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(38, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(10, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Id";
            // 
            // frmCatalogoCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(680, 307);
            this.Name = "frmCatalogoCategoria";
            this.Text = "Catalogo Categoria";
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
            ((System.ComponentModel.ISupportInitialize)(this.spCatCategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatCategoriaDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatos)).EndInit();
            this.gcDatos.ResumeLayout(false);
            this.gcDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoriaID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource spCatCategoriaBindingSource;
        private Datasets.Catalogos.spCatCategoriaDS spCatCategoriaDS;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoriaID;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraEditors.GroupControl gcDatos;
        private DevExpress.XtraEditors.TextEdit txtCategoria;
        private DevExpress.XtraEditors.TextEdit txtCategoriaID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
