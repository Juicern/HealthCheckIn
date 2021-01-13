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
        private string strAccount;
        private Dictionary<string, string> dictSubmitInfo;
        public FrmSubmit(string strAccount)
        {
            InitializeComponent();
            dictSubmitInfo = SubmitHelper.GetSubmitInfoFromConfig();
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
            this.tbTemperature.Text = dictSubmitInfo["temperature"];
            this.cbHealth.Text = dictSubmitInfo["health"];
            this.cbLocation.Text = dictSubmitInfo["location"];
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            dictSubmitInfo.Add("account", this.tbAccount.Text);
            dictSubmitInfo.Add("time", this.tbTime.Text);
            dictSubmitInfo["temperature"] = this.tbTemperature.Text;
            dictSubmitInfo["health"] = this.cbHealth.Text;
            dictSubmitInfo["location"] = this.cbLocation.Text;

            //更新数据库
            SubmitHelper.UpdateSubmitInfo(dictSubmitInfo);
            
            //更新config文件
            SubmitHelper.UpdateSubmitInfoToConfig(dictSubmitInfo);
            
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
