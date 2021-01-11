using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace HealthCheckIn
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            (this.tbAccount.Text, this.tbPassword.Text) = GetLoginInfoFormConfig();
        }

        private (string, string) GetLoginInfoFormConfig()
        {
            return (ConfigHelper.GetAppConfig("account"), ConfigHelper.GetAppConfig("password"));
        }
        private void UpdateLoginInfoToConfig()
        {
            ConfigHelper.UpdateAppConfig("account", this.tbAccount.Text);
            ConfigHelper.UpdateAppConfig("password", this.tbPassword.Text);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //账号不存在
            if(!LoginHelper.CheckAccount(this.tbAccount.Text))
            {
                MessageBox.Show("账号不存在，请点击“注册”按钮注册", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //密码错误
            if(!LoginHelper.CheckLogin(this.tbAccount.Text, this.tbPassword.Text))
            {
                MessageBox.Show("密码错误，请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //登录
            Login();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //账号已存在
            if (LoginHelper.CheckAccount(this.tbAccount.Text))
            {
                MessageBox.Show("账号已存在，请点击“登录”按钮登录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 注册
            var registerInfo = LoginHelper.Register(this.tbAccount.Text, this.tbPassword.Text);
            if (registerInfo.Item1)
            {
                MessageBox.Show("注册成功，将直接登录", "注册成功");
                //登录
                Login();
            }
            else
            {
                MessageBox.Show($"注册失败, 失败原因：\n{registerInfo.Item2}", "注册失败");
            }
            
        }
        private void Login() {
            new FrmSubmit(this.tbAccount.Text).Show();
            this.Close();
        }
    }
}
