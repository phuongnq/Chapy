namespace Chapy
{
    partial class FrmGroup
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Code = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Abbreviation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Register = new DevComponents.DotNetBar.ButtonX();
            this.btn_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ListStaff = new DevComponents.DotNetBar.ButtonX();
            this.btn_Delete = new DevComponents.DotNetBar.ButtonX();
            this.cbb_Schools = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "グループマスタコード";
            // 
            // txt_Code
            // 
            // 
            // 
            // 
            this.txt_Code.Border.Class = "TextBoxBorder";
            this.txt_Code.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Code.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Code.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_Code.Location = new System.Drawing.Point(170, 47);
            this.txt_Code.MaxLength = 2;
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(55, 23);
            this.txt_Code.TabIndex = 1;
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
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_Name.Location = new System.Drawing.Point(170, 88);
            this.txt_Name.MaxLength = 40;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(136, 23);
            this.txt_Name.TabIndex = 2;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "グループマスタ名称";
            // 
            // txt_Abbreviation
            // 
            // 
            // 
            // 
            this.txt_Abbreviation.Border.Class = "TextBoxBorder";
            this.txt_Abbreviation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Abbreviation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Abbreviation.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_Abbreviation.Location = new System.Drawing.Point(170, 128);
            this.txt_Abbreviation.MaxLength = 40;
            this.txt_Abbreviation.Name = "txt_Abbreviation";
            this.txt_Abbreviation.Size = new System.Drawing.Size(136, 23);
            this.txt_Abbreviation.TabIndex = 3;
            this.txt_Abbreviation.TextChanged += new System.EventHandler(this.txt_Abbreviation_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "グループマスタ略称";
            // 
            // btn_Register
            // 
            this.btn_Register.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Register.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Register.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_Register.Location = new System.Drawing.Point(240, 411);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(100, 32);
            this.btn_Register.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Register.Symbol = "";
            this.btn_Register.TabIndex = 6;
            this.btn_Register.Text = "登録";
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Cancel.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_Cancel.Location = new System.Drawing.Point(358, 411);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 32);
            this.btn_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Cancel.Symbol = "";
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "キャンセル";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(39, 195);
            this.dataGridViewX1.MultiSelect = false;
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RowTemplate.Height = 21;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(403, 197);
            this.dataGridViewX1.TabIndex = 5;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "コード";
            this.Column2.Name = "Column2";
            this.Column2.Width = 40;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "名前";
            this.Column3.Name = "Column3";
            this.Column3.Width = 260;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "性別";
            this.Column4.Name = "Column4";
            this.Column4.Width = 60;
            // 
            // btn_ListStaff
            // 
            this.btn_ListStaff.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ListStaff.BackColor = System.Drawing.Color.LightBlue;
            this.btn_ListStaff.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_ListStaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListStaff.Location = new System.Drawing.Point(39, 165);
            this.btn_ListStaff.Name = "btn_ListStaff";
            this.btn_ListStaff.Size = new System.Drawing.Size(87, 24);
            this.btn_ListStaff.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ListStaff.Symbol = "";
            this.btn_ListStaff.TabIndex = 4;
            this.btn_ListStaff.Text = "職員選択";
            this.btn_ListStaff.Click += new System.EventHandler(this.btn_ListStaff_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Delete.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Delete.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_Delete.Location = new System.Drawing.Point(39, 411);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(100, 32);
            this.btn_Delete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Delete.Symbol = "";
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "削除";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
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
            this.cbb_Schools.Location = new System.Drawing.Point(25, 11);
            this.cbb_Schools.Name = "cbb_Schools";
            this.cbb_Schools.Size = new System.Drawing.Size(166, 24);
            this.cbb_Schools.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbb_Schools.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(155, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(155, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(155, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "*";
            // 
            // FrmGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(476, 455);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbb_Schools);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_ListStaff);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.txt_Abbreviation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Code);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FrmGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "グループマスタ作成";
            this.Load += new System.EventHandler(this.FrmGroup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGroup_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
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
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.ButtonX btn_ListStaff;
        private DevComponents.DotNetBar.ButtonX btn_Delete;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_Schools;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}