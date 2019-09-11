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
    public partial class MainPage : MasterDetailPage
    {
        public MainPage(DataTemplateSelector _ListTemplateSelector)
        {
            InitializeComponent();
            Master = new MainPageMaster(_ListTemplateSelector);
        }
    }
}