namespace OPCtest4
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
            this.lblState = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSetGroupPro = new System.Windows.Forms.Button();
            this.txtGroupDeadband = new System.Windows.Forms.TextBox();
            this.txtGroupIsActive = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUpdateRate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIsSubscribed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIsActive = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.txtWriteTagValue = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTagValue = new System.Windows.Forms.TextBox();
            this.txtTimeStamps = new System.Windows.Forms.TextBox();
            this.txtQualities = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbServerName = new System.Windows.Forms.ComboBox();
            this.btnConnServer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemoteServerIP = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslServerState = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslServerStartTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslversion = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblState
            // 
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblState.Location = new System.Drawing.Point(456, 206);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(199, 104);
            this.lblState.TabIndex = 20;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSetGroupPro);
            this.groupBox5.Controls.Add(this.txtGroupDeadband);
            this.groupBox5.Controls.Add(this.txtGroupIsActive);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtUpdateRate);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtIsSubscribed);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtIsActive);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(10, 122);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(199, 193);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "尝试更改一下组的属性";
            // 
            // btnSetGroupPro
            // 
            this.btnSetGroupPro.Enabled = false;
            this.btnSetGroupPro.Location = new System.Drawing.Point(105, 164);
            this.btnSetGroupPro.Name = "btnSetGroupPro";
            this.btnSetGroupPro.Size = new System.Drawing.Size(75, 23);
            this.btnSetGroupPro.TabIndex = 19;
            this.btnSetGroupPro.Text = "设置";
            this.btnSetGroupPro.UseVisualStyleBackColor = true;
            this.btnSetGroupPro.Click += new System.EventHandler(this.BtnSetGroupPro_Click);
            // 
            // txtGroupDeadband
            // 
            this.txtGroupDeadband.Location = new System.Drawing.Point(145, 51);
            this.txtGroupDeadband.Name = "txtGroupDeadband";
            this.txtGroupDeadband.Size = new System.Drawing.Size(35, 21);
            this.txtGroupDeadband.TabIndex = 9;
            this.txtGroupDeadband.Text = "0";
            // 
            // txtGroupIsActive
            // 
            this.txtGroupIsActive.ForeColor = System.Drawing.Color.Blue;
            this.txtGroupIsActive.Location = new System.Drawing.Point(145, 24);
            this.txtGroupIsActive.Name = "txtGroupIsActive";
            this.txtGroupIsActive.Size = new System.Drawing.Size(35, 21);
            this.txtGroupIsActive.TabIndex = 8;
            this.txtGroupIsActive.Text = "true";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 12);
            this.label12.TabIndex = 7;
            this.label12.Text = "DefaultGroupDeadband:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "DefaultGroupIsActive:";
            // 
            // txtUpdateRate
            // 
            this.txtUpdateRate.Location = new System.Drawing.Point(145, 132);
            this.txtUpdateRate.Name = "txtUpdateRate";
            this.txtUpdateRate.Size = new System.Drawing.Size(35, 21);
            this.txtUpdateRate.TabIndex = 5;
            this.txtUpdateRate.Text = "1000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(68, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "UpdateRate:";
            // 
            // txtIsSubscribed
            // 
            this.txtIsSubscribed.ForeColor = System.Drawing.Color.Blue;
            this.txtIsSubscribed.Location = new System.Drawing.Point(145, 105);
            this.txtIsSubscribed.Name = "txtIsSubscribed";
            this.txtIsSubscribed.Size = new System.Drawing.Size(35, 21);
            this.txtIsSubscribed.TabIndex = 3;
            this.txtIsSubscribed.Text = "true";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "IsSubscribed:";
            // 
            // txtIsActive
            // 
            this.txtIsActive.ForeColor = System.Drawing.Color.Blue;
            this.txtIsActive.Location = new System.Drawing.Point(145, 78);
            this.txtIsActive.Name = "txtIsActive";
            this.txtIsActive.Size = new System.Drawing.Size(35, 21);
            this.txtIsActive.TabIndex = 1;
            this.txtIsActive.Text = "true";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "IsActive:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnWrite);
            this.groupBox4.Controls.Add(this.txtWriteTagValue);
            this.groupBox4.Location = new System.Drawing.Point(456, 138);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(199, 56);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "写入值";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(112, 18);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(69, 23);
            this.btnWrite.TabIndex = 1;
            this.btnWrite.Text = "写入";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.BtnWrite_Click);
            // 
            // txtWriteTagValue
            // 
            this.txtWriteTagValue.Location = new System.Drawing.Point(16, 20);
            this.txtWriteTagValue.Name = "txtWriteTagValue";
            this.txtWriteTagValue.Size = new System.Drawing.Size(90, 21);
            this.txtWriteTagValue.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTagValue);
            this.groupBox3.Controls.Add(this.txtTimeStamps);
            this.groupBox3.Controls.Add(this.txtQualities);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(456, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 121);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "当前值";
            // 
            // txtTagValue
            // 
            this.txtTagValue.Location = new System.Drawing.Point(56, 15);
            this.txtTagValue.Name = "txtTagValue";
            this.txtTagValue.ReadOnly = true;
            this.txtTagValue.Size = new System.Drawing.Size(124, 21);
            this.txtTagValue.TabIndex = 6;
            // 
            // txtTimeStamps
            // 
            this.txtTimeStamps.Location = new System.Drawing.Point(56, 69);
            this.txtTimeStamps.Name = "txtTimeStamps";
            this.txtTimeStamps.ReadOnly = true;
            this.txtTimeStamps.Size = new System.Drawing.Size(124, 21);
            this.txtTimeStamps.TabIndex = 4;
            // 
            // txtQualities
            // 
            this.txtQualities.Location = new System.Drawing.Point(56, 42);
            this.txtQualities.Name = "txtQualities";
            this.txtQualities.ReadOnly = true;
            this.txtQualities.Size = new System.Drawing.Size(124, 21);
            this.txtQualities.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "时间戳:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "品质:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tag值:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbServerName);
            this.groupBox1.Controls.Add(this.btnConnServer);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtRemoteServerIP);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 106);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接OPC服务器";
            // 
            // cmbServerName
            // 
            this.cmbServerName.FormattingEnabled = true;
            this.cmbServerName.Location = new System.Drawing.Point(59, 48);
            this.cmbServerName.Name = "cmbServerName";
            this.cmbServerName.Size = new System.Drawing.Size(121, 20);
            this.cmbServerName.TabIndex = 17;
            // 
            // btnConnServer
            // 
            this.btnConnServer.Location = new System.Drawing.Point(105, 74);
            this.btnConnServer.Name = "btnConnServer";
            this.btnConnServer.Size = new System.Drawing.Size(75, 23);
            this.btnConnServer.TabIndex = 16;
            this.btnConnServer.Text = "连接";
            this.btnConnServer.UseVisualStyleBackColor = true;
            this.btnConnServer.Click += new System.EventHandler(this.BtnConnServer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "服务器:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "IP:";
            // 
            // txtRemoteServerIP
            // 
            this.txtRemoteServerIP.Location = new System.Drawing.Point(59, 17);
            this.txtRemoteServerIP.Name = "txtRemoteServerIP";
            this.txtRemoteServerIP.Size = new System.Drawing.Size(121, 21);
            this.txtRemoteServerIP.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(215, 10);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 304);
            this.listBox1.TabIndex = 19;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslServerState,
            this.tsslServerStartTime,
            this.tsslversion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 324);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(666, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslServerState
            // 
            this.tsslServerState.Name = "tsslServerState";
            this.tsslServerState.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslServerStartTime
            // 
            this.tsslServerStartTime.Name = "tsslServerStartTime";
            this.tsslServerStartTime.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslversion
            // 
            this.tsslversion.Name = "tsslversion";
            this.tsslversion.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 346);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSetGroupPro;
        private System.Windows.Forms.TextBox txtGroupDeadband;
        private System.Windows.Forms.TextBox txtGroupIsActive;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUpdateRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIsSubscribed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIsActive;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox txtWriteTagValue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTagValue;
        private System.Windows.Forms.TextBox txtTimeStamps;
        private System.Windows.Forms.TextBox txtQualities;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbServerName;
        private System.Windows.Forms.Button btnConnServer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemoteServerIP;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslServerState;
        private System.Windows.Forms.ToolStripStatusLabel tsslServerStartTime;
        private System.Windows.Forms.ToolStripStatusLabel tsslversion;
    }
}

