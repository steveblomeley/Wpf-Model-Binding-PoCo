using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WpfComplexModelBindingPoco.Annotations;

namespace WpfComplexModelBindingPoco
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Camera> Cameras { get; set; } = new ObservableCollection<Camera>();

        private Camera _selectedCamera;
        public Camera SelectedCamera
        {
            get => _selectedCamera;
            set
            {
                _selectedCamera = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}