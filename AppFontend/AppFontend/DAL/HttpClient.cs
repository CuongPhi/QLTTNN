using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using AppFontend.DTO;

namespace AppFontend.DAL
{
    /*
     * @ Http class for fetch data from backend API
     * @ using Generic Type <T>
     */
    public class HttpC<T>
    {
        private HttpClient client;
        public async Task<object> FetchDataAsync(string path)
        {
            if(!Helper.isValidURL(path))
            {
                return null; // return null if invalid url
            }
            List<T> model = null;
            var client = new HttpClient();
            var task = client.GetAsync(path)
              .ContinueWith((taskwithresponse) =>
              {
                  var response = taskwithresponse.Result;
                  var jsonString = response.Content.ReadAsStringAsync();
                  jsonString.Wait();
                  model = JsonConvert.DeserializeObject<List<T>>(jsonString.Result);
              });
            task.Wait(); // waiting for data
            return model;
        }
        public HttpC()
        {
            client = new HttpClient();
        }
    }
}
