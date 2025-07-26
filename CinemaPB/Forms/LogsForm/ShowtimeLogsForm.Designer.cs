namespace CinemaPB.Forms.LogsForm
{
    partial class ShowtimeLogsForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowtimeLogsForm));
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            this.printBTN = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel7 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel6 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel5 = new DevExpress.XtraEditors.SidePanel();
            this.gcShowtimeLogs = new DevExpress.XtraGrid.GridControl();
            this.gvShowtimeLogs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LogID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ShowtimeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Activity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sidePanel1.SuspendLayout();
            this.sidePanel4.SuspendLayout();
            this.sidePanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcShowtimeLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvShowtimeLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.BorderThickness = 0;
            this.sidePanel1.Controls.Add(this.labelControl1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1236, 78);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(50, 37);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(171, 28);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Showtime Logs";
            // 
            // sidePanel2
            // 
            this.sidePanel2.BorderThickness = 0;
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel2.Location = new System.Drawing.Point(1191, 78);
            this.sidePanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(45, 525);
            this.sidePanel2.TabIndex = 1;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // sidePanel3
            // 
            this.sidePanel3.BorderThickness = 0;
            this.sidePanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel3.Location = new System.Drawing.Point(0, 78);
            this.sidePanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel3.Name = "sidePanel3";
            this.sidePanel3.Size = new System.Drawing.Size(50, 525);
            this.sidePanel3.TabIndex = 2;
            this.sidePanel3.Text = "sidePanel3";
            // 
            // sidePanel4
            // 
            this.sidePanel4.BorderThickness = 0;
            this.sidePanel4.Controls.Add(this.printBTN);
            this.sidePanel4.Controls.Add(this.sidePanel7);
            this.sidePanel4.Controls.Add(this.sidePanel6);
            this.sidePanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel4.Location = new System.Drawing.Point(50, 495);
            this.sidePanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel4.Name = "sidePanel4";
            this.sidePanel4.Size = new System.Drawing.Size(1141, 108);
            this.sidePanel4.TabIndex = 3;
            this.sidePanel4.Text = "sidePanel4";
            // 
            // printBTN
            // 
            this.printBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.printBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBTN.Appearance.Options.UseBackColor = true;
            this.printBTN.Appearance.Options.UseFont = true;
            this.printBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.printBTN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("printBTN.ImageOptions.SvgImage")));
            this.printBTN.Location = new System.Drawing.Point(1038, 23);
            this.printBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printBTN.Name = "printBTN";
            this.printBTN.Padding = new System.Windows.Forms.Padding(2);
            this.printBTN.Size = new System.Drawing.Size(103, 40);
            this.printBTN.TabIndex = 24;
            this.printBTN.Text = "PRINT";
            this.printBTN.Click += new System.EventHandler(this.printBTN_Click);
            // 
            // sidePanel7
            // 
            this.sidePanel7.BorderThickness = 0;
            this.sidePanel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel7.Location = new System.Drawing.Point(0, 63);
            this.sidePanel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel7.Name = "sidePanel7";
            this.sidePanel7.Size = new System.Drawing.Size(1141, 45);
            this.sidePanel7.TabIndex = 0;
            this.sidePanel7.Text = "sidePanel7";
            // 
            // sidePanel6
            // 
            this.sidePanel6.BorderThickness = 0;
            this.sidePanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel6.Location = new System.Drawing.Point(0, 0);
            this.sidePanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel6.Name = "sidePanel6";
            this.sidePanel6.Size = new System.Drawing.Size(1141, 23);
            this.sidePanel6.TabIndex = 0;
            this.sidePanel6.Text = "sidePanel6";
            // 
            // sidePanel5
            // 
            this.sidePanel5.BorderThickness = 0;
            this.sidePanel5.Controls.Add(this.gcShowtimeLogs);
            this.sidePanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel5.Location = new System.Drawing.Point(50, 78);
            this.sidePanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel5.Name = "sidePanel5";
            this.sidePanel5.Size = new System.Drawing.Size(1141, 417);
            this.sidePanel5.TabIndex = 4;
            this.sidePanel5.Text = "sidePanel5";
            // 
            // gcShowtimeLogs
            // 
            this.gcShowtimeLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcShowtimeLogs.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcShowtimeLogs.Location = new System.Drawing.Point(0, 0);
            this.gcShowtimeLogs.MainView = this.gvShowtimeLogs;
            this.gcShowtimeLogs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcShowtimeLogs.Name = "gcShowtimeLogs";
            this.gcShowtimeLogs.Size = new System.Drawing.Size(1141, 417);
            this.gcShowtimeLogs.TabIndex = 1;
            this.gcShowtimeLogs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvShowtimeLogs});
            this.gcShowtimeLogs.Load += new System.EventHandler(this.gcShowtimeLogs_Load);
            // 
            // gvShowtimeLogs
            // 
            this.gvShowtimeLogs.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.LogID,
            this.ShowtimeID,
            this.Username,
            this.DateTime,
            this.Activity});
            this.gvShowtimeLogs.DetailHeight = 284;
            this.gvShowtimeLogs.GridControl = this.gcShowtimeLogs;
            this.gvShowtimeLogs.Name = "gvShowtimeLogs";
            this.gvShowtimeLogs.OptionsEditForm.PopupEditFormWidth = 686;
            // 
            // LogID
            // 
            this.LogID.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogID.AppearanceCell.Options.UseFont = true;
            this.LogID.AppearanceCell.Options.UseTextOptions = true;
            this.LogID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LogID.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogID.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogID.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogID.AppearanceHeader.Options.UseBackColor = true;
            this.LogID.AppearanceHeader.Options.UseFont = true;
            this.LogID.AppearanceHeader.Options.UseForeColor = true;
            this.LogID.AppearanceHeader.Options.UseTextOptions = true;
            this.LogID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LogID.Caption = "#";
            this.LogID.FieldName = "LogID";
            this.LogID.MinWidth = 21;
            this.LogID.Name = "LogID";
            this.LogID.OptionsColumn.AllowEdit = false;
            this.LogID.OptionsColumn.AllowFocus = false;
            this.LogID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.LogID.Visible = true;
            this.LogID.VisibleIndex = 0;
            this.LogID.Width = 73;
            // 
            // ShowtimeID
            // 
            this.ShowtimeID.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowtimeID.AppearanceCell.Options.UseFont = true;
            this.ShowtimeID.AppearanceCell.Options.UseTextOptions = true;
            this.ShowtimeID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ShowtimeID.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ShowtimeID.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowtimeID.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.ShowtimeID.AppearanceHeader.Options.UseBackColor = true;
            this.ShowtimeID.AppearanceHeader.Options.UseFont = true;
            this.ShowtimeID.AppearanceHeader.Options.UseForeColor = true;
            this.ShowtimeID.AppearanceHeader.Options.UseTextOptions = true;
            this.ShowtimeID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ShowtimeID.Caption = "ShowtimeID";
            this.ShowtimeID.FieldName = "ShowtimeID";
            this.ShowtimeID.MinWidth = 21;
            this.ShowtimeID.Name = "ShowtimeID";
            this.ShowtimeID.OptionsColumn.AllowEdit = false;
            this.ShowtimeID.OptionsColumn.AllowFocus = false;
            this.ShowtimeID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ShowtimeID.Visible = true;
            this.ShowtimeID.VisibleIndex = 3;
            this.ShowtimeID.Width = 100;
            // 
            // Username
            // 
            this.Username.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.AppearanceCell.Options.UseFont = true;
            this.Username.AppearanceCell.Options.UseTextOptions = true;
            this.Username.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Username.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Username.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Username.AppearanceHeader.Options.UseBackColor = true;
            this.Username.AppearanceHeader.Options.UseFont = true;
            this.Username.AppearanceHeader.Options.UseForeColor = true;
            this.Username.AppearanceHeader.Options.UseTextOptions = true;
            this.Username.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Username.Caption = "Username";
            this.Username.FieldName = "Username";
            this.Username.MinWidth = 21;
            this.Username.Name = "Username";
            this.Username.OptionsColumn.AllowEdit = false;
            this.Username.OptionsColumn.AllowFocus = false;
            this.Username.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Username.Visible = true;
            this.Username.VisibleIndex = 1;
            this.Username.Width = 176;
            // 
            // DateTime
            // 
            this.DateTime.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime.AppearanceCell.Options.UseFont = true;
            this.DateTime.AppearanceCell.Options.UseTextOptions = true;
            this.DateTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DateTime.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DateTime.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DateTime.AppearanceHeader.Options.UseBackColor = true;
            this.DateTime.AppearanceHeader.Options.UseFont = true;
            this.DateTime.AppearanceHeader.Options.UseForeColor = true;
            this.DateTime.AppearanceHeader.Options.UseTextOptions = true;
            this.DateTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DateTime.Caption = "Date/Time";
            this.DateTime.FieldName = "DateTime";
            this.DateTime.MinWidth = 21;
            this.DateTime.Name = "DateTime";
            this.DateTime.OptionsColumn.AllowEdit = false;
            this.DateTime.OptionsColumn.AllowFocus = false;
            this.DateTime.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.DateTime.Visible = true;
            this.DateTime.VisibleIndex = 2;
            this.DateTime.Width = 180;
            // 
            // Activity
            // 
            this.Activity.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity.AppearanceCell.ForeColor = System.Drawing.Color.Gray;
            this.Activity.AppearanceCell.Options.UseFont = true;
            this.Activity.AppearanceCell.Options.UseForeColor = true;
            this.Activity.AppearanceCell.Options.UseTextOptions = true;
            this.Activity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Activity.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Activity.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Activity.AppearanceHeader.Options.UseBackColor = true;
            this.Activity.AppearanceHeader.Options.UseFont = true;
            this.Activity.AppearanceHeader.Options.UseForeColor = true;
            this.Activity.AppearanceHeader.Options.UseTextOptions = true;
            this.Activity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Activity.Caption = "Activity";
            this.Activity.FieldName = "Activity";
            this.Activity.MinWidth = 21;
            this.Activity.Name = "Activity";
            this.Activity.OptionsColumn.AllowEdit = false;
            this.Activity.OptionsColumn.AllowFocus = false;
            this.Activity.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Activity.Visible = true;
            this.Activity.VisibleIndex = 4;
            this.Activity.Width = 167;
            // 
            // ShowtimeLogsForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidePanel5);
            this.Controls.Add(this.sidePanel4);
            this.Controls.Add(this.sidePanel3);
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.sidePanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ShowtimeLogsForm";
            this.Size = new System.Drawing.Size(1236, 603);
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            this.sidePanel4.ResumeLayout(false);
            this.sidePanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcShowtimeLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvShowtimeLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.SidePanel sidePanel3;
        private DevExpress.XtraEditors.SidePanel sidePanel4;
        private DevExpress.XtraEditors.SidePanel sidePanel7;
        private DevExpress.XtraEditors.SidePanel sidePanel6;
        private DevExpress.XtraEditors.SidePanel sidePanel5;
        private DevExpress.XtraEditors.SimpleButton printBTN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcShowtimeLogs;
        private DevExpress.XtraGrid.Views.Grid.GridView gvShowtimeLogs;
        private DevExpress.XtraGrid.Columns.GridColumn LogID;
        private DevExpress.XtraGrid.Columns.GridColumn Username;
        private DevExpress.XtraGrid.Columns.GridColumn DateTime;
        private DevExpress.XtraGrid.Columns.GridColumn Activity;
        private DevExpress.XtraGrid.Columns.GridColumn ShowtimeID;
    }
}
