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
            //await webAPICall.coord2regionCode();

            foreach(var i in c2r_docs.c2r)
            {
                Console.WriteLine(i.region_type);
                Console.WriteLine(i.address_name);
                Console.WriteLine(i.region_1depth_name);
                Console.WriteLine(i.region_2depth_name);
                Console.WriteLine(i.region_3depth_name);
                Console.WriteLine(i.region_4depth_name);
                Console.WriteLine(i.code);
                Console.WriteLine(i.x);
                Console.WriteLine(i.y);
                Console.WriteLine();
            }
        }
    }
}
