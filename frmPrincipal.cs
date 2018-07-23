using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPSuite.Base;
using RPSuite.Data;
using System.Globalization;
using System.Threading;

namespace RPSuite
{
    public partial class frmPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm, IMessageFilter
    {
        private DateTime _wentIdle;
        private bool isUserInput(Message m)
        {
            // look for any message that was the result of user input
            if (m.Msg == 0x200) { return true; } // WM_MOUSEMOVE
            if (m.Msg == 0x020A) { return true; } // WM_MOUSEWHEEL
            if (m.Msg == 0x100) { return true; } // WM_KEYDOWN
            if (m.Msg == 0x101) { return true; } // WM_KEYUP
            return false;
        }
        public bool PreFilterMessage(ref Message m)
        {
            // reset our last idle time if the message was user input
            if (isUserInput(m))
            {
                _wentIdle = DateTime.Now;
            }
            return false;
        }
        private void HideRibbonPageGroup(object key, object sender, EventArgs e)
        {
            rpgBasicas.Visible = (bool)key;
        }

        private void RegisterBarItems()
        {
            Actions.HideRibbonPageGroup += HideRibbonPageGroup;
            Actions.RegisterAction(ActionKeys.actNuevo, new BarItemAction(this.btnNuevo));
            Actions.RegisterAction(ActionKeys.actGuardar, new BarItemAction(this.btnGuardar));
            Actions.RegisterAction(ActionKeys.actCancelar, new BarItemAction(this.btnCancelar));
            Actions.RegisterAction(ActionKeys.actProcesar, new BarItemAction(this.btnProcesar));
            Actions.RegisterAction(ActionKeys.actEliminar, new BarItemAction(this.btnEliminar));
            Actions.RegisterAction(ActionKeys.actImprimir, new BarItemAction(this.btnImprimir));

            Actions.RegisterAction(ActionKeys.actXML, new BarItemAction(this.btnXML));
            Actions.RegisterAction(ActionKeys.actEnviarCorreo, new BarItemAction(this.btnEnviarCorreo));
            Actions.RegisterAction(ActionKeys.actAddenda, new BarItemAction(this.btnAddenda));
            Actions.RegisterAction(ActionKeys.actPrimer, new BarItemAction(this.btnPrimer));
            Actions.RegisterAction(ActionKeys.actSiguiente, new BarItemAction(this.btnSiguiente));
            Actions.RegisterAction(ActionKeys.actAnterior, new BarItemAction(this.btnAnterior));
            Actions.RegisterAction(ActionKeys.actUltimo, new BarItemAction(this.btnUltimo));
            Actions.RegisterAction(ActionKeys.actActualizar, new BarItemAction(this.btnActualizar));
            Actions.RegisterAction(ActionKeys.actBuscar, new BarItemAction(this.btnBuscar));
        }

        private void RefreshStatusBar()
        {
            bsiHora.Caption = DateTime.Now.ToString("HH:mm:ss tt");
            bsiFecha.Caption = DateTime.Now.ToString("dddd dd MMMM yyyy");
            bsiNUM.Enabled = Control.IsKeyLocked(Keys.NumLock);
            bsiMAY.Enabled = Control.IsKeyLocked(Keys.CapsLock);
            bsiINS.Enabled = Control.IsKeyLocked(Keys.Scroll);
            bsiVersion.Caption = "Versión: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            if ((DataModule.Seguridad != null) && (DataModule.Seguridad.UserID != ""))
            {
                TimeSpan diff = DateTime.Now - _wentIdle;
                bsiIdle.Caption = "idle: " + diff.ToString("mm\\:ss");
            } else
            {
                bsiIdle.Caption = "idle:";
                bsiUsuario.Caption = "";
                bsiTipoCambio.Caption = "";
            }           
        }
        public frmPrincipal()
        {
            _wentIdle = DateTime.Now;
            Application.AddMessageFilter(this);
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("es-MX");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            rbPrincipal.Images = RPSuite.Data.DataModule.Images16;
            rbPrincipal.LargeImages = RPSuite.Data.DataModule.Images48;

            RegisterBarItems();
            RefreshStatusBar();
            bvcMenuPrincipal.SelectedTab = bvtFavoritos;
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ModuleInfoCollection.ShowModuleByName("FacturacionContado", this);
            //ModuleInfoCollection.ShowModuleByName("Module1", this);
            bvcMenuPrincipal.Close();
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ModuleInfoCollection.ShowModuleByName("Module2", this);
            bvcMenuPrincipal.Close();
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshStatusBar();
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RPSuite.Forms.frmLogin Login = new RPSuite.Forms.frmLogin();
            Login.ShowDialog();
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ModuleInfoCollection.ShowModuleByName("CatalogoBanco", this);
            bvcMenuPrincipal.Close();
            
        }

