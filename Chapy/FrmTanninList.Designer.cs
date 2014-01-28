namespace Chapy
{
    partial class FrmTanninList
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
            this.BtnDelete = new DevComponents.DotNetBar.ButtonX();
            this.BtnBack = new DevComponents.DotNetBar.ButtonX();
            this.BtnEdit = new DevComponents.DotNetBar.ButtonX();
            this.BtnAdd = new DevComponents.DotNetBar.ButtonX();
            this.DAT_GRI_VIW = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTannin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DAT_GRI_VIW)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnDelete.BackColor = System.Drawing.Color.LightBlue;
            this.BtnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.BtnDelete.Location = new System.Drawing.Point(376, 353);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(65, 30);
            this.BtnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnDelete.Symbol = "";
            this.BtnDelete.TabIndex = 22;
            this.BtnDelete.Text = "削除";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnBack.BackColor = System.Drawing.Color.LightBlue;
            this.BtnBack.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.BtnBack.Location = new System.Drawing.Point(341, 406);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(100, 35);
            this.BtnBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnBack.Symbol = "";
            this.BtnBack.TabIndex = 21;
            this.BtnBack.Text = "戻る";
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnEdit.BackColor = System.Drawing.Color.LightBlue;
            this.BtnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.BtnEdit.Location = new System.Drawing.Point(136, 406);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(100, 35);
            this.BtnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnEdit.Symbol = "";
            this.BtnEdit.TabIndex = 20;
            this.BtnEdit.Text = "編集";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnAdd.BackColor = System.Drawing.Color.LightBlue;
            this.BtnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.BtnAdd.Location = new System.Drawing.Point(13, 406);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(100, 35);
            this.BtnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnAdd.Symbol = "";
            this.BtnAdd.TabIndex = 19;
            this.BtnAdd.Text = "追加";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DAT_GRI_VIW
            // 
            this.DAT_GRI_VIW.AllowUserToAddRows = false;
            this.DAT_GRI_VIW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DAT_GRI_VIW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk,
            this.No,
            this.NameTannin,
            this.ID});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DAT_GRI_VIW.DefaultCellStyle = dataGridViewCellStyle1;
            this.DAT_GRI_VIW.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DAT_GRI_VIW.Location = new System.Drawing.Point(13, 27);
            this.DAT_GRI_VIW.Name = "DAT_GRI_VIW";
            this.DAT_GRI_VIW.Size = new System.Drawing.Size(428, 320);
            this.DAT_GRI_VIW.TabIndex = 23;
            this.DAT_GRI_VIW.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DAT_GRI_VIW_CellBeginEdit_1);
            this.DAT_GRI_VIW.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DAT_GRI_VIW_CellContentClick);
            // 
            // chk
            // 
            this.chk.HeaderText = "";
            this.chk.Name = "chk";
            this.chk.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chk.Width = 40;
            // 
            // No
            // 
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.No.Width = 40;
            // 
            // NameTannin
            // 
            this.NameTannin.HeaderText = "担任マスタ名";
            this.NameTannin.Name = "NameTannin";
            this.NameTannin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NameTannin.Width = 300;
            // 
            // ID
            // 
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // FrmTanninList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 462);
            this.Controls.Add(this.DAT_GRI_VIW);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Name = "FrmTanninList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "担任一覧";
            this.Load += new System.EventHandler(this.FrmTanninList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DAT_GRI_VIW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX BtnDelete;
        private DevComponents.DotNetBar.ButtonX BtnBack;
        private DevComponents.DotNetBar.ButtonX BtnEdit;
        private DevComponents.DotNetBar.ButtonX BtnAdd;
        private DevComponents.DotNetBar.Controls.DataGridViewX DAT_GRI_VIW;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTannin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}