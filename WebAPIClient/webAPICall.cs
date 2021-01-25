using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Text.Json;

namespace WebAPIClient
{
    class webAPICall
    {
        private static readonly HttpClient client= new HttpClient();
        private static readonly string rkey = "9c7d94846184790b196d8d8eb088b867";
        private static readonly string header = "KakaoAK " + rkey;
        
        public static void webAPICall_init()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization", header);
        } 
        public static async Task<ta_docs> ProcessRepositories()
        {
            string uri = "https://dapi.kakao.com/v2/local/search/category.json";
            string url = uri + "?category_group_code=AT4&x=37.559029962862304&y=126.98816827267991&radius=20000";
            
            //var stringTask = client.GetStringAsync("https://api.github.com/orgs/dotnet/repos");
            //var stringTask = client.GetStringAsync(url);
            var streamTask = client.GetStreamAsync(url);
            
            
//            var touristAttractions = await JsonSerializer.DeserializeAsync<List<touristAttraction>>(await streamTask);
            var touristAttractions = await JsonSerializer.DeserializeAsync<ta_docs>(await streamTask);
            
            return touristAttractions;

            /*var msg = await stringTask;
            Console.Write(msg);*/
        }

        public static async Task<c2r_docs> coord2regionCode(string query)
        {
            string uri = "https://dapi.kakao.com/v2/local/geo/coord2regioncode.json";
            string url = uri + query;
            
            var streamTask = client.GetStreamAsync(url);
            
            var regions = await JsonSerializer.DeserializeAsync<c2r_docs>(await streamTask);
            
            return regions;
        }
    }
}