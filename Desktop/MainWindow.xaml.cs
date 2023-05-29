using System.Windows;
using Microsoft.Extensions.DependencyInjection;


namespace Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfBlazorWebView();
            serviceCollection.AddAntDesign();
            Resources.Add("services",serviceCollection.BuildServiceProvider());
        }
    }
}