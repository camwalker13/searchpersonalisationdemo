using System.Text.Json.Serialization;

namespace SearchPersoConsoleApp
{
    public class DecisionResult
    {
        [JsonPropertyName("searchModel")]
        public string SearchModel { get; set; }
    }

//    {  
//      "decisionOutput": "search_model",
//      "searchModel": "${DecTable.outputs[0].search_model}"
//    }
}
