namespace RPSuite.Forms.Catalogos
{
    partial class frmCatalogoCuentaBancaria
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
            this.spCatCuentaBancariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spCatCuentaBancariaDS = new RPSuite.Datasets.Catalogos.spCatCuentaBancariaDS();
            this.colCuentaBancariaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuentaContable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDlls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBancoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstacionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtCuentaCantable = new DevExpress.XtraEditors.TextEdit();
            this.lueEstacion = new DevExpress.XtraEditors.LookUpEdit();
            this.lueBanco = new DevExpress.XtraEditors.LookUpEdit();
            this.chkDlls = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCuentaBancaria = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.spCatBancoDS = new RPSuite.Datasets.Catalogos.spCatBancoDS();
            this.spCatEstacionDS = new RPSuite.Datasets.Catalogos.spCatEstacionDS();
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
            ((System.ComponentModel.ISupportInitialize)(this.spCatCuentaBancariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatCuentaBancariaDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaCantable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEstacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDlls.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaBancaria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatBancoDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatEstacionDS)).BeginInit();
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
            this.tpDatos.Controls.Add(this.groupControl1);
            // 
            // dgcCatalogo
            // 
            this.dgcCatalogo.DataSource = this.spCatCuentaBancariaBindingSource;
            // 
            // gvCatalogo
            // 
            this.gvCatalogo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCuentaBancariaID,
            this.colCuenta,
            this.colCuentaContable,
            this.colDlls,
            this.colBancoID,
            this.colEstacionID});
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
            // spCatCuentaBancariaBindingSource
            // 
            this.spCatCuentaBancariaBindingSource.DataMember = "spCatCuentaBancaria";
            this.spCatCuentaBancariaBindingSource.DataSource = this.spCatCuentaBancariaDS;
            this.spCatCuentaBancariaBindingSource.Sort = "";
            // 
            // spCatCuentaBancariaDS
            // 
            this.spCatCuentaBancariaDS.DataSetName = "spCatCuentaBancariaDS";
            this.spCatCuentaBancariaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colCuentaBancariaID
            // 
            this.colCuentaBancariaID.FieldName = "CuentaBancariaID";
            this.colCuentaBancariaID.Name = "colCuentaBancariaID";
            this.colCuentaBancariaID.Visible = true;
            this.colCuentaBancariaID.VisibleIndex = 0;
            // 
            // colCuenta
            // 
            this.colCuenta.FieldName = "Cuenta";
            this.colCuenta.Name = "colCuenta";
            this.colCuenta.Visible = true;
            this.colCuenta.VisibleIndex = 1;
            // 
            // colCuentaContable
            // 
            this.colCuentaContable.FieldName = "CuentaContable";
            this.colCuentaContable.Name = "colCuentaContable";
            this.colCuentaContable.Visible = true;
            this.colCuentaContable.VisibleIndex = 2;
            // 
            // colDlls
            // 
            this.colDlls.FieldName = "Dlls";
            this.colDlls.Name = "colDlls";
            this.colDlls.Visible = true;
            this.colDlls.VisibleIndex = 3;
            // 
            // colBancoID
            // 
            this.colBancoID.FieldName = "BancoID";
            this.colBancoID.Name = "colBancoID";
            this.colBancoID.Visible = true;
            this.colBancoID.VisibleIndex = 4;
            // 
            // colEstacionID
            // 
            this.colEstacionID.FieldName = "EstacionID";
            this.colEstacionID.Name = "colEstacionID";
            this.colEstacionID.Visible = true;
            this.colEstacionID.VisibleIndex = 5;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtCuentaCantable);
            this.groupControl1.Controls.Add(this.lueEstacion);
            this.groupControl1.Controls.Add(this.lueBanco);
            this.groupControl1.Controls.Add(this.chkDlls);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtCuentaBancaria);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(28, 11);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(481, 239);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Datos";
            // 
            // txtCuentaCantable
            // 
            this.txtCuentaCantable.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatCuentaBancariaBindingSource, "CuentaContable", true));
            this.txtCuentaCantable.Location = new System.Drawing.Point(30, 173);
            this.txtCuentaCantable.Name = "txtCuentaCantable";
            this.txtCuentaCantable.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuentaCantable.Size = new System.Drawing.Size(174, 20);
            this.txtCuentaCantable.TabIndex = 11;
            // 
            // lueEstacion
            // 
            this.lueEstacion.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatCuentaBancariaBindingSource, "EstacionID", true));
            this.lueEstacion.Location = new System.Drawing.Point(201, 117);
            this.lueEstacion.Name = "lueEstacion";
            this.lueEstacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEstacion.Size = new System.Drawing.Size(150, 20);
            this.lueEstacion.TabIndex = 10;
            // 
            // lueBanco
            // 
            this.lueBanco.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatCuentaBancariaBindingSource, "BancoID", true));
            this.lueBanco.Location = new System.Drawing.Point(30, 117);
            this.lueBanco.Name = "lueBanco";
            this.lueBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueBanco.Size = new System.Drawing.Size(148, 20);
            this.lueBanco.TabIndex = 9;
            // 
            // chkDlls
            // 
            this.chkDlls.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatCuentaBancariaBindingSource, "Dlls", true));
            this.chkDlls.Location = new System.Drawing.Point(367, 59);
            this.chkDlls.Name = "chkDlls";
            this.chkDlls.Properties.Caption = "dlls";
            this.chkDlls.Size = new System.Drawing.Size(75, 19);
            this.chkDlls.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(30, 154);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(81, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Cuenta Contable";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(201, 98);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Estacion";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 98);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Banco";
            // 
            // txtCuentaBancaria
            // 
            this.txtCuentaBancaria.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatCuentaBancariaBindingSource, "Cuenta", true));
            this.txtCuentaBancaria.Location = new System.Drawing.Point(91, 59);
            this.txtCuentaBancaria.Name = "txtCuentaBancaria";
            this.txtCuentaBancaria.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuentaBancaria.Size = new System.Drawing.Size(260, 20);
            this.txtCuentaBancaria.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatCuentaBancariaBindingSource, "BancoID", true));
            this.txtID.Location = new System.Drawing.Point(30, 59);
            this.txtID.Name = "txtID";
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(55, 20);
            this.txtID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // spCatBancoDS
            // 
            this.spCatBancoDS.DataSetName = "spCatBancoDS";
            this.spCatBancoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spCatEstacionDS
            // 
            this.spCatEstacionDS.DataSetName = "spCatEstacionDS";
            this.spCatEstacionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmCatalogoCuentaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(680, 307);
            this.Name = "frmCatalogoCuentaBancaria";
            this.Text = "Catalogo Cuenta bancaria";
            this.Load += new System.EventHandler(this.frmCatalogoCuentaBancaria_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.spCatCuentaBancariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatCuentaBancariaDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaCantable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEstacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDlls.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaBancaria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatBancoDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatEstacionDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource spCatCuentaBancariaBindingSource;
        private Datasets.Catalogos.spCatCuentaBancariaDS spCatCuentaBancariaDS;
        private DevExpress.XtraGrid.Columns.GridColumn colCuentaBancariaID;
        private DevExpress.XtraGrid.Columns.GridColumn colCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colCuentaContable;
        private DevExpress.XtraGrid.Columns.GridColumn colDlls;
        private DevExpress.XtraGrid.Columns.GridColumn colBancoID;
        private DevExpress.XtraGrid.Columns.GridColumn colEstacionID;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtCuentaCantable;
        private DevExpress.XtraEditors.LookUpEdit lueEstacion;
        private DevExpress.XtraEditors.LookUpEdit lueBanco;
        private DevExpress.XtraEditors.CheckEdit chkDlls;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCuentaBancaria;
        private DevExpress.XtraEditors.TextEdit txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Datasets.Catalogos.spCatBancoDS spCatBancoDS;
        private Datasets.Catalogos.spCatEstacionDS spCatEstacionDS;
    }
}
