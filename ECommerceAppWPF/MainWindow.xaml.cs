using System.Windows;

namespace ECommerceAppWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel.MainViewModel();
        }
    }
}
