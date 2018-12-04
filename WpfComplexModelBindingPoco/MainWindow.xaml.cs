using System.Collections.ObjectModel;
using System.Windows;

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
            _vm.Cameras.Add(new Camera { Model = "Model AB-c", FirmwareVersion = "9.8.7" });
            _vm.Cameras.Add(new Camera { Model = "Model x", FirmwareVersion = "1.2.3" });
            _vm.Cameras.Add(new Camera { Model = "Model Z/1", FirmwareVersion = "4.5.600" });

            InitializeComponent();
            DataContext = _vm;
        }
    }
}