namespace 资产管理系统.UI
{
    partial class frmBaseInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaseInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMessge = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lstInfo = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddType = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUnit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClearType = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnKeepPlace = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMessge);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Controls.Add(this.lstInfo);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnAddType);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnUnit);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnClearType);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnKeepPlace);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnType);
            this.groupBox1.Controls.Add(this.btnName);
            this.groupBox1.Location = new System.Drawing.Point(39, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblMessge
            // 
            this.lblMessge.AutoSize = true;
            this.lblMessge.Location = new System.Drawing.Point(100, 41);
            this.lblMessge.Name = "lblMessge";
            this.lblMessge.Size = new System.Drawing.Size(0, 12);
            this.lblMessge.TabIndex = 22;
            // 
            // txtInput
            // 
            this.txtInput.Enabled = false;
            this.txtInput.Location = new System.Drawing.Point(148, 20);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(165, 21);
            this.txtInput.TabIndex = 21;
            // 
            // lstInfo
            // 
            this.lstInfo.FormattingEnabled = true;
            this.lstInfo.ItemHeight = 12;
            this.lstInfo.Location = new System.Drawing.Point(100, 59);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(213, 208);
            this.lstInfo.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(319, 101);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddType
            // 
            this.btnAddType.Location = new System.Drawing.Point(19, 166);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(75, 23);
            this.btnAddType.TabIndex = 17;
            this.btnAddType.Tag = "addType";
            this.btnAddType.Text = "增长方式";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.GetAllRes);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(319, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "取消添加";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUnit
            // 
            this.btnUnit.Location = new System.Drawing.Point(19, 244);
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.Size = new System.Drawing.Size(75, 23);
            this.btnUnit.TabIndex = 18;
            this.btnUnit.Tag = "unit";
            this.btnUnit.Text = "计量单位";
            this.btnUnit.UseVisualStyleBackColor = true;
            this.btnUnit.Click += new System.EventHandler(this.GetAllRes);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(319, 196);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 14;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClearType
            // 
            this.btnClearType.Location = new System.Drawing.Point(19, 206);
            this.btnClearType.Name = "btnClearType";
            this.btnClearType.Size = new System.Drawing.Size(75, 23);
            this.btnClearType.TabIndex = 19;
            this.btnClearType.Tag = "clearType";
            this.btnClearType.Text = "清理方式";
            this.btnClearType.UseVisualStyleBackColor = true;
            this.btnClearType.Click += new System.EventHandler(this.GetAllRes);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(319, 244);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnKeepPlace
            // 
            this.btnKeepPlace.Location = new System.Drawing.Point(19, 126);
            this.btnKeepPlace.Name = "btnKeepPlace";
            this.btnKeepPlace.Size = new System.Drawing.Size(75, 23);
            this.btnKeepPlace.TabIndex = 16;
            this.btnKeepPlace.Tag = "keepPlace";
            this.btnKeepPlace.Text = "保管地点";
            this.btnKeepPlace.UseVisualStyleBackColor = true;
            this.btnKeepPlace.Click += new System.EventHandler(this.GetAllRes);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(319, 59);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "添加新项";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnType
            // 
            this.btnType.Location = new System.Drawing.Point(19, 89);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(75, 23);
            this.btnType.TabIndex = 14;
            this.btnType.Tag = "eqType";
            this.btnType.Text = "资产类别";
            this.btnType.UseVisualStyleBackColor = true;
            this.btnType.Click += new System.EventHandler(this.GetAllRes);
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(19, 55);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 23);
            this.btnName.TabIndex = 15;
            this.btnName.Tag = "eqName";
            this.btnName.Text = "资产名称";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.GetAllRes);
            // 
            // frmBaseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 330);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBaseInfo";
            this.Tag = "eqName";
            this.Text = "资产基本信息";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUnit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnClearType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnKeepPlace;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblMessge;
    }
}