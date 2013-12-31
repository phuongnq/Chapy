namespace Chapy
{
    partial class FrmTannin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_Name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Code = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_Term = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.DAT_GRI_VIW = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.学年 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学年名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.クラス = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.クラス名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.人数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.担任１ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.担任2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.担任3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.担任4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.担任5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.担任6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffId3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffId4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffId5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffId6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Save = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Back = new DevComponents.DotNetBar.ButtonX();
            this.cbb_Schools = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DAT_GRI_VIW)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            // 
            // 
            // 
            this.txt_Name.Border.Class = "TextBoxBorder";
            this.txt_Name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Name.Location = new System.Drawing.Point(311, 60);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Name.MaxLength = 40;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(147, 23);
            this.txt_Name.TabIndex = 22;
            // 
            // txt_Code
            // 
            // 
            // 
            // 
            this.txt_Code.Border.Class = "TextBoxBorder";
            this.txt_Code.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Code.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_Code.Location = new System.Drawing.Point(133, 28);
            this.txt_Code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Code.MaxLength = 4;
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(40, 23);
            this.txt_Code.TabIndex = 20;
            this.txt_Code.Leave += new System.EventHandler(this.txt_Code_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Term);
            this.groupBox1.Controls.Add(this.DAT_GRI_VIW);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.txt_Code);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(1003, 479);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // cb_Term
            // 
            this.cb_Term.DisplayMember = "Text";
            this.cb_Term.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Term.FormattingEnabled = true;
            this.cb_Term.ItemHeight = 17;
            this.cb_Term.Location = new System.Drawing.Point(133, 58);
            this.cb_Term.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_Term.Name = "cb_Term";
            this.cb_Term.Size = new System.Drawing.Size(140, 23);
            this.cb_Term.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_Term.TabIndex = 25;
            this.cb_Term.SelectedValueChanged += new System.EventHandler(this.cb_Term_SelectedValueChanged);
            // 
            // DAT_GRI_VIW
            // 
            this.DAT_GRI_VIW.AllowUserToDeleteRows = false;
            this.DAT_GRI_VIW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DAT_GRI_VIW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk,
            this.学年,
            this.学年名,
            this.クラス,
            this.クラス名,
            this.人数,
            this.担任１,
            this.担任2,
            this.担任3,
            this.担任4,
            this.担任5,
            this.担任6,
            this.staffId1,
            this.staffId2,
            this.staffId3,
            this.staffId4,
            this.staffId5,
            this.staffId6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DAT_GRI_VIW.DefaultCellStyle = dataGridViewCellStyle2;
            this.DAT_GRI_VIW.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DAT_GRI_VIW.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DAT_GRI_VIW.Location = new System.Drawing.Point(0, 130);
            this.DAT_GRI_VIW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DAT_GRI_VIW.Name = "DAT_GRI_VIW";
            this.DAT_GRI_VIW.Size = new System.Drawing.Size(1003, 349);
            this.DAT_GRI_VIW.TabIndex = 23;
            this.DAT_GRI_VIW.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DAT_GRI_VIW_CellDoubleClick);
            // 
            // chk
            // 
            this.chk.HeaderText = "";
            this.chk.Name = "chk";
            this.chk.Width = 40;
            // 
            // 学年
            // 
            this.学年.HeaderText = "学年";
            this.学年.Name = "学年";
            this.学年.Width = 40;
            // 
            // 学年名
            // 
            this.学年名.HeaderText = "学年名";
            this.学年名.Name = "学年名";
            // 
            // クラス
            // 
            this.クラス.HeaderText = "クラス";
            this.クラス.Name = "クラス";
            this.クラス.Width = 40;
            // 
            // クラス名
            // 
            this.クラス名.HeaderText = "クラス名";
            this.クラス名.Name = "クラス名";
            // 
            // 人数
            // 
            this.人数.HeaderText = "人数";
            this.人数.Name = "人数";
            this.人数.Width = 40;
            // 
            // 担任１
            // 
            this.担任１.HeaderText = "担任１";
            this.担任１.Name = "担任１";
            // 
            // 担任2
            // 
            this.担任2.HeaderText = "担任2";
            this.担任2.Name = "担任2";
            // 
            // 担任3
            // 
            this.担任3.HeaderText = "担任3";
            this.担任3.Name = "担任3";
            // 
            // 担任4
            // 
            this.担任4.HeaderText = "担任4";
            this.担任4.Name = "担任4";
            // 
            // 担任5
            // 
            this.担任5.HeaderText = "担任5";
            this.担任5.Name = "担任5";
            // 
            // 担任6
            // 
            this.担任6.HeaderText = "担任6";
            this.担任6.Name = "担任6";
            // 
            // staffId1
            // 
            this.staffId1.HeaderText = "staffId1";
            this.staffId1.Name = "staffId1";
            this.staffId1.Visible = false;
            // 
            // staffId2
            // 
            this.staffId2.HeaderText = "staffId2";
            this.staffId2.Name = "staffId2";
            this.staffId2.Visible = false;
            // 
            // staffId3
            // 
            this.staffId3.HeaderText = "staffId3";
            this.staffId3.Name = "staffId3";
            this.staffId3.Visible = false;
            // 
            // staffId4
            // 
            this.staffId4.HeaderText = "staffId4";
            this.staffId4.Name = "staffId4";
            this.staffId4.Visible = false;
            // 
            // staffId5
            // 
            this.staffId5.HeaderText = "staffId5";
            this.staffId5.Name = "staffId5";
            this.staffId5.Visible = false;
            // 
            // staffId6
            // 
            this.staffId6.HeaderText = "staffId6";
            this.staffId6.Name = "staffId6";
            this.staffId6.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "担任マスタコード";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "学年クラスマスタ";
            // 
            // btn_Save
            // 
            this.btn_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Save.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_Save.Location = new System.Drawing.Point(782, 540);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(100, 32);
            this.btn_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Save.Symbol = "";
            this.btn_Save.TabIndex = 24;
            this.btn_Save.Text = "登録";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Column13";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Column11";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Column10";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Column9";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Column8";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.HeaderText = "Column7";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Column6";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "クラス名";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "クラス";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "学年名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "学年";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(878, 438);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(87, 26);
            this.BtnInsert.TabIndex = 22;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Column12";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btn_Back
            // 
            this.btn_Back.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Back.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Back.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_Back.Location = new System.Drawing.Point(911, 540);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(100, 32);
            this.btn_Back.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Back.Symbol = "";
            this.btn_Back.TabIndex = 26;
            this.btn_Back.Text = "戻る";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // cbb_Schools
            // 
            this.cbb_Schools.DisplayMember = "Text";
            this.cbb_Schools.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Schools.DropDownHeight = 90;
            this.cbb_Schools.Enabled = false;
            this.cbb_Schools.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Schools.FormattingEnabled = true;
            this.cbb_Schools.IntegralHeight = false;
            this.cbb_Schools.ItemHeight = 18;
            this.cbb_Schools.Location = new System.Drawing.Point(9, 9);
            this.cbb_Schools.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_Schools.Name = "cbb_Schools";
            this.cbb_Schools.Size = new System.Drawing.Size(193, 24);
            this.cbb_Schools.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbb_Schools.TabIndex = 27;
            // 
            // FrmTannin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 585);
            this.Controls.Add(this.cbb_Schools);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnInsert);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTannin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTannins";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DAT_GRI_VIW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txt_Name;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Code;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DevComponents.DotNetBar.Controls.DataGridViewX DAT_GRI_VIW;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学年;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学年名;
        private System.Windows.Forms.DataGridViewTextBoxColumn クラス;
        private System.Windows.Forms.DataGridViewTextBoxColumn クラス名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 人数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 担任１;
        private System.Windows.Forms.DataGridViewTextBoxColumn 担任2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 担任3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 担任4;
        private System.Windows.Forms.DataGridViewTextBoxColumn 担任5;
        private System.Windows.Forms.DataGridViewTextBoxColumn 担任6;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffId2;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffId3;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffId4;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffId5;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffId6;
        private DevComponents.DotNetBar.ButtonX btn_Save;
        private DevComponents.DotNetBar.ButtonX btn_Back;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_Schools;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_Term;
    }
}