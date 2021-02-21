using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Text.Json;

namespace WindowsFormsApp2
{
    class recommend
    {
        public static c2r_docs rand_recommend()
        {
            Random rand = new Random();

            while(true)
            {
                double a = rand.Next(1259000000, 1300000000) / 10000000.0;
                double b = rand.Next(340000000, 385000000) / 10000000.0;
                string x = a.ToString();
                string y = b.ToString();
                string query = "?x=" + x + "&y=" + y;

                var c2r_docs = webAPICall.coord2regionCode(query);
                if(c2r_docs.c2r[0].region_1depth_name != "")
                    return c2r_docs;
            }
        }
    }
}