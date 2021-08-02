using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gitprofile;

namespace gitprofile
{
    class GitProfile
    {
        public static void Main(string[] args)
        {
            string res = API.Api.GetApiData("TechPenguineer");
            Console.WriteLine(res);
        }
    }
}
