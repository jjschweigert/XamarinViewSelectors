using Xamarin.Essentials;
using Xamarin.Forms;


namespace ViewSelector
{
    public partial class App : Application
    {
        public static Models.TemplateSelector templateSelector = new Models.TemplateSelector
        {
            Templates = new System.Collections.Generic.Dictionary<System.Type, DataTemplate>
            {

                { typeof(Models.Views.Template1_Key), new DataTemplate(typeof(Views.ViewCells.Template1)) },
                { typeof(Models.Views.Template2_Key), new DataTemplate(typeof(Views.ViewCells.Template2)) },
                { typeof(Models.Views.Template3_Key), new DataTemplate(typeof(Views.ViewCells.Template3)) },
            }
        };

        public App()
        {
            InitializeComponent();


            MainPage = new Views.MainPage(templateSelector);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
