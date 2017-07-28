using System;
using Newtonsoft.Json;

namespace human_recognition_app
{
    public class HumanRecognitionModel
    {
        [JsonProperty(PropertyName = "Id")]
        public string ID { get; set; }

        [JsonProperty(PropertyName = "PredictionValue")]
        public float PredictionValue { get; set; }
    }
}