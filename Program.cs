using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCheckIn
{
    static class Program
    {
        public static string strCurAccount;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            if(frmLogin.DialogResult == DialogResult.OK)
            {
                Application.Run(new FrmSubmit(strCurAccount));
            }
            else
            {
                return;
            }
        }
    }
}
