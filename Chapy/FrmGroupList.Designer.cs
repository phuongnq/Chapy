﻿namespace Chapy
{
    partial class FrmGroupList
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
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btn_Delete = new DevComponents.DotNetBar.ButtonX();
            this.btn_Creat = new DevComponents.DotNetBar.ButtonX();
            this.btn_Edit = new DevComponents.DotNetBar.ButtonX();
            this.btn_Back = new DevComponents.DotNetBar.ButtonX();
            this.cbb_Schools = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Id});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(37, 64);
            this.dataGridViewX1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewX1.MultiSelect = false;
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.RowTemplate.Height = 21;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(514, 358);
            this.dataGridViewX1.TabIndex = 1;
            // 
            // btn_Delete
            // 
            this.btn_Delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Delete.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Delete.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_Delete.Location = new System.Drawing.Point(473, 430);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(72, 29);
            this.btn_Delete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Delete.Symbol = "";
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "削除";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Creat
            // 
            this.btn_Creat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Creat.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Creat.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_Creat.Location = new System.Drawing.Point(41, 478);
            this.btn_Creat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Creat.Name = "btn_Creat";
            this.btn_Creat.Size = new System.Drawing.Size(100, 40);
            this.btn_Creat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Creat.Symbol = "";
            this.btn_Creat.TabIndex = 3;
            this.btn_Creat.Text = "新規作成";
            this.btn_Creat.Click += new System.EventHandler(this.btn_Creat_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Edit.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Edit.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_Edit.Location = new System.Drawing.Point(189, 478);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(100, 40);
            this.btn_Edit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Edit.Symbol = "";
            this.btn_Edit.TabIndex = 4;
            this.btn_Edit.Text = "編集";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Back.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Back.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_Back.Location = new System.Drawing.Point(445, 478);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(100, 40);
            this.btn_Back.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Back.Symbol = "";
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "戻る";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
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
            this.cbb_Schools.Location = new System.Drawing.Point(41, 14);
            this.cbb_Schools.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_Schools.Name = "cbb_Schools";
            this.cbb_Schools.Size = new System.Drawing.Size(193, 24);
            this.cbb_Schools.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbb_Schools.TabIndex = 11;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Code";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "グループ名";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 290;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "略称";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 110;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Visible = false;
            this.Id.Width = 5;
            // 
            // FrmGroupList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(584, 542);
            this.Controls.Add(this.cbb_Schools);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Creat);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dataGridViewX1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmGroupList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "グループマスタ";
            this.Load += new System.EventHandler(this.FrmGroupList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.ButtonX btn_Delete;
        private DevComponents.DotNetBar.ButtonX btn_Creat;
        private DevComponents.DotNetBar.ButtonX btn_Edit;
        private DevComponents.DotNetBar.ButtonX btn_Back;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_Schools;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}