        private void tileItem4_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            tlcFavoritos.Images = Data.DataModule.Images48;
            tileItem4.ImageIndex = 0;
        }

        private bool ItemsChecked(DevExpress.XtraEditors.TileControl tc)
        {
            bool esVisible = false;
            foreach (DevExpress.XtraEditors.TileGroup Gpr in tc.Groups)
            {
                foreach (DevExpress.XtraEditors.TileItem Aux in Gpr.Items)
                {
                    if (Aux.Checked)
                    {
                        esVisible = true;
                    }
                }
            }
            return esVisible;
        }

        private void tlcFavoritos_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == System.Windows.Forms.MouseButtons.Right)
            {
                DevExpress.XtraEditors.TileControl tileControl = (DevExpress.XtraEditors.TileControl)sender;
                DevExpress.XtraEditors.TileControlHitInfo hitInfo = tileControl.CalcHitInfo(tileControl.PointToClient(MousePosition));
                if (hitInfo.InItem)
                {
                    hitInfo.ItemInfo.Item.Checked = !hitInfo.ItemInfo.Item.Checked;
                }
                
                gbFavoritos.Parent = tileControl.Parent;
                gbFavoritos.Visible = ItemsChecked(tileControl);
            }
        }

        private void bvcMenuPrincipal_SelectedTabChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            foreach (Control child in bvcMenuPrincipal.SelectedTab.ContentControl.Controls)
            {
                if (child is DevExpress.XtraEditors.TileControl)
                {
                    if (ItemsChecked((DevExpress.XtraEditors.TileControl)child))
                    {
                        gbFavoritos.Parent = (DevExpress.XtraEditors.TileControl)child;
                        gbFavoritos.Visible = true;
                    }
                }
            }
        }

        private void tileItem6_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }

        private void tileItem7_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ModuleInfoCollection.ShowModuleByName("CatalogoReportes", this);
            bvcMenuPrincipal.Close();
        }

        private void tileItem13_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ModuleInfoCollection.ShowModuleByName("CatalogoCategoria", this);
            bvcMenuPrincipal.Close();
        }

        private void tetCatProducto_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ModuleInfoCollection.ShowModuleByName("CatalogoProducto", this);
            bvcMenuPrincipal.Close();
        }

        private void tiCatalogoCuentaBancaria_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ModuleInfoCollection.ShowModuleByName("CatalogoCuentaBancaria", this);
            bvcMenuPrincipal.Close();
        }

        private void tiCatalogoProveedor_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ModuleInfoCollection.ShowModuleByName("CatalogoProveedor", this);
            bvcMenuPrincipal.Close();
        }

        private void tiFormadePago_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ModuleInfoCollection.ShowModuleByName("CatalogoFormadePago", this);
            bvcMenuPrincipal.Close();
        }

        private void tileItem14_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ModuleInfoCollection.ShowModuleByName("CatalogoEstacion", this);
            bvcMenuPrincipal.Close();
        }

        private void bvtCatalogos_SelectedChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

        }

        private void timGrupoNomina_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ModuleInfoCollection.ShowModuleByName("CatalogoGrupoNomina", this);
            bvcMenuPrincipal.Close();
        }

        private void timCatalogoEmpleado_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ModuleInfoCollection.ShowModuleByName("CatalogoEmpleado", this);
            bvcMenuPrincipal.Close();

        }

        private void timTipoDocumento_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ModuleInfoCollection.ShowModuleByName("CatalogoTipoDocumento", this);
            bvcMenuPrincipal.Close();

        }

        private void tileItem26_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ModuleInfoCollection.ShowModuleByName("CatalogoDiaFestivo", this);
            bvcMenuPrincipal.Close();

            
        }

        private void tileItem27_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ModuleInfoCollection.ShowModuleByName("CatalogoTerminalBiometrica", this);
            bvcMenuPrincipal.Close();
            
        }

        private void tileItem28_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ModuleInfoCollection.ShowModuleByName("CatalogoBanco", this);
            bvcMenuPrincipal.Close();
        }

        private void timAlmacen_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ModuleInfoCollection.ShowModuleByName("Almacen", this);
            bvcMenuPrincipal.Close();
        }

        private void bvtConfiguracion_SelectedChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

        }

        private void tileItem15_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ModuleInfoCollection.ShowModuleByName("RegimenFiscal", this);
            bvcMenuPrincipal.Close();
        }

        private void timGrupoEstacion_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ModuleInfoCollection.ShowModuleByName("GrupoEstacion", this);
            bvcMenuPrincipal.Close();
        }

        private void timGasolinero_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ModuleInfoCollection.ShowModuleByName("Gasolinero", this);
            bvcMenuPrincipal.Close();
        }
    }
}
