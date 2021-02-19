using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.IO;

namespace WindowsFormsApp2
{
    class webAPICall
    {
        private static readonly string rkey = "9c7d94846184790b196d8d8eb088b867";
        private static readonly string header = "KakaoAK " + rkey;

        public static ta_docs categorySearch(string query)      // 특정 범위에서 지정된 카테고리(관광지)에 대한 정보 반환 
        {
            string uri = "https://dapi.kakao.com/v2/local/search/category.json";
            string url = uri + query;
            WebRequest request = WebRequest.Create(url);
            request.Headers.Add("Authorization", header);

            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            String json = reader.ReadToEnd();
            stream.Close();

            ta_docs tas = JsonSerializer.Deserialize<ta_docs>(json);

            return tas;
        }

        public static c2r_docs coord2regionCode(string query)   // 좌표를 입력하여 그 좌표의 행정구역을 반환.
        {
            string uri = "https://dapi.kakao.com/v2/local/geo/coord2regioncode.json";
            string url = uri + query;
            WebRequest request = WebRequest.Create(url);
            request.Headers.Add("Authorization", header);

            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            String json = reader.ReadToEnd();
            stream.Close();

            c2r_docs regions = JsonSerializer.Deserialize<c2r_docs>(json);

            return regions;
        }
    }
}
