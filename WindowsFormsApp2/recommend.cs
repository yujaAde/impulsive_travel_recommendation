using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

namespace WindowsFormsApp2
{
    class recommend
    {
        public static c2r_docs rand_recommend() // 랜덤한 좌표를 중심으로 관광지 검색
        {
            Random rand = new Random();

            while (true)
            {
                double a = rand.Next(1259000000, 1300000000) / 10000000.0;
                //double a = rand.Next(1239000000, 1320000000) / 10000000.0;
                double b = rand.Next(340000000, 385000000) / 10000000.0;
                string x = a.ToString();
                string y = b.ToString();
                string query = "?x=" + x + "&y=" + y;

                var c2r_docs = webAPICall.coord2regionCode(query);
                if (c2r_docs.c2r[0].region_1depth_name != "")
                    return c2r_docs;
            }
        }
        
        public static void find_recommend()     // 관광지 추천
        {
            c2r_docs c2r_docs = recommend.rand_recommend();
            string query = "?category_group_code=AT4&x=" + c2r_docs.c2r[0].x + "&y=" + c2r_docs.c2r[0].y + "&radius=20000";
            ta_docs ta_docs = webAPICall.categorySearch(query);

            foreach (var i in ta_docs.touristAttractions)
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
