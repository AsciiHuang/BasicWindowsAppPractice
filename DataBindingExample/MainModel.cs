using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace DataBindingExample
{
    public class MainModel
    {
        public MainModel()
        {
            TextProperty = "Microsoft";
            BrushProperty = new SolidColorBrush(Colors.BurlyWood);
            IntegerProperty = 20;
            BitmapProperty = new BitmapImage(new Uri("https://assets.onestore.ms/cdnfiles/onestorerolling-1504-30011/shell/v1_1/images/logo/microsoft.png"));
            StringURIProperty = "https://i-msdn.sec.s-msft.com/dynimg/IC733879.jpg";
            ObjectProperty = new CustomData("Data Title", "Data Description");
        }

        public String TextProperty
        {
            get;
            set;
        }

        public SolidColorBrush BrushProperty
        {
            get;
            set;
        }

        private Int32 _integerProperty;
        public Int32 IntegerProperty
        {
            get
            {
                return _integerProperty;
            }
            set
            {
                _integerProperty = value;
            }
        }

        private BitmapImage _bitmapProperty;
        public BitmapImage BitmapProperty
        {
            get
            {
                return _bitmapProperty;
            }
            set
            {
                _bitmapProperty = value;
            }
        }

        public String StringURIProperty
        {
            get;
            set;
        }

        public CustomData ObjectProperty
        {
            get;
            set;
        }

        public List<CustomData> ListDatas
        {
            get;
            set;
        }
    }
}
