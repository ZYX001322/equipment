using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 资产管理系统.Model;
using System.Data;
using 资产管理系统.BLL;

namespace 资产管理系统.UI
{
    public partial class frmKeeper : frmBase
    {
        public frmKeeper()
        {
            InitializeComponent();
        }

        //封装一个字段formState，显示窗体的状态，根据窗体状态决定哪些按钮可用
        private string formState = "查看";

        public string FormState
        {
            get { return formState; }
            set
            {
                formState = value;
                if (value == "添加")
                {
                    txtKeeper.Enabled = true;
                    btnAdd.Enabled = false;
                    btnCancel.Enabled = true;
                    btnSave.Enabled = true;
                    btnDel.Enabled = false;
                }
                else if (value == "查看")
                {
                    txtKeeper.Enabled = false;
                    txtKeeper.Text = "";
                    btnAdd.Enabled = true;
                    btnCancel.Enabled = false;
                    btnSave.Enabled = false;
                    btnDel.Enabled = true;
                }
            }
        }
    

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.FormState = "添加";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void frmKeeper_Load(object sender, EventArgs e)
        {
            资产管理系统.BLL.KeeperManager keeperMgr=new KeeperManager();
            DataTable dt = keeperMgr.BingListBox();
            lstKeeper.DataSource = dt;
            lstKeeper.DisplayMember = "keeper"; //DisplayMember是listBox中项的Text
            lstKeeper.ValueMember = "id"; // ValueMember是listBox中项的值value
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.FormState = "查看";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lstKeeper.SelectedIndex == -1) //如果没选，就什么都不做
                return;
            if (UnitCommon.ConfirmMsg("确定删除该保管人员吗？"))
            {
                KeeperManager keeperMgr=new KeeperManager();
                bool done=keeperMgr.DeleteKeeper(int.Parse(lstKeeper.SelectedValue.ToString()));
                if (done)
                {
                    // 如果删除成功，重新绑定listBox
                    DataTable dt2=keeperMgr.BingListBox();
                    lstKeeper.DataSource = dt2;
                    lstKeeper.DisplayMember = "keeper";
                    lstKeeper.ValueMember = "id";
                    this.FormState = "查看";
                }
                else
                {
                    UnitCommon.ErrorMsg("删除仓库保管人员失败!");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtKeeper.Text.Trim() == "")
            {
                UnitCommon.InfoMsg("请输入仓管人员信息！");
                txtKeeper.Focus();
                return;
            }
           
            Keeper keeper=new Keeper();
            keeper.Name = txtKeeper.Text.Trim(); // keeper的id字段是自增字段，不用管
            
            KeeperManager keeperMgr=new KeeperManager();
            bool done=keeperMgr.AddKeeper(keeper);
            if (done)
            {
                DataTable dt3 = keeperMgr.BingListBox();
                lstKeeper.DataSource = dt3;
                lstKeeper.DisplayMember = "keeper";
                lstKeeper.ValueMember = "id";
                this.FormState = "查看";
            }
            else
            {
                UnitCommon.ErrorMsg("保存仓管人员信息失败!");
            }
        }
    }
}
