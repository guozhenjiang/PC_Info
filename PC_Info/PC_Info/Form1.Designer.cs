namespace PC_Info
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_PcName = new System.Windows.Forms.TextBox();
            this.textBox_Mac_Wired = new System.Windows.Forms.TextBox();
            this.textBox_Mac_WireLess = new System.Windows.Forms.TextBox();
            this.textBox_IP_Wired = new System.Windows.Forms.TextBox();
            this.textBox_IP_WireLess = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGotInfo = new System.Windows.Forms.Button();
            this.buttonCopyInfo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Wired_IPv6 = new System.Windows.Forms.TextBox();
            this.textBox_WireLess_IPv6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(457, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "主机名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(0, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "有线网络";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(0, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "无线网络";
            // 
            // textBox_PcName
            // 
            this.textBox_PcName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_PcName.CausesValidation = false;
            this.textBox_PcName.Enabled = false;
            this.textBox_PcName.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_PcName.Location = new System.Drawing.Point(559, 8);
            this.textBox_PcName.Name = "textBox_PcName";
            this.textBox_PcName.ReadOnly = true;
            this.textBox_PcName.Size = new System.Drawing.Size(498, 35);
            this.textBox_PcName.TabIndex = 3;
            this.textBox_PcName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Mac_Wired
            // 
            this.textBox_Mac_Wired.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_Mac_Wired.CausesValidation = false;
            this.textBox_Mac_Wired.Enabled = false;
            this.textBox_Mac_Wired.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Mac_Wired.Location = new System.Drawing.Point(98, 89);
            this.textBox_Mac_Wired.Name = "textBox_Mac_Wired";
            this.textBox_Mac_Wired.ReadOnly = true;
            this.textBox_Mac_Wired.Size = new System.Drawing.Size(210, 31);
            this.textBox_Mac_Wired.TabIndex = 4;
            this.textBox_Mac_Wired.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Mac_WireLess
            // 
            this.textBox_Mac_WireLess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_Mac_WireLess.CausesValidation = false;
            this.textBox_Mac_WireLess.Enabled = false;
            this.textBox_Mac_WireLess.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Mac_WireLess.Location = new System.Drawing.Point(98, 140);
            this.textBox_Mac_WireLess.Name = "textBox_Mac_WireLess";
            this.textBox_Mac_WireLess.ReadOnly = true;
            this.textBox_Mac_WireLess.Size = new System.Drawing.Size(210, 31);
            this.textBox_Mac_WireLess.TabIndex = 5;
            this.textBox_Mac_WireLess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_IP_Wired
            // 
            this.textBox_IP_Wired.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_IP_Wired.CausesValidation = false;
            this.textBox_IP_Wired.Enabled = false;
            this.textBox_IP_Wired.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IP_Wired.Location = new System.Drawing.Point(314, 89);
            this.textBox_IP_Wired.Name = "textBox_IP_Wired";
            this.textBox_IP_Wired.ReadOnly = true;
            this.textBox_IP_Wired.Size = new System.Drawing.Size(239, 31);
            this.textBox_IP_Wired.TabIndex = 6;
            this.textBox_IP_Wired.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_IP_WireLess
            // 
            this.textBox_IP_WireLess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_IP_WireLess.CausesValidation = false;
            this.textBox_IP_WireLess.Enabled = false;
            this.textBox_IP_WireLess.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IP_WireLess.Location = new System.Drawing.Point(314, 140);
            this.textBox_IP_WireLess.Name = "textBox_IP_WireLess";
            this.textBox_IP_WireLess.ReadOnly = true;
            this.textBox_IP_WireLess.Size = new System.Drawing.Size(239, 31);
            this.textBox_IP_WireLess.TabIndex = 7;
            this.textBox_IP_WireLess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(124, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "网卡 Mac 地址";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(374, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "IPv4 地址";
            // 
            // buttonGotInfo
            // 
            this.buttonGotInfo.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonGotInfo.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonGotInfo.Location = new System.Drawing.Point(98, 193);
            this.buttonGotInfo.Name = "buttonGotInfo";
            this.buttonGotInfo.Size = new System.Drawing.Size(455, 106);
            this.buttonGotInfo.TabIndex = 10;
            this.buttonGotInfo.Text = "2 点击获取";
            this.buttonGotInfo.UseVisualStyleBackColor = false;
            this.buttonGotInfo.Click += new System.EventHandler(this.buttonGotInfo_Click);
            // 
            // buttonCopyInfo
            // 
            this.buttonCopyInfo.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonCopyInfo.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCopyInfo.Location = new System.Drawing.Point(559, 193);
            this.buttonCopyInfo.Name = "buttonCopyInfo";
            this.buttonCopyInfo.Size = new System.Drawing.Size(498, 106);
            this.buttonCopyInfo.TabIndex = 11;
            this.buttonCopyInfo.Text = "3 点击复制";
            this.buttonCopyInfo.UseVisualStyleBackColor = false;
            this.buttonCopyInfo.Click += new System.EventHandler(this.buttonCopyInfo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(766, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "IPv6 地址";
            // 
            // textBox_Wired_IPv6
            // 
            this.textBox_Wired_IPv6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_Wired_IPv6.CausesValidation = false;
            this.textBox_Wired_IPv6.Enabled = false;
            this.textBox_Wired_IPv6.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Wired_IPv6.Location = new System.Drawing.Point(559, 89);
            this.textBox_Wired_IPv6.Name = "textBox_Wired_IPv6";
            this.textBox_Wired_IPv6.ReadOnly = true;
            this.textBox_Wired_IPv6.Size = new System.Drawing.Size(498, 31);
            this.textBox_Wired_IPv6.TabIndex = 13;
            this.textBox_Wired_IPv6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_WireLess_IPv6
            // 
            this.textBox_WireLess_IPv6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_WireLess_IPv6.CausesValidation = false;
            this.textBox_WireLess_IPv6.Enabled = false;
            this.textBox_WireLess_IPv6.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_WireLess_IPv6.Location = new System.Drawing.Point(559, 140);
            this.textBox_WireLess_IPv6.Name = "textBox_WireLess_IPv6";
            this.textBox_WireLess_IPv6.ReadOnly = true;
            this.textBox_WireLess_IPv6.Size = new System.Drawing.Size(498, 31);
            this.textBox_WireLess_IPv6.TabIndex = 14;
            this.textBox_WireLess_IPv6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(0, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = "1 输入姓名";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.BackColor = System.Drawing.Color.Aqua;
            this.textBox_UserName.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_UserName.Location = new System.Drawing.Point(112, 8);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(268, 35);
            this.textBox_UserName.TabIndex = 16;
            this.textBox_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label8.Location = new System.Drawing.Point(681, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(376, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "作者：郭振江 guo_zhen_jiang@163.com 2017-09-14";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(10, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(543, 28);
            this.label9.TabIndex = 18;
            this.label9.Text = "按照 1、2、3 操作后，以上信息就被复制到了剪贴板中了";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 347);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_WireLess_IPv6);
            this.Controls.Add(this.textBox_Wired_IPv6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonCopyInfo);
            this.Controls.Add(this.buttonGotInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_IP_WireLess);
            this.Controls.Add(this.textBox_IP_Wired);
            this.Controls.Add(this.textBox_Mac_WireLess);
            this.Controls.Add(this.textBox_Mac_Wired);
            this.Controls.Add(this.textBox_PcName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "PC 信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_PcName;
        private System.Windows.Forms.TextBox textBox_Mac_Wired;
        private System.Windows.Forms.TextBox textBox_Mac_WireLess;
        private System.Windows.Forms.TextBox textBox_IP_Wired;
        private System.Windows.Forms.TextBox textBox_IP_WireLess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGotInfo;
        private System.Windows.Forms.Button buttonCopyInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Wired_IPv6;
        private System.Windows.Forms.TextBox textBox_WireLess_IPv6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

