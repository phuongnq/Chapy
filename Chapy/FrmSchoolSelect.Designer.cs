namespace Chapy
{
    partial class FrmSchoolSelect
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
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbb_List_School = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btn_GoToMain = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 17;
            this.comboBoxEx1.Location = new System.Drawing.Point(269, 190);
            this.comboBoxEx1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(1, 23);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 0;
            // 
            // cbb_List_School
            // 
            this.cbb_List_School.DisplayMember = "Text";
            this.cbb_List_School.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_List_School.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_List_School.FormattingEnabled = true;
            this.cbb_List_School.ItemHeight = 23;
            this.cbb_List_School.Location = new System.Drawing.Point(83, 111);
            this.cbb_List_School.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_List_School.Name = "cbb_List_School";
            this.cbb_List_School.Size = new System.Drawing.Size(370, 29);
            this.cbb_List_School.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbb_List_School.TabIndex = 1;
            // 
            // btn_GoToMain
            // 
            this.btn_GoToMain.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_GoToMain.BackColor = System.Drawing.Color.LightBlue;
            this.btn_GoToMain.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_GoToMain.Location = new System.Drawing.Point(138, 181);
            this.btn_GoToMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_GoToMain.Name = "btn_GoToMain";
            this.btn_GoToMain.Size = new System.Drawing.Size(100, 32);
            this.btn_GoToMain.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_GoToMain.TabIndex = 2;
            this.btn_GoToMain.Text = "実行";
            this.btn_GoToMain.Click += new System.EventHandler(this.btn_GoToMain_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.BackColor = System.Drawing.Color.LightBlue;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.buttonX2.Location = new System.Drawing.Point(317, 181);
            this.buttonX2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(100, 32);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 3;
            this.buttonX2.Text = "キャンセル";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "施設を選択してください";
            // 
            // FrmSchoolSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(534, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.btn_GoToMain);
            this.Controls.Add(this.cbb_List_School);
            this.Controls.Add(this.comboBoxEx1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSchoolSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "チャッピー";
            this.Load += new System.EventHandler(this.FrmSchoolSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_List_School;
        private DevComponents.DotNetBar.ButtonX btn_GoToMain;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private System.Windows.Forms.Label label1;
    }
}