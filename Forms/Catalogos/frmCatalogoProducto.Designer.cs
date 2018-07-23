namespace RPSuite.Forms
{
    partial class frmCatalogoProducto
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtCuentaContableIVA = new DevExpress.XtraEditors.TextEdit();
            this.spCatProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spCatProductoDS = new RPSuite.Datasets.Catalogos.spCatProductoDS();
            this.txtCuentaContableVenta = new DevExpress.XtraEditors.TextEdit();
            this.txtCuentaContableCompra = new DevExpress.XtraEditors.TextEdit();
            this.chkInventariable = new DevExpress.XtraEditors.CheckEdit();
            this.chkProductoActivo = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtFactorPuntos = new DevExpress.XtraEditors.TextEdit();
            this.txtComision = new DevExpress.XtraEditors.TextEdit();
            this.txtClavePemex = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtPrecioEstacionIEPS = new DevExpress.XtraEditors.TextEdit();
            this.txtPrecioEstacionCosto = new DevExpress.XtraEditors.TextEdit();
            this.txtPrecioEstacionPrecio = new DevExpress.XtraEditors.TextEdit();
            this.txtPrecioEstacionEstacionID = new DevExpress.XtraEditors.TextEdit();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtIEPS = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigoBarras = new DevExpress.XtraEditors.TextEdit();
            this.txtUnidad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lueCategoria = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtCosto = new DevExpress.XtraEditors.TextEdit();
            this.txtPrecioPromedio = new DevExpress.XtraEditors.TextEdit();
            this.txtPrecioVenta = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.colProductoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClavePemex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuentaContableCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuentaContableVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuentaContableIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInventariable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostoPromedio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoriaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIEPS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactorPuntos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveCatastral = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveProdServ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            this.spCatCategoriaDS = new RPSuite.Datasets.Catalogos.spCatCategoriaDS();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaContableIVA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatProductoDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaContableVenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaContableCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkInventariable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkProductoActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactorPuntos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClavePemex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioEstacionIEPS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioEstacionCosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioEstacionPrecio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioEstacionEstacionID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIEPS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoBarras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioPromedio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spCatCategoriaDS)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCatalogo
            // 
            this.tcCatalogo.SelectedTabPage = this.tpBuscar;
            this.tcCatalogo.Size = new System.Drawing.Size(847, 447);
            // 
            // gcBusqueda
            // 
            this.gcBusqueda.Size = new System.Drawing.Size(845, 100);
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
            this.tpBuscar.Size = new System.Drawing.Size(845, 422);
            // 
            // tpDatos
            // 
            this.tpDatos.Controls.Add(this.groupControl1);
            this.tpDatos.Size = new System.Drawing.Size(845, 422);
            // 
            // dgcCatalogo
            // 
            this.dgcCatalogo.DataSource = this.spCatProductoBindingSource;
            this.dgcCatalogo.Size = new System.Drawing.Size(845, 322);
            // 
            // gvCatalogo
            // 
            this.gvCatalogo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductoID,
            this.colCodigo,
            this.colNombre,
            this.colPrecioVenta,
            this.colClavePemex,
            this.colCosto,
            this.colStatus,
            this.colBarras,
            this.colCuentaContableCompra,
            this.colCuentaContableVenta,
            this.colCuentaContableIVA,
            this.colInventariable,
            this.colCostoPromedio,
            this.colCategoriaID,
            this.colIEPS,
            this.colFactorPuntos,
            this.colUnidad,
            this.colComision,
            this.colClaveCatastral,
            this.colClaveProdServ});
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
            this.groupControl1.Controls.Add(this.txtCuentaContableIVA);
            this.groupControl1.Controls.Add(this.txtCuentaContableVenta);
            this.groupControl1.Controls.Add(this.txtCuentaContableCompra);
            this.groupControl1.Controls.Add(this.chkInventariable);
            this.groupControl1.Controls.Add(this.chkProductoActivo);
            this.groupControl1.Controls.Add(this.labelControl16);
            this.groupControl1.Controls.Add(this.labelControl15);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.txtFactorPuntos);
            this.groupControl1.Controls.Add(this.txtComision);
            this.groupControl1.Controls.Add(this.txtClavePemex);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.txtIEPS);
            this.groupControl1.Controls.Add(this.txtCodigoBarras);
            this.groupControl1.Controls.Add(this.txtUnidad);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.lueCategoria);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txtCosto);
            this.groupControl1.Controls.Add(this.txtPrecioPromedio);
            this.groupControl1.Controls.Add(this.txtPrecioVenta);
            this.groupControl1.Controls.Add(this.txtNombre);
            this.groupControl1.Controls.Add(this.txtCodigo);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(21, 11);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(752, 377);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Datos";
            // 
            // txtCuentaContableIVA
            // 
            this.txtCuentaContableIVA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoBindingSource, "CuentaContableIVA", true));
            this.txtCuentaContableIVA.Location = new System.Drawing.Point(30, 287);
            this.txtCuentaContableIVA.Name = "txtCuentaContableIVA";
            this.txtCuentaContableIVA.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuentaContableIVA.Size = new System.Drawing.Size(206, 20);
            this.txtCuentaContableIVA.TabIndex = 34;
            // 
            // spCatProductoBindingSource
            // 
            this.spCatProductoBindingSource.DataMember = "spCatProducto";
            this.spCatProductoBindingSource.DataSource = this.spCatProductoDS;
            this.spCatProductoBindingSource.Sort = "";
            // 
            // spCatProductoDS
            // 
            this.spCatProductoDS.DataSetName = "spCatProductoDS";
            this.spCatProductoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCuentaContableVenta
            // 
            this.txtCuentaContableVenta.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoBindingSource, "CuentaContableVenta", true));
            this.txtCuentaContableVenta.Location = new System.Drawing.Point(261, 242);
            this.txtCuentaContableVenta.Name = "txtCuentaContableVenta";
            this.txtCuentaContableVenta.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuentaContableVenta.Size = new System.Drawing.Size(189, 20);
            this.txtCuentaContableVenta.TabIndex = 33;
            // 
            // txtCuentaContableCompra
            // 
            this.txtCuentaContableCompra.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoBindingSource, "CuentaContableCompra", true));
            this.txtCuentaContableCompra.Location = new System.Drawing.Point(30, 242);
            this.txtCuentaContableCompra.Name = "txtCuentaContableCompra";
            this.txtCuentaContableCompra.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuentaContableCompra.Size = new System.Drawing.Size(206, 20);
            this.txtCuentaContableCompra.TabIndex = 32;
            // 
            // chkInventariable
            // 
            this.chkInventariable.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoBindingSource, "Inventariable", true));
            this.chkInventariable.Location = new System.Drawing.Point(269, 293);
            this.chkInventariable.Name = "chkInventariable";
            this.chkInventariable.Properties.Caption = "Inventariable";
            this.chkInventariable.Size = new System.Drawing.Size(128, 19);
            this.chkInventariable.TabIndex = 31;
            // 
            // chkProductoActivo
            // 
            this.chkProductoActivo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoBindingSource, "Status", true));
            this.chkProductoActivo.Location = new System.Drawing.Point(268, 268);
            this.chkProductoActivo.Name = "chkProductoActivo";
            this.chkProductoActivo.Properties.Caption = "Producto Activo";
            this.chkProductoActivo.Size = new System.Drawing.Size(158, 19);
            this.chkProductoActivo.TabIndex = 30;
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(30, 268);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(101, 13);
            this.labelControl16.TabIndex = 29;
            this.labelControl16.Text = "Cuenta Contable IVA";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(261, 225);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(112, 13);
            this.labelControl15.TabIndex = 28;
            this.labelControl15.Text = "Cuenta Contable Venta";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(30, 223);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(121, 13);
            this.labelControl14.TabIndex = 27;
            this.labelControl14.Text = "Cuenta Contable Compra";
            // 
            // txtFactorPuntos
            // 
            this.txtFactorPuntos.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoBindingSource, "FactorPuntos", true));
            this.txtFactorPuntos.Location = new System.Drawing.Point(142, 197);
            this.txtFactorPuntos.Name = "txtFactorPuntos";
            this.txtFactorPuntos.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFactorPuntos.Size = new System.Drawing.Size(94, 20);
            this.txtFactorPuntos.TabIndex = 26;
            // 
            // txtComision
            // 
            this.txtComision.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoBindingSource, "Comision", true));
            this.txtComision.Location = new System.Drawing.Point(30, 197);
            this.txtComision.Name = "txtComision";
            this.txtComision.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComision.Size = new System.Drawing.Size(100, 20);
            this.txtComision.TabIndex = 25;
            // 
            // txtClavePemex
            // 
            this.txtClavePemex.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoBindingSource, "ClavePemex", true));
            this.txtClavePemex.Location = new System.Drawing.Point(261, 199);
            this.txtClavePemex.Name = "txtClavePemex";
            this.txtClavePemex.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClavePemex.Size = new System.Drawing.Size(189, 20);
            this.txtClavePemex.TabIndex = 24;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(261, 184);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(62, 13);
            this.labelControl13.TabIndex = 23;
            this.labelControl13.Text = "Clave Pemex";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(142, 178);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(67, 13);
            this.labelControl12.TabIndex = 22;
            this.labelControl12.Text = "Factor Puntos";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtPrecioEstacionIEPS);
            this.groupControl2.Controls.Add(this.txtPrecioEstacionCosto);
            this.groupControl2.Controls.Add(this.txtPrecioEstacionPrecio);
            this.groupControl2.Controls.Add(this.txtPrecioEstacionEstacionID);
            this.groupControl2.Controls.Add(this.btnCancelar);
            this.groupControl2.Controls.Add(this.btnAceptar);
            this.groupControl2.Controls.Add(this.labelControl20);
            this.groupControl2.Controls.Add(this.labelControl19);
            this.groupControl2.Controls.Add(this.labelControl18);
            this.groupControl2.Controls.Add(this.labelControl17);
            this.groupControl2.Location = new System.Drawing.Point(484, 133);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(217, 200);
            this.groupControl2.TabIndex = 21;
            this.groupControl2.Text = "Precio Por Estacion";
            // 
            // txtPrecioEstacionIEPS
            // 
            this.txtPrecioEstacionIEPS.Location = new System.Drawing.Point(85, 102);
            this.txtPrecioEstacionIEPS.Name = "txtPrecioEstacionIEPS";
            this.txtPrecioEstacionIEPS.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioEstacionIEPS.TabIndex = 9;
            // 
            // txtPrecioEstacionCosto
            // 
            this.txtPrecioEstacionCosto.Location = new System.Drawing.Point(85, 76);
            this.txtPrecioEstacionCosto.Name = "txtPrecioEstacionCosto";
            this.txtPrecioEstacionCosto.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioEstacionCosto.TabIndex = 8;
            // 
            // txtPrecioEstacionPrecio
            // 
            this.txtPrecioEstacionPrecio.Location = new System.Drawing.Point(85, 50);
            this.txtPrecioEstacionPrecio.Name = "txtPrecioEstacionPrecio";
            this.txtPrecioEstacionPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioEstacionPrecio.TabIndex = 7;
            // 
            // txtPrecioEstacionEstacionID
            // 
            this.txtPrecioEstacionEstacionID.Location = new System.Drawing.Point(85, 24);
            this.txtPrecioEstacionEstacionID.Name = "txtPrecioEstacionEstacionID";
            this.txtPrecioEstacionEstacionID.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioEstacionEstacionID.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(110, 152);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(17, 152);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(17, 109);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(22, 13);
            this.labelControl20.TabIndex = 3;
            this.labelControl20.Text = "IEPS";
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(17, 83);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(28, 13);
            this.labelControl19.TabIndex = 2;
            this.labelControl19.Text = "Costo";
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(18, 57);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(29, 13);
            this.labelControl18.TabIndex = 1;
            this.labelControl18.Text = "Precio";
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(17, 31);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(54, 13);
            this.labelControl17.TabIndex = 0;
            this.labelControl17.Text = "Estacion ID";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(261, 133);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(22, 13);
            this.labelControl11.TabIndex = 20;
            this.labelControl11.Text = "IEPS";
            // 
            // txtIEPS
            // 
            this.txtIEPS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoBindingSource, "IEPS", true));
            this.txtIEPS.Location = new System.Drawing.Point(261, 152);
            this.txtIEPS.Name = "txtIEPS";
            this.txtIEPS.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIEPS.Size = new System.Drawing.Size(83, 20);
            this.txtIEPS.TabIndex = 19;
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoBindingSource, "Barras", true));
            this.txtCodigoBarras.Location = new System.Drawing.Point(261, 107);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoBarras.Size = new System.Drawing.Size(189, 20);
            this.txtCodigoBarras.TabIndex = 18;
            // 
            // txtUnidad
            // 
            this.txtUnidad.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoBindingSource, "Unidad", true));
            this.txtUnidad.Location = new System.Drawing.Point(142, 107);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnidad.Size = new System.Drawing.Size(94, 20);
            this.txtUnidad.TabIndex = 17;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(484, 85);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(47, 13);
            this.labelControl10.TabIndex = 16;
            this.labelControl10.Text = "Categoria";
            // 
            // lueCategoria
            // 
            this.lueCategoria.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoBindingSource, "CategoriaID", true));
            this.lueCategoria.Location = new System.Drawing.Point(484, 104);
            this.lueCategoria.Name = "lueCategoria";
            this.lueCategoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCategoria.Size = new System.Drawing.Size(212, 20);
            this.lueCategoria.TabIndex = 15;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(142, 88);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(33, 13);
            this.labelControl9.TabIndex = 14;
            this.labelControl9.Text = "Unidad";
            // 
            // txtCosto
            // 
            this.txtCosto.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoBindingSource, "Costo", true));
            this.txtCosto.Location = new System.Drawing.Point(30, 152);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 13;
            // 
            // txtPrecioPromedio
            // 
            this.txtPrecioPromedio.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoBindingSource, "CostoPromedio", true));
            this.txtPrecioPromedio.Location = new System.Drawing.Point(350, 152);
            this.txtPrecioPromedio.Name = "txtPrecioPromedio";
            this.txtPrecioPromedio.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecioPromedio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioPromedio.TabIndex = 12;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoBindingSource, "PrecioVenta", true));
            this.txtPrecioVenta.Location = new System.Drawing.Point(142, 152);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecioVenta.Size = new System.Drawing.Size(94, 20);
            this.txtPrecioVenta.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoBindingSource, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(142, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Size = new System.Drawing.Size(554, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoBindingSource, "Codigo", true));
            this.txtCodigo.Location = new System.Drawing.Point(30, 107);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 9;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatProductoBindingSource, "ProductoID", true));
            this.txtID.Location = new System.Drawing.Point(30, 59);
            this.txtID.Name = "txtID";
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 8;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(261, 93);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(82, 13);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Codigo de Barras";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(32, 178);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(42, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Comision";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(30, 133);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(28, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Costo";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(350, 133);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(76, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Precio Promedio";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(142, 133);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Precio Venta";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(30, 88);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Codigo\r\n";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(136, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nombre";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Producto";
            // 
            // colProductoID
            // 
            this.colProductoID.FieldName = "ProductoID";
            this.colProductoID.Name = "colProductoID";
            this.colProductoID.Visible = true;
            this.colProductoID.VisibleIndex = 0;
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 1;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 2;
            // 
            // colPrecioVenta
            // 
            this.colPrecioVenta.FieldName = "PrecioVenta";
            this.colPrecioVenta.Name = "colPrecioVenta";
            this.colPrecioVenta.Visible = true;
            this.colPrecioVenta.VisibleIndex = 3;
            // 
            // colClavePemex
            // 
            this.colClavePemex.FieldName = "ClavePemex";
            this.colClavePemex.Name = "colClavePemex";
            this.colClavePemex.Visible = true;
            this.colClavePemex.VisibleIndex = 4;
            // 
            // colCosto
            // 
            this.colCosto.FieldName = "Costo";
            this.colCosto.Name = "colCosto";
            this.colCosto.Visible = true;
            this.colCosto.VisibleIndex = 5;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 6;
            // 
            // colBarras
            // 
            this.colBarras.FieldName = "Barras";
            this.colBarras.Name = "colBarras";
            this.colBarras.Visible = true;
            this.colBarras.VisibleIndex = 7;
            // 
            // colCuentaContableCompra
            // 
            this.colCuentaContableCompra.FieldName = "CuentaContableCompra";
            this.colCuentaContableCompra.Name = "colCuentaContableCompra";
            this.colCuentaContableCompra.Visible = true;
            this.colCuentaContableCompra.VisibleIndex = 8;
            // 
            // colCuentaContableVenta
            // 
            this.colCuentaContableVenta.FieldName = "CuentaContableVenta";
            this.colCuentaContableVenta.Name = "colCuentaContableVenta";
            this.colCuentaContableVenta.Visible = true;
            this.colCuentaContableVenta.VisibleIndex = 9;
            // 
            // colCuentaContableIVA
            // 
            this.colCuentaContableIVA.FieldName = "CuentaContableIVA";
            this.colCuentaContableIVA.Name = "colCuentaContableIVA";
            this.colCuentaContableIVA.Visible = true;
            this.colCuentaContableIVA.VisibleIndex = 10;
            // 
            // colInventariable
            // 
            this.colInventariable.FieldName = "Inventariable";
            this.colInventariable.Name = "colInventariable";
            this.colInventariable.Visible = true;
            this.colInventariable.VisibleIndex = 11;
            // 
            // colCostoPromedio
            // 
            this.colCostoPromedio.FieldName = "CostoPromedio";
            this.colCostoPromedio.Name = "colCostoPromedio";
            this.colCostoPromedio.Visible = true;
            this.colCostoPromedio.VisibleIndex = 12;
            // 
            // colCategoriaID
            // 
            this.colCategoriaID.FieldName = "CategoriaID";
            this.colCategoriaID.Name = "colCategoriaID";
            this.colCategoriaID.Visible = true;
            this.colCategoriaID.VisibleIndex = 13;
            // 
            // colIEPS
            // 
            this.colIEPS.FieldName = "IEPS";
            this.colIEPS.Name = "colIEPS";
            this.colIEPS.Visible = true;
            this.colIEPS.VisibleIndex = 14;
            // 
            // colFactorPuntos
            // 
            this.colFactorPuntos.FieldName = "FactorPuntos";
            this.colFactorPuntos.Name = "colFactorPuntos";
            this.colFactorPuntos.Visible = true;
            this.colFactorPuntos.VisibleIndex = 15;
            // 
            // colUnidad
            // 
            this.colUnidad.FieldName = "Unidad";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.Visible = true;
            this.colUnidad.VisibleIndex = 16;
            // 
            // colComision
            // 
            this.colComision.FieldName = "Comision";
            this.colComision.Name = "colComision";
            this.colComision.Visible = true;
            this.colComision.VisibleIndex = 17;
            // 
            // colClaveCatastral
            // 
            this.colClaveCatastral.FieldName = "ClaveCatastral";
            this.colClaveCatastral.Name = "colClaveCatastral";
            this.colClaveCatastral.Visible = true;
            this.colClaveCatastral.VisibleIndex = 18;
            // 
            // colClaveProdServ
            // 
            this.colClaveProdServ.FieldName = "ClaveProdServ";
            this.colClaveProdServ.Name = "colClaveProdServ";
            this.colClaveProdServ.Visible = true;
            this.colClaveProdServ.VisibleIndex = 19;
            // 
            // wizardControl1
            // 
            this.wizardControl1.Controls.Add(this.welcomeWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage1);
            this.wizardControl1.Controls.Add(this.completionWizardPage1);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Location = new System.Drawing.Point(1, 1);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wizardPage1,
            this.completionWizardPage1});
            this.wizardControl1.Size = new System.Drawing.Size(845, 422);
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(628, 290);
            // 
            // wizardPage1
            // 
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(813, 279);
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.Size = new System.Drawing.Size(628, 290);
            // 
            // spCatCategoriaDS
            // 
            this.spCatCategoriaDS.DataSetName = "spCatCategoriaDS";
            this.spCatCategoriaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmCatalogoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(847, 447);
            this.Name = "frmCatalogoProducto";
            this.Text = "Catalogo Producto";
            this.Load += new System.EventHandler(this.frmCatalogoProducto_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaContableIVA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatProductoDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaContableVenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaContableCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkInventariable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkProductoActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactorPuntos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClavePemex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioEstacionIEPS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioEstacionCosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioEstacionPrecio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioEstacionEstacionID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIEPS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoBarras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioPromedio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spCatCategoriaDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtIEPS;
        private DevExpress.XtraEditors.TextEdit txtCodigoBarras;
        private DevExpress.XtraEditors.TextEdit txtUnidad;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LookUpEdit lueCategoria;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtCosto;
        private DevExpress.XtraEditors.TextEdit txtPrecioPromedio;
        private DevExpress.XtraEditors.TextEdit txtPrecioVenta;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCuentaContableIVA;
        private DevExpress.XtraEditors.TextEdit txtCuentaContableVenta;
        private DevExpress.XtraEditors.TextEdit txtCuentaContableCompra;
        private DevExpress.XtraEditors.CheckEdit chkInventariable;
        private DevExpress.XtraEditors.CheckEdit chkProductoActivo;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit txtFactorPuntos;
        private DevExpress.XtraEditors.TextEdit txtComision;
        private DevExpress.XtraEditors.TextEdit txtClavePemex;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtPrecioEstacionIEPS;
        private DevExpress.XtraEditors.TextEdit txtPrecioEstacionCosto;
        private DevExpress.XtraEditors.TextEdit txtPrecioEstacionPrecio;
        private DevExpress.XtraEditors.TextEdit txtPrecioEstacionEstacionID;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private System.Windows.Forms.BindingSource spCatProductoBindingSource;
        private Datasets.Catalogos.spCatProductoDS spCatProductoDS;
        private DevExpress.XtraGrid.Columns.GridColumn colProductoID;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colClavePemex;
        private DevExpress.XtraGrid.Columns.GridColumn colCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colBarras;
        private DevExpress.XtraGrid.Columns.GridColumn colCuentaContableCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colCuentaContableVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colCuentaContableIVA;
        private DevExpress.XtraGrid.Columns.GridColumn colInventariable;
        private DevExpress.XtraGrid.Columns.GridColumn colCostoPromedio;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoriaID;
        private DevExpress.XtraGrid.Columns.GridColumn colIEPS;
        private DevExpress.XtraGrid.Columns.GridColumn colFactorPuntos;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidad;
        private DevExpress.XtraGrid.Columns.GridColumn colComision;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveCatastral;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveProdServ;
        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private Datasets.Catalogos.spCatCategoriaDS spCatCategoriaDS;
    }
}
