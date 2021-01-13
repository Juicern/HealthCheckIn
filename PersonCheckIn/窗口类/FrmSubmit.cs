using CheckInHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCheckIn
{
    public partial class FrmSubmit : Form
    {
        private readonly string strAccount;
        private Submit submit;
        public FrmSubmit(string strAccount)
        {
            InitializeComponent();
            this.submit = SubmitHelper.GetSubmitInfoFromConfig();
            this.strAccount = strAccount;
        }

        private void FrmSubmit_Load(object sender, EventArgs e)
        {
            InitInfo();
        }
        private void InitInfo()
        {
            this.tbAccount.Text = this.strAccount;
            this.tbTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
            this.tbTemperature.Text = this.submit.temperature;
            this.cbHealth.Text = this.submit.health;
            this.cbLocation.Text = this.submit.location;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            this.submit.account = this.tbAccount.Text;
            this.submit.time = DateTime.Now.ToString();
            this.submit.temperature = this.tbTemperature.Text;
            this.submit.health = this.cbHealth.Text;
            this.submit.location = this.cbLocation.Text;

            //更新数据库
            SubmitHelper.UpdateSubmitInfo(this.submit);
            
            //更新config文件
            SubmitHelper.UpdateSubmitInfoToConfig(this.submit);
            
            MessageBox.Show("打卡成功");
        }
        /// <summary>
        /// 检查输入是否有未填写的
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            if(this.tbTemperature.Text == string.Empty)
            {
                MessageBox.Show($"未输入体温", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(this.cbHealth.Text == string.Empty)
            {
                MessageBox.Show($"未选择健康状况", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(this.cbLocation.Text == string.Empty)
            {
                MessageBox.Show($"未选择地点", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
