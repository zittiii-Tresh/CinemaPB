namespace CinemaPB.Forms
{
    partial class MoviesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoviesForm));
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.posterPE = new DevExpress.XtraEditors.PictureEdit();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            this.availabilityLC = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.availabilityTS = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.browseBTN = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel6 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel5 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel7 = new DevExpress.XtraEditors.SidePanel();
            this.moviegenreLUE = new DevExpress.XtraEditors.LookUpEdit();
            this.durationTE = new DevExpress.XtraEditors.TimeEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.movienameTE = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.movielanguageLUE = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.movieratingLUE = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.moviedescriptionTE = new DevExpress.XtraEditors.TextEdit();
            this.saveBTN = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel8 = new DevExpress.XtraEditors.SidePanel();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel9 = new DevExpress.XtraEditors.SidePanel();
            this.moviesGC = new DevExpress.XtraGrid.GridControl();
            this.moviesGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.moviedurationTE = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posterPE.Properties)).BeginInit();
            this.sidePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityTS.Properties)).BeginInit();
            this.sidePanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviegenreLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movienameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movielanguageLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieratingLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviedescriptionTE.Properties)).BeginInit();
            this.sidePanel8.SuspendLayout();
            this.sidePanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviedurationTE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sidePanel1.BorderThickness = 0;
            this.sidePanel1.Controls.Add(this.posterPE);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel1.Location = new System.Drawing.Point(42, 44);
            this.sidePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(562, 753);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // posterPE
            // 
            this.posterPE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("posterPE.BackgroundImage")));
            this.posterPE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.posterPE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.posterPE.EditValue = ((object)(resources.GetObject("posterPE.EditValue")));
            this.posterPE.Location = new System.Drawing.Point(0, 0);
            this.posterPE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.posterPE.Name = "posterPE";
            this.posterPE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(87)))));
            this.posterPE.Properties.Appearance.Options.UseBackColor = true;
            this.posterPE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.posterPE.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.posterPE.Size = new System.Drawing.Size(562, 753);
            this.posterPE.TabIndex = 0;
            // 
            // sidePanel2
            // 
            this.sidePanel2.AllowResize = false;
            this.sidePanel2.BorderThickness = 0;
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel2.Location = new System.Drawing.Point(0, 0);
            this.sidePanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(1365, 44);
            this.sidePanel2.TabIndex = 1;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // sidePanel3
            // 
            this.sidePanel3.AllowResize = false;
            this.sidePanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sidePanel3.BorderThickness = 0;
            this.sidePanel3.Controls.Add(this.availabilityLC);
            this.sidePanel3.Controls.Add(this.simpleButton6);
            this.sidePanel3.Controls.Add(this.simpleButton5);
            this.sidePanel3.Controls.Add(this.availabilityTS);
            this.sidePanel3.Controls.Add(this.labelControl1);
            this.sidePanel3.Controls.Add(this.browseBTN);
            this.sidePanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel3.Location = new System.Drawing.Point(0, 797);
            this.sidePanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel3.Name = "sidePanel3";
            this.sidePanel3.Size = new System.Drawing.Size(1365, 72);
            this.sidePanel3.TabIndex = 2;
            this.sidePanel3.Text = "sidePanel3";
            // 
            // availabilityLC
            // 
            this.availabilityLC.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availabilityLC.Appearance.ForeColor = System.Drawing.Color.White;
            this.availabilityLC.Appearance.Options.UseFont = true;
            this.availabilityLC.Appearance.Options.UseForeColor = true;
            this.availabilityLC.Location = new System.Drawing.Point(136, 24);
            this.availabilityLC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.availabilityLC.Name = "availabilityLC";
            this.availabilityLC.Size = new System.Drawing.Size(57, 16);
            this.availabilityLC.TabIndex = 19;
            this.availabilityLC.Text = "Available";
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton6.Appearance.Options.UseBackColor = true;
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.ImageOptions.Image")));
            this.simpleButton6.Location = new System.Drawing.Point(1104, 11);
            this.simpleButton6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Padding = new System.Windows.Forms.Padding(2);
            this.simpleButton6.Size = new System.Drawing.Size(102, 39);
            this.simpleButton6.TabIndex = 25;
            this.simpleButton6.Text = "Update";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.Options.UseBackColor = true;
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(1218, 11);
            this.simpleButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Padding = new System.Windows.Forms.Padding(2);
            this.simpleButton5.Size = new System.Drawing.Size(102, 39);
            this.simpleButton5.TabIndex = 24;
            this.simpleButton5.Text = "Delete";
            // 
            // availabilityTS
            // 
            this.availabilityTS.EditValue = true;
            this.availabilityTS.Location = new System.Drawing.Point(42, 15);
            this.availabilityTS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.availabilityTS.Name = "availabilityTS";
            this.availabilityTS.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availabilityTS.Properties.Appearance.Options.UseFont = true;
            this.availabilityTS.Properties.AutoHeight = false;
            this.availabilityTS.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.availabilityTS.Properties.OffText = "Off";
            this.availabilityTS.Properties.OnText = "On";
            this.availabilityTS.Properties.ThumbWidth = 10;
            this.availabilityTS.Size = new System.Drawing.Size(105, 35);
            this.availabilityTS.TabIndex = 2;
            this.availabilityTS.Toggled += new System.EventHandler(this.availabilityTS_Toggled);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(404, 28);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Upload Poster";
            // 
            // browseBTN
            // 
            this.browseBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.browseBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseBTN.Appearance.Options.UseBackColor = true;
            this.browseBTN.Appearance.Options.UseFont = true;
            this.browseBTN.Location = new System.Drawing.Point(516, 23);
            this.browseBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.browseBTN.Name = "browseBTN";
            this.browseBTN.Size = new System.Drawing.Size(88, 28);
            this.browseBTN.TabIndex = 0;
            this.browseBTN.Text = "Browse";
            this.browseBTN.Click += new System.EventHandler(this.browseBTN_Click);
            // 
            // sidePanel4
            // 
            this.sidePanel4.AllowResize = false;
            this.sidePanel4.BorderThickness = 0;
            this.sidePanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel4.Location = new System.Drawing.Point(0, 44);
            this.sidePanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel4.Name = "sidePanel4";
            this.sidePanel4.Size = new System.Drawing.Size(42, 753);
            this.sidePanel4.TabIndex = 3;
            this.sidePanel4.Text = "sidePanel4";
            // 
            // sidePanel6
            // 
            this.sidePanel6.AllowResize = false;
            this.sidePanel6.BorderThickness = 0;
            this.sidePanel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel6.Location = new System.Drawing.Point(1327, 44);
            this.sidePanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel6.Name = "sidePanel6";
            this.sidePanel6.Size = new System.Drawing.Size(38, 753);
            this.sidePanel6.TabIndex = 5;
            this.sidePanel6.Text = "sidePanel6";
            // 
            // sidePanel5
            // 
            this.sidePanel5.AllowResize = false;
            this.sidePanel5.BorderThickness = 0;
            this.sidePanel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel5.Location = new System.Drawing.Point(604, 44);
            this.sidePanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel5.Name = "sidePanel5";
            this.sidePanel5.Size = new System.Drawing.Size(29, 753);
            this.sidePanel5.TabIndex = 6;
            this.sidePanel5.Text = "sidePanel5";
            // 
            // sidePanel7
            // 
            this.sidePanel7.AllowResize = false;
            this.sidePanel7.BorderThickness = 0;
            this.sidePanel7.Controls.Add(this.moviegenreLUE);
            this.sidePanel7.Controls.Add(this.durationTE);
            this.sidePanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel7.Location = new System.Drawing.Point(633, 44);
            this.sidePanel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel7.Name = "sidePanel7";
            this.sidePanel7.Size = new System.Drawing.Size(694, 418);
            this.sidePanel7.TabIndex = 7;
            this.sidePanel7.Text = "sidePanel7";
            // 
            // moviegenreLUE
            // 
            this.moviegenreLUE.Location = new System.Drawing.Point(323, 75);
            this.moviegenreLUE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moviegenreLUE.Name = "moviegenreLUE";
            this.moviegenreLUE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.moviegenreLUE.Properties.Appearance.Options.UseBackColor = true;
            this.moviegenreLUE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.moviegenreLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.moviegenreLUE.Properties.NullText = "";
            this.moviegenreLUE.Size = new System.Drawing.Size(260, 28);
            this.moviegenreLUE.TabIndex = 17;
            // 
            // durationTE
            // 
            this.durationTE.EditValue = null;
            this.durationTE.Location = new System.Drawing.Point(29, 143);
            this.durationTE.Name = "durationTE";
            this.durationTE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.durationTE.Properties.Appearance.Options.UseBackColor = true;
            this.durationTE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.durationTE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.durationTE.Properties.MaskSettings.Set("mask", "hh mm");
            this.durationTE.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.durationTE.Size = new System.Drawing.Size(260, 28);
            this.durationTE.TabIndex = 18;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(639, 54);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(169, 37);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "ADD MOVIE";
            // 
            // movienameTE
            // 
            this.movienameTE.Location = new System.Drawing.Point(662, 119);
            this.movienameTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.movienameTE.Name = "movienameTE";
            this.movienameTE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.movienameTE.Properties.Appearance.Options.UseBackColor = true;
            this.movienameTE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.movienameTE.Size = new System.Drawing.Size(260, 28);
            this.movienameTE.TabIndex = 9;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.simpleButton2.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.simpleButton2.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.simpleButton2.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton2.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton2.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.simpleButton2.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.simpleButton2.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton2.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.simpleButton2.Location = new System.Drawing.Point(1239, 112);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(40, 39);
            this.simpleButton2.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(666, 151);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 16);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Movie Name";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(961, 151);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 16);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Movie Genre";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(665, 220);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(88, 16);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Movie Duration";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(957, 119);
            this.textEdit2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.textEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit2.Properties.NullText = "";
            this.textEdit2.Size = new System.Drawing.Size(260, 28);
            this.textEdit2.TabIndex = 10;
            // 
            // movielanguageLUE
            // 
            this.movielanguageLUE.Location = new System.Drawing.Point(959, 188);
            this.movielanguageLUE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.movielanguageLUE.Name = "movielanguageLUE";
            this.movielanguageLUE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.movielanguageLUE.Properties.Appearance.Options.UseBackColor = true;
            this.movielanguageLUE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.movielanguageLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.movielanguageLUE.Properties.NullText = "";
            this.movielanguageLUE.Size = new System.Drawing.Size(260, 28);
            this.movielanguageLUE.TabIndex = 16;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(962, 222);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(99, 16);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Movie Language";
            // 
            // movieratingLUE
            // 
            this.movieratingLUE.Location = new System.Drawing.Point(662, 259);
            this.movieratingLUE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.movieratingLUE.Name = "movieratingLUE";
            this.movieratingLUE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.movieratingLUE.Properties.Appearance.Options.UseBackColor = true;
            this.movieratingLUE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.movieratingLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.movieratingLUE.Properties.NullText = "";
            this.movieratingLUE.Size = new System.Drawing.Size(260, 28);
            this.movieratingLUE.TabIndex = 18;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(665, 292);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(76, 16);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Movie Rating";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(664, 398);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(105, 16);
            this.labelControl8.TabIndex = 21;
            this.labelControl8.Text = "Movie Description";
            // 
            // moviedescriptionTE
            // 
            this.moviedescriptionTE.Location = new System.Drawing.Point(662, 326);
            this.moviedescriptionTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moviedescriptionTE.Name = "moviedescriptionTE";
            this.moviedescriptionTE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.moviedescriptionTE.Properties.Appearance.Options.UseBackColor = true;
            this.moviedescriptionTE.Properties.Appearance.Options.UseTextOptions = true;
            this.moviedescriptionTE.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.moviedescriptionTE.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.moviedescriptionTE.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.moviedescriptionTE.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.moviedescriptionTE.Properties.AutoHeight = false;
            this.moviedescriptionTE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.moviedescriptionTE.Size = new System.Drawing.Size(624, 64);
            this.moviedescriptionTE.TabIndex = 22;
            // 
            // saveBTN
            // 
            this.saveBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.saveBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBTN.Appearance.Options.UseBackColor = true;
            this.saveBTN.Appearance.Options.UseFont = true;
            this.saveBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveBTN.ImageOptions.Image")));
            this.saveBTN.Location = new System.Drawing.Point(1156, 418);
            this.saveBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Padding = new System.Windows.Forms.Padding(2);
            this.saveBTN.Size = new System.Drawing.Size(129, 39);
            this.saveBTN.TabIndex = 23;
            this.saveBTN.Text = "Save Movie";
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.simpleButton4.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.Appearance.Options.UseBorderColor = true;
            this.simpleButton4.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.simpleButton4.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.simpleButton4.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton4.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton4.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.simpleButton4.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.simpleButton4.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton4.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.simpleButton4.Location = new System.Drawing.Point(1239, 181);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(40, 39);
            this.simpleButton4.TabIndex = 24;
            // 
            // sidePanel8
            // 
            this.sidePanel8.AllowResize = false;
            this.sidePanel8.BorderThickness = 0;
            this.sidePanel8.Controls.Add(this.labelControl9);
            this.sidePanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel8.Location = new System.Drawing.Point(633, 462);
            this.sidePanel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel8.Name = "sidePanel8";
            this.sidePanel8.Size = new System.Drawing.Size(694, 50);
            this.sidePanel8.TabIndex = 25;
            this.sidePanel8.Text = "sidePanel8";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(7, 8);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(102, 37);
            this.labelControl9.TabIndex = 9;
            this.labelControl9.Text = "Movies";
            // 
            // sidePanel9
            // 
            this.sidePanel9.AllowResize = false;
            this.sidePanel9.Controls.Add(this.moviesGC);
            this.sidePanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel9.Location = new System.Drawing.Point(633, 512);
            this.sidePanel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel9.Name = "sidePanel9";
            this.sidePanel9.Size = new System.Drawing.Size(694, 285);
            this.sidePanel9.TabIndex = 26;
            this.sidePanel9.Text = "sidePanel9";
            // 
            // moviesGC
            // 
            this.moviesGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moviesGC.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.moviesGC.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.moviesGC.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moviesGC.Location = new System.Drawing.Point(0, 0);
            this.moviesGC.MainView = this.moviesGV;
            this.moviesGC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moviesGC.Name = "moviesGC";
            this.moviesGC.Size = new System.Drawing.Size(694, 285);
            this.moviesGC.TabIndex = 0;
            this.moviesGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.moviesGV});
            // 
            // moviesGV
            // 
            this.moviesGV.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.moviesGV.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.moviesGV.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.moviesGV.Appearance.Empty.Options.UseBackColor = true;
            this.moviesGV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.moviesGV.Appearance.FocusedRow.Options.UseBackColor = true;
            this.moviesGV.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.moviesGV.Appearance.GroupButton.Options.UseBackColor = true;
            this.moviesGV.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.moviesGV.Appearance.GroupPanel.Options.UseBackColor = true;
            this.moviesGV.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(102)))));
            this.moviesGV.Appearance.GroupRow.Options.UseBackColor = true;
            this.moviesGV.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(88)))), ((int)(((byte)(102)))));
            this.moviesGV.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.moviesGV.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.moviesGV.Appearance.Preview.Options.UseBackColor = true;
            this.moviesGV.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.moviesGV.Appearance.Row.Options.UseBackColor = true;
            this.moviesGV.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.moviesGV.Appearance.TopNewRow.Options.UseBackColor = true;
            this.moviesGV.DetailHeight = 284;
            this.moviesGV.GridControl = this.moviesGC;
            this.moviesGV.Name = "moviesGV";
            this.moviesGV.OptionsEditForm.PopupEditFormWidth = 686;
            this.moviesGV.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.moviesGV.OptionsView.EnableAppearanceEvenRow = true;
            this.moviesGV.OptionsView.EnableAppearanceOddRow = true;
            this.moviesGV.PaintStyleName = "Skin";
            // 
            // moviedurationTE
            // 
            this.moviedurationTE.EditValue = null;
            this.moviedurationTE.Location = new System.Drawing.Point(662, 188);
            this.moviedurationTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moviedurationTE.Name = "moviedurationTE";
            this.moviedurationTE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.moviedurationTE.Properties.Appearance.Options.UseBackColor = true;
            this.moviedurationTE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.moviedurationTE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.moviedurationTE.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.moviedurationTE.Size = new System.Drawing.Size(260, 28);
            this.moviedurationTE.TabIndex = 14;
            // 
            // MoviesForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidePanel9);
            this.Controls.Add(this.sidePanel8);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.moviedescriptionTE);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.movieratingLUE);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.movielanguageLUE);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.movienameTE);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.sidePanel7);
            this.Controls.Add(this.sidePanel5);
            this.Controls.Add(this.sidePanel6);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.sidePanel4);
            this.Controls.Add(this.sidePanel3);
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.moviedurationTE);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MoviesForm";
            this.Size = new System.Drawing.Size(1365, 869);
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.posterPE.Properties)).EndInit();
            this.sidePanel3.ResumeLayout(false);
            this.sidePanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityTS.Properties)).EndInit();
            this.sidePanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moviegenreLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movienameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movielanguageLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieratingLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviedescriptionTE.Properties)).EndInit();
            this.sidePanel8.ResumeLayout(false);
            this.sidePanel8.PerformLayout();
            this.sidePanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moviesGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviedurationTE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.SidePanel sidePanel3;
        private DevExpress.XtraEditors.SidePanel sidePanel4;
        private DevExpress.XtraEditors.SidePanel sidePanel6;
        private DevExpress.XtraEditors.SidePanel sidePanel5;
        private DevExpress.XtraEditors.SidePanel sidePanel7;
        private DevExpress.XtraEditors.PictureEdit posterPE;
        private DevExpress.XtraEditors.SimpleButton browseBTN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit movienameTE;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit textEdit2;
        private DevExpress.XtraEditors.LookUpEdit movielanguageLUE;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit movieratingLUE;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit moviedescriptionTE;
        private DevExpress.XtraEditors.SimpleButton saveBTN;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SidePanel sidePanel8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SidePanel sidePanel9;
        private DevExpress.XtraGrid.GridControl moviesGC;
        private DevExpress.XtraGrid.Views.Grid.GridView moviesGV;
        private DevExpress.XtraEditors.ToggleSwitch availabilityTS;
        private DevExpress.XtraEditors.LookUpEdit moviegenreLUE;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.DateTimeOffsetEdit moviedurationTE;
        private DevExpress.XtraEditors.LabelControl availabilityLC;
        private DevExpress.XtraEditors.TimeEdit durationTE;
    }
}
