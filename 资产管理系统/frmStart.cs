using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 资产管理系统
{
    public partial class frmStart : 资产管理系统.frmBase
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            this.DialogResult=DialogResult.OK;
        }
    }
}
