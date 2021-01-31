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
    public partial class Form1 : Form
    {
        public Form1() //메인폼(이름 깜빡하고 못고침)
        {
            InitializeComponent();
            this.Text = "impulsive_travel_recommendation"; //제목
            this.ClientSize = new Size(600, 600); //사이즈 (조절 필요)
        }

        private void BT_Main_ImplsvRcmd_Click(object sender, EventArgs e) //충동적 여행지 추천 버튼 누름.
        {
            Form f2 = new ImplsvRcmd();
            this.AddOwnedForm(f2);

            f2.Activate();
            f2.Show();
        }

        private void BT_Main_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

