using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.IO;
using HtmlAgilityPack;
using System.Net.Http;
using System.Net.Http.Headers;

namespace gitprofile.API
{
    class Api
    {
        public async Task GetApiData(String username)
        {
            string url_data = $"https://api.github.com/users/TechPenguineer";

            HttpClient web = new HttpClient();
            var res = await web.GetStringAsync(url_data);

            ParseHtml(res);
            Console.WriteLine(res);
        }

        public void ParseHtml(string HtmlData)
        {
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(HtmlData);

            var table = htmlDocument.DocumentNode.Descendants("tbody");

            foreach(var row in table.ToList()[0].ChildNodes)
            {
                foreach(var column in row.ChildNodes)
                {
                    _ = column.ChildNodes.Count;
                }
            }

        }
    }
}
