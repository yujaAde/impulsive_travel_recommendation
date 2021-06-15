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
                 * KKM ���� ���
                 * ������ ��ǥ �߽����� ���� �ݰ� ���
                 * ����(����) 1���� 111KM, �浵(����) 91KM ��.
                 * ���� - �������� �뷫 108km�̹Ƿ� �̸� ������ ȯ���� ����,�浵 ������ 0.9¥�� ���� ���� �߽����� �ߴ´�
                 * �뷫 ���� ���� 80km���ʹ� ���عٴ��̹Ƿ� x ��ǥ ��꿡�� ����, ��ǥ ���� 0.1�� ������ �� �����.
                 */
                double target_x = 127.3845;
                double target_y = 36.3504; // ���� ��ǥ

                double radius_x = 0.9; // ���� ������
                double limit_x = 0.1; // x��ǥ ���Ѱ�

                double baeyool = 1000000.0;

                double a = rand.Next(Convert.ToInt32((target_x - radius_x + limit_x) * baeyool), Convert.ToInt32((target_x + radius_x) * baeyool)) / baeyool; //�ϴ� X��ǥ�� ���� ���

                double temp_x = a - target_x;
                double radius_y = Math.Sqrt(radius_x * radius_x - temp_x * temp_x); //y�� ������ ��ǥ ���

                double b = rand.Next(Convert.ToInt32((target_y - radius_y) * baeyool), Convert.ToInt32((target_y + radius_y) * baeyool)) / baeyool; //Y��ǥ�� ���

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