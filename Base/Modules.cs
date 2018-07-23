using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Reflection;
using System.Collections;

namespace RPSuite.Base
{
        // Esta clase contiene la informacion acerca del modulo
        public class ModuleInfo
        {
            string name;
            public Type moduleType;
            BaseModule module;

            // Agregamos la informacion del modulo
            public ModuleInfo(string name, Type moduleType)
            {
                // Si el modulo que se quiere agregar no desciende de BaseModule generar error
                if (!moduleType.IsSubclassOf(typeof(BaseModule)))
                    throw new ArgumentException("La clase no desiende de ModuleBase");
                this.name = name;
                this.moduleType = moduleType;
                this.module = null;
            }

            public string Name { get { return this.name; } }

            // Muestra el modulo en la forma principal 
            public void Show(Form parent)
            {
                // Creamos el modulo
                CreateModule();
                module.Visible = false;    
                module.MdiParent = parent;
                module.Dock = DockStyle.Fill;
                module.Visible = true;
            }
            
            // Cerramos el modulo
            public void Close()
            {
                // Destruimos la instancia del modulo para que se pueda volver abrir
                module = null;
            }

            // Creamos la instancia del modulo 
            protected void CreateModule()
            {
                // Validamos que el modulo no este activo
                if (this.module == null)
                {
                    ConstructorInfo constructorInfoObj = moduleType.GetConstructor(Type.EmptyTypes);
                    if (constructorInfoObj == null)
                        throw new ApplicationException(moduleType.FullName + " doesn't have a public constructor with empty parameters");
                    this.module = constructorInfoObj.Invoke(null) as BaseModule;
                }
            }

            // Propiedad de la instacia del modulo 
            public BaseModule Module { get { return this.module; } }
        }

        // Clase de la lista de todos los modulos registrados 
        [ListBindable(false)]
        public class ModuleInfoCollection : CollectionBase
        {
            static ModuleInfoCollection instance;
            ModuleInfo currentModule;

            // Creamos una instancia estatica de la clase 
            static ModuleInfoCollection()
            {
                instance = new ModuleInfoCollection();
            }
            
            // Asignamos en null el modulo Actual a la instacia estatica
            ModuleInfoCollection() : base()
            {
                this.currentModule = null;
            }

            // Devuelve una modulo con el nombre como indice
            public ModuleInfo this[string name]
            {
                get
                {
                    foreach (ModuleInfo info in this)
                        if (info.Name.Equals(name))
                            return info;
                    return null;
                }
            }

            // Devuelve una modulo con el tipo como indice
            public ModuleInfo this[Type moduleType]
            {
                get
                {
                    foreach (ModuleInfo info in this)
                        if (info.moduleType.Equals(moduleType))
                            return info;
                    return null;
                }
            }

            // Registramos el modulo 
            public static void Add(string name, Type moduleType)
            {
                ModuleInfo item = new ModuleInfo(name, moduleType);
                instance.Add(item);
            }

            public static ModuleInfoCollection Instance { get { return instance; } }

            // Muestra el modulo en la forma asignada 
            public static void ShowModule(ModuleInfo item, Form parent)
            {
                item.Show(parent);
                instance.currentModule = item;
            } 

            // Muestra un modulo por nombre en la forma asignada
            public static void ShowModuleByName(string ModuleName, Form parent)
            {
                ShowModule(instance[ModuleName], parent);  
            }
            
            // Activa el modulo como Actual
            public static void MakeCurrentModule(Type moduleType)
            {
                instance.currentModule = instance[moduleType];
            }

            // Cierra el modulo 
            public static void CloseModule(Type moduleType)
            {
              instance[moduleType].Close();
            }

            // Regresa la informacion del modulo Actual 
            public static ModuleInfo CurrentModuleInfo { get { return instance.currentModule; } }

            void Add(ModuleInfo value)
            {
                if (List.IndexOf(value) < 0)
                    List.Add(value);
            }
        }   
}
