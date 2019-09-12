using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageMaster : ContentPage
    {
        public DataTemplateSelector ListTemplateSelector { get; set; }
        public ObservableCollection<object> MenuItems { get; set; }

        public MainPageMaster(DataTemplateSelector _ListTemplateSelector)
        {
            InitializeComponent();
            ListTemplateSelector = _ListTemplateSelector;

            MenuItems = new ObservableCollection<object>()
            {
                new Models.Views.Template1_Key(),
                new Models.Views.Template2_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template3_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(),
                new Models.Views.Template1_Key(), 
            };

            BindingContext = this;
        }
    }
}