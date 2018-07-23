namespace RPSuite.Forms
{
    partial class frmCatalogoProveedor
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtDiasPlazo = new DevExpress.XtraEditors.TextEdit();
            this.spCatProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spCatProveedorDS = new RPSuite.Datasets.Catalogos.spCatProveedorDS();
            this.txtCuentaContable = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtFax = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.txtRFC = new DevExpress.XtraEditors.TextEdit();
            this.txtCuidad = new DevExpress.XtraEditors.TextEdit();
            this.txtColonia = new DevExpress.XtraEditors.TextEdit();
            this.txtCalle = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.colProveedorId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColonia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCiudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodPostal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiasPlazo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuentaContable = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasPlazo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatProveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatProveedorDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaContable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColonia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCatalogo
            // 
            this.tcCatalogo.Size = new System.Drawing.Size(640, 450);
            // 
            // gcBusqueda
            // 
            this.gcBusqueda.Size = new System.Drawing.Size(638, 100);
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
            this.tpBuscar.Size = new System.Drawing.Size(638, 425);
            // 
            // tpDatos
            // 
            this.tpDatos.Controls.Add(this.groupControl1);
            this.tpDatos.Size = new System.Drawing.Size(638, 425);
            // 
            // dgcCatalogo
            // 
            this.dgcCatalogo.DataSource = this.spCatProveedorBindingSource;
            this.dgcCatalogo.Size = new System.Drawing.Size(638, 325);
            // 
            // gvCatalogo
            // 
            this.gvCatalogo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProveedorId,
            this.colNombre,
            this.colCalle,
            this.colColonia,
            this.colCiudad,
            this.colRFC,
            this.colTelefono,
            this.colFax,
            this.colCodPostal,
            this.colEmail,
            this.colReferencia,
            this.colDiasPlazo,
            this.colCuentaContable});
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtDiasPlazo);
            this.groupControl1.Controls.Add(this.txtCuentaContable);
            this.groupControl1.Controls.Add(this.txtEmail);
            this.groupControl1.Controls.Add(this.txtFax);
            this.groupControl1.Controls.Add(this.txtTelefono);
            this.groupControl1.Controls.Add(this.txtRFC);
            this.groupControl1.Controls.Add(this.txtCuidad);
            this.groupControl1.Controls.Add(this.txtColonia);
            this.groupControl1.Controls.Add(this.txtCalle);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtNombre);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtProveedor);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(28, 11);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(571, 396);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Datos";
            // 
            // txtDiasPlazo
            // 
            this.txtDiasPlazo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProveedorBindingSource, "DiasPlazo", true));
            this.txtDiasPlazo.Location = new System.Drawing.Point(282, 348);
            this.txtDiasPlazo.Name = "txtDiasPlazo";
            this.txtDiasPlazo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDiasPlazo.Size = new System.Drawing.Size(234, 20);
            this.txtDiasPlazo.TabIndex = 21;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Between;
            conditionValidationRule1.ErrorText = "Escriba un Valor entre 0 -100";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            conditionValidationRule1.Value1 = "0";
            conditionValidationRule1.Value2 = "100";
            this.vpValidador.SetValidationRule(this.txtDiasPlazo, conditionValidationRule1);
            // 
            // spCatProveedorBindingSource
            // 
            this.spCatProveedorBindingSource.DataMember = "spCatProveedor";
            this.spCatProveedorBindingSource.DataSource = this.spCatProveedorDS;
            this.spCatProveedorBindingSource.Sort = "";
            // 
            // spCatProveedorDS
            // 
            this.spCatProveedorDS.DataSetName = "spCatProveedorDS";
            this.spCatProveedorDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCuentaContable
            // 
            this.txtCuentaContable.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProveedorBindingSource, "CuentaContable", true));
            this.txtCuentaContable.Location = new System.Drawing.Point(34, 348);
            this.txtCuentaContable.Name = "txtCuentaContable";
            this.txtCuentaContable.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuentaContable.Size = new System.Drawing.Size(234, 20);
            this.txtCuentaContable.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProveedorBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(282, 293);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Size = new System.Drawing.Size(234, 20);
            this.txtEmail.TabIndex = 19;
            // 
            // txtFax
            // 
            this.txtFax.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProveedorBindingSource, "Fax", true));
            this.txtFax.Location = new System.Drawing.Point(33, 293);
            this.txtFax.Name = "txtFax";
            this.txtFax.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFax.Size = new System.Drawing.Size(235, 20);
            this.txtFax.TabIndex = 18;
            // 
            // txtTelefono
            // 
            this.txtTelefono.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProveedorBindingSource, "Telefono", true));
            this.txtTelefono.Location = new System.Drawing.Point(282, 248);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Size = new System.Drawing.Size(234, 20);
            this.txtTelefono.TabIndex = 17;
            // 
            // txtRFC
            // 
            this.txtRFC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProveedorBindingSource, "RFC", true));
            this.txtRFC.Location = new System.Drawing.Point(33, 248);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRFC.Size = new System.Drawing.Size(235, 20);
            this.txtRFC.TabIndex = 16;
            // 
            // txtCuidad
            // 
            this.txtCuidad.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProveedorBindingSource, "Ciudad", true));
            this.txtCuidad.Location = new System.Drawing.Point(282, 203);
            this.txtCuidad.Name = "txtCuidad";
            this.txtCuidad.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuidad.Size = new System.Drawing.Size(234, 20);
            this.txtCuidad.TabIndex = 15;
            // 
            // txtColonia
            // 
            this.txtColonia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProveedorBindingSource, "Colonia", true));
            this.txtColonia.Location = new System.Drawing.Point(34, 203);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColonia.Size = new System.Drawing.Size(234, 20);
            this.txtColonia.TabIndex = 14;
            // 
            // txtCalle
            // 
            this.txtCalle.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProveedorBindingSource, "Calle", true));
            this.txtCalle.Location = new System.Drawing.Point(34, 158);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCalle.Size = new System.Drawing.Size(482, 20);
            this.txtCalle.TabIndex = 13;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(282, 329);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(63, 13);
            this.labelControl11.TabIndex = 12;
            this.labelControl11.Text = "Dias de Plazo";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(33, 329);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(81, 13);
            this.labelControl10.TabIndex = 11;
            this.labelControl10.Text = "Cuenta Contable";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(282, 274);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(28, 13);
            this.labelControl9.TabIndex = 10;
            this.labelControl9.Text = "E-mail";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(33, 274);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(18, 13);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = "Fax";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(282, 229);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(42, 13);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "Telefono";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(34, 229);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(32, 13);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "R.F.C.";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(282, 184);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Cuidad";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(34, 184);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Colonia";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(34, 139);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Calle";
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProveedorBindingSource, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(34, 113);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Size = new System.Drawing.Size(482, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 94);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Nombre";
            // 
            // txtProveedor
            // 
            this.txtProveedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spCatProveedorBindingSource, "ProveedorId", true));
            this.txtProveedor.Location = new System.Drawing.Point(34, 67);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(100, 21);
            this.txtProveedor.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(34, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Proveedor ID";
            // 
            // colProveedorId
            // 
            this.colProveedorId.FieldName = "ProveedorId";
            this.colProveedorId.Name = "colProveedorId";
            this.colProveedorId.Visible = true;
            this.colProveedorId.VisibleIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            // 
            // colCalle
            // 
            this.colCalle.FieldName = "Calle";
            this.colCalle.Name = "colCalle";
            this.colCalle.Visible = true;
            this.colCalle.VisibleIndex = 2;
            // 
            // colColonia
            // 
            this.colColonia.FieldName = "Colonia";
            this.colColonia.Name = "colColonia";
            this.colColonia.Visible = true;
            this.colColonia.VisibleIndex = 3;
            // 
            // colCiudad
            // 
            this.colCiudad.FieldName = "Ciudad";
            this.colCiudad.Name = "colCiudad";
            this.colCiudad.Visible = true;
            this.colCiudad.VisibleIndex = 4;
            // 
            // colRFC
            // 
            this.colRFC.FieldName = "RFC";
            this.colRFC.Name = "colRFC";
            this.colRFC.Visible = true;
            this.colRFC.VisibleIndex = 5;
            // 
            // colTelefono
            // 
            this.colTelefono.FieldName = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.Visible = true;
            this.colTelefono.VisibleIndex = 6;
            // 
            // colFax
            // 
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 7;
            // 
            // colCodPostal
            // 
            this.colCodPostal.FieldName = "CodPostal";
            this.colCodPostal.Name = "colCodPostal";
            this.colCodPostal.Visible = true;
            this.colCodPostal.VisibleIndex = 8;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 9;
            // 
            // colReferencia
            // 
            this.colReferencia.FieldName = "Referencia";
            this.colReferencia.Name = "colReferencia";
            this.colReferencia.Visible = true;
            this.colReferencia.VisibleIndex = 10;
            // 
            // colDiasPlazo
            // 
            this.colDiasPlazo.FieldName = "DiasPlazo";
            this.colDiasPlazo.Name = "colDiasPlazo";
            this.colDiasPlazo.Visible = true;
            this.colDiasPlazo.VisibleIndex = 11;
            // 
            // colCuentaContable
            // 
            this.colCuentaContable.FieldName = "CuentaContable";
            this.colCuentaContable.Name = "colCuentaContable";
            this.colCuentaContable.Visible = true;
            this.colCuentaContable.VisibleIndex = 12;
            // 
            // frmCatalogoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Name = "frmCatalogoProveedor";
            this.Text = "Catalogo Proveedor";
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasPlazo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatProveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatProveedorDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaContable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColonia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtDiasPlazo;
        private DevExpress.XtraEditors.TextEdit txtCuentaContable;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtFax;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.TextEdit txtRFC;
        private DevExpress.XtraEditors.TextEdit txtCuidad;
        private DevExpress.XtraEditors.TextEdit txtColonia;
        private DevExpress.XtraEditors.TextEdit txtCalle;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtProveedor;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource spCatProveedorBindingSource;
        private Datasets.Catalogos.spCatProveedorDS spCatProveedorDS;
        private DevExpress.XtraGrid.Columns.GridColumn colProveedorId;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colCalle;
        private DevExpress.XtraGrid.Columns.GridColumn colColonia;
        private DevExpress.XtraGrid.Columns.GridColumn colCiudad;
        private DevExpress.XtraGrid.Columns.GridColumn colRFC;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colCodPostal;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colReferencia;
        private DevExpress.XtraGrid.Columns.GridColumn colDiasPlazo;
        private DevExpress.XtraGrid.Columns.GridColumn colCuentaContable;
    }
}
