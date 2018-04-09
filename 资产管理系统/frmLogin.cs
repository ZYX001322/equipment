using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using 资产管理系统.BLL;
using 资产管理系统.Model;


namespace 资产管理系统.UI
{
    public partial class frmLogin : frmBase
    {
        public frmLogin()
        {
            InitializeComponent();
            //this.skinEngine1.SkinFile = "XPGreen.ssk";
            this.skinEngine1.SkinFile = "GlassOrange.ssk";
        }

        //重置文本框方法
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
            txtUser.Focus(); 
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (UnitCommon.ConfirmMsg("确认要退出吗？"))
            {
                Application.Exit();
            }
            else
            {
                
            }
        }

        //loginUser用来将user的信息给frmMain窗体
        public 资产管理系统.Model.SysUser loginUser = null;
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) //用户名或密码输入为空
                return;
            else
            {
                资产管理系统.Model.SysUser user=null;
                bool valid=资产管理系统.BLL.LoginManager.Login(txtUser.Text.Trim(), txtPass.Text.Trim(),out user);
                if (valid)
                {
                    loginUser = user;
                    this.DialogResult=DialogResult.OK;
                }
                else
                {
                    UnitCommon.ErrorMsg("用户名或密码不正确，请重新输入！");
                    txtUser.Focus();
                    txtUser.SelectAll();
                }
            }
        }

        private bool CheckInput()
        {
            if (txtUser.Text.Trim()=="")
            {
                UnitCommon.InfoMsg("用户名不能为空！");
                txtUser.Focus(); //鼠标聚焦在此文本框内
                return false;
            }
            else if (txtPass.Text.Trim() == "")
            {
                UnitCommon.InfoMsg("密码不能为空!");
                txtPass.Focus(); //鼠标聚焦在此文本框内
                return false;
            }
            return true;                 
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
