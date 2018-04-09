using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 资产管理系统.Model;
using 资产管理系统.BLL;
using System.Data;

namespace 资产管理系统.UI
{
    public partial class frmDepartment : 资产管理系统.frmBase
    {
        public frmDepartment()
        {
            InitializeComponent();
        }
        private string formState = "查看";

        public string FormState
        {
            get { return formState; }
            set { formState = value; 
                if (value == "添加" || value == "修改")
                {
                    btnAdd.Enabled = false;
                    btnCancel.Enabled = true; //取消可用
                    btnSave.Enabled = true;  // 保存可用
                    btnDel.Enabled = false;
                    btnUpdate.Enabled = false;
                    tvwDepart.LabelEdit = true; // 打开TreeView的编辑状态
                }
                else if (value == "查看")
                {
                    btnAdd.Enabled = true;  // 添加可用
                    btnCancel.Enabled = false;
                    btnSave.Enabled = false;
                    btnDel.Enabled = true;  // 删除可用
                    btnUpdate.Enabled = true;  // 修改可用
                    tvwDepart.LabelEdit = false; // 关闭TreeView的编辑状态
                }         
            }
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            BuildDeptTree();
        }

        private void BuildDeptTree()
        {
            tvwDepart.Nodes.Clear(); // 先清空TreeView的所有节点
            Company comp=new Company();
            CompanyManager compMgr=new CompanyManager();
            comp=compMgr.GetCompanyInfo();
            if (comp!=null)
            {
                //根节点处显示公司名
                TreeNode root=new TreeNode(comp.Name,0,0);
                //将根节点加入TreaeView中
                tvwDepart.Nodes.Add(root);
                DepartmentManager deptMgr=new DepartmentManager();
                DataTable dt = deptMgr.GetDeptInfo();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i]; // row为dt的第i行
                    //dt第i行第2列,即部门名显示在TreeNode上
                    TreeNode treeNode=new TreeNode(row[1].ToString(),1,1);
                    // 将dt第i行第1列，即部门id绑定在TreeNode上
                    treeNode.Tag = row[0];
                    root.Nodes.Add(treeNode); //将treeNode添加在根节点上
                }
                root.ExpandAll(); // 将所有节点展开
            }
            tvwDepart.LabelEdit = false; // 关闭 TreeView的编辑状态
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormState = "添加";
            TreeNode treeNode=new TreeNode("请输入新部门名称",1,1);
            treeNode.Tag = "new";
            tvwDepart.Nodes[0].Nodes.Add(treeNode); // 在TreeView根节点下添加treeNode
            treeNode.BeginEdit(); // 使添加的节点处于编辑状态
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormState = "查看";
            BuildDeptTree(); // 重新构建树
        }

        private TreeNode deptofModified = null; //用来记录被修改的节点

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tvwDepart.SelectedNode == null) // 如果没有选节点
                return;            
            FormState = "修改";           
            tvwDepart.SelectedNode.BeginEdit();// 打开选定的节点的编辑状态
            deptofModified = tvwDepart.SelectedNode;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string state = FormState; // 获取当前的状态
            string deptName = "";
            if (state=="添加")
            {
                // 遍历Tree根节点下的所有子节点,找到添加的新节点
                foreach (TreeNode node in tvwDepart.Nodes[0].Nodes) 
                {
                    if (node.Tag.ToString() == "new")
                    {
                        deptName = node.Text.Trim(); // 获取添加节点的名字
                        break;
                    }
                }

                if (deptName == "" || deptName == "请输入新部门名称")
                {
                    UnitCommon.InfoMsg("请输入新部门名称!");
                    return;
                }

                Department dept=new Department();
                dept.Name = deptName;
                DepartmentManager deptMgr=new DepartmentManager();
                bool succ=deptMgr.AddDept(dept);
                if (succ) // 保存成功
                {
                    FormState = "查看"; // 注意不要写成formState
                    BuildDeptTree();
                }
                else
                {
                    UnitCommon.ErrorMsg("保存新部门失败！");
                }

                return;           
            }
            else if (state == "修改")
            {
                if (deptofModified != null)
                {
                    int id = int.Parse(deptofModified.Tag.ToString());
                    string name = deptofModified.Text.Trim();
                    if (name=="")
                    {
                        UnitCommon.WarnMsg("部门名称不能为空！");
                        return;
                    }

                    Department dept=new Department();
                    dept.Id = id;
                    dept.Name = name;
                    DepartmentManager deptMgr=new DepartmentManager();
                    bool succ2=deptMgr.UpadateDept(dept);
                    if (succ2)
                    {
                        FormState = "查看";
                        BuildDeptTree();
                    }
                    else
                    {
                        UnitCommon.ErrorMsg("修改部门信息失败！");
                    }
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (tvwDepart.SelectedNode==null)
            {
                UnitCommon.WarnMsg("请选择待删除的部门！");
                return;
            }
            if (tvwDepart.SelectedNode.Level==0)
            {
                UnitCommon.WarnMsg("不能删除公司！"); // 根节点不能删除
                return;
            }
            if (UnitCommon.ConfirmMsg("确定要删除该部门吗？"))
            {
                int id = int.Parse(tvwDepart.SelectedNode.Tag.ToString());
                DepartmentManager deptMgr=new DepartmentManager();
                bool succ3=deptMgr.DelDept(id);
                if (succ3)
                {
                    FormState = "查看";
                    BuildDeptTree();
                }
                else
                {
                    UnitCommon.ErrorMsg("删除部门失败！");
                }
            }            
        }
    }
}
