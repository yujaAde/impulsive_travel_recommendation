namespace WindowsFormsApp2
{
    partial class ImplsvRcmd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_ImplsvRcmd_Location = new System.Windows.Forms.ListBox();
            this.BT_ImplsvRcmd_Rcmd = new System.Windows.Forms.Button();
            this.BT_ImplsvRcmd_Filter = new System.Windows.Forms.Button();
            this.BT_ImplsvRcmd_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_ImplsvRcmd_testbutton = new System.Windows.Forms.Button();
            this.WB_ImplsvRcmd_Mapviewer = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_ImplsvRcmd_Location
            // 
            this.LB_ImplsvRcmd_Location.FormattingEnabled = true;
            this.LB_ImplsvRcmd_Location.HorizontalScrollbar = true;
            this.LB_ImplsvRcmd_Location.ItemHeight = 12;
            this.LB_ImplsvRcmd_Location.Location = new System.Drawing.Point(800, 341);
            this.LB_ImplsvRcmd_Location.Name = "LB_ImplsvRcmd_Location";
            this.LB_ImplsvRcmd_Location.Size = new System.Drawing.Size(472, 508);
            this.LB_ImplsvRcmd_Location.TabIndex = 1;
            this.LB_ImplsvRcmd_Location.SelectedIndexChanged += new System.EventHandler(this.LB_ImplsvRcmd_Location_SelectedIndexChanged);
            // 
            // BT_ImplsvRcmd_Rcmd
            // 
            this.BT_ImplsvRcmd_Rcmd.Location = new System.Drawing.Point(3, 17);
            this.BT_ImplsvRcmd_Rcmd.Name = "BT_ImplsvRcmd_Rcmd";
            this.BT_ImplsvRcmd_Rcmd.Size = new System.Drawing.Size(125, 40);
            this.BT_ImplsvRcmd_Rcmd.TabIndex = 2;
            this.BT_ImplsvRcmd_Rcmd.Text = "여행지 추천";
            this.BT_ImplsvRcmd_Rcmd.UseVisualStyleBackColor = true;
            this.BT_ImplsvRcmd_Rcmd.Click += new System.EventHandler(this.BT_ImplsvRcmd_Rcmd_Click);
            // 
            // BT_ImplsvRcmd_Filter
            // 
            this.BT_ImplsvRcmd_Filter.Location = new System.Drawing.Point(3, 78);
            this.BT_ImplsvRcmd_Filter.Name = "BT_ImplsvRcmd_Filter";
            this.BT_ImplsvRcmd_Filter.Size = new System.Drawing.Size(125, 40);
            this.BT_ImplsvRcmd_Filter.TabIndex = 3;
            this.BT_ImplsvRcmd_Filter.Text = "여행지 필터링 (미구현)";
            this.BT_ImplsvRcmd_Filter.UseVisualStyleBackColor = true;
            this.BT_ImplsvRcmd_Filter.Click += new System.EventHandler(this.BT_ImplsvRcmd_Filter_Click);
            // 
            // BT_ImplsvRcmd_Exit
            // 
            this.BT_ImplsvRcmd_Exit.Location = new System.Drawing.Point(161, 78);
            this.BT_ImplsvRcmd_Exit.Name = "BT_ImplsvRcmd_Exit";
            this.BT_ImplsvRcmd_Exit.Size = new System.Drawing.Size(125, 40);
            this.BT_ImplsvRcmd_Exit.TabIndex = 4;
            this.BT_ImplsvRcmd_Exit.Text = "종료";
            this.BT_ImplsvRcmd_Exit.UseVisualStyleBackColor = true;
            this.BT_ImplsvRcmd_Exit.Click += new System.EventHandler(this.BT_ImplsvRcmd_Exit_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1260, 179);
            this.label1.TabIndex = 5;
            this.label1.Text = "여행지 추천 버튼을 눌러주세요";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BT_ImplsvRcmd_testbutton);
            this.panel1.Controls.Add(this.BT_ImplsvRcmd_Rcmd);
            this.panel1.Controls.Add(this.BT_ImplsvRcmd_Exit);
            this.panel1.Controls.Add(this.BT_ImplsvRcmd_Filter);
            this.panel1.Location = new System.Drawing.Point(800, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 133);
            this.panel1.TabIndex = 6;
            // 
            // BT_ImplsvRcmd_testbutton
            // 
            this.BT_ImplsvRcmd_testbutton.Location = new System.Drawing.Point(161, 17);
            this.BT_ImplsvRcmd_testbutton.Name = "BT_ImplsvRcmd_testbutton";
            this.BT_ImplsvRcmd_testbutton.Size = new System.Drawing.Size(123, 40);
            this.BT_ImplsvRcmd_testbutton.TabIndex = 5;
            this.BT_ImplsvRcmd_testbutton.Text = "TestButton";
            this.BT_ImplsvRcmd_testbutton.UseVisualStyleBackColor = true;
            this.BT_ImplsvRcmd_testbutton.Click += new System.EventHandler(this.BT_ImplsvRcmd_testbutton_Click);
            // 
            // WB_ImplsvRcmd_Mapviewer
            // 
            this.WB_ImplsvRcmd_Mapviewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WB_ImplsvRcmd_Mapviewer.Location = new System.Drawing.Point(12, 202);
            this.WB_ImplsvRcmd_Mapviewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.WB_ImplsvRcmd_Mapviewer.Name = "WB_ImplsvRcmd_Mapviewer";
            this.WB_ImplsvRcmd_Mapviewer.ScrollBarsEnabled = false;
            this.WB_ImplsvRcmd_Mapviewer.Size = new System.Drawing.Size(700, 700);
            this.WB_ImplsvRcmd_Mapviewer.TabIndex = 7;
            this.WB_ImplsvRcmd_Mapviewer.TabStop = false;
            this.WB_ImplsvRcmd_Mapviewer.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // ImplsvRcmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 861);
            this.Controls.Add(this.WB_ImplsvRcmd_Mapviewer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_ImplsvRcmd_Location);
            this.Controls.Add(this.panel1);
            this.Name = "ImplsvRcmd";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox LB_ImplsvRcmd_Location;
        private System.Windows.Forms.Button BT_ImplsvRcmd_Rcmd;
        private System.Windows.Forms.Button BT_ImplsvRcmd_Filter;
        private System.Windows.Forms.Button BT_ImplsvRcmd_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser WB_ImplsvRcmd_Mapviewer;
        private System.Windows.Forms.Button BT_ImplsvRcmd_testbutton;
    }
}