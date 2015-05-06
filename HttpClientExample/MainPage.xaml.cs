using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Data.Json;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HttpClientExample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void OnGetResponseButtonClick(object sender, RoutedEventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://www.einvoice.nat.gov.tw/");
            HttpResponseMessage response = await httpClient.GetAsync("PB2CAPIVAN/invapp/InvApp");

            /*
             *  使用 Post Method 帶字串參數訪問 API
             *  HttpResponseMessage response = await httpClient.PostAsync("PB2CAPIVAN/invapp/InvApp", new StringContent("API Request Params"));
            */

            /*
             *  使用 Post Method 帶 Key/Value 參數訪問 API
             *  MultipartFormDataContent form = new MultipartFormDataContent();
             *  form.Add(new StringContent("param"), "data");
             *  HttpResponseMessage response = await httpClient.PostAsync("PB2CAPIVAN/invapp/InvApp", form));
            */

            if (response.StatusCode == HttpStatusCode.OK)
            {
                String strResponse = await response.Content.ReadAsStringAsync();
                if (!String.IsNullOrEmpty(strResponse))
                {
                    String code = "", msg = "", v = "";
                    JsonObject jsonObj = JsonObject.Parse(strResponse);
                    if (jsonObj["code"].ValueType == JsonValueType.String)
                    {
                        code = jsonObj["code"].GetString();
                    }
                    if (jsonObj["msg"].ValueType == JsonValueType.String)
                    {
                        msg = jsonObj["msg"].GetString();
                    }
                    if (jsonObj["v"].ValueType == JsonValueType.String)
                    {
                        v = jsonObj["v"].GetString();
                    }
                    txt_response.Text = strResponse;
                    lbl_response_detail.Text = String.Format("Code : {0}\nMsg : {1}\nVersion : {2}", code, msg, v);
                }
            }
        }
    }
}
