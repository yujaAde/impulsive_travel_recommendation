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
        static void Main(string[] args)
        {
            c2r_docs c2r_docs = recommend.rand_recommend();
            string query = "?category_group_code=AT4&x=" + c2r_docs.c2r[0].x + "&y=" + c2r_docs.c2r[0].y + "&radius=20000";
            ta_docs ta_docs = webAPICall.categorySearch(query);

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
