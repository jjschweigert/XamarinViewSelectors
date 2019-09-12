using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Views
{
    public class TestView_3_Model:Models.BaseModel
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
        private string _Cell3_Text { get; set; }
        public string Cell3_Text
        {
            get
            {
                return _Cell3_Text;
            }
            set
            {
                _Cell3_Text = value;
                base.NotifyPropertyChanged("Cell3_Text");
            }
        }

        private string _Cell4_Text { get; set; }
        public string Cell4_Text
        {
            get
            {
                return _Cell4_Text;
            }
            set
            {
                _Cell4_Text = value;
                base.NotifyPropertyChanged("Cell4_Text");
            }
        }

        public TestView_3_Model(string InitialCell1 = "", string InitialCell2 = "", string InitialCell3 = "", string InitialCell4 = "")
        {
            _Cell1_Text = InitialCell1;
            _Cell2_Text = InitialCell2;
            _Cell3_Text = InitialCell3;
            _Cell4_Text = InitialCell4;
        }
    }
}
