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
    public partial class frmEmployee : 资产管理系统.frmBase
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            BuildEmpTree();
            // 将DataGridView的自动产生列功能关闭，手工产生列
            dataGridView1.AutoGenerateColumns = false;
            InitCbxNewDept();
            InitCbxDept();
        }

        

        /// <summary>
        /// 初始化下拉框控件cbxNewDepart下拉项的值
        /// </summary>
        private void InitCbxNewDept()
        {
            cbxNewDepart.Items.Clear(); // 先将ComoBox控件cbxNewDepart的Items清空
            DepartmentManager deptMgr = new DepartmentManager();
            DataTable dt = deptMgr.GetDeptInfo();
            cbxNewDepart.DataSource = dt; // 将dt与cbxNewDepart绑定
            cbxNewDepart.DisplayMember = dt.Columns[1].ColumnName; // dt表的第2列的列名,即表department列depatname
            cbxNewDepart.ValueMember = dt.Columns[0].ColumnName; // dt表的第1列的列名,即表department列depatname
            cbxNewDepart.SelectedIndex = 0; // 选中第一个部门
        }

        /// <summary>
        /// 初始化下拉框控件cbxDepart下拉项的值
        /// </summary>
        private void InitCbxDept()
        {
            cbxDepart.Items.Clear(); // 先将ComoBox控件cbxDepart的Items清空
            DepartmentManager deptMgr = new DepartmentManager();
            DataTable dt = deptMgr.GetDeptInfo();
            cbxDepart.DataSource = dt; // 将dt与cbxDepart绑定
            cbxDepart.DisplayMember = dt.Columns[1].ColumnName; // dt表的第2列的列名,即表department列depatname
            cbxDepart.ValueMember = dt.Columns[0].ColumnName; // dt表的第1列的列名,即表department列depatname
            cbxDepart.SelectedIndex = 0; // 选中第一个部门
        }

        private void BuildEmpTree()
        {
            tvwEmp.Nodes.Clear(); // 先清空TreeView的所有节点
            Company comp = new Company();
            CompanyManager compMgr = new CompanyManager();
            comp = compMgr.GetCompanyInfo();
            if (comp != null)
            {
                //根节点处显示公司名
                TreeNode root = new TreeNode(comp.Name, 0, 0);
                //将根节点加入TreaeView中
                tvwEmp.Nodes.Add(root);
                DepartmentManager deptMgr = new DepartmentManager();
                DataTable dt = deptMgr.GetDeptInfo();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i]; // row为dt的第i行
                    //dt第i行第2列,即部门名显示在TreeNode上
                    TreeNode treeNode = new TreeNode(row[1].ToString(), 1, 1);
                    // 将dt第i行第1列，即部门id绑定在TreeNode上
                    treeNode.Tag = row[0];
                    // 在treeNode节点下再生成员工节点,整个树有三层，根节点一层，部门节点一层，员工节点一层
                    CreateEmpTreeNode(treeNode);
                    root.Nodes.Add(treeNode); //将treeNode添加在根节点上
                }
                root.ExpandAll(); // 将根节点展开
            }
            tvwEmp.LabelEdit = false; // 关闭 TreeView的编辑状态
        }

        /// <summary>
        /// 产生员工节点
        /// </summary>
        /// <param name="deptNode"></param>
        private void CreateEmpTreeNode(TreeNode deptNode)
        {
            int deptId = int.Parse(deptNode.Tag.ToString()); // 得到部门ID
            EmployeeManager empMgr = new EmployeeManager();
            DataTable dt = empMgr.GetAllEmpByDeptID(deptId); // 按部门号获取员工信息
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i]; // dr为dt的第i行
                    TreeNode empNode = new TreeNode(dr[1].ToString(), 2, 2); //dr[1]表示行的第二列为员工姓名,2表示图片索引
                    empNode.Tag = dr[0]; // dr[0]表示行的第一列为员工编号
                    deptNode.Nodes.Add(empNode); // 将员工节点empNode添加到部门节点deptNode中

                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 将在左边TreeView中选定的节点信息，显示在右边的dataGridView中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvwEmp_AfterSelect(object sender, TreeViewEventArgs e)
        {
            BindDataGridView();
        }

        private void BindDataGridView()
        {
            if (tvwEmp.SelectedNode == null) // 如果在TreeView中没选节点，则什么也不做
                return;
            DataTable dt = null;
            EmployeeManager empMgr = new EmployeeManager();
            if (tvwEmp.SelectedNode.Level == 0) //在TreeView中选的是根节点
            {
                dt = empMgr.GetAllEmployees();
            }
            else if (tvwEmp.SelectedNode.Level == 1) //在TreeView中选的是一级子节点，即部门节点
            {
                int deptid = int.Parse(tvwEmp.SelectedNode.Tag.ToString()); // 获取所选节点的部门编号
                dt = empMgr.GetAllEmpByDeptID(deptid);
            }
            else if (tvwEmp.SelectedNode.Level == 2) //在TreeView中选的是二级子节点，即员工节点
            {
                int empid = int.Parse(tvwEmp.SelectedNode.Tag.ToString()); // 获取所选节点的员工编号
                dt = empMgr.GetEmployeeByIdofDataTable(empid);
            }

            //将表dt与DataGridView1进行绑定
            dataGridView1.DataSource = dt;
        }

        private void toolbtnSearch_Click(object sender, EventArgs e)
        {
            if (toolcbxSearchtype.SelectedIndex == -1)
            {
                UnitCommon.WarnMsg("请选择查询类别！");
                toolcbxSearchtype.Focus();
                return;
            }

            if (toolStripTextBox1.Text.Trim() == "")
            {
                UnitCommon.WarnMsg("请输入查询条件！");
                toolStripTextBox1.Focus();
                return;
            }

            string searchField = "";
            if (toolcbxSearchtype.Text.Trim() == "工号")
            {
                searchField = "empid";
            }
            else if (toolcbxSearchtype.Text.Trim() == "姓名")
            {
                searchField = "name";
            }
            else if (toolcbxSearchtype.Text.Trim() == "性别")
            {
                searchField = "sex";
            }
            else
            {
                searchField = "departname";
            }

            string cond = string.Format("{0}='{1}'", searchField, toolStripTextBox1.Text.Trim());
            EmployeeManager empMgr = new EmployeeManager();
            DataTable dt = empMgr.GetEmployeeByCondition(cond);
            dataGridView1.DataSource = dt;
        }

        /// <summary>
        /// 获取所有员工信息，并绑定在DataGridView中
        /// </summary>
        private void BindEmpInfo()
        {
            EmployeeManager empMgr = new EmployeeManager();
            DataTable dt = empMgr.GetAllEmployees();
            dataGridView1.DataSource = dt; //将表dt绑定在dataGridView中
        }

        private void toolbtnAll_Click(object sender, EventArgs e)
        {
            BindEmpInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1) // 代表控件tabControl1的第二个界面，新员工注册
            {
                Employee emp = new Employee();
                if (txtNewName.Text.Trim() == "")
                {
                    UnitCommon.WarnMsg("请输入新员工姓名！");
                    return;
                }
                else
                {
                    emp.Name = txtNewName.Text.Trim();
                    emp.Sex = rabFemale.Checked ? "女" : "男";
                    emp.Departid = int.Parse(cbxNewDepart.SelectedValue.ToString());

                    EmployeeManager empMgr = new EmployeeManager();
                    bool succ = empMgr.AddEmployee(emp);
                    if (succ)
                    {
                        BindEmpInfo(); //重新 刷新dataGridView
                        txtNewName.Text = ""; // 重新初始化为空
                        rabMale.Checked = true; // 默认勾选 男
                        cbxNewDepart.SelectedIndex = 0; // 下拉框ComoBox默认显示第一项
                        tabControl1.SelectedIndex = 0; // 默认显示控件tabControl1的第一个界面，员工信息
                        BuildEmpTree(); // 重新 刷新TreeView
                    }
                    else
                    {
                        UnitCommon.ErrorMsg("新员工注册失败！");
                        return;
                    }
                }

            }
            if (tabControl1.SelectedIndex == 2) //代表修改
            {
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                EmployeeManager empMgr = new EmployeeManager();
                Employee emp = empMgr.GetEmployeeById(id);
                if (emp != null)
                {
                    emp.Name = txtName.Text;
                    emp.Sex = rabBoy.Checked ? "男" : "女";
                    emp.Departid = int.Parse(cbxDepart.SelectedValue.ToString());

                    bool succ = empMgr.UpdateEmployee(emp);
                    if (succ)
                    {
                        BindEmpInfo(); //重新 刷新dataGridView
                        txtName.Text = "";
                        rabBoy.Checked = false; // 不勾选 男
                        rabGirl.Checked = false; // 不勾选 女
                        cbxDepart.SelectedIndex = -1; // 下拉框不显示下拉项值
                        tabControl1.SelectedIndex = 0; // 回到第一个界面，员工信息
                        BuildEmpTree(); //重新 刷新TreeView
                    }
                    else
                    {
                        UnitCommon.ErrorMsg("修改员工信息失败!");
                        return;
                    }

                }
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //当双击dataGridView1某行时，获取所选行(可能有多行)的第一行、第一列的值，即员工编号
            int id=int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            EmployeeManager empMgr=new EmployeeManager();
            Employee emp = empMgr.GetEmployeeById(id); // 通过id，查询该ID号员工
            if (emp != null)
            {
                //将emp的属性值赋给控件tabControl1的第三个界面，修改信息下的一些控件
                txtEmpNo.Text = emp.EmpId.ToString();
                txtName.Text = emp.Name;
                rabGirl.Checked = emp.Sex == "女";
                rabBoy.Checked = emp.Sex == "男";
                cbxDepart.SelectedValue = emp.Departid.ToString();  
                // 当双击dataGridView1某行时，切换到控件tabControl1的第三个界面，修改信息
                tabControl1.SelectedIndex = 2;
            }
        }

        private void cbxDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 如果选上控件tabControl1的第三个界面，修改信息
            if (tabControl1.SelectedIndex == 2) 
            {
                dataGridView1_CellDoubleClick(null,null);
            }
        }

        private void toolbtnDel_Click(object sender, EventArgs e)
        {
            if (UnitCommon.ConfirmMsg("您确定要删除此员工的信息吗?"))
            {
                tabControl1.SelectedIndex = 0; // 切换到tabControl1的第一个界面，员工信息
                //当双击dataGridView1某行时，获取所选行(可能有多行)的第一行、第一列的值，即员工编号
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                EmployeeManager empMgr=new EmployeeManager();
                empMgr.DelEmployee(id);
                int result =empMgr.DelEmployee(id);
                if (result == -1)
                {
                    UnitCommon.WarnMsg("该员工是仓库保管员，必须取消其仓管身份之后才请允许删除,删除失败!");
                    return;
                }

                if (result == -2)
                {
                    UnitCommon.WarnMsg("该员工领取的固定资产尚未归还，必须归还之后才允许删除,删除失败!");
                    return;
                }
                if (result > 0)
                {
                    BindDataGridView(); // 重新刷新DataGridView
                    BuildEmpTree(); // 重新刷新TreeView
                }
                else
                {
                    UnitCommon.ErrorMsg("删除员工信息失败！");
                }
            }
        }


    }

}

