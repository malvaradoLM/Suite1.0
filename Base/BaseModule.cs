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
    public partial class BaseModule : frmPadre
    {
        private Actions actions;
        public BaseModule()
        {
            InitializeComponent();
            this.actions = new Actions();
            // Creamos un handler vacio para las acciones del modulo para que sean procesadas antes de registrar acciones
            Actions.OnPerformModuleAction += new ActionModuleHandler(DoActionModuleHandler);
            // Registramos las acciones del modulo
            RegisterActions();
        }

        public Actions Actions { get { return actions; } }

        // Este metodo debe ser declarado en las clases desendientes mediante override  
        // para actualizar el estado de cada accion, como las propiedades Enabled o IsDown 
        public virtual void UpdateActions() { }

        // Este metodo debe ser declarado en las clases desendientes mediante override  
        // Aqui se definen las acciones que utilizara el modulo  
        protected virtual void RegisterActions() { }

        protected virtual void DoActionModuleHandler(object key, object sender, EventArgs e) { }

        private void BaseModule_Activated(object sender, EventArgs e)
        {
            // Activamos los controles en el GUI
            Actions.UpdateVisibility();
            // Actualizamos el estado de las acciones
            UpdateActions();
            // Asignamos este modulo como Actual
            ModuleInfoCollection.MakeCurrentModule(this.GetType());
        }

        private void BaseModule_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Ocultamos todos los controles del GUI
            Actions.HideAllVisibility();
            // Cerramos este modulo
            ModuleInfoCollection.CloseModule(this.GetType());
        }

        private void BaseModule_Load(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Enter += ControlReceivedFocus;
            }
        }

        void ControlReceivedFocus(object sender, EventArgs e)
        {
            UpdateActions();
        }

//        internal void DoBuscar(object key, object sender, EventArgs e)
//        {
//            throw new NotImplementedException();
 //       }
    }
}
