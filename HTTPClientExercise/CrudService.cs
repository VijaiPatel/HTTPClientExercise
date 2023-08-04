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
            MyhtttpClient.BaseAddress = new Uri("http://localhost:5000");
        }
    }
}
