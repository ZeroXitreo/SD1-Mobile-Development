using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BookClient.Data
{
    public class BookManager
    {
        const string Url = "https://fast-castle-50377.herokuapp.com/";

        private string strAuthorizationKey;

        internal async Task<HttpClient> GetClient()
        {
            HttpClient client = new HttpClient();

            if (string.IsNullOrWhiteSpace(strAuthorizationKey))
            {
                Auth auth = new Auth()
                {
                    identifier = "student",
                    password = "Student1234"
                };
                string serialized = JsonConvert.SerializeObject(auth);
                HttpContent requestContent = new StringContent(serialized, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(Url + "auth/local", requestContent);
                string responseContent = await response.Content.ReadAsStringAsync();
                JObject result = JsonConvert.DeserializeObject<JObject>(responseContent);
                strAuthorizationKey = (string)result.First;
            }

            client.DefaultRequestHeaders.Add("Authorization", strAuthorizationKey);
            return client;
        }

        public List<Book> GetAllBooks()
        {
            return null;
        }

        public bool Add(Book book)
        {
            return false;
        }

        public bool Update(Book book)
        {
            return false;
        }

        public bool Delete(Book book)
        {
            return false;
        }
    }
}
