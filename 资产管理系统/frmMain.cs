using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 资产管理系统.BLL;
using 资产管理系统.Model;

namespace 资产管理系统.UI
{
    public partial class frmMain : 资产管理系统.frmBase
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //用来接收frmLogin传来的loginUser对象
        public 资产管理系统.Model.SysUser User = null;
        private void frmMain_Load(object sender, EventArgs e)
        {
            stalUser.Text = "系统管理员："+User.LoginName;
            stalTime.Text = DateTime.Now.ToString(); // 得到登陆时间
            Company comp=new Company();
            CompanyManager compMgr=new CompanyManager();
            comp = compMgr.GetCompanyInfo();
            if (comp != null)
            {   
                stalCompany.Text = comp.Name;
                stalAdress.Text = comp.Address;
            }           
        }

        private void 资产保管人员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKeeper frmkeeper=new frmKeeper();
            frmkeeper.ShowDialog();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (UnitCommon.ConfirmMsg("确认要退出系统吗?"))
            {
                Application.Exit();
            }
            else
            {
                return;
            }
            
        }

        private void 员工管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee frmEmp=new frmEmployee();
            frmEmp.ShowDialog();
        }

        private void 部门ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartment dept=new frmDepartment();
            dept.ShowDialog();
        }

        private void 系统退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 基本设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseInfo info=new frmBaseInfo();
            info.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmBaseInfo info = new frmBaseInfo();
            info.ShowDialog();
        }      
    }
}
