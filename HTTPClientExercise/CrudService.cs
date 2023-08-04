using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTPClientExercise
{
    public class CrudService
    {
        private static HttpClient MyhtttpClient = new HttpClient();

        public CrudService() 
        {
            MyhtttpClient.BaseAddress = new Uri("http://localhost:5045");
            MyhtttpClient.Timeout = new TimeSpan(0, 0, 30);
        }
        public async Task Run()
        {
            await GetResource();
        }
        public async Task GetResource()
        {
            var response = await MyhtttpClient.GetAsync("api/todoitems");
            response.EnsureSuccessStatusCode();
        }
    }
}
