namespace Chapy
{
    partial class FrmSchedule
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTimezone = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMethod3 = new DevComponents.DotNetBar.ButtonX();
            this.btnMethod2 = new DevComponents.DotNetBar.ButtonX();
            this.btnMethod1 = new DevComponents.DotNetBar.ButtonX();
            this.btnMethod0 = new DevComponents.DotNetBar.ButtonX();
            this.lblSchoolName = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonX9 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX8 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX7 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this.dgvSchedule = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimezone)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTimezone);
            this.groupBox1.Controls.Add(this.btnMethod3);
            this.groupBox1.Controls.Add(this.btnMethod2);
            this.groupBox1.Controls.Add(this.btnMethod1);
            this.groupBox1.Controls.Add(this.btnMethod0);
            this.groupBox1.Controls.Add(this.lblSchoolName);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgvTimezone
            // 
            this.dgvTimezone.AllowUserToAddRows = false;
            this.dgvTimezone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimezone.ColumnHeadersVisible = false;
            this.dgvTimezone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTimezone.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTimezone.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvTimezone.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTimezone.Location = new System.Drawing.Point(485, 18);
            this.dgvTimezone.Name = "dgvTimezone";
            this.dgvTimezone.RowHeadersVisible = false;
            this.dgvTimezone.RowTemplate.Height = 21;
            this.dgvTimezone.Size = new System.Drawing.Size(294, 113);
            this.dgvTimezone.TabIndex = 7;
            // 
            // Column3
            // 
            this.Column3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column3.HeaderText = "Color";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 40;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Name";
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Time";
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // btnMethod3
            // 
            this.btnMethod3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMethod3.Location = new System.Drawing.Point(345, 96);
            this.btnMethod3.Name = "btnMethod3";
            this.btnMethod3.Size = new System.Drawing.Size(75, 32);
            this.btnMethod3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMethod3.TabIndex = 6;
            this.btnMethod3.Text = "D パターン";
            this.btnMethod3.Click += new System.EventHandler(this.btnMethod_Click);
            // 
            // btnMethod2
            // 
            this.btnMethod2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMethod2.Location = new System.Drawing.Point(237, 96);
            this.btnMethod2.Name = "btnMethod2";
            this.btnMethod2.Size = new System.Drawing.Size(75, 32);
            this.btnMethod2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMethod2.TabIndex = 5;
            this.btnMethod2.Text = "C パターン";
            this.btnMethod2.Click += new System.EventHandler(this.btnMethod_Click);
            // 
            // btnMethod1
            // 
            this.btnMethod1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMethod1.Location = new System.Drawing.Point(129, 96);
            this.btnMethod1.Name = "btnMethod1";
            this.btnMethod1.Size = new System.Drawing.Size(75, 32);
            this.btnMethod1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMethod1.TabIndex = 4;
            this.btnMethod1.Text = "B パターン";
            this.btnMethod1.Click += new System.EventHandler(this.btnMethod_Click);
            // 
            // btnMethod0
            // 
            this.btnMethod0.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMethod0.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnMethod0.Location = new System.Drawing.Point(19, 96);
            this.btnMethod0.Name = "btnMethod0";
            this.btnMethod0.Size = new System.Drawing.Size(75, 32);
            this.btnMethod0.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMethod0.TabIndex = 3;
            this.btnMethod0.Text = "A パターン";
            this.btnMethod0.Click += new System.EventHandler(this.btnMethod_Click);
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // 
            // 
            this.lblSchoolName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSchoolName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSchoolName.Location = new System.Drawing.Point(169, 15);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(154, 23);
            this.lblSchoolName.TabIndex = 2;
            this.lblSchoolName.Text = "01. チャイルド幼稚園";
            this.lblSchoolName.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelX1.Location = new System.Drawing.Point(6, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(157, 30);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "シフト作成　＜予定＞";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonX9);
            this.groupBox2.Controls.Add(this.buttonX8);
            this.groupBox2.Controls.Add(this.buttonX7);
            this.groupBox2.Controls.Add(this.buttonX6);
            this.groupBox2.Controls.Add(this.buttonX5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(782, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // buttonX9
            // 
            this.buttonX9.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX9.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX9.Location = new System.Drawing.Point(604, 21);
            this.buttonX9.Name = "buttonX9";
            this.buttonX9.Size = new System.Drawing.Size(75, 42);
            this.buttonX9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX9.TabIndex = 4;
            this.buttonX9.Text = "戻る";
            this.buttonX9.Click += new System.EventHandler(this.buttonX9_Click);
            // 
            // buttonX8
            // 
            this.buttonX8.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX8.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX8.Font = new System.Drawing.Font("Meiryo", 10F);
            this.buttonX8.Location = new System.Drawing.Point(421, 21);
            this.buttonX8.Name = "buttonX8";
            this.buttonX8.Size = new System.Drawing.Size(75, 42);
            this.buttonX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX8.TabIndex = 3;
            this.buttonX8.Text = "キャンセル";
            // 
            // buttonX7
            // 
            this.buttonX7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX7.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX7.Font = new System.Drawing.Font("Meiryo", 10F);
            this.buttonX7.Location = new System.Drawing.Point(265, 21);
            this.buttonX7.Name = "buttonX7";
            this.buttonX7.Size = new System.Drawing.Size(75, 42);
            this.buttonX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX7.TabIndex = 2;
            this.buttonX7.Text = "登録";
            // 
            // buttonX6
            // 
            this.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX6.Font = new System.Drawing.Font("Meiryo", 10F);
            this.buttonX6.Location = new System.Drawing.Point(135, 21);
            this.buttonX6.Name = "buttonX6";
            this.buttonX6.Size = new System.Drawing.Size(75, 42);
            this.buttonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX6.TabIndex = 1;
            this.buttonX6.Text = "編集";
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX5.Font = new System.Drawing.Font("Meiryo", 10F);
            this.buttonX5.Location = new System.Drawing.Point(12, 21);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Size = new System.Drawing.Size(75, 42);
            this.buttonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX5.TabIndex = 0;
            this.buttonX5.Text = "実績作成";
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSchedule.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSchedule.EnableHeadersVisualStyles = false;
            this.dgvSchedule.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSchedule.Location = new System.Drawing.Point(0, 134);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowTemplate.Height = 21;
            this.dgvSchedule.Size = new System.Drawing.Size(782, 150);
            this.dgvSchedule.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "クラス";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "教師";
            this.Column2.Name = "Column2";
            // 
            // FrmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 374);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "FrmSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSchedule";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimezone)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX lblSchoolName;
        private DevComponents.DotNetBar.ButtonX btnMethod3;
        private DevComponents.DotNetBar.ButtonX btnMethod2;
        private DevComponents.DotNetBar.ButtonX btnMethod1;
        private DevComponents.DotNetBar.ButtonX btnMethod0;
        private DevComponents.DotNetBar.ButtonX buttonX8;
        private DevComponents.DotNetBar.ButtonX buttonX7;
        private DevComponents.DotNetBar.ButtonX buttonX6;
        private DevComponents.DotNetBar.ButtonX buttonX5;
        private DevComponents.DotNetBar.ButtonX buttonX9;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTimezone;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}