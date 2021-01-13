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

namespace CheckInManagement
{
    public partial class FrmManagement : Form
    {
        public FrmManagement(string strAccount)
        {
            InitializeComponent();
        }

        private void FrmManagement_Load(object sender, EventArgs e)
        {
            RefreshPersons();
            RefreshSubmits();
        }
        
        /// <summary>
        /// 刷新人员信息
        /// </summary>
        private void RefreshPersons()
        {
            this.lvPersons.Items.Clear();
            foreach(var person in ManagerHelper.GetAllPersons())
            {
                var item = new ListViewItem
                {
                    Text = person.account
                };
                this.lvPersons.Items.Add(item);       
            }
        }
        /// <summary>
        /// 刷新打卡信息，若未选中人员则显示全部信息
        /// </summary>
        /// <param name="strAccount">选中的人员</param>
        private void RefreshSubmits(string strAccount = null)
        {
            this.dgvSubmits.Rows.Clear();
            List<Submit> submits;
            if (strAccount == null) submits = ManagerHelper.GetAllSubmits();
            else submits = ManagerHelper.GetPersonSubmits(strAccount);
            foreach(var submit in submits)
            {
                var index = this.dgvSubmits.Rows.Add();
                this.dgvSubmits.Rows[index].Cells[0].Value = submit.account;
                this.dgvSubmits.Rows[index].Cells[1].Value = submit.time;
                this.dgvSubmits.Rows[index].Cells[2].Value = submit.temperature;
                this.dgvSubmits.Rows[index].Cells[3].Value = submit.health;
                this.dgvSubmits.Rows[index].Cells[4].Value = submit.location;
            }
        }

        private void lvPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lvPersons.SelectedItems.Count != 0) RefreshSubmits(this.lvPersons.SelectedItems[0].Text);
        }
    }
}
