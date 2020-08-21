
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace WidgetSampleCS
{






    public sealed partial class Widget1 : Page
    {
        public static string youTubeURL = "https://www.youtube.com/watch?v=EYGNT0g_zD0";

        public static WebView web;


        public Widget1()
        {
            this.InitializeComponent();



        }

 



        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
         

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.googleapis.com/youtube/v3/videos" +
                "?id=PfKyQaPxbxA" +
                "&t=14s" +
                "&key=AIzaSyBN0lnNIT6E4F0DV46-D61MeIcm00YAXP8&part=liveStreamingDetails");

            var json = new WebClient().DownloadString("https://www.googleapis.com/youtube/v3/videos" +
                "?id=PfKyQaPxbxA" +
                "&t=14s" +
                "&key=AIzaSyBN0lnNIT6E4F0DV46-D61MeIcm00YAXP8&part=liveStreamingDetails");
            json = json.Replace("\n", "").Replace("\r", "");
            JObject jo = (JObject)JsonConvert.DeserializeObject(json);




        }
        public ObservableCollection<Messages> Mes { get; } = new ObservableCollection<Messages>();

       
   

  

        private void IMG_Tapped(object sender, TappedRoutedEventArgs e)
        {
      

           Mes.Insert(0,new Messages(
                   "кукdddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddу",
                   "rehfrf",
                   "https://yt3.ggpht.com/a/AATXAJx7w91fP4lUNBfqe3VdLCY42-_MFJX9kR5JwAr9IQ=s48-c-k-c0xffffffff-no-rj-mo"));


       

        
        }

     

  
    }
}
