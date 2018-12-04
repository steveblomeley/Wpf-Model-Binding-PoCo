using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace WpfComplexModelBindingPoco
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainPageViewModel _vm = new MainPageViewModel();

        public MainWindow()
        {
            _vm.Cameras.Add(new Camera { Model = "Model AB-c", FirmwareVersion = "9.8.7", Scaling = 7});
            _vm.Cameras.Add(new Camera { Model = "Model x", FirmwareVersion = "1.2.3", Scaling = 2 });
            _vm.Cameras.Add(new Camera { Model = "Model Z/1", FirmwareVersion = "4.5.600", Scaling = 10 });

            InitializeComponent();
            DataContext = _vm;
        }

        private void ListOfCameras_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!(e.AddedItems[0] is Camera selectedCamera)) return;

            _vm.SelectedCamera = selectedCamera;
        }
    }
}