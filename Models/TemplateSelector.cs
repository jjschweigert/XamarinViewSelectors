using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Models
{
    public class TemplateSelector: DataTemplateSelector
    {
        public Dictionary<Type, DataTemplate> Templates { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var ItemType = item.GetType();

            if(Templates.Keys.Contains(ItemType))
            {
                try
                {
                    return Templates[ItemType];
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Failed to get data template with error:\n" + ex.Message);
                }
            }

            return null;
        }
    }
}
