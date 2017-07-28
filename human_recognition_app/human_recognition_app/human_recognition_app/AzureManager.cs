using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace human_recognition_app
{
    public class AzureManager
    {

        private static AzureManager instance;
        private MobileServiceClient client;
        private IMobileServiceTable<HumanRecognitionModel> HumanRecognitionTable;

        private AzureManager()
        {
            this.client = new MobileServiceClient("http://humanrecognition.azurewebsites.net");
            this.HumanRecognitionTable = this.client.GetTable<HumanRecognitionModel>();
        }

        public MobileServiceClient AzureClient
        {
            get { return client; }
        }

        public static AzureManager AzureManagerInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AzureManager();
                }

                return instance;
            }
        }

        public async Task<List<HumanRecognitionModel>> GetHumanRecognitionInformation()
        {
            return await this.HumanRecognitionTable.ToListAsync();
        }

        public async Task PostHumanRecognitionInformation(HumanRecognitionModel HumanRecognitionModel)
        {
            await this.HumanRecognitionTable.InsertAsync(HumanRecognitionModel);
        }
    }
}