using Windows.UI.Xaml.Controls;

namespace UwpComboboxAnomaly
{
    public sealed partial class MainPage : Page
    {

        private readonly CMainViewModel MainViewModel = new CMainViewModel();

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void CbdlExample_SelectionChanged(object _1, SelectionChangedEventArgs _2)
        {
            MainViewModel.EventResult = $"Combobox.SelectedIndex={CbdlExample.SelectedIndex}, MainViewModel.SelectedIndex={MainViewModel.SelectedIndex}";
        }
    }
}
