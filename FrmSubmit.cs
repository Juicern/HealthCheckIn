﻿using System;
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
    }
}