using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace RPSuite.Base
{
        // La clase abstracta para una Accion
        public abstract class Action
        {
            object control;
            object key;

            public Action(object control)
            {
                this.control = control;
            }

            // Si es true, la accion es implementada en el modulo y se muestra el GUI 
            // Si es false, la accion no es implementada en el modulo y se oculta del GUI 
            public abstract bool Visible { get; set; }

            // propiedad Enabled en el control relacionado a la accion en el GUI 
            public abstract bool Enabled { get; set; }

            // true si el control del GUI tiene el estado de down/pushed 
            public virtual bool IsDown { get { return false; } set { } }

            // El enlace de la accion a un control en el GUI 
            protected object Control { get { return control; } }

            // El codigo Identificador de la accion
            internal protected object Key { get { return key; } set { key = value; } }
        }
        
        // Definicion del encabezado del procedimiento que sera asignado a la accion
        public delegate void ActionModuleHandler(object key, object sender, EventArgs e);

        // La clase del controlador de acciones 
        // Es creada una instacia en cada modulo 
        // Contiene una hash-table estatica con cada accion registrada a nivel global.  

        public class Actions
        {
            // La lista global de acciones 
            static Hashtable registeredActions;

            // La lista de acciones soportadas por el modulo 
            Hashtable supportedActions;

            static Actions()
            {
                registeredActions = new Hashtable();
            }

            // Regustrar una accion en la lista globla. El parametro key es el codigo Identificador de la accion 
            public static void RegisterAction(object key, Action action)
            {
                // Si ya existe un Identificador de accion en la lista generar un error 
                if (Actions.registeredActions[key] != null)
                    throw new ApplicationException(string.Format("Ya existe una accion con este Identificador '{0}'.", key));
                // Se agrega la accion a la hash table global 
                Actions.registeredActions.Add(key, action);
                action.Key = key;
            }
            // Metodo para ejectutar el procedimiento asignado a la accion del modulo activo
            public static void PerformAction(object key, object sender, EventArgs e)
            {
                // Evaluamos que el modulo actual sea diferente de null  
                if (ModuleInfoCollection.CurrentModuleInfo != null)
                {
                    BaseModule module = ModuleInfoCollection.CurrentModuleInfo.Module;
                    // Ejecutamos el procedimiento asignado 
                    module.Actions.PerformModuleAction(key, sender, e);
                    // Una vez ejecutado el procedimiento reactualizamos el estado de las acciones del modulo
                    module.UpdateActions();
                }
            }

            public static void PerformAction(Action action, object sender, EventArgs e)
            {
                Actions.PerformAction(action.Key, sender, e);
            }

            // Este evento sera asignado en la clase BaseModule 
            public event ActionModuleHandler OnPerformModuleAction;

            public Actions()
            {
                // Creamos la hashtable de acciones soportadas para el modulo actual 
                this.supportedActions = new Hashtable();
            }

            // Notificamos que la accion sera soportada
            // Asignamos el procedimiento que se ejecutara en por la accion
            // Si el procedimiento asignado es null, el metodo Actions.PerformAction sera ejecutado 
            public void AddSupportedAction(object key, ActionModuleHandler actionHandler)
            {
                if (!Actions.registeredActions.ContainsKey(key))
                    new System.Exception(string.Format("El Identificador de la accion '{0}' es incorrecto", key));
                this.supportedActions.Add(key, actionHandler);
            }
            
            // Decuelve una accion de la lista con el codigo Identificador como indice
            public Action this[object key]
            {
                get
                {
                    if (!this.supportedActions.ContainsKey(key))
                        return null;
                    else return Actions.registeredActions[key] as Action;
                }
            }

            private bool IsVisibleActions()
            {
                bool Aux = false;
                foreach (object key in Actions.registeredActions.Keys)
                    if (((Action)Actions.registeredActions[key]).Visible)
                        Aux = true;
                return Aux;
            }

            // Oculta o muestra los controles del GUI  
            // dependiendo si son acciones soportadas por el modulo actual 
            public void UpdateVisibility()
            {
                foreach (object key in Actions.registeredActions.Keys)
                    ((Action)Actions.registeredActions[key]).Visible = this.supportedActions.ContainsKey(key);
                HideRibbonPageGroup(IsVisibleActions(), null, null);
            }
            
            //Oculta todos los controles del GUI
            public void HideAllVisibility()
            {
                foreach (object key in Actions.registeredActions.Keys)
                    ((Action)Actions.registeredActions[key]).Visible = false;
                HideRibbonPageGroup(IsVisibleActions(), null, null);
            }

            // Este metodo es ejecutado cuando se da click en el control del GUI 
            public void PerformModuleAction(object key, object sender, EventArgs e)
            {
                object handler = this.supportedActions[key];
                if (handler != null)
                    ((ActionModuleHandler)handler)(key, sender, e);
                else
                {
                    if (this.OnPerformModuleAction != null)
                        this.OnPerformModuleAction(key, sender, e);
                }
            }

            public static ActionModuleHandler HideRibbonPageGroup
            {
                get; set;
            }
        }  
}
