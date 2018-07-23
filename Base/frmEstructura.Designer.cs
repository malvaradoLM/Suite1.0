namespace RPSuite.Base
{
    partial class frmEstructura
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
            this.tbControl = new DevExpress.XtraTab.XtraTabControl();
            this.tpDatos = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbControl)).BeginInit();
            this.tbControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControl.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            this.tbControl.Location = new System.Drawing.Point(0, 0);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedTabPage = this.tpDatos;
            this.tbControl.Size = new System.Drawing.Size(712, 581);
            this.tbControl.TabIndex = 0;
            this.tbControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpDatos});
            // 
            // tpDatos
            // 
            this.tpDatos.Name = "tpDatos";
            this.tpDatos.Size = new System.Drawing.Size(710, 556);
            this.tpDatos.Text = "Datos";
            // 
            // frmEstructura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(712, 581);
            this.Controls.Add(this.tbControl);
            this.Name = "frmEstructura";
            this.Text = "Estructura";
            this.Load += new System.EventHandler(this.frmEstructura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbControl)).EndInit();
            this.tbControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraTab.XtraTabControl tbControl;
        public DevExpress.XtraTab.XtraTabPage tpDatos;
    }
}
