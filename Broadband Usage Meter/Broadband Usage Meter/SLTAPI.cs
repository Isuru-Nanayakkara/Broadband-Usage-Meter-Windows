using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Net.Http;

namespace Broadband_Usage_Meter
{
    class SLTAPI
    {
        private HttpClient client;
        private string baseURL = "https://www.internetvas.slt.lk/SLTVasPortal-war/";

        public SLTAPI()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(baseURL);
        }

        public async Task login(string userID, string password)
        {
            var parameters = new Dictionary<string, string>
                {
                    { "j_username", userID },
                    { "j_password", password }
                };

            var encodedParameters = new FormUrlEncodedContent(parameters);
            var response = await client.PostAsync("login/j_security_check/j_security_check", encodedParameters);
            response.EnsureSuccessStatusCode();
            string responseString = await response.Content.ReadAsStringAsync();
            //Console.WriteLine(responseString);
        }

        public async Task<Usage> fetchUsage()
        {
            var response = await client.GetAsync("application/GetProfile");
            response.EnsureSuccessStatusCode();
            Stream responseStream = await response.Content.ReadAsStreamAsync();
            responseStream.Position = 0;

            //MemoryStream stream = new MemoryStream();
            //stream.Position = 0;

            StreamReader reader = new StreamReader(responseStream);
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Usage));
            Usage usage = (Usage)serializer.ReadObject(responseStream);
            return usage;
        }
    }
}
