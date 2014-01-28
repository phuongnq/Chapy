namespace Chapy
{
    partial class FrmScheduleEdit
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
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnBack = new DevComponents.DotNetBar.ButtonX();
            this.dgvTimezone = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSchoolName = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTimeRange = new DevComponents.DotNetBar.LabelX();
            this.cmbSchedule = new System.Windows.Forms.ComboBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dgvSchedule = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimezone)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // Column2
            // 
            this.Column2.HeaderText = "教師";
            this.Column2.Name = "Column2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(351, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 90);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnEdit.Font = new System.Drawing.Font("Meiryo", 10F);
            this.btnEdit.Location = new System.Drawing.Point(6, 47);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 38);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.SubItemsExpandWidth = 10;
            this.btnEdit.Symbol = "";
            this.btnEdit.SymbolSize = 15F;
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "編集";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Meiryo", 10F);
            this.btnCancel.Location = new System.Drawing.Point(95, 47);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 38);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "キャンセル";
            // 
            // btnBack
            // 
            this.btnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBack.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBack.Location = new System.Drawing.Point(12, 26);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 46);
            this.btnBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBack.Symbol = "";
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "戻る";
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
            this.dgvTimezone.Location = new System.Drawing.Point(524, 18);
            this.dgvTimezone.Name = "dgvTimezone";
            this.dgvTimezone.RowHeadersVisible = false;
            this.dgvTimezone.RowTemplate.Height = 21;
            this.dgvTimezone.Size = new System.Drawing.Size(299, 90);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(826, 85);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "クラス";
            this.Column1.Name = "Column1";
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // 
            // 
            this.lblSchoolName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSchoolName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSchoolName.Location = new System.Drawing.Point(158, 18);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(154, 25);
            this.lblSchoolName.TabIndex = 2;
            this.lblSchoolName.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelX1.Location = new System.Drawing.Point(6, 13);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(157, 33);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "シフト作成　＜予定＞";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTimeRange);
            this.groupBox1.Controls.Add(this.cmbSchedule);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dgvTimezone);
            this.groupBox1.Controls.Add(this.lblSchoolName);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 111);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lbTimeRange
            // 
            // 
            // 
            // 
            this.lbTimeRange.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTimeRange.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbTimeRange.Location = new System.Drawing.Point(6, 80);
            this.lbTimeRange.Name = "lbTimeRange";
            this.lbTimeRange.Size = new System.Drawing.Size(339, 23);
            this.lbTimeRange.TabIndex = 21;
            this.lbTimeRange.Text = "平成25...";
            // 
            // cmbSchedule
            // 
            this.cmbSchedule.FormattingEnabled = true;
            this.cmbSchedule.Location = new System.Drawing.Point(71, 55);
            this.cmbSchedule.Name = "cmbSchedule";
            this.cmbSchedule.Size = new System.Drawing.Size(184, 21);
            this.cmbSchedule.TabIndex = 20;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelX3.Location = new System.Drawing.Point(6, 52);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(59, 25);
            this.labelX3.TabIndex = 19;
            this.labelX3.Text = "他のシフト";
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvSchedule.Cursor = System.Windows.Forms.Cursors.Default;
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
            this.dgvSchedule.Location = new System.Drawing.Point(0, 111);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowTemplate.Height = 21;
            this.dgvSchedule.Size = new System.Drawing.Size(826, 242);
            this.dgvSchedule.TabIndex = 5;
            // 
            // FrmScheduleEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 438);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "FrmScheduleEdit";
            this.Text = "FrmScheduleEdit";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimezone)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnBack;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTimezone;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private DevComponents.DotNetBar.LabelX lblSchoolName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSchedule;
        private System.Windows.Forms.ComboBox cmbSchedule;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX lbTimeRange;
    }
}