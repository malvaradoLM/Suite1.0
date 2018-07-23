using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPSuite.Forms.Catalogos;
using RPSuite.Forms;
using RPSuite.Forms.Liquidacion;
using RPSuite.Forms.Inventario;

namespace RPSuite.Base
{
        // Clase global de modulos registrados
        public class ModulesRegistration

        {
            // Regitrar aqui todos los modulos 
            static public void Register()
            {
                ModuleInfoCollection.Add("Module1", typeof(frmCatalogoEstacion));
                ModuleInfoCollection.Add("Module2", typeof(Form2));
                ModuleInfoCollection.Add("CatalogoCliente", typeof(frmCatalogoCliente));
                ModuleInfoCollection.Add("CatalogoBanco", typeof(frmCatalogoBanco));
                ModuleInfoCollection.Add("CatalogoReportes", typeof(frmCatalogoReportes));
                ModuleInfoCollection.Add("CatalogoCategoria", typeof(frmCatalogoCategoria));
                ModuleInfoCollection.Add("CatalogoProducto", typeof(frmCatalogoProducto));
                ModuleInfoCollection.Add("CatalogoCuentaBancaria", typeof(frmCatalogoCuentaBancaria));
                ModuleInfoCollection.Add("CatalogoProveedor", typeof(frmCatalogoProveedor));
                ModuleInfoCollection.Add("CatalogoFormadePago", typeof(frmCatalogoFormadePago));
                ModuleInfoCollection.Add("CatalogoEstacion", typeof(frmCatalogoEstacion));
                ModuleInfoCollection.Add("CatalogoGrupoNomina", typeof(frmCatalogoGrupoNomina));
                ModuleInfoCollection.Add("CatalogoEmpleado", typeof(frmCatalogoEmpleadocs));
                ModuleInfoCollection.Add("CatalogoTipoDocumento", typeof(frmCatalogoTipoDocumento));
                ModuleInfoCollection.Add("CatalogoDiaFestivo", typeof(frmCatalogoDiaFestivo));
                ModuleInfoCollection.Add("CatalogoTerminalBiometrica", typeof(frmCatalogoTerminalBiometrica));
         
            //Configuracion
            ModuleInfoCollection.Add("CatalogoEstacion", typeof(frmCatalogoEstacion));
            ModuleInfoCollection.Add("RegimenFiscal", typeof(frmCatalogoRegimenFiscal));
            ModuleInfoCollection.Add("GrupoEstacion", typeof(frmCatalogoGrupoEstacion));
            ModuleInfoCollection.Add("Gasolinero", typeof(frmCatalogoGasolinero));

            // Facturacion
            ModuleInfoCollection.Add("FacturacionContado", typeof(frmFacturaContado));


            //Almacen
            ModuleInfoCollection.Add("Almacen", typeof(frmAlmacen));




        }
    }    
}
