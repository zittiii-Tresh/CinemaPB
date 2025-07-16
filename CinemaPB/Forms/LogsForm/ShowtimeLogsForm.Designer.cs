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
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            this.printBTN = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel7 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel6 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel5 = new DevExpress.XtraEditors.SidePanel();
            this.gcShowtimeLogs = new DevExpress.XtraGrid.GridControl();
            this.gvShowtimeLogs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
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
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1442, 96);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
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
            this.printBTN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("printBTN.ImageOptions.SvgImage")));
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
            this.sidePanel5.Controls.Add(this.gcShowtimeLogs);
            this.sidePanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel5.Location = new System.Drawing.Point(58, 96);
            this.sidePanel5.Name = "sidePanel5";
            this.sidePanel5.Size = new System.Drawing.Size(1331, 513);
            this.sidePanel5.TabIndex = 4;
            this.sidePanel5.Text = "sidePanel5";
            // 
            // gcShowtimeLogs
            // 
            this.gcShowtimeLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcShowtimeLogs.Location = new System.Drawing.Point(0, 0);
            this.gcShowtimeLogs.MainView = this.gvShowtimeLogs;
            this.gcShowtimeLogs.Name = "gcShowtimeLogs";
            this.gcShowtimeLogs.Size = new System.Drawing.Size(1331, 513);
            this.gcShowtimeLogs.TabIndex = 0;
            this.gcShowtimeLogs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvShowtimeLogs});
            // 
            // gvShowtimeLogs
            // 
            this.gvShowtimeLogs.GridControl = this.gcShowtimeLogs;
            this.gvShowtimeLogs.Name = "gvShowtimeLogs";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(58, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(213, 37);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Showtime Logs";
            // 
            // ShowtimeLogsForm
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
            this.Name = "ShowtimeLogsForm";
            this.Size = new System.Drawing.Size(1442, 742);
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
        private DevExpress.XtraGrid.GridControl gcShowtimeLogs;
        private DevExpress.XtraGrid.Views.Grid.GridView gvShowtimeLogs;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
