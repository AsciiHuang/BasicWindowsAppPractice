using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace DataBindingExample
{
    public class CustomData
    {
        static Random random = new Random(255);

        public CustomData()
        {
        }

        public CustomData(String title, String description)
        {
            this.Title = title;
            this.Description = description;
            ColorIcon = new SolidColorBrush(Color.FromArgb(255, (byte)random.Next(255), (byte)random.Next(255), (byte)random.Next(255)));
        }

        public SolidColorBrush ColorIcon
        {
            get;
            set;
        }

        public String Title
        {
            get;
            set;
        }

        public String Description
        {
            get;
            set;
        }
    }
}
