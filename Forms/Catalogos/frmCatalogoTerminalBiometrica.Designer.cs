namespace RPSuite.Forms
{
    partial class frmCatalogoTerminalBiometrica
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
            this.spCatTerminalBiometricaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spCatTerminalBiometricaDS = new RPSuite.Datasets.Catalogos.spCatTerminalBiometricaDS();
            this.colTerminalBiometricaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPuerto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtDireccionIP = new DevExpress.XtraEditors.TextEdit();
            this.txtPuerto = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnConectar = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfigurar = new DevExpress.XtraEditors.SimpleButton();
            this.txtConexion = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnRespaldar = new DevExpress.XtraEditors.SimpleButton();
            this.btnRestaurar = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.spCatTerminalBiometricaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatTerminalBiometricaDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccionIP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuerto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConexion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcCatalogo
            // 
            this.tcCatalogo.SelectedTabPage = this.tpBuscar;
            this.tcCatalogo.Size = new System.Drawing.Size(680, 359);
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
            this.tpDatos.Controls.Add(this.groupControl3);
            this.tpDatos.Controls.Add(this.groupControl2);
            this.tpDatos.Controls.Add(this.groupControl1);
            this.tpDatos.Size = new System.Drawing.Size(678, 334);
            // 
            // dgcCatalogo
            // 
            this.dgcCatalogo.DataSource = this.spCatTerminalBiometricaBindingSource;
            // 
            // gvCatalogo
            // 
            this.gvCatalogo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTerminalBiometricaID,
            this.colNombre,
            this.colIP,
            this.colPuerto,
            this.colTipo});
            this.gvCatalogo.OptionsBehavior.Editable = false;
            this.gvCatalogo.OptionsFind.AlwaysVisible = true;
            this.gvCatalogo.OptionsFind.SearchInPreview = true;
            this.gvCatalogo.OptionsFind.ShowClearButton = false;
            this.gvCatalogo.OptionsFind.ShowCloseButton = false;
            this.gvCatalogo.OptionsFind.ShowFindButton = false;
            this.gvCatalogo.OptionsSelection.MultiSelect = true;
            this.gvCatalogo.OptionsView.ColumnAutoWidth = false;
            // 
            // spCatTerminalBiometricaBindingSource
            // 
            this.spCatTerminalBiometricaBindingSource.DataMember = "spCatTerminalBiometrica";
            this.spCatTerminalBiometricaBindingSource.DataSource = this.spCatTerminalBiometricaDS;
            this.spCatTerminalBiometricaBindingSource.Sort = "";
            // 
            // spCatTerminalBiometricaDS
            // 
            this.spCatTerminalBiometricaDS.DataSetName = "spCatTerminalBiometrica";
            this.spCatTerminalBiometricaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colTerminalBiometricaID
            // 
            this.colTerminalBiometricaID.FieldName = "TerminalBiometricaID";
            this.colTerminalBiometricaID.Name = "colTerminalBiometricaID";
            this.colTerminalBiometricaID.Visible = true;
            this.colTerminalBiometricaID.VisibleIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            // 
            // colIP
            // 
            this.colIP.FieldName = "IP";
            this.colIP.Name = "colIP";
            this.colIP.Visible = true;
            this.colIP.VisibleIndex = 2;
            // 
            // colPuerto
            // 
            this.colPuerto.FieldName = "Puerto";
            this.colPuerto.Name = "colPuerto";
            this.colPuerto.Visible = true;
            this.colPuerto.VisibleIndex = 3;
            // 
            // colTipo
            // 
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 4;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtPuerto);
            this.groupControl1.Controls.Add(this.txtDireccionIP);
            this.groupControl1.Controls.Add(this.txtNombre);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(11, 24);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(387, 200);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Datos Terminal";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 86);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nombre";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(18, 131);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Direccion IP";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(293, 131);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(32, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Puerto";
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatTerminalBiometricaBindingSource, "TerminalBiometricaID", true));
            this.txtID.Location = new System.Drawing.Point(18, 60);
            this.txtID.Name = "txtID";
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatTerminalBiometricaBindingSource, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(18, 105);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Size = new System.Drawing.Size(350, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtDireccionIP
            // 
            this.txtDireccionIP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatTerminalBiometricaBindingSource, "IP", true));
            this.txtDireccionIP.Location = new System.Drawing.Point(18, 150);
            this.txtDireccionIP.Name = "txtDireccionIP";
            this.txtDireccionIP.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccionIP.Size = new System.Drawing.Size(256, 20);
            this.txtDireccionIP.TabIndex = 6;
            // 
            // txtPuerto
            // 
            this.txtPuerto.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatTerminalBiometricaBindingSource, "Puerto", true));
            this.txtPuerto.Location = new System.Drawing.Point(293, 150);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPuerto.Size = new System.Drawing.Size(75, 20);
            this.txtPuerto.TabIndex = 7;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtConexion);
            this.groupControl2.Controls.Add(this.btnConfigurar);
            this.groupControl2.Controls.Add(this.btnConectar);
            this.groupControl2.Location = new System.Drawing.Point(418, 24);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(237, 200);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Probar Conexion";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(14, 30);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectarse";
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(157, 30);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(75, 23);
            this.btnConfigurar.TabIndex = 1;
            this.btnConfigurar.Text = "Configurar";
            // 
            // txtConexion
            // 
            this.txtConexion.Location = new System.Drawing.Point(14, 60);
            this.txtConexion.Name = "txtConexion";
            this.txtConexion.Size = new System.Drawing.Size(218, 20);
            this.txtConexion.TabIndex = 2;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnRestaurar);
            this.groupControl3.Controls.Add(this.btnRespaldar);
            this.groupControl3.Location = new System.Drawing.Point(11, 235);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(387, 75);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Huerllas Checador";
            // 
            // btnRespaldar
            // 
            this.btnRespaldar.Location = new System.Drawing.Point(32, 33);
            this.btnRespaldar.Name = "btnRespaldar";
            this.btnRespaldar.Size = new System.Drawing.Size(75, 23);
            this.btnRespaldar.TabIndex = 0;
            this.btnRespaldar.Text = "Respaldar";
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(163, 37);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(75, 23);
            this.btnRestaurar.TabIndex = 1;
            this.btnRestaurar.Text = "Restaurar";
            // 
            // frmCatalogoTerminalBiometrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(680, 359);
            this.Name = "frmCatalogoTerminalBiometrica";
            this.Text = "Terminales Biometricas";
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
            ((System.ComponentModel.ISupportInitialize)(this.spCatTerminalBiometricaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatTerminalBiometricaDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccionIP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuerto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtConexion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource spCatTerminalBiometricaBindingSource;
        private Datasets.Catalogos.spCatTerminalBiometricaDS spCatTerminalBiometricaDS;
        private DevExpress.XtraGrid.Columns.GridColumn colTerminalBiometricaID;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colIP;
        private DevExpress.XtraGrid.Columns.GridColumn colPuerto;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnRestaurar;
        private DevExpress.XtraEditors.SimpleButton btnRespaldar;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtConexion;
        private DevExpress.XtraEditors.SimpleButton btnConfigurar;
        private DevExpress.XtraEditors.SimpleButton btnConectar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtPuerto;
        private DevExpress.XtraEditors.TextEdit txtDireccionIP;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
