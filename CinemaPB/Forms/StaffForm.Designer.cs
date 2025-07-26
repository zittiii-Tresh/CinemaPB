namespace CinemaPB.Forms
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.staffLBL = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.showtimehall1BTN = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.showtimehall2BTN = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.showtimelistACE = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mainSPanel = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.mainSPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.AllowDrop = true;
            this.accordionControl1.AllowElementDragging = true;
            this.accordionControl1.AllowItemSelection = true;
            this.accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.ElementPositionOnExpanding = DevExpress.XtraBars.Navigation.ElementPositionOnExpanding.Fixed;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.staffLBL,
            this.accordionControlSeparator1,
            this.accordionControlElement4,
            this.showtimelistACE});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.True;
            this.accordionControl1.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl1.Size = new System.Drawing.Size(284, 637);
            this.accordionControl1.TabIndex = 1;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement1.ImageOptions.SvgImage")));
            this.accordionControlElement1.ImageOptions.SvgImageSize = new System.Drawing.Size(210, 65);
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            // 
            // staffLBL
            // 
            this.staffLBL.Appearance.Default.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffLBL.Appearance.Default.ForeColor = System.Drawing.Color.White;
            this.staffLBL.Appearance.Default.Options.UseFont = true;
            this.staffLBL.Appearance.Default.Options.UseForeColor = true;
            this.staffLBL.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("staffLBL.ImageOptions.SvgImage")));
            this.staffLBL.ImageOptions.SvgImageSize = new System.Drawing.Size(55, 55);
            this.staffLBL.Name = "staffLBL";
            this.staffLBL.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.staffLBL.Text = "Staff";
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Appearance.Default.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement4.Appearance.Default.ForeColor = System.Drawing.Color.White;
            this.accordionControlElement4.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement4.Appearance.Default.Options.UseForeColor = true;
            this.accordionControlElement4.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.showtimehall1BTN,
            this.showtimehall2BTN});
            this.accordionControlElement4.Expanded = true;
            this.accordionControlElement4.HeaderIndent = 34;
            this.accordionControlElement4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement4.ImageOptions.Image")));
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Text = "Showtime Scheduling";
            // 
            // showtimehall1BTN
            // 
            this.showtimehall1BTN.Appearance.Default.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtimehall1BTN.Appearance.Default.ForeColor = System.Drawing.Color.White;
            this.showtimehall1BTN.Appearance.Default.Options.UseFont = true;
            this.showtimehall1BTN.Appearance.Default.Options.UseForeColor = true;
            this.showtimehall1BTN.Appearance.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.showtimehall1BTN.Appearance.Hovered.Options.UseBackColor = true;
            this.showtimehall1BTN.Appearance.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.showtimehall1BTN.Appearance.Pressed.Options.UseBackColor = true;
            this.showtimehall1BTN.HeaderIndent = 20;
            this.showtimehall1BTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("showtimehall1BTN.ImageOptions.Image")));
            this.showtimehall1BTN.Name = "showtimehall1BTN";
            this.showtimehall1BTN.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.showtimehall1BTN.Text = "Hall 1";
            this.showtimehall1BTN.Click += new System.EventHandler(this.showtimehall1BTN_Click);
            // 
            // showtimehall2BTN
            // 
            this.showtimehall2BTN.Appearance.Default.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtimehall2BTN.Appearance.Default.ForeColor = System.Drawing.Color.White;
            this.showtimehall2BTN.Appearance.Default.Options.UseFont = true;
            this.showtimehall2BTN.Appearance.Default.Options.UseForeColor = true;
            this.showtimehall2BTN.Appearance.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.showtimehall2BTN.Appearance.Hovered.Options.UseBackColor = true;
            this.showtimehall2BTN.Appearance.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.showtimehall2BTN.Appearance.Pressed.Options.UseBackColor = true;
            this.showtimehall2BTN.HeaderIndent = 20;
            this.showtimehall2BTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("showtimehall2BTN.ImageOptions.Image")));
            this.showtimehall2BTN.Name = "showtimehall2BTN";
            this.showtimehall2BTN.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.showtimehall2BTN.Text = "Hall 2";
            this.showtimehall2BTN.Click += new System.EventHandler(this.showtimehall2BTN_Click);
            // 
            // showtimelistACE
            // 
            this.showtimelistACE.Appearance.Default.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtimelistACE.Appearance.Default.ForeColor = System.Drawing.Color.White;
            this.showtimelistACE.Appearance.Default.Options.UseFont = true;
            this.showtimelistACE.Appearance.Default.Options.UseForeColor = true;
            this.showtimelistACE.HeaderIndent = 34;
            this.showtimelistACE.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("showtimelistACE.ImageOptions.SvgImage")));
            this.showtimelistACE.Name = "showtimelistACE";
            this.showtimelistACE.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.showtimelistACE.Text = "Showtime List";
            // 
            // mainSPanel
            // 
            this.mainSPanel.AllowResize = false;
            this.mainSPanel.BorderThickness = 0;
            this.mainSPanel.Controls.Add(this.sidePanel1);
            this.mainSPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSPanel.Location = new System.Drawing.Point(284, 0);
            this.mainSPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainSPanel.Name = "mainSPanel";
            this.mainSPanel.Size = new System.Drawing.Size(1033, 637);
            this.mainSPanel.TabIndex = 3;
            this.mainSPanel.Text = "sidePanel1";
            // 
            // sidePanel1
            // 
            this.sidePanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sidePanel1.BackgroundImage")));
            this.sidePanel1.BorderThickness = 0;
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(213, 637);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // StaffForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 637);
            this.Controls.Add(this.mainSPanel);
            this.Controls.Add(this.accordionControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("StaffForm.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.mainSPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement staffLBL;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement showtimehall1BTN;
        private DevExpress.XtraBars.Navigation.AccordionControlElement showtimehall2BTN;
        private DevExpress.XtraEditors.SidePanel mainSPanel;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement showtimelistACE;
    }
}