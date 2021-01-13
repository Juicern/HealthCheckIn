
namespace CheckInManagement
{
    partial class FrmManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManagement));
            this.lvPersons = new System.Windows.Forms.ListView();
            this.dgvSubmits = new System.Windows.Forms.DataGridView();
            this.account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.health = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPersons = new System.Windows.Forms.GroupBox();
            this.gbSubmits = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubmits)).BeginInit();
            this.gbPersons.SuspendLayout();
            this.gbSubmits.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvPersons
            // 
            this.lvPersons.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lvPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPersons.HideSelection = false;
            this.lvPersons.Location = new System.Drawing.Point(4, 32);
            this.lvPersons.Margin = new System.Windows.Forms.Padding(4);
            this.lvPersons.Name = "lvPersons";
            this.lvPersons.Size = new System.Drawing.Size(234, 970);
            this.lvPersons.TabIndex = 0;
            this.lvPersons.UseCompatibleStateImageBehavior = false;
            this.lvPersons.View = System.Windows.Forms.View.List;
            this.lvPersons.SelectedIndexChanged += new System.EventHandler(this.lvPersons_SelectedIndexChanged);
            // 
            // dgvSubmits
            // 
            this.dgvSubmits.AllowUserToAddRows = false;
            this.dgvSubmits.AllowUserToDeleteRows = false;
            this.dgvSubmits.AllowUserToResizeColumns = false;
            this.dgvSubmits.AllowUserToResizeRows = false;
            this.dgvSubmits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubmits.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubmits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubmits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubmits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.account,
            this.time,
            this.temperature,
            this.health,
            this.location});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubmits.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubmits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubmits.Location = new System.Drawing.Point(3, 31);
            this.dgvSubmits.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSubmits.Name = "dgvSubmits";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubmits.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSubmits.RowHeadersVisible = false;
            this.dgvSubmits.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvSubmits.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSubmits.RowTemplate.Height = 30;
            this.dgvSubmits.Size = new System.Drawing.Size(1223, 972);
            this.dgvSubmits.TabIndex = 1;
            // 
            // account
            // 
            this.account.HeaderText = "账号";
            this.account.MinimumWidth = 8;
            this.account.Name = "account";
            // 
            // time
            // 
            this.time.HeaderText = "时间";
            this.time.MinimumWidth = 8;
            this.time.Name = "time";
            // 
            // temperature
            // 
            this.temperature.HeaderText = "体温";
            this.temperature.MinimumWidth = 8;
            this.temperature.Name = "temperature";
            // 
            // health
            // 
            this.health.HeaderText = "健康";
            this.health.MinimumWidth = 8;
            this.health.Name = "health";
            // 
            // location
            // 
            this.location.HeaderText = "地点";
            this.location.MinimumWidth = 8;
            this.location.Name = "location";
            // 
            // gbPersons
            // 
            this.gbPersons.Controls.Add(this.lvPersons);
            this.gbPersons.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbPersons.Location = new System.Drawing.Point(0, 0);
            this.gbPersons.Margin = new System.Windows.Forms.Padding(4);
            this.gbPersons.Name = "gbPersons";
            this.gbPersons.Padding = new System.Windows.Forms.Padding(4);
            this.gbPersons.Size = new System.Drawing.Size(242, 1006);
            this.gbPersons.TabIndex = 2;
            this.gbPersons.TabStop = false;
            this.gbPersons.Text = "学生信息";
            // 
            // gbSubmits
            // 
            this.gbSubmits.Controls.Add(this.dgvSubmits);
            this.gbSubmits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSubmits.Location = new System.Drawing.Point(242, 0);
            this.gbSubmits.Name = "gbSubmits";
            this.gbSubmits.Size = new System.Drawing.Size(1229, 1006);
            this.gbSubmits.TabIndex = 3;
            this.gbSubmits.TabStop = false;
            this.gbSubmits.Text = "打卡记录";
            // 
            // FrmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1471, 1006);
            this.Controls.Add(this.gbSubmits);
            this.Controls.Add(this.gbPersons);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打卡管理";
            this.Load += new System.EventHandler(this.FrmManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubmits)).EndInit();
            this.gbPersons.ResumeLayout(false);
            this.gbSubmits.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPersons;
        private System.Windows.Forms.DataGridView dgvSubmits;
        private System.Windows.Forms.GroupBox gbPersons;
        private System.Windows.Forms.GroupBox gbSubmits;
        private System.Windows.Forms.DataGridViewTextBoxColumn account;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn health;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
    }
}