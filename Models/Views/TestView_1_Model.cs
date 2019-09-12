using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Views
{
    public class TestView_1_Model:Models.BaseModel
    {
        private string _Cell1_Text { get; set; }
        public string Cell1_Text
        {
            get
            {
                return _Cell1_Text;
            }
            set
            {
                _Cell1_Text = value;
                base.NotifyPropertyChanged("Cell1_Text");
            }
        }

        private string _Cell2_Text { get; set; }
        public string Cell2_Text
        {
            get
            {
                return _Cell2_Text;
            }
            set
            {
                _Cell2_Text = value;
                base.NotifyPropertyChanged("Cell2_Text");
            }
        }

        public TestView_1_Model(string InitialCell1 = "", string InitialCell2 = "")
        {
            _Cell1_Text = InitialCell1;
            _Cell2_Text = InitialCell2;
        }
    }
}
