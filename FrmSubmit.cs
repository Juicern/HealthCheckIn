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
        public FrmSubmit(string strAccount)
        {
            InitializeComponent();
            this.strAccount = strAccount;
        }

        private void FrmSubmit_Load(object sender, EventArgs e)
        {
            this.lbAcount.Text = $"用户: {strAccount}";
            this.lbTime.Text = $"时间: {DateTime.Now:yyyy/MM/dd}";
        }
        private void InitInfo()
        {

        }
    }
}
