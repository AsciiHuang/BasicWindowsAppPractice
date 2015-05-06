using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DataBindingExample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //public MainModel Model
        //{
        //    get;
        //    set;
        //}

        public MainPage()
        {
            this.InitializeComponent();
            initData();
            DataContext = this;
            //Model = new MainModel();
            //this.DataContext = Model;
        }

        private void initData()
        {
            TextProperty = "Microsoft";
            BrushProperty = new SolidColorBrush(Colors.BurlyWood);
            IntegerProperty = 20;
            BitmapProperty = new BitmapImage(new Uri("https://assets.onestore.ms/cdnfiles/onestorerolling-1504-30011/shell/v1_1/images/logo/microsoft.png"));
            StringURIProperty = "https://i-msdn.sec.s-msft.com/dynimg/IC733879.jpg";
            ObjectProperty = new CustomData("Data Title", "Data Description");
            List<CustomData> datas = new List<CustomData>();
            for (int i = 0; i < 50; ++i)
            {
                datas.Add(new CustomData(String.Format("Title {0}", i), String.Format("Description {0}", i)));
            }
            ListDatas = datas;
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
