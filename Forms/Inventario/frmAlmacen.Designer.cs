namespace RPSuite.Forms.Inventario
{
    partial class frmAlmacen
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
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.spCatTipoMovimientoDS = new RPSuite.Datasets.Catalogos.spCatTipoMovimientoDS();
            this.pcDatosAlmacen = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtReferencia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lueAlmacenDestino = new DevExpress.XtraEditors.LookUpEdit();
            this.lueEstacionDestino = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtBonoMerma = new DevExpress.XtraEditors.TextEdit();
            this.lueProveedor = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lueAlmacen = new DevExpress.XtraEditors.LookUpEdit();
            this.lueTipoMovimiento = new DevExpress.XtraEditors.LookUpEdit();
            this.txtFolio = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtFecha = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pcgrid = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.spCatFolioDS = new RPSuite.Datasets.Catalogos.spCatFolioDS();
            this.spCatProveedorDS = new RPSuite.Datasets.Catalogos.spCatProveedorDS();
            this.spCatEstacionDS = new RPSuite.Datasets.Catalogos.spCatEstacionDS();
            ((System.ComponentModel.ISupportInitialize)(this.tbControl)).BeginInit();
            this.tbControl.SuspendLayout();
            this.tpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatTipoMovimientoDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDatosAlmacen)).BeginInit();
            this.pcDatosAlmacen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAlmacenDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEstacionDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBonoMerma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAlmacen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTipoMovimiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcgrid)).BeginInit();
            this.pcgrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatFolioDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatProveedorDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatEstacionDS)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Size = new System.Drawing.Size(716, 617);
            // 
            // tpDatos
            // 
            this.tpDatos.Controls.Add(this.pcgrid);
            this.tpDatos.Controls.Add(this.pcDatosAlmacen);
            this.tpDatos.Controls.Add(this.textEdit7);
            this.tpDatos.Controls.Add(this.textEdit6);
            this.tpDatos.Controls.Add(this.textEdit5);
            this.tpDatos.Controls.Add(this.textEdit4);
            this.tpDatos.Controls.Add(this.labelControl13);
            this.tpDatos.Controls.Add(this.labelControl12);
            this.tpDatos.Controls.Add(this.labelControl11);
            this.tpDatos.Controls.Add(this.labelControl10);
            this.tpDatos.Size = new System.Drawing.Size(714, 592);
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(467, 477);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(59, 13);
            this.labelControl10.TabIndex = 2;
            this.labelControl10.Text = "Bono Merma";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(467, 503);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(42, 13);
            this.labelControl11.TabIndex = 3;
            this.labelControl11.Text = "SubTotal";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(467, 529);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(17, 13);
            this.labelControl12.TabIndex = 4;
            this.labelControl12.Text = "IVA";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(467, 555);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(24, 13);
            this.labelControl13.TabIndex = 5;
            this.labelControl13.Text = "Total";
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(550, 470);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.ReadOnly = true;
            this.textEdit4.Size = new System.Drawing.Size(148, 20);
            this.textEdit4.TabIndex = 6;
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(550, 496);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Properties.ReadOnly = true;
            this.textEdit5.Size = new System.Drawing.Size(148, 20);
            this.textEdit5.TabIndex = 7;
            this.textEdit5.EditValueChanged += new System.EventHandler(this.textEdit5_EditValueChanged);
            // 
            // textEdit6
            // 
            this.textEdit6.Location = new System.Drawing.Point(550, 522);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.ReadOnly = true;
            this.textEdit6.Size = new System.Drawing.Size(148, 20);
            this.textEdit6.TabIndex = 8;
            // 
            // textEdit7
            // 
            this.textEdit7.Location = new System.Drawing.Point(550, 548);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.ReadOnly = true;
            this.textEdit7.Size = new System.Drawing.Size(148, 20);
            this.textEdit7.TabIndex = 9;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // spCatTipoMovimientoDS
            // 
            this.spCatTipoMovimientoDS.DataSetName = "spCatTipoMovimientoDS";
            this.spCatTipoMovimientoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pcDatosAlmacen
            // 
            this.pcDatosAlmacen.Controls.Add(this.groupControl1);
            this.pcDatosAlmacen.Location = new System.Drawing.Point(-1, 0);
            this.pcDatosAlmacen.Name = "pcDatosAlmacen";
            this.pcDatosAlmacen.Size = new System.Drawing.Size(712, 185);
            this.pcDatosAlmacen.TabIndex = 10;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtReferencia);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.lueAlmacenDestino);
            this.groupControl1.Controls.Add(this.lueEstacionDestino);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtBonoMerma);
            this.groupControl1.Controls.Add(this.lueProveedor);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.lueAlmacen);
            this.groupControl1.Controls.Add(this.lueTipoMovimiento);
            this.groupControl1.Controls.Add(this.txtFolio);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.dtFecha);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(5, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(680, 174);
            this.groupControl1.TabIndex = 1;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(15, 133);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(244, 20);
            this.txtReferencia.TabIndex = 17;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(439, 114);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(79, 13);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "Almacen Destino";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(265, 114);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(79, 13);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Estacion Destino";
            // 
            // lueAlmacenDestino
            // 
            this.lueAlmacenDestino.Location = new System.Drawing.Point(439, 133);
            this.lueAlmacenDestino.Name = "lueAlmacenDestino";
            this.lueAlmacenDestino.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueAlmacenDestino.Size = new System.Drawing.Size(203, 20);
            this.lueAlmacenDestino.TabIndex = 14;
            // 
            // lueEstacionDestino
            // 
            this.lueEstacionDestino.Location = new System.Drawing.Point(265, 133);
            this.lueEstacionDestino.Name = "lueEstacionDestino";
            this.lueEstacionDestino.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEstacionDestino.Size = new System.Drawing.Size(168, 20);
            this.lueEstacionDestino.TabIndex = 13;
            this.lueEstacionDestino.EditValueChanged += new System.EventHandler(this.lueEstacionDestino_EditValueChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(15, 114);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Referencia";
            // 
            // txtBonoMerma
            // 
            this.txtBonoMerma.Location = new System.Drawing.Point(439, 88);
            this.txtBonoMerma.Name = "txtBonoMerma";
            this.txtBonoMerma.Size = new System.Drawing.Size(203, 20);
            this.txtBonoMerma.TabIndex = 11;
            // 
            // lueProveedor
            // 
            this.lueProveedor.Location = new System.Drawing.Point(15, 88);
            this.lueProveedor.Name = "lueProveedor";
            this.lueProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueProveedor.Size = new System.Drawing.Size(418, 20);
            this.lueProveedor.TabIndex = 10;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(439, 69);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 13);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Bono Merma";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(15, 69);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Proveedor";
            // 
            // lueAlmacen
            // 
            this.lueAlmacen.Location = new System.Drawing.Point(439, 43);
            this.lueAlmacen.Name = "lueAlmacen";
            this.lueAlmacen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueAlmacen.Size = new System.Drawing.Size(203, 20);
            this.lueAlmacen.TabIndex = 7;
            // 
            // lueTipoMovimiento
            // 
            this.lueTipoMovimiento.Location = new System.Drawing.Point(230, 43);
            this.lueTipoMovimiento.Name = "lueTipoMovimiento";
            this.lueTipoMovimiento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTipoMovimiento.Size = new System.Drawing.Size(203, 20);
            this.lueTipoMovimiento.TabIndex = 6;
            this.lueTipoMovimiento.EditValueChanged += new System.EventHandler(this.lueTipoMovimiento_EditValueChanged);
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(124, 43);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(100, 20);
            this.txtFolio.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(439, 24);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Almacen";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(230, 24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(92, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Tipo de Movimiento";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(124, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(22, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Folio";
            // 
            // dtFecha
            // 
            this.dtFecha.EditValue = null;
            this.dtFecha.Location = new System.Drawing.Point(15, 43);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Size = new System.Drawing.Size(100, 20);
            this.dtFecha.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Fecha";
            // 
            // pcgrid
            // 
            this.pcgrid.Controls.Add(this.gridControl1);
            this.pcgrid.Location = new System.Drawing.Point(0, 191);
            this.pcgrid.Name = "pcgrid";
            this.pcgrid.Size = new System.Drawing.Size(703, 262);
            this.pcgrid.TabIndex = 11;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(5, 5);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(693, 250);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // spCatFolioDS
            // 
            this.spCatFolioDS.DataSetName = "spCatFolioDS";
            this.spCatFolioDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spCatProveedorDS
            // 
            this.spCatProveedorDS.DataSetName = "spCatProveedorDS";
            this.spCatProveedorDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spCatEstacionDS
            // 
            this.spCatEstacionDS.DataSetName = "spCatEstacionDS";
            this.spCatEstacionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(716, 617);
            this.Name = "frmAlmacen";
            ((System.ComponentModel.ISupportInitialize)(this.tbControl)).EndInit();
            this.tbControl.ResumeLayout(false);
            this.tpDatos.ResumeLayout(false);
            this.tpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatTipoMovimientoDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDatosAlmacen)).EndInit();
            this.pcDatosAlmacen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAlmacenDestino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEstacionDestino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBonoMerma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAlmacen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTipoMovimiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcgrid)).EndInit();
            this.pcgrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatFolioDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatProveedorDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatEstacionDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private System.Windows.Forms.ImageList imageList1;
        private Datasets.Catalogos.spCatTipoMovimientoDS spCatTipoMovimientoDS;
        private DevExpress.XtraEditors.PanelControl pcDatosAlmacen;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtReferencia;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit lueAlmacenDestino;
        private DevExpress.XtraEditors.LookUpEdit lueEstacionDestino;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtBonoMerma;
        private DevExpress.XtraEditors.LookUpEdit lueProveedor;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit lueAlmacen;
        private DevExpress.XtraEditors.LookUpEdit lueTipoMovimiento;
        private DevExpress.XtraEditors.TextEdit txtFolio;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtFecha;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl pcgrid;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Datasets.Catalogos.spCatFolioDS spCatFolioDS;
        private Datasets.Catalogos.spCatProveedorDS spCatProveedorDS;
        private Datasets.Catalogos.spCatEstacionDS spCatEstacionDS;
    }
}
