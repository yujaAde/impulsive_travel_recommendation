using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Text.Json;

namespace WebAPIClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            webAPICall.webAPICall_init();
            var c2r_docs = await recommand.rand_recommand();
            string query = "?category_group_code=AT4&x=" + c2r_docs.c2r[0].x + "&y=" + c2r_docs.c2r[0].y + "&radius=20000";
            var ta_docs = await webAPICall.categorySearch(query);

            foreach(var i in ta_docs.touristAttractions)
            {
                Console.WriteLine(i.address_name);
                Console.WriteLine(i.place_name);
                Console.WriteLine(i.category_name);
                Console.WriteLine(i.x);
                Console.WriteLine(i.y);
                Console.WriteLine();
            }
        }
    }
}
