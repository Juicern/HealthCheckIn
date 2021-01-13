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
using CheckInHelper;

namespace CheckInManagement
{
    public partial class FrmLogin : Form
    {
        Manager manager;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //读取配置文件
            this.manager = ManagerLoginHelper.GetLoginInfoFormConfig();
            InitInfo();
        }
        private void InitInfo()
        {
            this.tbAccount.Text = this.manager.account;
            this.tbPassword.Text = this.manager.password;
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            //账号不存在
            if (!ManagerLoginHelper.CheckAccount(this.tbAccount.Text))
            {
                MessageBox.Show("账号不存在，请点击“注册”按钮注册", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //密码错误
            if(!ManagerLoginHelper.CheckLogin(this.tbAccount.Text, this.tbPassword.Text))
            {
                MessageBox.Show("密码错误，请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //登录
            Login();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            //账号已存在
            if (ManagerLoginHelper.CheckAccount(this.tbAccount.Text))
            {
                MessageBox.Show("账号已存在，请点击“登录”按钮登录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 注册
            var registerInfo = ManagerLoginHelper.Register(this.tbAccount.Text, this.tbPassword.Text);
            if (registerInfo.Item1)
            {
                MessageBox.Show("注册成功，将直接登录", "注册成功", MessageBoxButtons.OK);
                //登录
                Login();
            }
            else
            {
                MessageBox.Show($"注册失败, 失败原因：\n{registerInfo.Item2}", "注册失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        /// <summary>
        /// 登录，跳到提交表单的窗口
        /// </summary>
        private void Login() {
            this.manager.account = this.tbAccount.Text;
            this.manager.password = this.tbPassword.Text;
            ManagerLoginHelper.UpdateLoginInfoToConfig(this.manager);
            this.DialogResult = DialogResult.OK;
            Program.strCurAccount = this.tbAccount.Text;
            this.Close();
        }

        private void cbShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPwd.Checked) this.tbPassword.PasswordChar = (char)0;
            else this.tbPassword.PasswordChar = '*';
        }
        /// <summary>
        /// 检查输入是否有未填写的
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            if(this.tbAccount.Text == string.Empty)
            {
                MessageBox.Show($"未输入账号", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.tbPassword.Text == string.Empty)
            {
                MessageBox.Show($"未输入密码", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
            return true;
        }
    }
}
