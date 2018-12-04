using System.ComponentModel;
using System.Runtime.CompilerServices;
using WpfComplexModelBindingPoco.Annotations;

namespace WpfComplexModelBindingPoco
{
    public class Camera : INotifyPropertyChanged
    {
        // Properties that are populated and displayed in list of cameras
        private string _model;
        public string Model
        {
            get => _model;
            set
            {
                _model = value;
                OnPropertyChanged();
            }
        }

        private string _firmwareVersion;
        public string FirmwareVersion
        {
            get => _firmwareVersion;
            set
            {
                _firmwareVersion = value;
                OnPropertyChanged();
            }
        }

        // Properties that are displayed only for the selected camera
        private int _scaling;
        public int Scaling
        {
            get => _scaling;
            set
            {
                _scaling = value;
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
