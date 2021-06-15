using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Text.Json;

namespace ImpsvRcmd
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

        public static c2r_docs rand_recommend_filter() {
            Random rand = new Random();

            while (true)
            {
                /*
                 * KKM 수정 요약
                 * 대전의 좌표 중심으로 원형 반경 계산
                 * 위도(남북) 1도당 111KM, 경도(동서) 91KM 임.
                 * 대전 - 수원까지 대략 108km이므로 이를 간단히 환산해 위도,경도 반지름 0.9짜리 원을 대전 중심으로 긋는다
                 * 대략 대전 서쪽 80km부터는 서해바다이므로 x 좌표 계산에서 제외, 좌표 계산시 0.1을 차감한 뒤 계산함.
                 */
                double target_x = 127.3845;
                double target_y = 36.3504; // 대전 좌표

                double radius_x = 0.9; // 원의 반지름
                double limit_x = 0.1; // x좌표 제한값

                double baeyool = 1000000.0;

                double a = rand.Next(Convert.ToInt32((target_x - radius_x + limit_x) * baeyool), Convert.ToInt32((target_x + radius_x) * baeyool)) / baeyool; //일단 X좌표를 먼저 계산

                double temp_x = a - target_x;
                double radius_y = Math.Sqrt(radius_x * radius_x - temp_x * temp_x); //y가 가능한 좌표 계산

                double b = rand.Next(Convert.ToInt32((target_y - radius_y) * baeyool), Convert.ToInt32((target_y + radius_y) * baeyool)) / baeyool; //Y좌표를 계산

                string x = a.ToString();
                string y = b.ToString();
                string query = "?x=" + x + "&y=" + y;

                var c2r_docs = webAPICall.coord2regionCode(query);
                if (c2r_docs.c2r[0].region_1depth_name != "")
                    return c2r_docs;
            }
        }
    }
}