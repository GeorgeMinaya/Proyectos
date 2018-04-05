
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Clinica.Dental.SantaApolonia.ViewModel
{
    public class vmb : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
