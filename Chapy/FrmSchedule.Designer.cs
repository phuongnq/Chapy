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
            this.lbTimeRange = new DevComponents.DotNetBar.LabelX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
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
            this.btnBack = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnYotei = new DevComponents.DotNetBar.ButtonX();
            this.dgvSchedule = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimezone)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTimeRange);
            this.groupBox1.Controls.Add(this.groupBox3);
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
            this.groupBox1.Size = new System.Drawing.Size(861, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbTimeRange
            // 
            // 
            // 
            // 
            this.lbTimeRange.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTimeRange.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbTimeRange.Location = new System.Drawing.Point(6, 48);
            this.lbTimeRange.Name = "lbTimeRange";
            this.lbTimeRange.Size = new System.Drawing.Size(366, 23);
            this.lbTimeRange.TabIndex = 9;
            this.lbTimeRange.Text = "平成25...";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(386, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 113);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnEdit.Font = new System.Drawing.Font("Meiryo", 10F);
            this.btnEdit.Location = new System.Drawing.Point(6, 72);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 35);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.SubItemsExpandWidth = 10;
            this.btnEdit.Symbol = "";
            this.btnEdit.SymbolSize = 15F;
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "編集";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Meiryo", 10F);
            this.btnCancel.Location = new System.Drawing.Point(95, 72);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 35);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.dgvTimezone.Location = new System.Drawing.Point(559, 18);
            this.dgvTimezone.Name = "dgvTimezone";
            this.dgvTimezone.RowHeadersVisible = false;
            this.dgvTimezone.RowTemplate.Height = 21;
            this.dgvTimezone.Size = new System.Drawing.Size(299, 113);
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
            this.btnMethod3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMethod3.Location = new System.Drawing.Point(249, 87);
            this.btnMethod3.Name = "btnMethod3";
            this.btnMethod3.Size = new System.Drawing.Size(75, 41);
            this.btnMethod3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMethod3.TabIndex = 6;
            this.btnMethod3.Text = "D パターン";
            this.btnMethod3.Click += new System.EventHandler(this.btnMethod_Click);
            // 
            // btnMethod2
            // 
            this.btnMethod2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMethod2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMethod2.Location = new System.Drawing.Point(168, 87);
            this.btnMethod2.Name = "btnMethod2";
            this.btnMethod2.Size = new System.Drawing.Size(75, 41);
            this.btnMethod2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMethod2.TabIndex = 5;
            this.btnMethod2.Text = "C パターン";
            this.btnMethod2.Click += new System.EventHandler(this.btnMethod_Click);
            // 
            // btnMethod1
            // 
            this.btnMethod1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMethod1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMethod1.Location = new System.Drawing.Point(87, 87);
            this.btnMethod1.Name = "btnMethod1";
            this.btnMethod1.Size = new System.Drawing.Size(75, 41);
            this.btnMethod1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMethod1.TabIndex = 4;
            this.btnMethod1.Text = "B パターン";
            this.btnMethod1.Click += new System.EventHandler(this.btnMethod_Click);
            // 
            // btnMethod0
            // 
            this.btnMethod0.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMethod0.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnMethod0.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMethod0.Location = new System.Drawing.Point(6, 87);
            this.btnMethod0.Name = "btnMethod0";
            this.btnMethod0.Size = new System.Drawing.Size(75, 41);
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
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnYotei);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(861, 78);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnBack
            // 
            this.btnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBack.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBack.Location = new System.Drawing.Point(249, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 42);
            this.btnBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBack.Symbol = "";
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "戻る";
            this.btnBack.Click += new System.EventHandler(this.buttonX9_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Font = new System.Drawing.Font("Meiryo", 10F);
            this.btnSave.Location = new System.Drawing.Point(142, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 42);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.Symbol = "";
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "登録";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnYotei
            // 
            this.btnYotei.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnYotei.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnYotei.Font = new System.Drawing.Font("Meiryo", 10F);
            this.btnYotei.Location = new System.Drawing.Point(12, 21);
            this.btnYotei.Name = "btnYotei";
            this.btnYotei.Size = new System.Drawing.Size(98, 42);
            this.btnYotei.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnYotei.Symbol = "";
            this.btnYotei.TabIndex = 0;
            this.btnYotei.Text = "予定シフト";
            this.btnYotei.Click += new System.EventHandler(this.btnYotei_Click);
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
            this.dgvSchedule.Location = new System.Drawing.Point(0, 134);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowTemplate.Height = 21;
            this.dgvSchedule.Size = new System.Drawing.Size(861, 162);
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
            this.ClientSize = new System.Drawing.Size(861, 374);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "FrmSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSchedule";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
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
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnYotei;
        private DevComponents.DotNetBar.ButtonX btnBack;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTimezone;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.LabelX lbTimeRange;
    }
}