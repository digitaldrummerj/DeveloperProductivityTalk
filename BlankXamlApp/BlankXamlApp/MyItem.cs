using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankXamlApp
{
    public class MyItem
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description 
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        private string _description;

        public MyItem(string title, string subtitle, string description)
        {
            Title = title;
            Subtitle = subtitle;
            Description = description;
        }
    } 
}
