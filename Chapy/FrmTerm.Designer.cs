namespace Chapy
{
    partial class FrmTerm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbDrop_schoolName = new DevComponents.DotNetBar.Controls.TextBoxDropDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbdropbxTerm_Year = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnTerm_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.btnTerm_Save = new DevComponents.DotNetBar.ButtonX();
            this.txbTerm_className = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label6 = new System.Windows.Forms.Label();
            this.txbTerm_classCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTerm_gradeName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTerm_gradeCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTerm_termName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTerm_termCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridViewTerm_GradeClassList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTerm_deleteClass = new DevComponents.DotNetBar.ButtonX();
            this.btnTerm_Edit = new DevComponents.DotNetBar.ButtonX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.btnTerm_Back = new DevComponents.DotNetBar.ButtonX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTerm_StaffOfClassDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnTerm_StaffOfClassNew = new DevComponents.DotNetBar.ButtonX();
            this.dgvTerm_StaffList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ColStaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTerm_GradeClassList)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerm_StaffList)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDrop_schoolName
            // 
            // 
            // 
            // 
            this.tbDrop_schoolName.BackgroundStyle.Class = "TextBoxBorder";
            this.tbDrop_schoolName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbDrop_schoolName.ButtonDropDown.Visible = true;
            this.tbDrop_schoolName.Enabled = false;
            this.tbDrop_schoolName.Location = new System.Drawing.Point(30, 13);
            this.tbDrop_schoolName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDrop_schoolName.Name = "tbDrop_schoolName";
            this.tbDrop_schoolName.Size = new System.Drawing.Size(183, 22);
            this.tbDrop_schoolName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbDrop_schoolName.TabIndex = 0;
            this.tbDrop_schoolName.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbdropbxTerm_Year);
            this.groupBox1.Controls.Add(this.btnTerm_Cancel);
            this.groupBox1.Controls.Add(this.btnTerm_Save);
            this.groupBox1.Controls.Add(this.txbTerm_className);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txbTerm_classCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbTerm_gradeName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbTerm_gradeCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbTerm_termName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbTerm_termCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(449, 283);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(189, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(98, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(98, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "*";
            // 
            // tbdropbxTerm_Year
            // 
            this.tbdropbxTerm_Year.DisabledBackColor = System.Drawing.Color.Transparent;
            this.tbdropbxTerm_Year.DisabledForeColor = System.Drawing.Color.Transparent;
            this.tbdropbxTerm_Year.DisplayMember = "Text";
            this.tbdropbxTerm_Year.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tbdropbxTerm_Year.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdropbxTerm_Year.ForeColor = System.Drawing.Color.Black;
            this.tbdropbxTerm_Year.FormattingEnabled = true;
            this.tbdropbxTerm_Year.ItemHeight = 23;
            this.tbdropbxTerm_Year.Location = new System.Drawing.Point(116, 46);
            this.tbdropbxTerm_Year.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbdropbxTerm_Year.Name = "tbdropbxTerm_Year";
            this.tbdropbxTerm_Year.Size = new System.Drawing.Size(67, 29);
            this.tbdropbxTerm_Year.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbdropbxTerm_Year.TabIndex = 3;
            this.tbdropbxTerm_Year.SelectedIndexChanged += new System.EventHandler(this.tbdropbxTerm_Year_SelectedIndexChanged);
            this.tbdropbxTerm_Year.TextChanged += new System.EventHandler(this.tbdropbxTerm_Year_TextChanged);
            // 
            // btnTerm_Cancel
            // 
            this.btnTerm_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTerm_Cancel.BackColor = System.Drawing.Color.LightBlue;
            this.btnTerm_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btnTerm_Cancel.Location = new System.Drawing.Point(286, 235);
            this.btnTerm_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTerm_Cancel.Name = "btnTerm_Cancel";
            this.btnTerm_Cancel.Size = new System.Drawing.Size(100, 30);
            this.btnTerm_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTerm_Cancel.Symbol = "";
            this.btnTerm_Cancel.TabIndex = 14;
            this.btnTerm_Cancel.Text = "キャンセル";
            this.btnTerm_Cancel.Click += new System.EventHandler(this.btnTerm_Cancel_Click);
            // 
            // btnTerm_Save
            // 
            this.btnTerm_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTerm_Save.BackColor = System.Drawing.Color.LightBlue;
            this.btnTerm_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btnTerm_Save.Location = new System.Drawing.Point(37, 235);
            this.btnTerm_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTerm_Save.Name = "btnTerm_Save";
            this.btnTerm_Save.Size = new System.Drawing.Size(100, 30);
            this.btnTerm_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTerm_Save.Symbol = "";
            this.btnTerm_Save.TabIndex = 13;
            this.btnTerm_Save.Text = "登録";
            this.btnTerm_Save.Click += new System.EventHandler(this.btnTerm_Save_Click);
            // 
            // txbTerm_className
            // 
            // 
            // 
            // 
            this.txbTerm_className.Border.Class = "TextBoxBorder";
            this.txbTerm_className.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txbTerm_className.Location = new System.Drawing.Point(116, 200);
            this.txbTerm_className.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTerm_className.MaxLength = 40;
            this.txbTerm_className.Name = "txbTerm_className";
            this.txbTerm_className.Size = new System.Drawing.Size(168, 23);
            this.txbTerm_className.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "クラス名";
            // 
            // txbTerm_classCode
            // 
            // 
            // 
            // 
            this.txbTerm_classCode.Border.Class = "TextBoxBorder";
            this.txbTerm_classCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txbTerm_classCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txbTerm_classCode.Location = new System.Drawing.Point(116, 162);
            this.txbTerm_classCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTerm_classCode.MaxLength = 2;
            this.txbTerm_classCode.Name = "txbTerm_classCode";
            this.txbTerm_classCode.Size = new System.Drawing.Size(49, 23);
            this.txbTerm_classCode.TabIndex = 10;
            this.txbTerm_classCode.TextChanged += new System.EventHandler(this.txbTerm_classCode_TextChanged);
            this.txbTerm_classCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTerm_classCode_KeyPress);
            this.txbTerm_classCode.Leave += new System.EventHandler(this.txbTerm_classCode_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "クラスコード";
            // 
            // txbTerm_gradeName
            // 
            // 
            // 
            // 
            this.txbTerm_gradeName.Border.Class = "TextBoxBorder";
            this.txbTerm_gradeName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txbTerm_gradeName.Location = new System.Drawing.Point(115, 122);
            this.txbTerm_gradeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTerm_gradeName.MaxLength = 40;
            this.txbTerm_gradeName.Name = "txbTerm_gradeName";
            this.txbTerm_gradeName.Size = new System.Drawing.Size(168, 23);
            this.txbTerm_gradeName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "学年名";
            // 
            // txbTerm_gradeCode
            // 
            // 
            // 
            // 
            this.txbTerm_gradeCode.Border.Class = "TextBoxBorder";
            this.txbTerm_gradeCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txbTerm_gradeCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txbTerm_gradeCode.Location = new System.Drawing.Point(116, 83);
            this.txbTerm_gradeCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTerm_gradeCode.MaxLength = 2;
            this.txbTerm_gradeCode.Name = "txbTerm_gradeCode";
            this.txbTerm_gradeCode.Size = new System.Drawing.Size(49, 23);
            this.txbTerm_gradeCode.TabIndex = 6;
            this.txbTerm_gradeCode.TextChanged += new System.EventHandler(this.txbTerm_gradeCode_TextChanged);
            this.txbTerm_gradeCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTerm_gradeCode_KeyPress);
            this.txbTerm_gradeCode.Leave += new System.EventHandler(this.txbTerm_gradeCode_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "学年コード";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txbTerm_termName
            // 
            // 
            // 
            // 
            this.txbTerm_termName.Border.Class = "TextBoxBorder";
            this.txbTerm_termName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txbTerm_termName.Location = new System.Drawing.Point(207, 47);
            this.txbTerm_termName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTerm_termName.MaxLength = 40;
            this.txbTerm_termName.Name = "txbTerm_termName";
            this.txbTerm_termName.Size = new System.Drawing.Size(168, 23);
            this.txbTerm_termName.TabIndex = 4;
            this.txbTerm_termName.TextChanged += new System.EventHandler(this.txbTerm_termName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "年度選択";
            // 
            // txbTerm_termCode
            // 
            // 
            // 
            // 
            this.txbTerm_termCode.Border.Class = "TextBoxBorder";
            this.txbTerm_termCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txbTerm_termCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txbTerm_termCode.Location = new System.Drawing.Point(116, 12);
            this.txbTerm_termCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTerm_termCode.MaxLength = 5;
            this.txbTerm_termCode.Name = "txbTerm_termCode";
            this.txbTerm_termCode.Size = new System.Drawing.Size(49, 23);
            this.txbTerm_termCode.TabIndex = 1;
            this.txbTerm_termCode.TextChanged += new System.EventHandler(this.txbTerm_termCode_TextChanged);
            this.txbTerm_termCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTerm_termCode_KeyPress);
            this.txbTerm_termCode.Leave += new System.EventHandler(this.txbTerm_termCode_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "マスタコード";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridViewTerm_GradeClassList);
            this.groupBox2.Controls.Add(this.btnTerm_deleteClass);
            this.groupBox2.Controls.Add(this.btnTerm_Edit);
            this.groupBox2.Controls.Add(this.buttonX4);
            this.groupBox2.Location = new System.Drawing.Point(30, 327);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(942, 288);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // gridViewTerm_GradeClassList
            // 
            this.gridViewTerm_GradeClassList.AllowUserToAddRows = false;
            this.gridViewTerm_GradeClassList.AllowUserToDeleteRows = false;
            this.gridViewTerm_GradeClassList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTerm_GradeClassList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewTerm_GradeClassList.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewTerm_GradeClassList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewTerm_GradeClassList.HighlightSelectedColumnHeaders = false;
            this.gridViewTerm_GradeClassList.Location = new System.Drawing.Point(6, 12);
            this.gridViewTerm_GradeClassList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridViewTerm_GradeClassList.MultiSelect = false;
            this.gridViewTerm_GradeClassList.Name = "gridViewTerm_GradeClassList";
            this.gridViewTerm_GradeClassList.ReadOnly = true;
            this.gridViewTerm_GradeClassList.RowTemplate.Height = 21;
            this.gridViewTerm_GradeClassList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewTerm_GradeClassList.Size = new System.Drawing.Size(936, 221);
            this.gridViewTerm_GradeClassList.TabIndex = 17;
            this.gridViewTerm_GradeClassList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewTerm_GradeClassList_CellClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "学年コード";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "学年名";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 300;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "クラスコード";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "クラス名";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 335;
            // 
            // btnTerm_deleteClass
            // 
            this.btnTerm_deleteClass.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTerm_deleteClass.BackColor = System.Drawing.Color.LightBlue;
            this.btnTerm_deleteClass.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btnTerm_deleteClass.Location = new System.Drawing.Point(836, 241);
            this.btnTerm_deleteClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTerm_deleteClass.Name = "btnTerm_deleteClass";
            this.btnTerm_deleteClass.Size = new System.Drawing.Size(100, 30);
            this.btnTerm_deleteClass.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTerm_deleteClass.Symbol = "";
            this.btnTerm_deleteClass.TabIndex = 16;
            this.btnTerm_deleteClass.Text = "削除";
            this.btnTerm_deleteClass.Click += new System.EventHandler(this.btnTerm_deleteClass_Click);
            // 
            // btnTerm_Edit
            // 
            this.btnTerm_Edit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTerm_Edit.BackColor = System.Drawing.Color.LightBlue;
            this.btnTerm_Edit.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btnTerm_Edit.Location = new System.Drawing.Point(713, 241);
            this.btnTerm_Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTerm_Edit.Name = "btnTerm_Edit";
            this.btnTerm_Edit.Size = new System.Drawing.Size(100, 30);
            this.btnTerm_Edit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTerm_Edit.Symbol = "";
            this.btnTerm_Edit.TabIndex = 15;
            this.btnTerm_Edit.Text = "編集";
            this.btnTerm_Edit.Click += new System.EventHandler(this.btnTerm_Edit_Click);
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.BackColor = System.Drawing.Color.LightBlue;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.buttonX4.Location = new System.Drawing.Point(37, 241);
            this.buttonX4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(100, 30);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.TabIndex = 14;
            this.buttonX4.Text = "コピー";
            // 
            // btnTerm_Back
            // 
            this.btnTerm_Back.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTerm_Back.BackColor = System.Drawing.Color.LightBlue;
            this.btnTerm_Back.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btnTerm_Back.Location = new System.Drawing.Point(866, 623);
            this.btnTerm_Back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTerm_Back.Name = "btnTerm_Back";
            this.btnTerm_Back.Size = new System.Drawing.Size(100, 29);
            this.btnTerm_Back.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTerm_Back.Symbol = "";
            this.btnTerm_Back.TabIndex = 14;
            this.btnTerm_Back.Text = "戻る";
            this.btnTerm_Back.Click += new System.EventHandler(this.btnTerm_Back_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTerm_StaffOfClassDelete);
            this.groupBox3.Controls.Add(this.btnTerm_StaffOfClassNew);
            this.groupBox3.Controls.Add(this.dgvTerm_StaffList);
            this.groupBox3.Location = new System.Drawing.Point(495, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(477, 283);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // btnTerm_StaffOfClassDelete
            // 
            this.btnTerm_StaffOfClassDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTerm_StaffOfClassDelete.BackColor = System.Drawing.Color.LightBlue;
            this.btnTerm_StaffOfClassDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btnTerm_StaffOfClassDelete.Location = new System.Drawing.Point(135, 235);
            this.btnTerm_StaffOfClassDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTerm_StaffOfClassDelete.Name = "btnTerm_StaffOfClassDelete";
            this.btnTerm_StaffOfClassDelete.Size = new System.Drawing.Size(100, 30);
            this.btnTerm_StaffOfClassDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTerm_StaffOfClassDelete.Symbol = "";
            this.btnTerm_StaffOfClassDelete.TabIndex = 20;
            this.btnTerm_StaffOfClassDelete.Text = "削除";
            this.btnTerm_StaffOfClassDelete.Click += new System.EventHandler(this.btnTerm_StaffOfClassDelete_Click);
            // 
            // btnTerm_StaffOfClassNew
            // 
            this.btnTerm_StaffOfClassNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTerm_StaffOfClassNew.BackColor = System.Drawing.Color.LightBlue;
            this.btnTerm_StaffOfClassNew.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btnTerm_StaffOfClassNew.Location = new System.Drawing.Point(6, 235);
            this.btnTerm_StaffOfClassNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTerm_StaffOfClassNew.Name = "btnTerm_StaffOfClassNew";
            this.btnTerm_StaffOfClassNew.Size = new System.Drawing.Size(100, 30);
            this.btnTerm_StaffOfClassNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTerm_StaffOfClassNew.Symbol = "";
            this.btnTerm_StaffOfClassNew.TabIndex = 19;
            this.btnTerm_StaffOfClassNew.Text = "追加";
            this.btnTerm_StaffOfClassNew.Click += new System.EventHandler(this.btnTerm_StaffOfClassNew_Click);
            // 
            // dgvTerm_StaffList
            // 
            this.dgvTerm_StaffList.AllowUserToAddRows = false;
            this.dgvTerm_StaffList.AllowUserToDeleteRows = false;
            this.dgvTerm_StaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTerm_StaffList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColStaffName,
            this.jobType,
            this.staffId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTerm_StaffList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTerm_StaffList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTerm_StaffList.HighlightSelectedColumnHeaders = false;
            this.dgvTerm_StaffList.Location = new System.Drawing.Point(6, 14);
            this.dgvTerm_StaffList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTerm_StaffList.MultiSelect = false;
            this.dgvTerm_StaffList.Name = "dgvTerm_StaffList";
            this.dgvTerm_StaffList.ReadOnly = true;
            this.dgvTerm_StaffList.RowTemplate.Height = 21;
            this.dgvTerm_StaffList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTerm_StaffList.Size = new System.Drawing.Size(465, 204);
            this.dgvTerm_StaffList.TabIndex = 18;
            this.dgvTerm_StaffList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTerm_StaffList_CellDoubleClick);
            // 
            // ColStaffName
            // 
            this.ColStaffName.HeaderText = "担当者名";
            this.ColStaffName.Name = "ColStaffName";
            this.ColStaffName.ReadOnly = true;
            this.ColStaffName.Width = 125;
            // 
            // jobType
            // 
            this.jobType.HeaderText = "職種";
            this.jobType.Name = "jobType";
            this.jobType.ReadOnly = true;
            // 
            // staffId
            // 
            this.staffId.HeaderText = "";
            this.staffId.Name = "staffId";
            this.staffId.ReadOnly = true;
            this.staffId.Visible = false;
            // 
            // FrmTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnTerm_Back);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbDrop_schoolName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTerm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学年クラスマスタ";
            this.Load += new System.EventHandler(this.FrmTerm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTerm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTerm_GradeClassList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerm_StaffList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxDropDown tbDrop_schoolName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txbTerm_termCode;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX txbTerm_termName;
        private DevComponents.DotNetBar.Controls.TextBoxX txbTerm_gradeCode;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX txbTerm_gradeName;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.TextBoxX txbTerm_classCode;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.Controls.TextBoxX txbTerm_className;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.ButtonX btnTerm_Save;
        private DevComponents.DotNetBar.ButtonX btnTerm_Cancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.ButtonX btnTerm_Back;
        private DevComponents.DotNetBar.ButtonX btnTerm_deleteClass;
        private DevComponents.DotNetBar.ButtonX btnTerm_Edit;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.Controls.DataGridViewX gridViewTerm_GradeClassList;
        private DevComponents.DotNetBar.Controls.ComboBoxEx tbdropbxTerm_Year;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTerm_StaffList;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobType;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffId;
        private DevComponents.DotNetBar.ButtonX btnTerm_StaffOfClassDelete;
        private DevComponents.DotNetBar.ButtonX btnTerm_StaffOfClassNew;
    }
}