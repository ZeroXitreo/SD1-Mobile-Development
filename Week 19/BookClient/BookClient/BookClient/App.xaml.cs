using BookClient.Data;
using Xamarin.Forms;

namespace BookClient
{
    public partial class App : Application
    {
        public App()
        {
            BookManager bookManager = new BookManager();
            bookManager.GetClient();

            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
