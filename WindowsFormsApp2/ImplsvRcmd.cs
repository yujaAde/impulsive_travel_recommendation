using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ImplsvRcmd : Form
    {
        public ImplsvRcmd()
        {
            InitializeComponent();
        }

        

        private void BT_ImplsvRcmd_Exit_Click(object sender, EventArgs e) //종료버튼이 눌린경우
        {
            this.Close();
        }

        private void BT_ImplsvRcmd_Rcmd_Click(object sender, EventArgs e) //추천버튼이 눌린 경우
        {
            
            try
            {
                MessageBox.Show("테스트용으로 일단 네이버 띄움");
                this.WB_ImplsvRcmd_Mapviewer.Navigate("https://www.naver.com");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void LB_ImplsvRcmd_Location_SelectedIndexChanged(object sender, EventArgs e) // 관광지 리스트에서 아이템을 선택한 경우
        {
            MessageBox.Show(LB_ImplsvRcmd_Location.SelectedItem.ToString());
        }

        private void BT_ImplsvRcmd_testbutton_Click(object sender, EventArgs e) //테스트 버튼. 일단 누르면 리스트박스에 내용추가
        {
            string str_location = "서대전역";
            double double_xAxis = 32.22;
            double double_yAxis = 34.22;
            string str_Information = "주변에 아무것도 없음";

            string data = "장소 : " + str_location + " 좌표 : (" + double_xAxis + ". " + double_yAxis + ") 설명 : " + str_Information;
            LB_ImplsvRcmd_Location.Items.Clear();//일단 데이터를 지워
            LB_ImplsvRcmd_Location.Items.Add(data);

            str_location = "우리집";
            double_xAxis = 32.25;
            double_yAxis = 34.22;
            str_Information = "경모 거주중";

            data = "장소 : " + str_location + " 좌표 : (" + double_xAxis + ". " + double_yAxis + ") 설명 : " + str_Information;
            LB_ImplsvRcmd_Location.Items.Add(data);
        }

        private void BT_ImplsvRcmd_Filter_Click(object sender, EventArgs e)
        {
            recommend.find_recommend();
        }
    }
}
