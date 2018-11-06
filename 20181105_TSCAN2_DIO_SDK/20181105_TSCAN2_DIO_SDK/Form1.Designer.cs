namespace _20181105_TSCAN2_DIO_SDK
{
    partial class frmMain
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
            this.btnGetSDKErrorString = new System.Windows.Forms.Button();
            this.btnSetLogFilePath = new System.Windows.Forms.Button();
            this.btnSetBodyNum = new System.Windows.Forms.Button();
            this.btnDIOInfo = new System.Windows.Forms.Button();
            this.btnIsClientConnected = new System.Windows.Forms.Button();
            this.lblDIOName = new System.Windows.Forms.Label();
            this.txtObjectIp4 = new System.Windows.Forms.TextBox();
            this.txtObjectIp3 = new System.Windows.Forms.TextBox();
            this.txtObjectIp2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtObjectIp1 = new System.Windows.Forms.TextBox();
            this.txtObjectName = new System.Windows.Forms.TextBox();
            this.lblInput8 = new System.Windows.Forms.Label();
            this.lblInput7 = new System.Windows.Forms.Label();
            this.lblInput6 = new System.Windows.Forms.Label();
            this.lblInput5 = new System.Windows.Forms.Label();
            this.lblInput4 = new System.Windows.Forms.Label();
            this.lblInput3 = new System.Windows.Forms.Label();
            this.lblInput2 = new System.Windows.Forms.Label();
            this.lblInput1 = new System.Windows.Forms.Label();
            this.btnOut8 = new System.Windows.Forms.Button();
            this.btnOut7 = new System.Windows.Forms.Button();
            this.btnOut6 = new System.Windows.Forms.Button();
            this.btnOut5 = new System.Windows.Forms.Button();
            this.btnOut4 = new System.Windows.Forms.Button();
            this.btnOut3 = new System.Windows.Forms.Button();
            this.btnOut2 = new System.Windows.Forms.Button();
            this.btnOut1 = new System.Windows.Forms.Button();
            this.BtnReleaseDIO = new System.Windows.Forms.Button();
            this.BtnCreateDIO = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ListViewResult = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ListViewSetting = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnGetSDKErrorString
            // 
            this.btnGetSDKErrorString.Location = new System.Drawing.Point(611, 80);
            this.btnGetSDKErrorString.Name = "btnGetSDKErrorString";
            this.btnGetSDKErrorString.Size = new System.Drawing.Size(89, 29);
            this.btnGetSDKErrorString.TabIndex = 109;
            this.btnGetSDKErrorString.Text = "에러확인";
            this.btnGetSDKErrorString.UseVisualStyleBackColor = true;
            // 
            // btnSetLogFilePath
            // 
            this.btnSetLogFilePath.Location = new System.Drawing.Point(611, 44);
            this.btnSetLogFilePath.Name = "btnSetLogFilePath";
            this.btnSetLogFilePath.Size = new System.Drawing.Size(89, 29);
            this.btnSetLogFilePath.TabIndex = 108;
            this.btnSetLogFilePath.Text = "SetLogPath";
            this.btnSetLogFilePath.UseVisualStyleBackColor = true;
            // 
            // btnSetBodyNum
            // 
            this.btnSetBodyNum.Location = new System.Drawing.Point(611, 9);
            this.btnSetBodyNum.Name = "btnSetBodyNum";
            this.btnSetBodyNum.Size = new System.Drawing.Size(89, 29);
            this.btnSetBodyNum.TabIndex = 107;
            this.btnSetBodyNum.Text = "SetBodyNum";
            this.btnSetBodyNum.UseVisualStyleBackColor = true;
            // 
            // btnDIOInfo
            // 
            this.btnDIOInfo.Location = new System.Drawing.Point(525, 113);
            this.btnDIOInfo.Name = "btnDIOInfo";
            this.btnDIOInfo.Size = new System.Drawing.Size(80, 29);
            this.btnDIOInfo.TabIndex = 106;
            this.btnDIOInfo.Text = "DIO Info";
            this.btnDIOInfo.UseVisualStyleBackColor = true;
            // 
            // btnIsClientConnected
            // 
            this.btnIsClientConnected.Location = new System.Drawing.Point(525, 79);
            this.btnIsClientConnected.Name = "btnIsClientConnected";
            this.btnIsClientConnected.Size = new System.Drawing.Size(80, 29);
            this.btnIsClientConnected.TabIndex = 105;
            this.btnIsClientConnected.Text = "IsConnect";
            this.btnIsClientConnected.UseVisualStyleBackColor = true;
            // 
            // lblDIOName
            // 
            this.lblDIOName.AutoSize = true;
            this.lblDIOName.Location = new System.Drawing.Point(300, 12);
            this.lblDIOName.Name = "lblDIOName";
            this.lblDIOName.Size = new System.Drawing.Size(63, 12);
            this.lblDIOName.TabIndex = 104;
            this.lblDIOName.Text = "DIO Name";
            // 
            // txtObjectIp4
            // 
            this.txtObjectIp4.Location = new System.Drawing.Point(486, 34);
            this.txtObjectIp4.Name = "txtObjectIp4";
            this.txtObjectIp4.Size = new System.Drawing.Size(33, 21);
            this.txtObjectIp4.TabIndex = 103;
            this.txtObjectIp4.Text = "115";
            this.txtObjectIp4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtObjectIp3
            // 
            this.txtObjectIp3.Location = new System.Drawing.Point(447, 34);
            this.txtObjectIp3.Name = "txtObjectIp3";
            this.txtObjectIp3.Size = new System.Drawing.Size(33, 21);
            this.txtObjectIp3.TabIndex = 102;
            this.txtObjectIp3.Text = "133";
            this.txtObjectIp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtObjectIp2
            // 
            this.txtObjectIp2.Location = new System.Drawing.Point(409, 34);
            this.txtObjectIp2.Name = "txtObjectIp2";
            this.txtObjectIp2.Size = new System.Drawing.Size(33, 21);
            this.txtObjectIp2.TabIndex = 101;
            this.txtObjectIp2.Text = "168";
            this.txtObjectIp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(370, 59);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 21);
            this.textBox3.TabIndex = 100;
            // 
            // txtObjectIp1
            // 
            this.txtObjectIp1.Location = new System.Drawing.Point(370, 34);
            this.txtObjectIp1.Name = "txtObjectIp1";
            this.txtObjectIp1.Size = new System.Drawing.Size(33, 21);
            this.txtObjectIp1.TabIndex = 99;
            this.txtObjectIp1.Text = "192";
            this.txtObjectIp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtObjectName
            // 
            this.txtObjectName.Location = new System.Drawing.Point(370, 9);
            this.txtObjectName.Name = "txtObjectName";
            this.txtObjectName.Size = new System.Drawing.Size(149, 21);
            this.txtObjectName.TabIndex = 98;
            // 
            // lblInput8
            // 
            this.lblInput8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblInput8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInput8.ForeColor = System.Drawing.Color.Black;
            this.lblInput8.Location = new System.Drawing.Point(265, 154);
            this.lblInput8.Name = "lblInput8";
            this.lblInput8.Size = new System.Drawing.Size(29, 29);
            this.lblInput8.TabIndex = 97;
            this.lblInput8.Text = "8";
            this.lblInput8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInput7
            // 
            this.lblInput7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblInput7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInput7.ForeColor = System.Drawing.Color.Black;
            this.lblInput7.Location = new System.Drawing.Point(228, 154);
            this.lblInput7.Name = "lblInput7";
            this.lblInput7.Size = new System.Drawing.Size(29, 29);
            this.lblInput7.TabIndex = 96;
            this.lblInput7.Text = "7";
            this.lblInput7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInput6
            // 
            this.lblInput6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblInput6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInput6.ForeColor = System.Drawing.Color.Black;
            this.lblInput6.Location = new System.Drawing.Point(192, 154);
            this.lblInput6.Name = "lblInput6";
            this.lblInput6.Size = new System.Drawing.Size(29, 29);
            this.lblInput6.TabIndex = 95;
            this.lblInput6.Text = "6";
            this.lblInput6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInput5
            // 
            this.lblInput5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblInput5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInput5.ForeColor = System.Drawing.Color.Black;
            this.lblInput5.Location = new System.Drawing.Point(156, 154);
            this.lblInput5.Name = "lblInput5";
            this.lblInput5.Size = new System.Drawing.Size(29, 29);
            this.lblInput5.TabIndex = 94;
            this.lblInput5.Text = "5";
            this.lblInput5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInput4
            // 
            this.lblInput4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblInput4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInput4.ForeColor = System.Drawing.Color.Black;
            this.lblInput4.Location = new System.Drawing.Point(121, 154);
            this.lblInput4.Name = "lblInput4";
            this.lblInput4.Size = new System.Drawing.Size(29, 29);
            this.lblInput4.TabIndex = 93;
            this.lblInput4.Text = "4";
            this.lblInput4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInput3
            // 
            this.lblInput3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblInput3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInput3.ForeColor = System.Drawing.Color.Black;
            this.lblInput3.Location = new System.Drawing.Point(84, 154);
            this.lblInput3.Name = "lblInput3";
            this.lblInput3.Size = new System.Drawing.Size(29, 29);
            this.lblInput3.TabIndex = 92;
            this.lblInput3.Text = "3";
            this.lblInput3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInput2
            // 
            this.lblInput2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblInput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInput2.ForeColor = System.Drawing.Color.Black;
            this.lblInput2.Location = new System.Drawing.Point(48, 154);
            this.lblInput2.Name = "lblInput2";
            this.lblInput2.Size = new System.Drawing.Size(29, 29);
            this.lblInput2.TabIndex = 91;
            this.lblInput2.Text = "2";
            this.lblInput2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInput1
            // 
            this.lblInput1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInput1.ForeColor = System.Drawing.Color.Black;
            this.lblInput1.Location = new System.Drawing.Point(12, 154);
            this.lblInput1.Name = "lblInput1";
            this.lblInput1.Size = new System.Drawing.Size(29, 29);
            this.lblInput1.TabIndex = 90;
            this.lblInput1.Text = "1";
            this.lblInput1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOut8
            // 
            this.btnOut8.Location = new System.Drawing.Point(575, 153);
            this.btnOut8.Name = "btnOut8";
            this.btnOut8.Size = new System.Drawing.Size(30, 30);
            this.btnOut8.TabIndex = 89;
            this.btnOut8.Text = "8";
            this.btnOut8.UseVisualStyleBackColor = true;
            // 
            // btnOut7
            // 
            this.btnOut7.Location = new System.Drawing.Point(539, 153);
            this.btnOut7.Name = "btnOut7";
            this.btnOut7.Size = new System.Drawing.Size(30, 30);
            this.btnOut7.TabIndex = 88;
            this.btnOut7.Text = "7";
            this.btnOut7.UseVisualStyleBackColor = true;
            // 
            // btnOut6
            // 
            this.btnOut6.Location = new System.Drawing.Point(503, 153);
            this.btnOut6.Name = "btnOut6";
            this.btnOut6.Size = new System.Drawing.Size(30, 30);
            this.btnOut6.TabIndex = 87;
            this.btnOut6.Text = "6";
            this.btnOut6.UseVisualStyleBackColor = true;
            // 
            // btnOut5
            // 
            this.btnOut5.Location = new System.Drawing.Point(467, 153);
            this.btnOut5.Name = "btnOut5";
            this.btnOut5.Size = new System.Drawing.Size(30, 30);
            this.btnOut5.TabIndex = 86;
            this.btnOut5.Text = "5";
            this.btnOut5.UseVisualStyleBackColor = true;
            // 
            // btnOut4
            // 
            this.btnOut4.Location = new System.Drawing.Point(431, 153);
            this.btnOut4.Name = "btnOut4";
            this.btnOut4.Size = new System.Drawing.Size(30, 30);
            this.btnOut4.TabIndex = 85;
            this.btnOut4.Text = "4";
            this.btnOut4.UseVisualStyleBackColor = true;
            // 
            // btnOut3
            // 
            this.btnOut3.Location = new System.Drawing.Point(395, 153);
            this.btnOut3.Name = "btnOut3";
            this.btnOut3.Size = new System.Drawing.Size(30, 30);
            this.btnOut3.TabIndex = 84;
            this.btnOut3.Text = "3";
            this.btnOut3.UseVisualStyleBackColor = true;
            // 
            // btnOut2
            // 
            this.btnOut2.Location = new System.Drawing.Point(359, 153);
            this.btnOut2.Name = "btnOut2";
            this.btnOut2.Size = new System.Drawing.Size(30, 30);
            this.btnOut2.TabIndex = 83;
            this.btnOut2.Text = "2";
            this.btnOut2.UseVisualStyleBackColor = true;
            // 
            // btnOut1
            // 
            this.btnOut1.Location = new System.Drawing.Point(323, 153);
            this.btnOut1.Name = "btnOut1";
            this.btnOut1.Size = new System.Drawing.Size(30, 30);
            this.btnOut1.TabIndex = 82;
            this.btnOut1.Text = "1";
            this.btnOut1.UseVisualStyleBackColor = true;
            // 
            // BtnReleaseDIO
            // 
            this.BtnReleaseDIO.Location = new System.Drawing.Point(525, 44);
            this.BtnReleaseDIO.Name = "BtnReleaseDIO";
            this.BtnReleaseDIO.Size = new System.Drawing.Size(80, 29);
            this.BtnReleaseDIO.TabIndex = 81;
            this.BtnReleaseDIO.Text = "ReleaseDIO";
            this.BtnReleaseDIO.UseVisualStyleBackColor = true;
            // 
            // BtnCreateDIO
            // 
            this.BtnCreateDIO.Location = new System.Drawing.Point(525, 9);
            this.BtnCreateDIO.Name = "BtnCreateDIO";
            this.BtnCreateDIO.Size = new System.Drawing.Size(80, 29);
            this.BtnCreateDIO.TabIndex = 80;
            this.BtnCreateDIO.Text = "CreateDIO";
            this.BtnCreateDIO.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 79;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ListViewResult
            // 
            this.ListViewResult.Location = new System.Drawing.Point(12, 192);
            this.ListViewResult.Name = "ListViewResult";
            this.ListViewResult.Size = new System.Drawing.Size(593, 239);
            this.ListViewResult.TabIndex = 78;
            this.ListViewResult.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 77;
            this.label3.Text = "저장경로";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 76;
            this.label2.Text = "로그파일명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 75;
            this.label1.Text = "IP";
            // 
            // ListViewSetting
            // 
            this.ListViewSetting.Location = new System.Drawing.Point(12, 12);
            this.ListViewSetting.Name = "ListViewSetting";
            this.ListViewSetting.Size = new System.Drawing.Size(282, 130);
            this.ListViewSetting.TabIndex = 74;
            this.ListViewSetting.UseCompatibleStateImageBehavior = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 439);
            this.Controls.Add(this.btnGetSDKErrorString);
            this.Controls.Add(this.btnSetLogFilePath);
            this.Controls.Add(this.btnSetBodyNum);
            this.Controls.Add(this.btnDIOInfo);
            this.Controls.Add(this.btnIsClientConnected);
            this.Controls.Add(this.lblDIOName);
            this.Controls.Add(this.txtObjectIp4);
            this.Controls.Add(this.txtObjectIp3);
            this.Controls.Add(this.txtObjectIp2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtObjectIp1);
            this.Controls.Add(this.txtObjectName);
            this.Controls.Add(this.lblInput8);
            this.Controls.Add(this.lblInput7);
            this.Controls.Add(this.lblInput6);
            this.Controls.Add(this.lblInput5);
            this.Controls.Add(this.lblInput4);
            this.Controls.Add(this.lblInput3);
            this.Controls.Add(this.lblInput2);
            this.Controls.Add(this.lblInput1);
            this.Controls.Add(this.btnOut8);
            this.Controls.Add(this.btnOut7);
            this.Controls.Add(this.btnOut6);
            this.Controls.Add(this.btnOut5);
            this.Controls.Add(this.btnOut4);
            this.Controls.Add(this.btnOut3);
            this.Controls.Add(this.btnOut2);
            this.Controls.Add(this.btnOut1);
            this.Controls.Add(this.BtnReleaseDIO);
            this.Controls.Add(this.BtnCreateDIO);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListViewResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListViewSetting);
            this.Name = "frmMain";
            this.Text = "TSCAN2_DIO_TEST_C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetSDKErrorString;
        private System.Windows.Forms.Button btnSetLogFilePath;
        private System.Windows.Forms.Button btnSetBodyNum;
        private System.Windows.Forms.Button btnDIOInfo;
        private System.Windows.Forms.Button btnIsClientConnected;
        private System.Windows.Forms.Label lblDIOName;
        private System.Windows.Forms.TextBox txtObjectIp4;
        private System.Windows.Forms.TextBox txtObjectIp3;
        private System.Windows.Forms.TextBox txtObjectIp2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtObjectIp1;
        private System.Windows.Forms.TextBox txtObjectName;
        private System.Windows.Forms.Label lblInput8;
        private System.Windows.Forms.Label lblInput7;
        private System.Windows.Forms.Label lblInput6;
        private System.Windows.Forms.Label lblInput5;
        private System.Windows.Forms.Label lblInput4;
        private System.Windows.Forms.Label lblInput3;
        private System.Windows.Forms.Label lblInput2;
        private System.Windows.Forms.Label lblInput1;
        private System.Windows.Forms.Button btnOut8;
        private System.Windows.Forms.Button btnOut7;
        private System.Windows.Forms.Button btnOut6;
        private System.Windows.Forms.Button btnOut5;
        private System.Windows.Forms.Button btnOut4;
        private System.Windows.Forms.Button btnOut3;
        private System.Windows.Forms.Button btnOut2;
        private System.Windows.Forms.Button btnOut1;
        private System.Windows.Forms.Button BtnReleaseDIO;
        private System.Windows.Forms.Button BtnCreateDIO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView ListViewResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListViewSetting;
    }
}

