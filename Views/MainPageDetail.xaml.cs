using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageDetail : ContentPage
    {
        public MainPageDetail_Model currentView { get; set; }
        public MainPageDetail()
        {
            InitializeComponent();
            currentView = new MainPageDetail_Model(new Views.TestView_1());
            BindingContext = currentView;
            Device.StartTimer(TimeSpan.FromSeconds(2), () => 
            {
                Type currViewType = currentView.CurrentView.GetType();
                if (currViewType == typeof(Views.TestView_1))
                {
                    currentView.CurrentView = new Views.TestView_2()
                    {
                        BindingContext = new Models.Views.TestView_2_Model("View 1", "View 2")
                    };
                }
                else if(currViewType == typeof(Views.TestView_2))
                {
                    currentView.CurrentView = new Views.TestView_3()
                    {
                        BindingContext = new Models.Views.TestView_3_Model("View 1", "View 2", "View 3", "View 4")
                    };
                }
                else if(currViewType == typeof(Views.TestView_3))
                {
                    currentView.CurrentView = new Views.TestView_1()
                    {
                        BindingContext = new Models.Views.TestView_1_Model("View 3", "View 4")
                    };
                }
                return true;
            });
        }
    }

    public class MainPageDetail_Model:Models.BaseModel
    {
        private ContentView _CurrentView { get; set; }
        public ContentView CurrentView
        {
            get
            {
                return _CurrentView;
            }
            set
            {
                _CurrentView = value;
                base.NotifyPropertyChanged("CurrentView");
            }
        }

        public MainPageDetail_Model(ContentView InitialView = null)
        {
            _CurrentView = InitialView;
        }
    }
}