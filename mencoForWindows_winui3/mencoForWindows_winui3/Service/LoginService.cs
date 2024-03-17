using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using mencoForWindows_winui3.Models;

namespace mencoForWindows_winui3.Service
{
    internal class LoginService
    {
        private HttpClient _httpClient;

        public LoginService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public LoginService()
        {
            this._httpClient = new HttpClient();
        }

        
    }
}
