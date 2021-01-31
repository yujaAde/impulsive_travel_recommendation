using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Text.Json;
using System.Net;
using System.IO;
using System.Text;


namespace WebAPIClient
{
    class webAPICall
    {
        private static readonly string rkey = "key";
        private static readonly string header = "KakaoAK " + rkey;
        
        public static ta_docs categorySearch(string query)
        {
            string uri = "https://dapi.kakao.com/v2/local/search/category.json";
            string url = uri + query;
            WebRequest request = WebRequest.Create(url);
            request.Headers.Add("Authorization", header);

            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            String json= reader.ReadToEnd();
            stream.Close();

            ta_docs tas = JsonSerializer.Deserialize<ta_docs>(json);

            return tas;
        }
        
        public static c2r_docs coord2regionCode(string query)
        {
            string uri = "https://dapi.kakao.com/v2/local/geo/coord2regioncode.json";
            string url = uri + query;
            WebRequest request = WebRequest.Create(url);
            request.Headers.Add("Authorization", header);

            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            String json= reader.ReadToEnd();
            stream.Close();

            c2r_docs regions = JsonSerializer.Deserialize<c2r_docs>(json);
            
            return regions;
        }
    }
}