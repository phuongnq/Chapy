namespace Chapy
{
    partial class FrmStaffType
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Code = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Abbreviation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Register = new DevComponents.DotNetBar.ButtonX();
            this.btn_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.cbb_Schools = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "職種マスタコード ";
            // 
            // txt_Code
            // 
            // 
            // 
            // 
            this.txt_Code.Border.Class = "TextBoxBorder";
            this.txt_Code.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Code.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_Code.Location = new System.Drawing.Point(159, 60);
            this.txt_Code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Code.MaxLength = 2;
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(64, 23);
            this.txt_Code.TabIndex = 2;
            this.txt_Code.TextChanged += new System.EventHandler(this.txt_Code_TextChanged);
            this.txt_Code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Code_KeyPress);
            this.txt_Code.Leave += new System.EventHandler(this.txt_Code_Leave);
            // 
            // txt_Name
            // 
            // 
            // 
            // 
            this.txt_Name.Border.Class = "TextBoxBorder";
            this.txt_Name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Name.Location = new System.Drawing.Point(159, 106);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Name.MaxLength = 20;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(159, 23);
            this.txt_Name.TabIndex = 4;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "職種マスタ名称";
            // 
            // txt_Abbreviation
            // 
            // 
            // 
            // 
            this.txt_Abbreviation.Border.Class = "TextBoxBorder";
            this.txt_Abbreviation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Abbreviation.Location = new System.Drawing.Point(159, 156);
            this.txt_Abbreviation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Abbreviation.MaxLength = 20;
            this.txt_Abbreviation.Name = "txt_Abbreviation";
            this.txt_Abbreviation.Size = new System.Drawing.Size(159, 23);
            this.txt_Abbreviation.TabIndex = 6;
            this.txt_Abbreviation.TextChanged += new System.EventHandler(this.txt_Abbreviation_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "職種マスタ略称";
            // 
            // btn_Register
            // 
            this.btn_Register.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Register.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Register.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_Register.Location = new System.Drawing.Point(83, 218);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(98, 40);
            this.btn_Register.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Register.Symbol = "";
            this.btn_Register.TabIndex = 7;
            this.btn_Register.Text = "登録";
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Cancel.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_Cancel.Location = new System.Drawing.Point(270, 218);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(98, 40);
            this.btn_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Cancel.Symbol = "";
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "キャンセル";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // cbb_Schools
            // 
            this.cbb_Schools.DisplayMember = "Text";
            this.cbb_Schools.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Schools.DropDownHeight = 90;
            this.cbb_Schools.Enabled = false;
            this.cbb_Schools.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Schools.FormattingEnabled = true;
            this.cbb_Schools.IntegralHeight = false;
            this.cbb_Schools.ItemHeight = 18;
            this.cbb_Schools.Location = new System.Drawing.Point(29, 14);
            this.cbb_Schools.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_Schools.Name = "cbb_Schools";
            this.cbb_Schools.Size = new System.Drawing.Size(193, 24);
            this.cbb_Schools.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbb_Schools.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(141, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(141, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(141, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "*";
            // 
            // FrmStaffType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(476, 308);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbb_Schools);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.txt_Abbreviation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Code);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmStaffType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "職種マスタ作成";
            this.Load += new System.EventHandler(this.FrmStaffType_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmStaffType_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Code;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Name;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Abbreviation;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.ButtonX btn_Register;
        private DevComponents.DotNetBar.ButtonX btn_Cancel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_Schools;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}