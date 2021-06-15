namespace ImpsvRcmd
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.BT_Main_ImplsvRcmd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BT_Main_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PN_main_BT = new System.Windows.Forms.Panel();
            this.PN_main_BT.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_Main_ImplsvRcmd
            // 
            this.BT_Main_ImplsvRcmd.Location = new System.Drawing.Point(53, 45);
            this.BT_Main_ImplsvRcmd.Name = "BT_Main_ImplsvRcmd";
            this.BT_Main_ImplsvRcmd.Size = new System.Drawing.Size(120, 40);
            this.BT_Main_ImplsvRcmd.TabIndex = 0;
            this.BT_Main_ImplsvRcmd.Text = "충동적 여행지 추천";
            this.BT_Main_ImplsvRcmd.UseVisualStyleBackColor = true;
            this.BT_Main_ImplsvRcmd.Click += new System.EventHandler(this.BT_Main_ImplsvRcmd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "여행지 검색 (미구현)";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BT_Main_close
            // 
            this.BT_Main_close.Location = new System.Drawing.Point(391, 266);
            this.BT_Main_close.Name = "BT_Main_close";
            this.BT_Main_close.Size = new System.Drawing.Size(120, 40);
            this.BT_Main_close.TabIndex = 2;
            this.BT_Main_close.Text = "종료";
            this.BT_Main_close.UseVisualStyleBackColor = true;
            this.BT_Main_close.Click += new System.EventHandler(this.BT_Main_close_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 163);
            this.label1.TabIndex = 3;
            this.label1.Text = "충동적 여행지 추천 프로그램입니다.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PN_main_BT
            // 
            this.PN_main_BT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_main_BT.Controls.Add(this.BT_Main_ImplsvRcmd);
            this.PN_main_BT.Controls.Add(this.button2);
            this.PN_main_BT.Controls.Add(this.BT_Main_close);
            this.PN_main_BT.Location = new System.Drawing.Point(12, 175);
            this.PN_main_BT.Name = "PN_main_BT";
            this.PN_main_BT.Size = new System.Drawing.Size(560, 374);
            this.PN_main_BT.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.PN_main_BT);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PN_main_BT.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_Main_ImplsvRcmd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BT_Main_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PN_main_BT;
    }
}

