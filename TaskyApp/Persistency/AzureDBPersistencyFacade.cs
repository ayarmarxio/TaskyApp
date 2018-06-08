using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TaskyApp.Persistency
{
    public class AzureDbPersistencyFacade<T>
    {
        private const string _serverUrl = "https://taskywebservice20180605122335.azurewebsites.net";
        private HttpClientHandler _httpClientHandler = new HttpClientHandler() { UseDefaultCredentials = true };
        private HttpClient _httpClient;

        public AzureDbPersistencyFacade()
        {
            
        }
        //public async Task<ObservableCollection<T>> LoadFromAzure()
        //{
        //    using (_httpClient = new HttpClient(_httpClientHandler))
        //    {
        //        _httpClient.BaseAddress = new Uri(_serverUrl);
        //        _httpClient.DefaultRequestHeaders.Clear();
        //        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //        try
        //        {
        //            Task<HttpResponseMessage> response = _httpClient.GetAsync($"{_serverUrl}/{}/{}");
        //            if (response != null)
        //            {
        //                if (response.Result.IsSuccessStatusCode)
        //                {
        //                    var stringResultTask = await response.Result.Content.ReadAsStringAsync();
        //                    // var collection = JsonConvert.
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
