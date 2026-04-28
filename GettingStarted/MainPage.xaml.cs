using Syncfusion.UI.Xaml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GettingStarted
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            OpenWorkbook();
        }

        async void OpenWorkbook()
        {
            Stream fileStream = typeof(MainPage).GetTypeInfo().Assembly.GetManifestResourceStream("GettingStarted.Assets.GettingStarted.xlsx");
            this.spreadsheet.Open(fileStream);
            //var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            //string resourcePath = "GettingStarted.Assets.GettingStarted.xlsx";
            //using (var fileStream = assembly.GetManifestResourceStream(resourcePath))
            //{
            //    await this.spreadsheet.Open(fileStream);
            //}
        }
    }
}
