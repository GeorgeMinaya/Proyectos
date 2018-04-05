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
using Clinica.Dental.SantaApolonia.ViewModel;
using System.Text.RegularExpressions;

namespace Clinica.Dental.SantaApolonia.Views
{
    /// <summary>
    /// Lógica de interacción para Registro.xaml
    /// </summary>
    public partial class Registro : Window
    {
        //RegistroViewModel rvm;

        public Registro()
        {
            DataContextChanged += Registro_DataContextChanged;
            //rvm = new RegistroViewModel();
            //this.DataContext = rvm;
            InitializeComponent();
            
        }

        private void Registro_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var dc = DataContext as vmbClose;
            dc.CloseWindowEvent += (f, g) => this.Close();
        }

        private void TextInputSoloNumeros(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
