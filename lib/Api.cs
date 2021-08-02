using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.Json.Serialization;
using System.Text.Json;
namespace gitprofile.API
{
    class Api
    {
        public static string GetApiData(String username)
        {
            string url_data = $"https://api.github.com/users/{username}";

            string json = new WebClient().DownloadString("https://api.coinmarketcap.com/v1/ticker/");

            List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
        }
    }
}
