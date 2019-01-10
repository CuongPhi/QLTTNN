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
    public class HttpC<T>
    {
        private HttpClient client = new HttpClient();
        public async Task<object> GetCourseAsync(string path)
        {
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
            task.Wait();
            return model;
        }
        public HttpC() {}
    }
}
