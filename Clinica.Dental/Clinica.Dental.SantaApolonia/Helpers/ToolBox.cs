using System.Windows;
using System.Windows.Controls;

namespace Clinica.Dental.SantaApolonia
{
    public class ToolBox : ItemsControl
    {
        private Size defaultItemSize = new Size(65, 65);
        public Size DefaultItemSize
        {
            get { return this.defaultItemSize; }
            set { this.defaultItemSize = value; }
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new ToolBoxItem();
        }

        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return (item is ToolBoxItem);
        }
    }
}
