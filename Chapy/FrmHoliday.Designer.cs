namespace Chapy
{
    partial class FrmHoliday
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
            this.advTree1 = new DevComponents.AdvTree.AdvTree();
            this.Setting = new DevComponents.AdvTree.ColumnHeader();
            this.node_weeken = new DevComponents.AdvTree.Node();
            this.holiday = new DevComponents.AdvTree.Node();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calendarView = new DevComponents.DotNetBar.Schedule.CalendarView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_Name = new DevComponents.DotNetBar.LabelX();
            this.txt_Name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_Finish = new DevComponents.DotNetBar.ButtonX();
            this.btn_Save = new DevComponents.DotNetBar.ButtonX();
            this.cb_year = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // advTree1
            // 
            this.advTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.advTree1.AllowDrop = true;
            this.advTree1.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.advTree1.BackgroundStyle.Class = "TreeBorderKey";
            this.advTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.advTree1.Columns.Add(this.Setting);
            this.advTree1.Dock = System.Windows.Forms.DockStyle.Top;
            this.advTree1.Location = new System.Drawing.Point(3, 20);
            this.advTree1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.advTree1.Name = "advTree1";
            this.advTree1.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node_weeken,
            this.holiday});
            this.advTree1.NodesConnector = this.nodeConnector1;
            this.advTree1.NodeStyle = this.elementStyle1;
            this.advTree1.PathSeparator = ";";
            this.advTree1.SelectionBox = false;
            this.advTree1.Size = new System.Drawing.Size(108, 349);
            this.advTree1.Styles.Add(this.elementStyle1);
            this.advTree1.TabIndex = 0;
            this.advTree1.Text = "advTree1";
            this.advTree1.NodeClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.advTree1_NodeClick);
            // 
            // Setting
            // 
            this.Setting.Name = "Setting";
            this.Setting.Text = "設定";
            this.Setting.Width.Absolute = 150;
            // 
            // node_weeken
            // 
            this.node_weeken.Expanded = true;
            this.node_weeken.Name = "node_weeken";
            this.node_weeken.Text = "週末";
            // 
            // holiday
            // 
            this.holiday.Expanded = true;
            this.holiday.Name = "holiday";
            this.holiday.Text = "休日";
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calendarView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(114, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(894, 587);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "カレンダー";
            // 
            // calendarView
            // 
            this.calendarView.AutoScroll = true;
            this.calendarView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.calendarView.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calendarView.ContainerControlProcessDialogKey = true;
            this.calendarView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarView.Location = new System.Drawing.Point(3, 20);
            this.calendarView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calendarView.MultiUserTabHeight = 19;
            this.calendarView.Name = "calendarView";
            this.calendarView.SelectedView = DevComponents.DotNetBar.Schedule.eCalendarView.Year;
            this.calendarView.Size = new System.Drawing.Size(888, 563);
            this.calendarView.TabIndex = 0;
            this.calendarView.Text = "calendarView";
            this.calendarView.TimeIndicator.BorderColor = System.Drawing.Color.Empty;
            this.calendarView.TimeIndicator.Tag = null;
            this.calendarView.TimeSlotDuration = 30;
            this.calendarView.YearViewLinkView = DevComponents.DotNetBar.Schedule.eCalendarView.Year;
            this.calendarView.YearViewDrawDayBackground += new System.EventHandler<DevComponents.DotNetBar.Schedule.YearViewDrawDayBackgroundEventArgs>(this.calendarView_YearViewDrawDayBackground);
            this.calendarView.ItemClick += new System.EventHandler(this.calendarView_ItemClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.advTree1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 75);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(114, 587);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_Name);
            this.groupBox3.Controls.Add(this.txt_Name);
            this.groupBox3.Controls.Add(this.btn_Finish);
            this.groupBox3.Controls.Add(this.btn_Save);
            this.groupBox3.Controls.Add(this.cb_year);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(1008, 75);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // lb_Name
            // 
            // 
            // 
            // 
            this.lb_Name.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_Name.Location = new System.Drawing.Point(551, 27);
            this.lb_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(42, 26);
            this.lb_Name.TabIndex = 11;
            this.lb_Name.Text = "休日名";
            // 
            // txt_Name
            // 
            // 
            // 
            // 
            this.txt_Name.Border.Class = "TextBoxBorder";
            this.txt_Name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Name.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_Name.Location = new System.Drawing.Point(599, 30);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Name.MaxLength = 40;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(138, 23);
            this.txt_Name.TabIndex = 10;
            // 
            // btn_Finish
            // 
            this.btn_Finish.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Finish.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Finish.Location = new System.Drawing.Point(889, 26);
            this.btn_Finish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(90, 27);
            this.btn_Finish.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Finish.Symbol = "";
            this.btn_Finish.TabIndex = 6;
            this.btn_Finish.Text = "戻る";
            this.btn_Finish.Click += new System.EventHandler(this.btn_Finish_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Save.Location = new System.Drawing.Point(759, 24);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(89, 29);
            this.btn_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Save.Symbol = "";
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "保存";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cb_year
            // 
            this.cb_year.FormattingEnabled = true;
            this.cb_year.Location = new System.Drawing.Point(91, 26);
            this.cb_year.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_year.Name = "cb_year";
            this.cb_year.Size = new System.Drawing.Size(140, 23);
            this.cb_year.TabIndex = 4;
            this.cb_year.SelectedValueChanged += new System.EventHandler(this.cb_year_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "年";
            // 
            // FrmHoliday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmHoliday";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "休暇設定";
            this.Load += new System.EventHandler(this.FrmHoliday_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.AdvTree.AdvTree advTree1;
        private DevComponents.AdvTree.ColumnHeader Setting;
        private DevComponents.AdvTree.Node node_weeken;
        private DevComponents.AdvTree.Node holiday;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.LabelX lb_Name;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Name;
        private DevComponents.DotNetBar.ButtonX btn_Finish;
        private DevComponents.DotNetBar.ButtonX btn_Save;
        private System.Windows.Forms.ComboBox cb_year;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Schedule.CalendarView calendarView;
    }
}