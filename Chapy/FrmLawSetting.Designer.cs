namespace Chapy
{
    partial class FrmLawSetting
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
            this.cbSchool = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new DevComponents.DotNetBar.ButtonX();
            this.btnReset = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMonthLimit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbWeekLimit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStaffType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSchool
            // 
            this.cbSchool.DisplayMember = "Text";
            this.cbSchool.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSchool.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSchool.FormattingEnabled = true;
            this.cbSchool.ItemHeight = 17;
            this.cbSchool.Location = new System.Drawing.Point(26, 15);
            this.cbSchool.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSchool.Name = "cbSchool";
            this.cbSchool.Size = new System.Drawing.Size(215, 23);
            this.cbSchool.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbSchool.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbMonthLimit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbWeekLimit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbStaffType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 322);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "法令設定";
            // 
            // btnBack
            // 
            this.btnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBack.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBack.Location = new System.Drawing.Point(460, 213);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 36);
            this.btnBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "戻る";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReset
            // 
            this.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReset.Location = new System.Drawing.Point(235, 213);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 36);
            this.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "リセット";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(67, 213);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 36);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "/回";
            // 
            // tbMonthLimit
            // 
            this.tbMonthLimit.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbMonthLimit.Border.Class = "TextBoxBorder";
            this.tbMonthLimit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbMonthLimit.ForeColor = System.Drawing.Color.Black;
            this.tbMonthLimit.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbMonthLimit.Location = new System.Drawing.Point(130, 120);
            this.tbMonthLimit.MaxLength = 2;
            this.tbMonthLimit.Name = "tbMonthLimit";
            this.tbMonthLimit.Size = new System.Drawing.Size(39, 23);
            this.tbMonthLimit.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "月出勤回数限定";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "/週";
            // 
            // tbWeekLimit
            // 
            this.tbWeekLimit.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbWeekLimit.Border.Class = "TextBoxBorder";
            this.tbWeekLimit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbWeekLimit.ForeColor = System.Drawing.Color.Black;
            this.tbWeekLimit.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbWeekLimit.Location = new System.Drawing.Point(130, 77);
            this.tbWeekLimit.MaxLength = 2;
            this.tbWeekLimit.Name = "tbWeekLimit";
            this.tbWeekLimit.Size = new System.Drawing.Size(39, 23);
            this.tbWeekLimit.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "週時間限定";
            // 
            // cbStaffType
            // 
            this.cbStaffType.DisplayMember = "Text";
            this.cbStaffType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStaffType.FormattingEnabled = true;
            this.cbStaffType.ItemHeight = 17;
            this.cbStaffType.Location = new System.Drawing.Point(130, 39);
            this.cbStaffType.Name = "cbStaffType";
            this.cbStaffType.Size = new System.Drawing.Size(157, 23);
            this.cbStaffType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbStaffType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "職種";
            // 
            // FrmLawSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 409);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbSchool);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLawSetting";
            this.Text = "法令設定";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLawSetting_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cbSchool;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbStaffType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX tbWeekLimit;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.TextBoxX tbMonthLimit;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.ButtonX btnReset;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnBack;
    }
}