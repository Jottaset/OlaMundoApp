using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace OlaMundoApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            Debug.WriteLine("Olha o q aconteceu no OnStart!!!");
        }

        protected override void OnSleep()
        {
            Debug.WriteLine("Olha o q aconteceu no OnSleep!!!");
        }

        protected override void OnResume()
        {
            Debug.WriteLine("Olha o q aconteceu no OnResume!!!");
        }
    }
}
