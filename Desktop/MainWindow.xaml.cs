using System.Windows;
using AntDesign.ProLayout;
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
            serviceCollection.Configure<ProSettings>(x =>
            {
                x.Title = "DogfishNet";
                x.NavTheme = "light";
                x.Layout = "mix";
                x.PrimaryColor = "daybreak";
                x.ContentWidth = "Fluid";
                x.HeaderHeight = 64;
            });
            Resources.Add("services",serviceCollection.BuildServiceProvider());
        }
    }
}