using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars;

namespace RPSuite.Base
{
    public class BarItemAction : Action
    {
        public BarItemAction(BarItem barItem) : base(barItem)
        {
            // Asignamos un procedimiento al evento ItemClick  
            barItem.ItemClick += new ItemClickEventHandler(DoItemClick);
        }

        public BarItem Item { get { return Control as BarItem; } }

        public override bool Visible
        {
            get { return Item.Visibility != BarItemVisibility.Never; }
            set
            {
                if (value)
                    Item.Visibility = BarItemVisibility.Always;
                else Item.Visibility = BarItemVisibility.Never;
            }
        }

        public override bool Enabled { get { return Item.Enabled; } set { Item.Enabled = value; } }

        // Esta propiedad es devuelta solo si el control es un BarButtonItem 
        public override bool IsDown
        {
            get
            {
                if (Item is BarButtonItem)
                    return (Item as BarButtonItem).Down;
                return false;
            }
            set
            {
                if (Item is BarButtonItem)
                    (Item as BarButtonItem).Down = value;
            }
        }

        // Ejectuta el procedimiento asignado a la accion
        void DoItemClick(object sender, ItemClickEventArgs e)
        {
            Actions.PerformAction(this, sender, e);
        }
    }
}
