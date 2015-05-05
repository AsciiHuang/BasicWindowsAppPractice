using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingExample
{
    public class CustomData
    {
        public CustomData()
        {
        }

        public CustomData(String title, String description)
        {
            this.Title = title;
            this.Description = description;
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
