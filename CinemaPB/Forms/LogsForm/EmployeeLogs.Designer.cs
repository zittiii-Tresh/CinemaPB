namespace CinemaPB.Forms.LogsForm
{
    partial class EmployeeLogs
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
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            this.printBTN = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel7 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel6 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel5 = new DevExpress.XtraEditors.SidePanel();
            this.gcEmployeeLogs = new DevExpress.XtraGrid.GridControl();
            this.gvEmployeeLogs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LogID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Activity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Authentication = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sidePanel1.SuspendLayout();
            this.sidePanel4.SuspendLayout();
            this.sidePanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployeeLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployeeLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.BorderThickness = 0;
            this.sidePanel1.Controls.Add(this.labelControl1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1442, 96);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(58, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(218, 37);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Employee Logs";
            // 
            // sidePanel2
            // 
            this.sidePanel2.BorderThickness = 0;
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel2.Location = new System.Drawing.Point(1389, 96);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(53, 646);
            this.sidePanel2.TabIndex = 1;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // sidePanel3
            // 
            this.sidePanel3.BorderThickness = 0;
            this.sidePanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel3.Location = new System.Drawing.Point(0, 96);
            this.sidePanel3.Name = "sidePanel3";
            this.sidePanel3.Size = new System.Drawing.Size(58, 646);
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
            this.sidePanel4.Location = new System.Drawing.Point(58, 609);
            this.sidePanel4.Name = "sidePanel4";
            this.sidePanel4.Size = new System.Drawing.Size(1331, 133);
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
            this.printBTN.Location = new System.Drawing.Point(1211, 28);
            this.printBTN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.printBTN.Name = "printBTN";
            this.printBTN.Padding = new System.Windows.Forms.Padding(2);
            this.printBTN.Size = new System.Drawing.Size(120, 50);
            this.printBTN.TabIndex = 24;
            this.printBTN.Text = "PRINT";
            // 
            // sidePanel7
            // 
            this.sidePanel7.BorderThickness = 0;
            this.sidePanel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel7.Location = new System.Drawing.Point(0, 78);
            this.sidePanel7.Name = "sidePanel7";
            this.sidePanel7.Size = new System.Drawing.Size(1331, 55);
            this.sidePanel7.TabIndex = 0;
            this.sidePanel7.Text = "sidePanel7";
            // 
            // sidePanel6
            // 
            this.sidePanel6.BorderThickness = 0;
            this.sidePanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel6.Location = new System.Drawing.Point(0, 0);
            this.sidePanel6.Name = "sidePanel6";
            this.sidePanel6.Size = new System.Drawing.Size(1331, 28);
            this.sidePanel6.TabIndex = 0;
            this.sidePanel6.Text = "sidePanel6";
            // 
            // sidePanel5
            // 
            this.sidePanel5.BorderThickness = 0;
            this.sidePanel5.Controls.Add(this.gcEmployeeLogs);
            this.sidePanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel5.Location = new System.Drawing.Point(58, 96);
            this.sidePanel5.Name = "sidePanel5";
            this.sidePanel5.Size = new System.Drawing.Size(1331, 513);
            this.sidePanel5.TabIndex = 4;
            this.sidePanel5.Text = "sidePanel5";
            // 
            // gcEmployeeLogs
            // 
            this.gcEmployeeLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcEmployeeLogs.Location = new System.Drawing.Point(0, 0);
            this.gcEmployeeLogs.MainView = this.gvEmployeeLogs;
            this.gcEmployeeLogs.Name = "gcEmployeeLogs";
            this.gcEmployeeLogs.Size = new System.Drawing.Size(1331, 513);
            this.gcEmployeeLogs.TabIndex = 0;
            this.gcEmployeeLogs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmployeeLogs});
            this.gcEmployeeLogs.Load += new System.EventHandler(this.gcEmployeeLogs_Load);
            // 
            // gvEmployeeLogs
            // 
            this.gvEmployeeLogs.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.LogID,
            this.Username,
            this.DateTime,
            this.Activity,
            this.Authentication});
            this.gvEmployeeLogs.GridControl = this.gcEmployeeLogs;
            this.gvEmployeeLogs.Name = "gvEmployeeLogs";
            // 
            // LogID
            // 
            this.LogID.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.LogID.AppearanceCell.Options.UseFont = true;
            this.LogID.AppearanceCell.Options.UseTextOptions = true;
            this.LogID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LogID.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogID.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.LogID.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogID.AppearanceHeader.Options.UseBackColor = true;
            this.LogID.AppearanceHeader.Options.UseFont = true;
            this.LogID.AppearanceHeader.Options.UseForeColor = true;
            this.LogID.AppearanceHeader.Options.UseTextOptions = true;
            this.LogID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LogID.Caption = "#";
            this.LogID.FieldName = "LogID";
            this.LogID.MinWidth = 25;
            this.LogID.Name = "LogID";
            this.LogID.OptionsColumn.AllowEdit = false;
            this.LogID.OptionsColumn.AllowFocus = false;
            this.LogID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.LogID.Visible = true;
            this.LogID.VisibleIndex = 0;
            this.LogID.Width = 78;
            // 
            // Username
            // 
            this.Username.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Username.AppearanceCell.Options.UseFont = true;
            this.Username.AppearanceCell.Options.UseTextOptions = true;
            this.Username.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Username.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Username.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.Username.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Username.AppearanceHeader.Options.UseBackColor = true;
            this.Username.AppearanceHeader.Options.UseFont = true;
            this.Username.AppearanceHeader.Options.UseForeColor = true;
            this.Username.AppearanceHeader.Options.UseTextOptions = true;
            this.Username.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Username.Caption = "Username";
            this.Username.FieldName = "Username";
            this.Username.MinWidth = 25;
            this.Username.Name = "Username";
            this.Username.OptionsColumn.AllowEdit = false;
            this.Username.OptionsColumn.AllowFocus = false;
            this.Username.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Username.Visible = true;
            this.Username.VisibleIndex = 1;
            this.Username.Width = 186;
            // 
            // DateTime
            // 
            this.DateTime.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.DateTime.AppearanceCell.Options.UseFont = true;
            this.DateTime.AppearanceCell.Options.UseTextOptions = true;
            this.DateTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DateTime.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DateTime.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.DateTime.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DateTime.AppearanceHeader.Options.UseBackColor = true;
            this.DateTime.AppearanceHeader.Options.UseFont = true;
            this.DateTime.AppearanceHeader.Options.UseForeColor = true;
            this.DateTime.AppearanceHeader.Options.UseTextOptions = true;
            this.DateTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DateTime.Caption = "Date/Time";
            this.DateTime.FieldName = "DateTime";
            this.DateTime.MinWidth = 25;
            this.DateTime.Name = "DateTime";
            this.DateTime.OptionsColumn.AllowEdit = false;
            this.DateTime.OptionsColumn.AllowFocus = false;
            this.DateTime.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.DateTime.Visible = true;
            this.DateTime.VisibleIndex = 2;
            this.DateTime.Width = 256;
            // 
            // Activity
            // 
            this.Activity.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic);
            this.Activity.AppearanceCell.ForeColor = System.Drawing.Color.Gray;
            this.Activity.AppearanceCell.Options.UseFont = true;
            this.Activity.AppearanceCell.Options.UseForeColor = true;
            this.Activity.AppearanceCell.Options.UseTextOptions = true;
            this.Activity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Activity.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Activity.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.Activity.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Activity.AppearanceHeader.Options.UseBackColor = true;
            this.Activity.AppearanceHeader.Options.UseFont = true;
            this.Activity.AppearanceHeader.Options.UseForeColor = true;
            this.Activity.AppearanceHeader.Options.UseTextOptions = true;
            this.Activity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Activity.Caption = "Activity";
            this.Activity.FieldName = "Activity";
            this.Activity.MinWidth = 25;
            this.Activity.Name = "Activity";
            this.Activity.OptionsColumn.AllowEdit = false;
            this.Activity.OptionsColumn.AllowFocus = false;
            this.Activity.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Activity.Visible = true;
            this.Activity.VisibleIndex = 4;
            this.Activity.Width = 335;
            // 
            // Authentication
            // 
            this.Authentication.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Authentication.AppearanceCell.Options.UseFont = true;
            this.Authentication.AppearanceCell.Options.UseTextOptions = true;
            this.Authentication.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Authentication.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Authentication.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.Authentication.AppearanceHeader.Options.UseBackColor = true;
            this.Authentication.AppearanceHeader.Options.UseFont = true;
            this.Authentication.AppearanceHeader.Options.UseTextOptions = true;
            this.Authentication.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Authentication.Caption = "Authentication";
            this.Authentication.FieldName = "Authentication";
            this.Authentication.MinWidth = 25;
            this.Authentication.Name = "Authentication";
            this.Authentication.OptionsColumn.AllowEdit = false;
            this.Authentication.OptionsColumn.AllowFocus = false;
            this.Authentication.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Authentication.Visible = true;
            this.Authentication.VisibleIndex = 3;
            this.Authentication.Width = 166;
            // 
            // EmployeeLogs
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidePanel5);
            this.Controls.Add(this.sidePanel4);
            this.Controls.Add(this.sidePanel3);
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.sidePanel1);
            this.Name = "EmployeeLogs";
            this.Size = new System.Drawing.Size(1442, 742);
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            this.sidePanel4.ResumeLayout(false);
            this.sidePanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployeeLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployeeLogs)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gcEmployeeLogs;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmployeeLogs;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn LogID;
        private DevExpress.XtraGrid.Columns.GridColumn Username;
        private DevExpress.XtraGrid.Columns.GridColumn DateTime;
        private DevExpress.XtraGrid.Columns.GridColumn Activity;
        private DevExpress.XtraGrid.Columns.GridColumn Authentication;
    }
}
