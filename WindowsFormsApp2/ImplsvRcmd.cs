using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

namespace WindowsFormsApp2
{
    public partial class ImplsvRcmd : Form
    {
        ta_docs ta_docs; //전역변수 사용함

        public ImplsvRcmd()
        {
            InitializeComponent();
        }

        private void BT_ImplsvRcmd_Exit_Click(object sender, EventArgs e) //종료버튼이 눌린경우
        {
            this.Close();
        }

        private void ListBoxUpdate(ta_docs ta_docs)
        {
            LB_ImplsvRcmd_Location.Items.Clear();//일단 데이터를 지워

            foreach (var i in ta_docs.touristAttractions) // 리스트 출력
            {
                string str_location2 = i.place_name; // 관광지 이름
                string str_Information = i.category_name; //분류

                string data = "이름: " + str_location2 + " 설명 : " + str_Information;
                LB_ImplsvRcmd_Location.Items.Add(data);
            }
        }

        private void BT_ImplsvRcmd_Rcmd_Click(object sender, EventArgs e) //추천버튼이 눌린 경우
        {
            c2r_docs c2r_docs = recommend.rand_recommend();

            string query = "?category_group_code=AT4&x=" + c2r_docs.c2r[0].x + "&y=" + c2r_docs.c2r[0].y + "&radius=20000";
            var x_value = c2r_docs.c2r[0].x;
            var y_value = c2r_docs.c2r[0].y;
            string first_string = "랜덤좌표 결과 - (" + x_value + ", " + y_value + ")";
            MessageBox.Show(first_string);
            ta_docs = webAPICall.categorySearch(query);

            ListBoxUpdate(ta_docs); // 리스트박스에 데이터를 업데이트한다


            //이 아래가 맵에 대한 코드가 들어갈 곳
            try
            {
                string url = "http://echerin.iptime.org/?x=" + x_value.ToString() + "&y=" + y_value.ToString();
                this.WB_ImplsvRcmd_Mapviewer.Navigate(url); //여기에 x,y 좌표에 대한 데이터로 지도를 띄워라
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LB_ImplsvRcmd_Location_SelectedIndexChanged(object sender, EventArgs e) // 관광지 리스트에서 아이템을 선택한 경우
        {
            int selected_index = LB_ImplsvRcmd_Location.SelectedIndex;

            string x_value = ta_docs.touristAttractions[selected_index].x;
            string y_value = ta_docs.touristAttractions[selected_index].y;
            string data = " 좌표 : (" + x_value + ". " + y_value + ")";

            //MessageBox.Show(data); // 이부분을 지도 출력하는 부분으로 고쳐라
            ExecScript("setCenter", x_value.ToString(), y_value.ToString());  // 선택한 관광지로 이동

        }

        private void BT_ImplsvRcmd_testbutton_Click(object sender, EventArgs e) //테스트 버튼.
        {
            //클래스 내의 전역변수 ta_docs를 통해 리스트의 데이터 갱신하도록 테스트 구현

            LB_ImplsvRcmd_Location.Items.Clear();//일단 데이터를 지워

            foreach (var i in ta_docs.touristAttractions)
            {
                string str_location = i.address_name; // 주소. ex) 대전시 중구 태평동
                string str_location2 = i.place_name; // 관광지 이름
                string double_xAxis = i.x;
                string double_yAxis = i.y;
                string str_Information = i.category_name; //분류

                string data = "주소 : " + str_location +" 이름: "+str_location2 + " 좌표 : (" + double_xAxis + ". " + double_yAxis + ") 설명 : " + str_Information;
                LB_ImplsvRcmd_Location.Items.Add(data);
            }   
        }

        private void BT_ImplsvRcmd_Filter_Click(object sender, EventArgs e) //필터 버튼
        {
            //구현
            marker_clear();
            markerScript("marker"); // 추천된 리스트의 마커를 표시함
        }

        // window form -> javascript
        private void ExecScript(string func_name, string x, string y)   // 좌표 이동 스크립트 호출
        {
            WB_ImplsvRcmd_Mapviewer.Document.InvokeScript(func_name, new object[] { x, y });
        }
        private void markerScript(string func_name)   // 마커 생성 스크립트 호출
        {
            foreach(var i in ta_docs.touristAttractions)
            {
                WB_ImplsvRcmd_Mapviewer.Document.InvokeScript(func_name, new object[] {i.x, i.y});
            }
            WB_ImplsvRcmd_Mapviewer.Document.InvokeScript("marker_on", new object[] {});
        }
        private void marker_clear()
        {
            WB_ImplsvRcmd_Mapviewer.Document.InvokeScript("marker_clear", new object[] { });
        }
    }
}

