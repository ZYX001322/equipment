using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 资产管理系统.Model;
using 资产管理系统.BLL;

namespace 资产管理系统.UI
{
    public partial class frmBaseInfo : frmBase
    {
        public frmBaseInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 绑定listBox资产表信息
        /// </summary>
        /// <param name="dt"></param>
        private void BindLstRes(DataTable dt)
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                lstInfo.Items.Clear(); //将lstInfo内容清空
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Resources res=new Resources();
                    res.Id = int.Parse(dt.Rows[i][0].ToString());
                    res.Name = dt.Rows[i][1].ToString();
                    lstInfo.Items.Add(res); // 将res对象加入lstInfo中
                }
                lstInfo.SelectedIndex = 0; // 鼠标选中lstInfo的第一项
            }
        }

        private string resType = "";

        private void GetAllRes(object sender, EventArgs e)
        {           
            //sender代表当前的button，即为btnName，获取btnName的Tag值
            lblMessge.Text = ((Button) sender).Text.ToString();
            resType=((Button) sender).Tag.ToString();
            DataTable dt = ResFactoryManager.GetAllRes(resType);
            this.BindLstRes(dt);
        }

        private string formState = "查看";

        /// <summary>
        /// 当前窗体的状态
        /// </summary>
        public string FormState
        {
            get { return formState; }
            set
            {
                formState = value;
                if (formState=="添加")
                {
                    txtInput.Enabled = true;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnDel.Enabled = false;
                    btnAdd.Enabled = false;
                    txtInput.Text = "请输入新加项的内容";
                }else if (formState=="查看")
                {
                    txtInput.Enabled = false;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnDel.Enabled = true;
                    btnAdd.Enabled = true;
                    txtInput.Text = "";
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.FormState = "添加";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "" || txtInput.Text == "请输入新加项的内容")
            {
                UnitCommon.InfoMsg("请输入新添加项的内容!");
                txtInput.Focus();
                txtInput.SelectAll();
                return;
            }

            Resources res=new Resources();
            res.Name = txtInput.Text.Trim();
            bool isOK = ResFactoryManager.Add(res, this.resType);
            if (isOK)
            {
                DataTable dt = ResFactoryManager.GetAllRes(resType);
                BindLstRes(dt);
                this.FormState = "查看";
            }
            else
            {
                UnitCommon.ErrorMsg("保存资产信息失败！");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.FormState = "查看";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lstInfo.SelectedIndex == -1) return; //表示没有选择要删除的项

            Resources res = lstInfo.SelectedItem as Resources;
            if (res != null)
            {
                if (UnitCommon.ConfirmMsg("您确定要删除此条记录吗？"))
                {
                    bool isok = ResFactoryManager.Del(res.Id, this.resType);
                    if (isok)
                    {
                        DataTable dt = ResFactoryManager.GetAllRes(resType);
                        this.BindLstRes(dt);
                        this.FormState = "查看";
                    }
                    else
                    {
                        UnitCommon.ErrorMsg("删除资产信息失败!");
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
