using Clinica.Dental.SantaApolonia.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Clinica.Dental.SantaApolonia.Views
{
    /// <summary>
    /// Lógica de interacción para Resumen.xaml
    /// </summary>
    public partial class Resumen : Window
    {
        public Resumen()
        {
            DataContextChanged += Resumen_DataContextChanged;
            
            InitializeComponent();
        }

        private void Resumen_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var dc = DataContext as vmbClose;
            dc.CloseWindowEvent += (f, g) => this.Close();
        }

        private void TextInputSoloNumeros(object sender, TextCompositionEventArgs e)
        {
            var regex = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
            if (regex.IsMatch(e.Text) && !(e.Text == "." && ((TextBox)sender).Text.Contains(e.Text)))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            lblSumaTotal.Text = ((ResumenViewModel)this.DataContext).SumaTotal;
        }
    }
}
