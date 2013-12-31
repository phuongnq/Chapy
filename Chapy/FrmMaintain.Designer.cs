namespace Chapy
{
    partial class FrmMaintain
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
            this.btn_Corporation = new DevComponents.DotNetBar.ButtonX();
            this.btn_CreatSchool = new DevComponents.DotNetBar.ButtonX();
            this.btn_TermList = new DevComponents.DotNetBar.ButtonX();
            this.btn_Building = new DevComponents.DotNetBar.ButtonX();
            this.btn_TanninMaster = new DevComponents.DotNetBar.ButtonX();
            this.btn_StaffType = new DevComponents.DotNetBar.ButtonX();
            this.btn_Position = new DevComponents.DotNetBar.ButtonX();
            this.btn_Group = new DevComponents.DotNetBar.ButtonX();
            this.btn_Calendar = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.rbMaintain_YearTypeJapanese = new System.Windows.Forms.RadioButton();
            this.rbMaintain_YearTypeWestern = new System.Windows.Forms.RadioButton();
            this.cbMaintain_JobType = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbMaintain_PositionType = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.rbMaintain_StaffCodeSort = new System.Windows.Forms.RadioButton();
            this.rbMaintain_StaffFuriganaSort = new System.Windows.Forms.RadioButton();
            this.rbMaintain_StaffBirthdaySort = new System.Windows.Forms.RadioButton();
            this.rbMaintain_StaffStartWorkSort = new System.Windows.Forms.RadioButton();
            this.rbMaintain_StaffMtoWSort = new System.Windows.Forms.RadioButton();
            this.rbMaintain_StaffWtoMSort = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.btn_Back = new DevComponents.DotNetBar.ButtonX();
            this.btn_Vacation = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpBoxMaintain_YearType = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rbMaintain_StaffMWSort = new System.Windows.Forms.RadioButton();
            this.grbxMaintain_StaffSort = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tbxStaff_Code = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.btnMaintain_Save = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpBoxMaintain_YearType.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.grbxMaintain_StaffSort.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Corporation
            // 
            this.btn_Corporation.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Corporation.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Corporation.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_Corporation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Corporation.Location = new System.Drawing.Point(36, 22);
            this.btn_Corporation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Corporation.Name = "btn_Corporation";
            this.btn_Corporation.Size = new System.Drawing.Size(160, 45);
            this.btn_Corporation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Corporation.TabIndex = 1;
            this.btn_Corporation.Text = "法人マスタ";
            this.btn_Corporation.Click += new System.EventHandler(this.btn_Corporation_Click);
            // 
            // btn_CreatSchool
            // 
            this.btn_CreatSchool.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_CreatSchool.BackColor = System.Drawing.Color.LightBlue;
            this.btn_CreatSchool.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_CreatSchool.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreatSchool.Location = new System.Drawing.Point(237, 22);
            this.btn_CreatSchool.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CreatSchool.Name = "btn_CreatSchool";
            this.btn_CreatSchool.Size = new System.Drawing.Size(160, 45);
            this.btn_CreatSchool.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_CreatSchool.TabIndex = 2;
            this.btn_CreatSchool.Text = "施設マスタ";
            this.btn_CreatSchool.Click += new System.EventHandler(this.btn_CreatSchool_Click);
            // 
            // btn_TermList
            // 
            this.btn_TermList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_TermList.BackColor = System.Drawing.Color.LightBlue;
            this.btn_TermList.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_TermList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TermList.Location = new System.Drawing.Point(36, 32);
            this.btn_TermList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_TermList.Name = "btn_TermList";
            this.btn_TermList.Size = new System.Drawing.Size(160, 45);
            this.btn_TermList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_TermList.TabIndex = 12;
            this.btn_TermList.Text = "学年クラスマスタ";
            this.btn_TermList.Click += new System.EventHandler(this.btn_TermList_Click);
            // 
            // btn_Building
            // 
            this.btn_Building.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Building.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Building.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_Building.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Building.Location = new System.Drawing.Point(36, 94);
            this.btn_Building.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Building.Name = "btn_Building";
            this.btn_Building.Size = new System.Drawing.Size(160, 45);
            this.btn_Building.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Building.TabIndex = 13;
            this.btn_Building.Text = "場所マスタ";
            this.btn_Building.Click += new System.EventHandler(this.btn_Building_Click);
            // 
            // btn_TanninMaster
            // 
            this.btn_TanninMaster.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_TanninMaster.BackColor = System.Drawing.Color.LightBlue;
            this.btn_TanninMaster.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_TanninMaster.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TanninMaster.Location = new System.Drawing.Point(237, 32);
            this.btn_TanninMaster.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_TanninMaster.Name = "btn_TanninMaster";
            this.btn_TanninMaster.Size = new System.Drawing.Size(160, 45);
            this.btn_TanninMaster.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_TanninMaster.TabIndex = 14;
            this.btn_TanninMaster.Text = "担任マスタ";
            this.btn_TanninMaster.Click += new System.EventHandler(this.btn_TanninMaster_Click);
            // 
            // btn_StaffType
            // 
            this.btn_StaffType.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_StaffType.BackColor = System.Drawing.Color.LightBlue;
            this.btn_StaffType.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_StaffType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StaffType.Location = new System.Drawing.Point(448, 32);
            this.btn_StaffType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_StaffType.Name = "btn_StaffType";
            this.btn_StaffType.Size = new System.Drawing.Size(160, 45);
            this.btn_StaffType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_StaffType.TabIndex = 15;
            this.btn_StaffType.Text = "職種マスタ";
            this.btn_StaffType.Click += new System.EventHandler(this.btn_StaffType_Click);
            // 
            // btn_Position
            // 
            this.btn_Position.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Position.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Position.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_Position.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Position.Location = new System.Drawing.Point(652, 32);
            this.btn_Position.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Position.Name = "btn_Position";
            this.btn_Position.Size = new System.Drawing.Size(160, 45);
            this.btn_Position.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Position.TabIndex = 16;
            this.btn_Position.Text = "職位マスタ";
            this.btn_Position.Click += new System.EventHandler(this.btn_Position_Click);
            // 
            // btn_Group
            // 
            this.btn_Group.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Group.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Group.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_Group.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Group.Location = new System.Drawing.Point(237, 94);
            this.btn_Group.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Group.Name = "btn_Group";
            this.btn_Group.Size = new System.Drawing.Size(160, 45);
            this.btn_Group.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Group.TabIndex = 17;
            this.btn_Group.Text = "グループマスタ";
            this.btn_Group.Click += new System.EventHandler(this.btn_Group_Click);
            // 
            // btn_Calendar
            // 
            this.btn_Calendar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Calendar.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Calendar.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_Calendar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calendar.Location = new System.Drawing.Point(448, 94);
            this.btn_Calendar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Calendar.Name = "btn_Calendar";
            this.btn_Calendar.Size = new System.Drawing.Size(160, 45);
            this.btn_Calendar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Calendar.TabIndex = 18;
            this.btn_Calendar.Text = "カレンダーマスタ";
            this.btn_Calendar.Click += new System.EventHandler(this.btn_Calendar_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelX3.Location = new System.Drawing.Point(27, 270);
            this.labelX3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(108, 35);
            this.labelX3.TabIndex = 20;
            this.labelX3.Text = "環境設定";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // rbMaintain_YearTypeJapanese
            // 
            this.rbMaintain_YearTypeJapanese.AutoSize = true;
            this.rbMaintain_YearTypeJapanese.Checked = true;
            this.rbMaintain_YearTypeJapanese.Location = new System.Drawing.Point(6, 24);
            this.rbMaintain_YearTypeJapanese.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMaintain_YearTypeJapanese.Name = "rbMaintain_YearTypeJapanese";
            this.rbMaintain_YearTypeJapanese.Size = new System.Drawing.Size(77, 19);
            this.rbMaintain_YearTypeJapanese.TabIndex = 24;
            this.rbMaintain_YearTypeJapanese.TabStop = true;
            this.rbMaintain_YearTypeJapanese.Text = "和歴表示";
            this.rbMaintain_YearTypeJapanese.UseVisualStyleBackColor = true;
            // 
            // rbMaintain_YearTypeWestern
            // 
            this.rbMaintain_YearTypeWestern.AutoSize = true;
            this.rbMaintain_YearTypeWestern.Location = new System.Drawing.Point(6, 63);
            this.rbMaintain_YearTypeWestern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMaintain_YearTypeWestern.Name = "rbMaintain_YearTypeWestern";
            this.rbMaintain_YearTypeWestern.Size = new System.Drawing.Size(77, 19);
            this.rbMaintain_YearTypeWestern.TabIndex = 25;
            this.rbMaintain_YearTypeWestern.Text = "西歴表示";
            this.rbMaintain_YearTypeWestern.UseVisualStyleBackColor = true;
            // 
            // cbMaintain_JobType
            // 
            // 
            // 
            // 
            this.cbMaintain_JobType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbMaintain_JobType.Checked = true;
            this.cbMaintain_JobType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMaintain_JobType.CheckValue = "Y";
            this.cbMaintain_JobType.Location = new System.Drawing.Point(22, 19);
            this.cbMaintain_JobType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMaintain_JobType.Name = "cbMaintain_JobType";
            this.cbMaintain_JobType.Size = new System.Drawing.Size(117, 26);
            this.cbMaintain_JobType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbMaintain_JobType.TabIndex = 31;
            this.cbMaintain_JobType.Text = "職類コード順";
            // 
            // cbMaintain_PositionType
            // 
            // 
            // 
            // 
            this.cbMaintain_PositionType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbMaintain_PositionType.Checked = true;
            this.cbMaintain_PositionType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMaintain_PositionType.CheckValue = "Y";
            this.cbMaintain_PositionType.Location = new System.Drawing.Point(23, 51);
            this.cbMaintain_PositionType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMaintain_PositionType.Name = "cbMaintain_PositionType";
            this.cbMaintain_PositionType.Size = new System.Drawing.Size(117, 26);
            this.cbMaintain_PositionType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbMaintain_PositionType.TabIndex = 32;
            this.cbMaintain_PositionType.Text = "職位コード順";
            // 
            // rbMaintain_StaffCodeSort
            // 
            this.rbMaintain_StaffCodeSort.AutoSize = true;
            this.rbMaintain_StaffCodeSort.Checked = true;
            this.rbMaintain_StaffCodeSort.Location = new System.Drawing.Point(40, 15);
            this.rbMaintain_StaffCodeSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMaintain_StaffCodeSort.Name = "rbMaintain_StaffCodeSort";
            this.rbMaintain_StaffCodeSort.Size = new System.Drawing.Size(93, 19);
            this.rbMaintain_StaffCodeSort.TabIndex = 33;
            this.rbMaintain_StaffCodeSort.TabStop = true;
            this.rbMaintain_StaffCodeSort.Text = "職員コード順";
            this.rbMaintain_StaffCodeSort.UseVisualStyleBackColor = true;
            // 
            // rbMaintain_StaffFuriganaSort
            // 
            this.rbMaintain_StaffFuriganaSort.AutoSize = true;
            this.rbMaintain_StaffFuriganaSort.Location = new System.Drawing.Point(41, 41);
            this.rbMaintain_StaffFuriganaSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMaintain_StaffFuriganaSort.Name = "rbMaintain_StaffFuriganaSort";
            this.rbMaintain_StaffFuriganaSort.Size = new System.Drawing.Size(75, 19);
            this.rbMaintain_StaffFuriganaSort.TabIndex = 34;
            this.rbMaintain_StaffFuriganaSort.Text = "フリガナ順";
            this.rbMaintain_StaffFuriganaSort.UseVisualStyleBackColor = true;
            this.rbMaintain_StaffFuriganaSort.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbMaintain_StaffBirthdaySort
            // 
            this.rbMaintain_StaffBirthdaySort.AutoSize = true;
            this.rbMaintain_StaffBirthdaySort.Location = new System.Drawing.Point(41, 68);
            this.rbMaintain_StaffBirthdaySort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMaintain_StaffBirthdaySort.Name = "rbMaintain_StaffBirthdaySort";
            this.rbMaintain_StaffBirthdaySort.Size = new System.Drawing.Size(90, 19);
            this.rbMaintain_StaffBirthdaySort.TabIndex = 35;
            this.rbMaintain_StaffBirthdaySort.Text = "生年月日順";
            this.rbMaintain_StaffBirthdaySort.UseVisualStyleBackColor = true;
            // 
            // rbMaintain_StaffStartWorkSort
            // 
            this.rbMaintain_StaffStartWorkSort.AutoSize = true;
            this.rbMaintain_StaffStartWorkSort.Location = new System.Drawing.Point(41, 98);
            this.rbMaintain_StaffStartWorkSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMaintain_StaffStartWorkSort.Name = "rbMaintain_StaffStartWorkSort";
            this.rbMaintain_StaffStartWorkSort.Size = new System.Drawing.Size(103, 19);
            this.rbMaintain_StaffStartWorkSort.TabIndex = 36;
            this.rbMaintain_StaffStartWorkSort.Text = "就職年月日順";
            this.rbMaintain_StaffStartWorkSort.UseVisualStyleBackColor = true;
            // 
            // rbMaintain_StaffMtoWSort
            // 
            this.rbMaintain_StaffMtoWSort.AutoSize = true;
            this.rbMaintain_StaffMtoWSort.Checked = true;
            this.rbMaintain_StaffMtoWSort.Location = new System.Drawing.Point(23, 19);
            this.rbMaintain_StaffMtoWSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMaintain_StaffMtoWSort.Name = "rbMaintain_StaffMtoWSort";
            this.rbMaintain_StaffMtoWSort.Size = new System.Drawing.Size(61, 19);
            this.rbMaintain_StaffMtoWSort.TabIndex = 37;
            this.rbMaintain_StaffMtoWSort.TabStop = true;
            this.rbMaintain_StaffMtoWSort.Text = "男→女";
            this.rbMaintain_StaffMtoWSort.UseVisualStyleBackColor = true;
            // 
            // rbMaintain_StaffWtoMSort
            // 
            this.rbMaintain_StaffWtoMSort.AutoSize = true;
            this.rbMaintain_StaffWtoMSort.Location = new System.Drawing.Point(23, 46);
            this.rbMaintain_StaffWtoMSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMaintain_StaffWtoMSort.Name = "rbMaintain_StaffWtoMSort";
            this.rbMaintain_StaffWtoMSort.Size = new System.Drawing.Size(61, 19);
            this.rbMaintain_StaffWtoMSort.TabIndex = 38;
            this.rbMaintain_StaffWtoMSort.Text = "女→男";
            this.rbMaintain_StaffWtoMSort.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(967, 564);
            this.radioButton9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(77, 19);
            this.radioButton9.TabIndex = 39;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "男女混合";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // btn_Back
            // 
            this.btn_Back.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Back.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Back.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_Back.Location = new System.Drawing.Point(881, 497);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(100, 45);
            this.btn_Back.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Back.TabIndex = 41;
            this.btn_Back.Text = "戻る";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Vacation
            // 
            this.btn_Vacation.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Vacation.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Vacation.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_Vacation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Vacation.Location = new System.Drawing.Point(652, 94);
            this.btn_Vacation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Vacation.Name = "btn_Vacation";
            this.btn_Vacation.Size = new System.Drawing.Size(160, 45);
            this.btn_Vacation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Vacation.TabIndex = 57;
            this.btn_Vacation.Text = "休暇マスタ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Corporation);
            this.groupBox1.Controls.Add(this.btn_CreatSchool);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1015, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "法人共通マスタ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonX1);
            this.groupBox2.Controls.Add(this.btn_Calendar);
            this.groupBox2.Controls.Add(this.btn_Vacation);
            this.groupBox2.Controls.Add(this.btn_StaffType);
            this.groupBox2.Controls.Add(this.btn_Position);
            this.groupBox2.Controls.Add(this.btn_Building);
            this.groupBox2.Controls.Add(this.btn_TanninMaster);
            this.groupBox2.Controls.Add(this.btn_Group);
            this.groupBox2.Controls.Add(this.btn_TermList);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 100);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1015, 162);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "各施設マスタ";
            // 
            // grpBoxMaintain_YearType
            // 
            this.grpBoxMaintain_YearType.Controls.Add(this.rbMaintain_YearTypeJapanese);
            this.grpBoxMaintain_YearType.Controls.Add(this.rbMaintain_YearTypeWestern);
            this.grpBoxMaintain_YearType.Location = new System.Drawing.Point(105, 307);
            this.grpBoxMaintain_YearType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxMaintain_YearType.Name = "grpBoxMaintain_YearType";
            this.grpBoxMaintain_YearType.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxMaintain_YearType.Size = new System.Drawing.Size(155, 115);
            this.grpBoxMaintain_YearType.TabIndex = 59;
            this.grpBoxMaintain_YearType.TabStop = false;
            this.grpBoxMaintain_YearType.Text = "年号表示";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.grbxMaintain_StaffSort);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(293, 307);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(749, 151);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "職員表示順";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rbMaintain_StaffMWSort);
            this.groupBox7.Controls.Add(this.rbMaintain_StaffMtoWSort);
            this.groupBox7.Controls.Add(this.rbMaintain_StaffWtoMSort);
            this.groupBox7.Location = new System.Drawing.Point(504, 24);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Size = new System.Drawing.Size(152, 102);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            // 
            // rbMaintain_StaffMWSort
            // 
            this.rbMaintain_StaffMWSort.AutoSize = true;
            this.rbMaintain_StaffMWSort.Location = new System.Drawing.Point(23, 75);
            this.rbMaintain_StaffMWSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMaintain_StaffMWSort.Name = "rbMaintain_StaffMWSort";
            this.rbMaintain_StaffMWSort.Size = new System.Drawing.Size(77, 19);
            this.rbMaintain_StaffMWSort.TabIndex = 39;
            this.rbMaintain_StaffMWSort.Text = "男女混合";
            this.rbMaintain_StaffMWSort.UseVisualStyleBackColor = true;
            // 
            // grbxMaintain_StaffSort
            // 
            this.grbxMaintain_StaffSort.Controls.Add(this.rbMaintain_StaffCodeSort);
            this.grbxMaintain_StaffSort.Controls.Add(this.rbMaintain_StaffFuriganaSort);
            this.grbxMaintain_StaffSort.Controls.Add(this.rbMaintain_StaffBirthdaySort);
            this.grbxMaintain_StaffSort.Controls.Add(this.rbMaintain_StaffStartWorkSort);
            this.grbxMaintain_StaffSort.Location = new System.Drawing.Point(225, 24);
            this.grbxMaintain_StaffSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbxMaintain_StaffSort.Name = "grbxMaintain_StaffSort";
            this.grbxMaintain_StaffSort.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbxMaintain_StaffSort.Size = new System.Drawing.Size(233, 122);
            this.grbxMaintain_StaffSort.TabIndex = 0;
            this.grbxMaintain_StaffSort.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbMaintain_JobType);
            this.groupBox5.Controls.Add(this.cbMaintain_PositionType);
            this.groupBox5.Location = new System.Drawing.Point(28, 24);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(160, 89);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Location = new System.Drawing.Point(59, 678);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox10.Size = new System.Drawing.Size(551, 58);
            this.groupBox10.TabIndex = 61;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "データのバックアップ先";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tbxStaff_Code);
            this.groupBox8.Controls.Add(this.buttonX2);
            this.groupBox8.Location = new System.Drawing.Point(51, 485);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(593, 57);
            this.groupBox8.TabIndex = 62;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "データバックアップ先";
            // 
            // tbxStaff_Code
            // 
            // 
            // 
            // 
            this.tbxStaff_Code.Border.Class = "TextBoxBorder";
            this.tbxStaff_Code.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxStaff_Code.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbxStaff_Code.Location = new System.Drawing.Point(98, 24);
            this.tbxStaff_Code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStaff_Code.MaxLength = 4;
            this.tbxStaff_Code.Name = "tbxStaff_Code";
            this.tbxStaff_Code.Size = new System.Drawing.Size(483, 23);
            this.tbxStaff_Code.TabIndex = 64;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.BackColor = System.Drawing.Color.LightBlue;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.buttonX2.Location = new System.Drawing.Point(22, 19);
            this.buttonX2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(62, 31);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 64;
            this.buttonX2.Text = "参照";
            // 
            // btnMaintain_Save
            // 
            this.btnMaintain_Save.AccessibleName = "";
            this.btnMaintain_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.btnMaintain_Save.BackColor = System.Drawing.Color.LightBlue;
            this.btnMaintain_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btnMaintain_Save.Location = new System.Drawing.Point(748, 497);
            this.btnMaintain_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMaintain_Save.Name = "btnMaintain_Save";
            this.btnMaintain_Save.Size = new System.Drawing.Size(100, 45);
            this.btnMaintain_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMaintain_Save.TabIndex = 63;
            this.btnMaintain_Save.Text = "登録";
            this.btnMaintain_Save.Click += new System.EventHandler(this.btnMaintain_Save_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.BackColor = System.Drawing.Color.LightBlue;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.buttonX1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(844, 32);
            this.buttonX1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(160, 45);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 58;
            this.buttonX1.Text = "就職制限マスタ";
            // 
            // FrmMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1054, 562);
            this.Controls.Add(this.btnMaintain_Save);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpBoxMaintain_YearType);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMaintain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "保守画面";
            this.Load += new System.EventHandler(this.FrmMaintain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.grpBoxMaintain_YearType.ResumeLayout(false);
            this.grpBoxMaintain_YearType.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.grbxMaintain_StaffSort.ResumeLayout(false);
            this.grbxMaintain_StaffSort.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn_Corporation;
        private DevComponents.DotNetBar.ButtonX btn_CreatSchool;
        private DevComponents.DotNetBar.ButtonX btn_TermList;
        private DevComponents.DotNetBar.ButtonX btn_Building;
        private DevComponents.DotNetBar.ButtonX btn_TanninMaster;
        private DevComponents.DotNetBar.ButtonX btn_StaffType;
        private DevComponents.DotNetBar.ButtonX btn_Position;
        private DevComponents.DotNetBar.ButtonX btn_Group;
        private DevComponents.DotNetBar.ButtonX btn_Calendar;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.RadioButton rbMaintain_YearTypeJapanese;
        private System.Windows.Forms.RadioButton rbMaintain_YearTypeWestern;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbMaintain_JobType;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbMaintain_PositionType;
        private System.Windows.Forms.RadioButton rbMaintain_StaffCodeSort;
        private System.Windows.Forms.RadioButton rbMaintain_StaffFuriganaSort;
        private System.Windows.Forms.RadioButton rbMaintain_StaffBirthdaySort;
        private System.Windows.Forms.RadioButton rbMaintain_StaffStartWorkSort;
        private System.Windows.Forms.RadioButton rbMaintain_StaffMtoWSort;
        private System.Windows.Forms.RadioButton rbMaintain_StaffWtoMSort;
        private System.Windows.Forms.RadioButton radioButton9;
        private DevComponents.DotNetBar.ButtonX btn_Back;
        private DevComponents.DotNetBar.ButtonX btn_Vacation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpBoxMaintain_YearType;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox grbxMaintain_StaffSort;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.RadioButton rbMaintain_StaffMWSort;
        private System.Windows.Forms.GroupBox groupBox8;
        private DevComponents.DotNetBar.ButtonX btnMaintain_Save;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxStaff_Code;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}