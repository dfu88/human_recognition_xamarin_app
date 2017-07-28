using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace human_recognition_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AzureTable : ContentPage
    {
        public AzureTable()
        {
            InitializeComponent();
        }

        async void ClickedAsync(object sender, System.EventArgs e)
        {
            List<HumanRecognitionModel> HumanRecognitionInformation = await AzureManager.AzureManagerInstance.GetHumanRecognitionInformation();

            HumanRecognitionList.ItemsSource = HumanRecognitionInformation;
        }
    }
} 