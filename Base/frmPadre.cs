using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSuite.Base
{
    public enum stEstado { Close, Browse, Append, Edit };
    public partial class frmPadre : Form
    {
        private stEstado _State;
        protected System.Windows.Forms.BindingSource DataSource { get; set; }
        public frmPadre()
        {
            InitializeComponent();
        }

        private void frmPadre_KeyDown(object sender, KeyEventArgs e)
        {
            if (RPSuite.Data.DataModule.OKEnter)
            {
                Control nextControl;
                //Checks if the Enter Key was Pressed
                if (e.KeyCode == Keys.Enter)
                {
                    //If so, it gets the next control and applies the focus to it
                    nextControl = GetNextControl(ActiveControl, !e.Shift);
                    if (nextControl == null)
                    {
                        nextControl = GetNextControl(null, true);
                    }
                    nextControl.Focus();
                    //Finally - it suppresses the Enter Key
                    e.SuppressKeyPress = true;
                }
            }
        }

        public stEstado State
        {
            get { return _State; }
            set { _State = value; }
        }

        #region DetectUpdate
        protected virtual void DoOnUpdateControl()
        {

        }
        private void _StartEditing(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            DoOnUpdateControl();
        }
        protected void SetBeginEdit(Control ctrl)
        {
            if (ctrl.Controls.Count > 0)
            {
                foreach (Control child in ctrl.Controls)
                {
                    //Check if the child control is bound to the BindingSource.
                    bool hasBinding = false;
                    foreach (Binding bind in child.DataBindings)
                    {
                        if (bind.DataSource == DataSource)
                        {
                            hasBinding = true;
                            break;
                        }
                    }
                    //If it is bound, fire the StartEditing event while it got focus.
                    if (hasBinding)
                    {
                        if (child is DevExpress.XtraEditors.BaseEdit)
                        {
                            ((DevExpress.XtraEditors.BaseEdit)child).EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(_StartEditing);
                        }
                    }
                    //Check its children.
                    SetBeginEdit(child);
                }
            }
        }
        #endregion

    }
}
