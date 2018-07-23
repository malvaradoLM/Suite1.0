namespace RPSuite.Base
{
    partial class BaseModule
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
            this.vpValidador = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).BeginInit();
            this.SuspendLayout();
            // 
            // BaseModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 379);
            this.Name = "BaseModule";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.BaseModule_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BaseModule_FormClosed);
            this.Load += new System.EventHandler(this.BaseModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider vpValidador;
    }
}