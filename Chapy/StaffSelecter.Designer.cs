namespace Chapy
{
    partial class StaffSelecter
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDropDown1 = new DevComponents.DotNetBar.Controls.TextBoxDropDown();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btn_SelectStaff = new DevComponents.DotNetBar.ButtonX();
            this.btn_Back = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewX1);
            this.groupBox1.Controls.Add(this.textBoxDropDown1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "職員選択";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "職種";
            // 
            // textBoxDropDown1
            // 
            // 
            // 
            // 
            this.textBoxDropDown1.BackgroundStyle.Class = "TextBoxBorder";
            this.textBoxDropDown1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxDropDown1.ButtonDropDown.Visible = true;
            this.textBoxDropDown1.Location = new System.Drawing.Point(90, 26);
            this.textBoxDropDown1.Name = "textBoxDropDown1";
            this.textBoxDropDown1.Size = new System.Drawing.Size(152, 18);
            this.textBoxDropDown1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.textBoxDropDown1.TabIndex = 1;
            this.textBoxDropDown1.Text = "";
            this.textBoxDropDown1.TextChanged += new System.EventHandler(this.textBoxDropDown1_TextChanged);
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(13, 56);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RowTemplate.Height = 21;
            this.dataGridViewX1.Size = new System.Drawing.Size(601, 270);
            this.dataGridViewX1.TabIndex = 2;
            // 
            // btn_SelectStaff
            // 
            this.btn_SelectStaff.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_SelectStaff.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_SelectStaff.Location = new System.Drawing.Point(375, 361);
            this.btn_SelectStaff.Name = "btn_SelectStaff";
            this.btn_SelectStaff.Size = new System.Drawing.Size(83, 33);
            this.btn_SelectStaff.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_SelectStaff.TabIndex = 1;
            this.btn_SelectStaff.Text = "選択";
            this.btn_SelectStaff.Click += new System.EventHandler(this.btn_SelectStaff_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Back.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Back.Location = new System.Drawing.Point(515, 361);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(83, 33);
            this.btn_Back.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "戻る";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // StaffSelecter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 415);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_SelectStaff);
            this.Controls.Add(this.groupBox1);
            this.Name = "StaffSelecter";
            this.Text = "職員選択";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxDropDown textBoxDropDown1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.ButtonX btn_SelectStaff;
        private DevComponents.DotNetBar.ButtonX btn_Back;
    }
}