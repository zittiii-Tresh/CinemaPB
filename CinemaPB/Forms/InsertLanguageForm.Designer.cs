namespace CinemaPB.Forms
{
    partial class InsertLanguageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertLanguageForm));
            this.languagesaveBTN = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.languageTE = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.languageTE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // languagesaveBTN
            // 
            this.languagesaveBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.languagesaveBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languagesaveBTN.Appearance.Options.UseBackColor = true;
            this.languagesaveBTN.Appearance.Options.UseFont = true;
            this.languagesaveBTN.Location = new System.Drawing.Point(142, 78);
            this.languagesaveBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.languagesaveBTN.Name = "languagesaveBTN";
            this.languagesaveBTN.Size = new System.Drawing.Size(81, 24);
            this.languagesaveBTN.TabIndex = 5;
            this.languagesaveBTN.Text = "SAVE";
            this.languagesaveBTN.Click += new System.EventHandler(this.languagesaveBTN_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(43, 38);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 17);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Language:";
            // 
            // languageTE
            // 
            this.languageTE.Location = new System.Drawing.Point(125, 32);
            this.languageTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.languageTE.Name = "languageTE";
            this.languageTE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.languageTE.Properties.Appearance.Options.UseBackColor = true;
            this.languageTE.Size = new System.Drawing.Size(189, 28);
            this.languageTE.TabIndex = 3;
            // 
            // InsertLanguageForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 134);
            this.Controls.Add(this.languagesaveBTN);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.languageTE);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("InsertLanguageForm.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "InsertLanguageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert New Language";
            ((System.ComponentModel.ISupportInitialize)(this.languageTE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton languagesaveBTN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit languageTE;
    }
}