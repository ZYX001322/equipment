namespace 资产管理系统.UI
{
    partial class frmEmployee
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.imgemp = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvwEmp = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpInfo = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpAdd = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxNewDepart = new System.Windows.Forms.ComboBox();
            this.rabMale = new System.Windows.Forms.RadioButton();
            this.rabFemale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpUpdate = new System.Windows.Forms.TabPage();
            this.cbxDepart = new System.Windows.Forms.ComboBox();
            this.rabBoy = new System.Windows.Forms.RadioButton();
            this.rabGirl = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolcbxSearchtype = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbtnAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbtnDel = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tbpAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbpUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgemp
            // 
            this.imgemp.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgemp.ImageStream")));
            this.imgemp.TransparentColor = System.Drawing.Color.Transparent;
            this.imgemp.Images.SetKeyName(0, "QuickVie.ico");
            this.imgemp.Images.SetKeyName(1, "writer01.ico");
            this.imgemp.Images.SetKeyName(2, "Big Boy.ico");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvwEmp);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(632, 414);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvwEmp
            // 
            this.tvwEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwEmp.ImageIndex = 0;
            this.tvwEmp.ImageList = this.imgemp;
            this.tvwEmp.Location = new System.Drawing.Point(0, 0);
            this.tvwEmp.Name = "tvwEmp";
            this.tvwEmp.SelectedImageIndex = 0;
            this.tvwEmp.Size = new System.Drawing.Size(162, 414);
            this.tvwEmp.TabIndex = 0;
            this.tvwEmp.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwEmp_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Location = new System.Drawing.Point(2, 362);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 52);
            this.panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(265, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(125, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 362);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpInfo);
            this.tabControl1.Controls.Add(this.tbpAdd);
            this.tabControl1.Controls.Add(this.tbpUpdate);
            this.tabControl1.Location = new System.Drawing.Point(-1, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(481, 334);
            this.tabControl1.TabIndex = 1;
            // 
            // tbpInfo
            // 
            this.tbpInfo.Controls.Add(this.dataGridView1);
            this.tbpInfo.Location = new System.Drawing.Point(4, 22);
            this.tbpInfo.Name = "tbpInfo";
            this.tbpInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInfo.Size = new System.Drawing.Size(473, 308);
            this.tbpInfo.TabIndex = 0;
            this.tbpInfo.Text = "员工信息";
            this.tbpInfo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNo,
            this.ColName,
            this.ColSex,
            this.ColDept});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(467, 302);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ColNo
            // 
            this.ColNo.DataPropertyName = "工号";
            this.ColNo.HeaderText = "编号";
            this.ColNo.Name = "ColNo";
            // 
            // ColName
            // 
            this.ColName.DataPropertyName = "姓名";
            this.ColName.HeaderText = "姓名";
            this.ColName.Name = "ColName";
            // 
            // ColSex
            // 
            this.ColSex.DataPropertyName = "性别";
            this.ColSex.HeaderText = "性别";
            this.ColSex.Name = "ColSex";
            // 
            // ColDept
            // 
            this.ColDept.DataPropertyName = "所在部门";
            this.ColDept.HeaderText = "所属部门";
            this.ColDept.Name = "ColDept";
            // 
            // tbpAdd
            // 
            this.tbpAdd.Controls.Add(this.pictureBox1);
            this.tbpAdd.Controls.Add(this.cbxNewDepart);
            this.tbpAdd.Controls.Add(this.rabMale);
            this.tbpAdd.Controls.Add(this.rabFemale);
            this.tbpAdd.Controls.Add(this.label5);
            this.tbpAdd.Controls.Add(this.txtNewName);
            this.tbpAdd.Controls.Add(this.label4);
            this.tbpAdd.Controls.Add(this.label2);
            this.tbpAdd.Location = new System.Drawing.Point(4, 22);
            this.tbpAdd.Name = "tbpAdd";
            this.tbpAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAdd.Size = new System.Drawing.Size(473, 308);
            this.tbpAdd.TabIndex = 1;
            this.tbpAdd.Text = "新员工注册";
            this.tbpAdd.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(275, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // cbxNewDepart
            // 
            this.cbxNewDepart.FormattingEnabled = true;
            this.cbxNewDepart.Location = new System.Drawing.Point(122, 173);
            this.cbxNewDepart.Name = "cbxNewDepart";
            this.cbxNewDepart.Size = new System.Drawing.Size(121, 20);
            this.cbxNewDepart.TabIndex = 12;
            // 
            // rabMale
            // 
            this.rabMale.AutoSize = true;
            this.rabMale.Checked = true;
            this.rabMale.Location = new System.Drawing.Point(174, 135);
            this.rabMale.Name = "rabMale";
            this.rabMale.Size = new System.Drawing.Size(35, 16);
            this.rabMale.TabIndex = 10;
            this.rabMale.TabStop = true;
            this.rabMale.Text = "男";
            this.rabMale.UseVisualStyleBackColor = true;
            // 
            // rabFemale
            // 
            this.rabFemale.AutoSize = true;
            this.rabFemale.Location = new System.Drawing.Point(122, 135);
            this.rabFemale.Name = "rabFemale";
            this.rabFemale.Size = new System.Drawing.Size(35, 16);
            this.rabFemale.TabIndex = 11;
            this.rabFemale.TabStop = true;
            this.rabFemale.Text = "女";
            this.rabFemale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "部门：";
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(122, 88);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(121, 21);
            this.txtNewName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "性别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "姓名：";
            // 
            // tbpUpdate
            // 
            this.tbpUpdate.Controls.Add(this.cbxDepart);
            this.tbpUpdate.Controls.Add(this.rabBoy);
            this.tbpUpdate.Controls.Add(this.rabGirl);
            this.tbpUpdate.Controls.Add(this.label3);
            this.tbpUpdate.Controls.Add(this.txtEmpNo);
            this.tbpUpdate.Controls.Add(this.txtName);
            this.tbpUpdate.Controls.Add(this.label6);
            this.tbpUpdate.Controls.Add(this.label9);
            this.tbpUpdate.Controls.Add(this.label7);
            this.tbpUpdate.Controls.Add(this.pictureBox2);
            this.tbpUpdate.Location = new System.Drawing.Point(4, 22);
            this.tbpUpdate.Name = "tbpUpdate";
            this.tbpUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUpdate.Size = new System.Drawing.Size(473, 308);
            this.tbpUpdate.TabIndex = 2;
            this.tbpUpdate.Text = "修改信息";
            this.tbpUpdate.UseVisualStyleBackColor = true;
            // 
            // cbxDepart
            // 
            this.cbxDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepart.FormattingEnabled = true;
            this.cbxDepart.Location = new System.Drawing.Point(130, 194);
            this.cbxDepart.Name = "cbxDepart";
            this.cbxDepart.Size = new System.Drawing.Size(121, 20);
            this.cbxDepart.TabIndex = 24;
            this.cbxDepart.SelectedIndexChanged += new System.EventHandler(this.cbxDepart_SelectedIndexChanged);
            // 
            // rabBoy
            // 
            this.rabBoy.AutoSize = true;
            this.rabBoy.Location = new System.Drawing.Point(184, 160);
            this.rabBoy.Name = "rabBoy";
            this.rabBoy.Size = new System.Drawing.Size(35, 16);
            this.rabBoy.TabIndex = 22;
            this.rabBoy.TabStop = true;
            this.rabBoy.Text = "男";
            this.rabBoy.UseVisualStyleBackColor = true;
            // 
            // rabGirl
            // 
            this.rabGirl.AutoSize = true;
            this.rabGirl.Location = new System.Drawing.Point(130, 160);
            this.rabGirl.Name = "rabGirl";
            this.rabGirl.Size = new System.Drawing.Size(35, 16);
            this.rabGirl.TabIndex = 23;
            this.rabGirl.TabStop = true;
            this.rabGirl.Text = "女";
            this.rabGirl.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "部门：";
            // 
            // txtEmpNo
            // 
            this.txtEmpNo.Enabled = false;
            this.txtEmpNo.Location = new System.Drawing.Point(130, 78);
            this.txtEmpNo.Name = "txtEmpNo";
            this.txtEmpNo.Size = new System.Drawing.Size(121, 21);
            this.txtEmpNo.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 121);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 21);
            this.txtName.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "性别：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "工号：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "姓名：";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(287, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolcbxSearchtype,
            this.toolStripSeparator2,
            this.toolStripTextBox1,
            this.toolStripSeparator3,
            this.toolbtnSearch,
            this.toolStripSeparator4,
            this.toolbtnAll,
            this.toolStripSeparator5,
            this.toolbtnDel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(458, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel1.Text = "条件查询：";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolcbxSearchtype
            // 
            this.toolcbxSearchtype.Items.AddRange(new object[] {
            "工号",
            "姓名",
            "性别",
            "所在部门"});
            this.toolcbxSearchtype.Name = "toolcbxSearchtype";
            this.toolcbxSearchtype.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolbtnSearch
            // 
            this.toolbtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnSearch.Image")));
            this.toolbtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnSearch.Name = "toolbtnSearch";
            this.toolbtnSearch.Size = new System.Drawing.Size(23, 22);
            this.toolbtnSearch.Text = "查询";
            this.toolbtnSearch.Click += new System.EventHandler(this.toolbtnSearch_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolbtnAll
            // 
            this.toolbtnAll.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnAll.Image")));
            this.toolbtnAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnAll.Name = "toolbtnAll";
            this.toolbtnAll.Size = new System.Drawing.Size(76, 22);
            this.toolbtnAll.Text = "所有员工";
            this.toolbtnAll.Click += new System.EventHandler(this.toolbtnAll_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolbtnDel
            // 
            this.toolbtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnDel.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnDel.Image")));
            this.toolbtnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnDel.Name = "toolbtnDel";
            this.toolbtnDel.Size = new System.Drawing.Size(23, 22);
            this.toolbtnDel.Text = "删除";
            this.toolbtnDel.Click += new System.EventHandler(this.toolbtnDel_Click);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(632, 414);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmEmployee";
            this.Text = "员工管理";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbpInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tbpAdd.ResumeLayout(false);
            this.tbpAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbpUpdate.ResumeLayout(false);
            this.tbpUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvwEmp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolcbxSearchtype;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolbtnSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolbtnAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolbtnDel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpInfo;
        private System.Windows.Forms.TabPage tbpAdd;
        private System.Windows.Forms.TabPage tbpUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbxNewDepart;
        private System.Windows.Forms.RadioButton rabMale;
        private System.Windows.Forms.RadioButton rabFemale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxDepart;
        private System.Windows.Forms.RadioButton rabBoy;
        private System.Windows.Forms.RadioButton rabGirl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList imgemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDept;
    }
}
