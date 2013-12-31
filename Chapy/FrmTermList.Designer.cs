namespace Chapy
{
    partial class FrmTermList
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.gridViewTermList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.radioBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btTerm_Delete = new DevComponents.DotNetBar.ButtonX();
            this.btnTerm_Create = new DevComponents.DotNetBar.ButtonX();
            this.btnTerm_Edit = new DevComponents.DotNetBar.ButtonX();
            this.btnTerm_Back = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTermList)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelX1.Location = new System.Drawing.Point(14, 14);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(101, 26);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "学年クラス";
            // 
            // gridViewTermList
            // 
            this.gridViewTermList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTermList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.radioBox,
            this.No,
            this.Column1});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewTermList.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridViewTermList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewTermList.Location = new System.Drawing.Point(33, 48);
            this.gridViewTermList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridViewTermList.Name = "gridViewTermList";
            this.gridViewTermList.Size = new System.Drawing.Size(466, 303);
            this.gridViewTermList.TabIndex = 2;
            this.gridViewTermList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewTermList_CellContentClick);
            // 
            // radioBox
            // 
            this.radioBox.HeaderText = "No.";
            this.radioBox.Name = "radioBox";
            this.radioBox.Width = 50;
            // 
            // No
            // 
            this.No.HeaderText = "学年クラスマスタ";
            this.No.Name = "No";
            this.No.Width = 350;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Width = 20;
            // 
            // btTerm_Delete
            // 
            this.btTerm_Delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btTerm_Delete.BackColor = System.Drawing.Color.LightBlue;
            this.btTerm_Delete.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btTerm_Delete.Location = new System.Drawing.Point(422, 359);
            this.btTerm_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btTerm_Delete.Name = "btTerm_Delete";
            this.btTerm_Delete.Size = new System.Drawing.Size(77, 26);
            this.btTerm_Delete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btTerm_Delete.Symbol = "";
            this.btTerm_Delete.TabIndex = 3;
            this.btTerm_Delete.Text = "削除";
            this.btTerm_Delete.Click += new System.EventHandler(this.btTerm_Delete_Click);
            // 
            // btnTerm_Create
            // 
            this.btnTerm_Create.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTerm_Create.AllowDrop = true;
            this.btnTerm_Create.BackColor = System.Drawing.Color.LightBlue;
            this.btnTerm_Create.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btnTerm_Create.Location = new System.Drawing.Point(33, 404);
            this.btnTerm_Create.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTerm_Create.Name = "btnTerm_Create";
            this.btnTerm_Create.Size = new System.Drawing.Size(108, 36);
            this.btnTerm_Create.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTerm_Create.Symbol = "";
            this.btnTerm_Create.TabIndex = 34;
            this.btnTerm_Create.Text = "新規作成";
            this.btnTerm_Create.Click += new System.EventHandler(this.btnTerm_Create_Click);
            // 
            // btnTerm_Edit
            // 
            this.btnTerm_Edit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTerm_Edit.AllowDrop = true;
            this.btnTerm_Edit.BackColor = System.Drawing.Color.LightBlue;
            this.btnTerm_Edit.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btnTerm_Edit.Location = new System.Drawing.Point(210, 404);
            this.btnTerm_Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTerm_Edit.Name = "btnTerm_Edit";
            this.btnTerm_Edit.Size = new System.Drawing.Size(108, 36);
            this.btnTerm_Edit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTerm_Edit.Symbol = "";
            this.btnTerm_Edit.TabIndex = 35;
            this.btnTerm_Edit.Text = "編集";
            this.btnTerm_Edit.Click += new System.EventHandler(this.btnTerm_Edit_Click);
            // 
            // btnTerm_Back
            // 
            this.btnTerm_Back.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTerm_Back.AllowDrop = true;
            this.btnTerm_Back.BackColor = System.Drawing.Color.LightBlue;
            this.btnTerm_Back.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btnTerm_Back.Location = new System.Drawing.Point(391, 408);
            this.btnTerm_Back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTerm_Back.Name = "btnTerm_Back";
            this.btnTerm_Back.Size = new System.Drawing.Size(108, 36);
            this.btnTerm_Back.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTerm_Back.Symbol = "";
            this.btnTerm_Back.TabIndex = 36;
            this.btnTerm_Back.Text = "戻る";
            this.btnTerm_Back.Click += new System.EventHandler(this.btnTerm_Back_Click);
            // 
            // FrmTermList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(544, 492);
            this.Controls.Add(this.btnTerm_Back);
            this.Controls.Add(this.btnTerm_Edit);
            this.Controls.Add(this.btnTerm_Create);
            this.Controls.Add(this.btTerm_Delete);
            this.Controls.Add(this.gridViewTermList);
            this.Controls.Add(this.labelX1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTermList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学年クラス";
            this.Load += new System.EventHandler(this.FrmTermList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTermList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX gridViewTermList;
        private System.Windows.Forms.DataGridViewTextBoxColumn radioBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private DevComponents.DotNetBar.ButtonX btTerm_Delete;
        private DevComponents.DotNetBar.ButtonX btnTerm_Create;
        private DevComponents.DotNetBar.ButtonX btnTerm_Edit;
        private DevComponents.DotNetBar.ButtonX btnTerm_Back;
    }
}