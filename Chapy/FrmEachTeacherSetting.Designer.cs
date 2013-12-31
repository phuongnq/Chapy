namespace Chapy
{
    partial class FrmEachTeacherSetting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnReg = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvStaff = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column8 = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDate = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbDate = new DevComponents.DotNetBar.LabelX();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbStaff = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDate)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnReg);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(557, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(449, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.Symbol = "";
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReg
            // 
            this.btnReg.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReg.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReg.Location = new System.Drawing.Point(368, 12);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 31);
            this.btnReg.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReg.Symbol = "";
            this.btnReg.TabIndex = 1;
            this.btnReg.Text = "登録";
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelX1.Location = new System.Drawing.Point(3, 20);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(129, 28);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "個別設定";
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToResizeColumns = false;
            this.dgvStaff.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaff.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvStaff.Location = new System.Drawing.Point(3, 54);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowHeadersVisible = false;
            this.dgvStaff.RowTemplate.Height = 21;
            this.dgvStaff.Size = new System.Drawing.Size(226, 329);
            this.dgvStaff.TabIndex = 1;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Staff";
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column8.Width = 220;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDate);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(232, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 386);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // dgvDate
            // 
            this.dgvDate.AllowUserToAddRows = false;
            this.dgvDate.AllowUserToResizeColumns = false;
            this.dgvDate.AllowUserToResizeRows = false;
            this.dgvDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDate.EnableHeadersVisualStyles = false;
            this.dgvDate.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDate.Location = new System.Drawing.Point(3, 62);
            this.dgvDate.Name = "dgvDate";
            this.dgvDate.RowHeadersVisible = false;
            this.dgvDate.RowTemplate.Height = 30;
            this.dgvDate.Size = new System.Drawing.Size(319, 321);
            this.dgvDate.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "月";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 45;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "火";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.Width = 45;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "水";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.Width = 45;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "木";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.Width = 45;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "金";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.Width = 45;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "土";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.Width = 45;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "日";
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.Width = 45;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbDate);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 43);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // lbDate
            // 
            // 
            // 
            // 
            this.lbDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbDate.Location = new System.Drawing.Point(6, 12);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(280, 23);
            this.lbDate.TabIndex = 0;
            this.lbDate.Text = "labelX2";
            this.lbDate.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvStaff);
            this.groupBox4.Controls.Add(this.lbStaff);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(0, 52);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 386);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // lbStaff
            // 
            // 
            // 
            // 
            this.lbStaff.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbStaff.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbStaff.Location = new System.Drawing.Point(3, 19);
            this.lbStaff.Name = "lbStaff";
            this.lbStaff.Size = new System.Drawing.Size(226, 35);
            this.lbStaff.TabIndex = 2;
            this.lbStaff.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // FrmEachTeacherSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 438);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmEachTeacherSetting";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDate)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvStaff;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.LabelX lbDate;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnReg;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevComponents.DotNetBar.LabelX lbStaff;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;

    }
}