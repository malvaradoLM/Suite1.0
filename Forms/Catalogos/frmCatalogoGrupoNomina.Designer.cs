namespace RPSuite.Forms.Catalogos
{
    partial class frmCatalogoGrupoNomina
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
            this.spCatGrupoNominaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spCatGrupoNominaDS = new RPSuite.Datasets.Catalogos.spCatGrupoNominaDS();
            this.colGrupoNominaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHorarioID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScript = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtCondigo = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tpScript = new DevExpress.XtraTab.XtraTabPage();
            this.mmoScript = new DevExpress.XtraEditors.MemoEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.spCatGrupoNominaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatGrupoNominaDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCondigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.tpScript.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmoScript.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCatalogo
            // 
            this.tcCatalogo.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpScript});
            this.tcCatalogo.Controls.SetChildIndex(this.tpScript, 0);
            this.tcCatalogo.Controls.SetChildIndex(this.tpDatos, 0);
            this.tcCatalogo.Controls.SetChildIndex(this.tpBuscar, 0);
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
            this.dgcCatalogo.DataSource = this.spCatGrupoNominaBindingSource;
            // 
            // gvCatalogo
            // 
            this.gvCatalogo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGrupoNominaID,
            this.colCodigo,
            this.colNombre,
            this.colHorarioID,
            this.colScript});
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
            // spCatGrupoNominaBindingSource
            // 
            this.spCatGrupoNominaBindingSource.DataMember = "spCatGrupoNomina";
            this.spCatGrupoNominaBindingSource.DataSource = this.spCatGrupoNominaDS;
            this.spCatGrupoNominaBindingSource.Sort = "";
            // 
            // spCatGrupoNominaDS
            // 
            this.spCatGrupoNominaDS.DataSetName = "6";
            this.spCatGrupoNominaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colGrupoNominaID
            // 
            this.colGrupoNominaID.FieldName = "GrupoNominaID";
            this.colGrupoNominaID.Name = "colGrupoNominaID";
            this.colGrupoNominaID.Visible = true;
            this.colGrupoNominaID.VisibleIndex = 0;
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
            // colHorarioID
            // 
            this.colHorarioID.FieldName = "HorarioID";
            this.colHorarioID.Name = "colHorarioID";
            this.colHorarioID.Visible = true;
            this.colHorarioID.VisibleIndex = 3;
            // 
            // colScript
            // 
            this.colScript.FieldName = "Script";
            this.colScript.Name = "colScript";
            this.colScript.Visible = true;
            this.colScript.VisibleIndex = 4;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.txtNombre);
            this.groupControl1.Controls.Add(this.txtCondigo);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(21, 11);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(386, 244);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Datos";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(26, 189);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Size = new System.Drawing.Size(300, 20);
            this.lookUpEdit1.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatGrupoNominaBindingSource, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(26, 144);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtCondigo
            // 
            this.txtCondigo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatGrupoNominaBindingSource, "Codigo", true));
            this.txtCondigo.Location = new System.Drawing.Point(26, 99);
            this.txtCondigo.Name = "txtCondigo";
            this.txtCondigo.Size = new System.Drawing.Size(100, 20);
            this.txtCondigo.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatGrupoNominaBindingSource, "GrupoNominaID", true));
            this.txtID.Location = new System.Drawing.Point(26, 54);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(28, 170);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Horario";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(26, 125);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Nombre";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Codigo";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // tpScript
            // 
            this.tpScript.Controls.Add(this.mmoScript);
            this.tpScript.Name = "tpScript";
            this.tpScript.Size = new System.Drawing.Size(678, 282);
            this.tpScript.Text = "Script";
            // 
            // mmoScript
            // 
            this.mmoScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mmoScript.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatGrupoNominaBindingSource, "Script", true));
            this.mmoScript.Location = new System.Drawing.Point(11, 3);
            this.mmoScript.Name = "mmoScript";
            this.mmoScript.Size = new System.Drawing.Size(612, 268);
            this.mmoScript.TabIndex = 0;
            // 
            // frmCatalogoGrupoNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(680, 307);
            this.Name = "frmCatalogoGrupoNomina";
            this.Text = "Grupo Nomina";
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
            ((System.ComponentModel.ISupportInitialize)(this.spCatGrupoNominaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatGrupoNominaDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCondigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.tpScript.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mmoScript.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource spCatGrupoNominaBindingSource;
        private Datasets.Catalogos.spCatGrupoNominaDS spCatGrupoNominaDS;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupoNominaID;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colHorarioID;
        private DevExpress.XtraGrid.Columns.GridColumn colScript;
        private DevExpress.XtraTab.XtraTabPage tpScript;
        private DevExpress.XtraEditors.MemoEdit mmoScript;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtCondigo;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
