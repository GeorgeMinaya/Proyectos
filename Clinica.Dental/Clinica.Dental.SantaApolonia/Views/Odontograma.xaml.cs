using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Clinica.Dental.SantaApolonia;
using Clinica.Dental.SantaApolonia.ViewModel;
using System.Xml.Linq;
using System.Globalization;
using System.IO;
using System.Xml;
using System.Windows.Markup;

namespace Clinica.Dental.SantaApolonia.Views
{
    /// <summary>
    /// Lógica de interacción para Ondotograma.xaml
    /// </summary>
    public partial class Odontograma : Window
    {
        public Odontograma()
        {
            DataContextChanged += Registro_DataContextChanged;
            //rvm = new OdontogramaViewModel();
            //this.DataContext = rvm;
            InitializeComponent();
            
        }

        public void SetCanvas(string sPaciente)
        {
            var archivo = AppDomain.CurrentDomain.BaseDirectory + sPaciente + ".xml";

            if (File.Exists(archivo))
            {
                var cargado = XElement.Load(archivo);
                IEnumerable<XElement> itemsXML = cargado.Elements("DesignerItems").Elements("DesignerItem");
                foreach (XElement itemXML in itemsXML)
                {
                    Guid id = new Guid(itemXML.Element("ID").Value);
                    DesignerItem item = DeserializeDesignerItem(itemXML, id, 0, 0);
                    MyDesignerCanvas.Children.Add(item);
                }
            }
        }

        private DesignerItem DeserializeDesignerItem(XElement itemXML, Guid id, double OffsetX, double OffsetY)
        {
            DesignerItem item = new DesignerItem(id);
            item.Width = Double.Parse(itemXML.Element("Width").Value, CultureInfo.InvariantCulture);
            item.Height = Double.Parse(itemXML.Element("Height").Value, CultureInfo.InvariantCulture);
            item.ParentID = new Guid(itemXML.Element("ParentID").Value);
            item.IsGroup = Boolean.Parse(itemXML.Element("IsGroup").Value);
            Canvas.SetLeft(item, Double.Parse(itemXML.Element("Left").Value, CultureInfo.InvariantCulture) + OffsetX);
            Canvas.SetTop(item, Double.Parse(itemXML.Element("Top").Value, CultureInfo.InvariantCulture) + OffsetY);
            Canvas.SetZIndex(item, Int32.Parse(itemXML.Element("zIndex").Value));
            Object content = XamlReader.Load(XmlReader.Create(new StringReader(itemXML.Element("Content").Value)));
            item.Content = content;
            return item;
        }

        private void Registro_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var dc = DataContext as vmbClose;
            dc.CloseWindowEvent += (f, g) => this.Close();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var items = (from i in MyDesignerCanvas.Children.OfType<DesignerItem>()
                             where i.IsSelected
                             select i).ToList();
                for (int i = 0; i < items.Count; i++)
                {
                    MyDesignerCanvas.Children.Remove(items[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
