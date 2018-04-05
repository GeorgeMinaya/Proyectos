using Clinica.Dental.SantaApolonia.ViewModel;
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

namespace Clinica.Dental.SantaApolonia.Views
{
    /// <summary>
    /// Lógica de interacción para Pacientes.xaml
    /// </summary>
    public partial class Pacientes : Window
    {
        public Pacientes()
        {
            DataContextChanged += Registro_DataContextChanged;
            InitializeComponent();
        }

        private void Registro_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var dc = DataContext as vmbClose;
            dc.CloseWindowEvent += (f, g) => this.Close();
        }
    }
}
