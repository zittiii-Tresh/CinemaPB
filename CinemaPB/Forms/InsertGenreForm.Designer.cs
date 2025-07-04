namespace CinemaPB.Forms
{
    partial class InsertGenreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertGenreForm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.genreTE = new DevExpress.XtraEditors.TextEdit();
            this.genresaveBTN = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.genreTE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(51, 39);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Genre:";
            // 
            // genreTE
            // 
            this.genreTE.Location = new System.Drawing.Point(110, 34);
            this.genreTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genreTE.Name = "genreTE";
            this.genreTE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.genreTE.Properties.Appearance.Options.UseBackColor = true;
            this.genreTE.Size = new System.Drawing.Size(189, 28);
            this.genreTE.TabIndex = 0;
            // 
            // genresaveBTN
            // 
            this.genresaveBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.genresaveBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genresaveBTN.Appearance.Options.UseBackColor = true;
            this.genresaveBTN.Appearance.Options.UseFont = true;
            this.genresaveBTN.Location = new System.Drawing.Point(140, 86);
            this.genresaveBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genresaveBTN.Name = "genresaveBTN";
            this.genresaveBTN.Size = new System.Drawing.Size(81, 24);
            this.genresaveBTN.TabIndex = 2;
            this.genresaveBTN.Text = "SAVE";
            this.genresaveBTN.Click += new System.EventHandler(this.genresaveBTN_Click);
            // 
            // InsertGenreForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 134);
            this.Controls.Add(this.genresaveBTN);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.genreTE);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("InsertGenreForm.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "InsertGenreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert New Genre";
            ((System.ComponentModel.ISupportInitialize)(this.genreTE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit genreTE;
        private DevExpress.XtraEditors.SimpleButton genresaveBTN;
    }
}