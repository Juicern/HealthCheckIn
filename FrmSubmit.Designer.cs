
namespace HealthCheckIn
{
    partial class FrmSubmit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSubmit));
            this.lbAcount = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbTemperature = new System.Windows.Forms.Label();
            this.tbAccount = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.tbTemperature = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHealth = new System.Windows.Forms.Label();
            this.cbHealth = new System.Windows.Forms.ComboBox();
            this.lbLocation = new System.Windows.Forms.Label();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAcount
            // 
            this.lbAcount.AutoSize = true;
            this.lbAcount.Location = new System.Drawing.Point(107, 39);
            this.lbAcount.Name = "lbAcount";
            this.lbAcount.Size = new System.Drawing.Size(70, 24);
            this.lbAcount.TabIndex = 0;
            this.lbAcount.Text = "用户:";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(107, 93);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(70, 24);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "时间:";
            // 
            // lbTemperature
            // 
            this.lbTemperature.AutoSize = true;
            this.lbTemperature.Location = new System.Drawing.Point(107, 147);
            this.lbTemperature.Name = "lbTemperature";
            this.lbTemperature.Size = new System.Drawing.Size(70, 24);
            this.lbTemperature.TabIndex = 6;
            this.lbTemperature.Text = "体温:";
            // 
            // tbAccount
            // 
            this.tbAccount.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbAccount.Location = new System.Drawing.Point(183, 36);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.ReadOnly = true;
            this.tbAccount.Size = new System.Drawing.Size(264, 35);
            this.tbAccount.TabIndex = 7;
            // 
            // tbTime
            // 
            this.tbTime.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbTime.Location = new System.Drawing.Point(183, 90);
            this.tbTime.Name = "tbTime";
            this.tbTime.ReadOnly = true;
            this.tbTime.Size = new System.Drawing.Size(264, 35);
            this.tbTime.TabIndex = 8;
            // 
            // tbTemperature
            // 
            this.tbTemperature.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbTemperature.Location = new System.Drawing.Point(183, 144);
            this.tbTemperature.Name = "tbTemperature";
            this.tbTemperature.Size = new System.Drawing.Size(224, 35);
            this.tbTemperature.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "度";
            // 
            // lbHealth
            // 
            this.lbHealth.AutoSize = true;
            this.lbHealth.Location = new System.Drawing.Point(107, 203);
            this.lbHealth.Name = "lbHealth";
            this.lbHealth.Size = new System.Drawing.Size(70, 24);
            this.lbHealth.TabIndex = 11;
            this.lbHealth.Text = "健康:";
            // 
            // cbHealth
            // 
            this.cbHealth.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbHealth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHealth.FormattingEnabled = true;
            this.cbHealth.Items.AddRange(new object[] {
            "健康",
            "生病"});
            this.cbHealth.Location = new System.Drawing.Point(184, 203);
            this.cbHealth.Name = "cbHealth";
            this.cbHealth.Size = new System.Drawing.Size(263, 32);
            this.cbHealth.TabIndex = 12;
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Location = new System.Drawing.Point(107, 260);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(70, 24);
            this.lbLocation.TabIndex = 13;
            this.lbLocation.Text = "位置:";
            // 
            // cbLocation
            // 
            this.cbLocation.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Items.AddRange(new object[] {
            "在校",
            "外出",
            "在家"});
            this.cbLocation.Location = new System.Drawing.Point(183, 257);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(263, 32);
            this.cbLocation.TabIndex = 14;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSubmit.Location = new System.Drawing.Point(202, 338);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(156, 54);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FrmSubmit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(568, 441);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.lbLocation);
            this.Controls.Add(this.cbHealth);
            this.Controls.Add(this.lbHealth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTemperature);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.tbAccount);
            this.Controls.Add(this.lbTemperature);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbAcount);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSubmit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "健康打卡-表单";
            this.Load += new System.EventHandler(this.FrmSubmit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAcount;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbTemperature;
        private System.Windows.Forms.TextBox tbAccount;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbTemperature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbHealth;
        private System.Windows.Forms.ComboBox cbHealth;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.Button btnSubmit;
    }
}