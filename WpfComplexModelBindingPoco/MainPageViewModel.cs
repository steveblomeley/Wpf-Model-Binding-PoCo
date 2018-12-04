using System.Collections.ObjectModel;

namespace WpfComplexModelBindingPoco
{
    public class MainPageViewModel
    {
        public ObservableCollection<Camera> Cameras { get; set; } = new ObservableCollection<Camera>();
    }
}