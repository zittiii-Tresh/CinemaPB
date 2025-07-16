namespace CinemaPB.Forms
{
    partial class ChangePasswordForm
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.passwordBE = new DevExpress.XtraEditors.ButtonEdit();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.beConfirmPassword = new DevExpress.XtraEditors.ButtonEdit();
            this.resultcaptionLBL = new DevExpress.XtraEditors.LabelControl();
            this.resultLBL = new DevExpress.XtraEditors.LabelControl();
            this.saveBTN = new DevExpress.XtraEditors.SimpleButton();
            this.lblConfirmPasswordCaption = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.passwordBE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beConfirmPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordBE
            // 
            this.passwordBE.EditValue = "Password";
            this.passwordBE.Location = new System.Drawing.Point(41, 53);
            this.passwordBE.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.passwordBE.Name = "passwordBE";
            this.passwordBE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBE.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.passwordBE.Properties.Appearance.Options.UseFont = true;
            this.passwordBE.Properties.Appearance.Options.UseForeColor = true;
            this.passwordBE.Properties.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.passwordBE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.passwordBE.Size = new System.Drawing.Size(228, 27);
            this.passwordBE.TabIndex = 24;
            this.passwordBE.Tag = "close";
            this.passwordBE.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.passwordBE_ButtonPressed);
            this.passwordBE.EditValueChanged += new System.EventHandler(this.passwordBE_EditValueChanged);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "eyeclose.png");
            this.imageCollection1.Images.SetKeyName(1, "eyeopen.png");
            // 
            // beConfirmPassword
            // 
            this.beConfirmPassword.EditValue = "Confirm Password";
            this.beConfirmPassword.Location = new System.Drawing.Point(313, 53);
            this.beConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.beConfirmPassword.Name = "beConfirmPassword";
            this.beConfirmPassword.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beConfirmPassword.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.beConfirmPassword.Properties.Appearance.Options.UseFont = true;
            this.beConfirmPassword.Properties.Appearance.Options.UseForeColor = true;
            this.beConfirmPassword.Properties.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.beConfirmPassword.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.beConfirmPassword.Size = new System.Drawing.Size(228, 27);
            this.beConfirmPassword.TabIndex = 25;
            this.beConfirmPassword.Tag = "close";
            this.beConfirmPassword.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beConfirmPassword_ButtonPressed);
            this.beConfirmPassword.EditValueChanged += new System.EventHandler(this.beConfirmPassword_EditValueChanged);
            // 
            // resultcaptionLBL
            // 
            this.resultcaptionLBL.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultcaptionLBL.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.resultcaptionLBL.Appearance.Options.UseFont = true;
            this.resultcaptionLBL.Appearance.Options.UseForeColor = true;
            this.resultcaptionLBL.Location = new System.Drawing.Point(45, 96);
            this.resultcaptionLBL.Name = "resultcaptionLBL";
            this.resultcaptionLBL.Size = new System.Drawing.Size(0, 17);
            this.resultcaptionLBL.TabIndex = 27;
            // 
            // resultLBL
            // 
            this.resultLBL.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLBL.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.resultLBL.Appearance.Options.UseFont = true;
            this.resultLBL.Appearance.Options.UseForeColor = true;
            this.resultLBL.Location = new System.Drawing.Point(45, 116);
            this.resultLBL.Name = "resultLBL";
            this.resultLBL.Size = new System.Drawing.Size(0, 17);
            this.resultLBL.TabIndex = 28;
            // 
            // saveBTN
            // 
            this.saveBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(117)))), ((int)(((byte)(24)))));
            this.saveBTN.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBTN.Appearance.Options.UseBackColor = true;
            this.saveBTN.Appearance.Options.UseFont = true;
            this.saveBTN.Location = new System.Drawing.Point(369, 144);
            this.saveBTN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(172, 38);
            this.saveBTN.TabIndex = 29;
            this.saveBTN.Text = "SAVE";
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // lblConfirmPasswordCaption
            // 
            this.lblConfirmPasswordCaption.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPasswordCaption.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblConfirmPasswordCaption.Appearance.Options.UseFont = true;
            this.lblConfirmPasswordCaption.Appearance.Options.UseForeColor = true;
            this.lblConfirmPasswordCaption.Location = new System.Drawing.Point(319, 98);
            this.lblConfirmPasswordCaption.Name = "lblConfirmPasswordCaption";
            this.lblConfirmPasswordCaption.Size = new System.Drawing.Size(0, 17);
            this.lblConfirmPasswordCaption.TabIndex = 30;
            // 
            // ChangePasswordForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 223);
            this.Controls.Add(this.lblConfirmPasswordCaption);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.resultLBL);
            this.Controls.Add(this.resultcaptionLBL);
            this.Controls.Add(this.beConfirmPassword);
            this.Controls.Add(this.passwordBE);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            ((System.ComponentModel.ISupportInitialize)(this.passwordBE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beConfirmPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ButtonEdit passwordBE;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.ButtonEdit beConfirmPassword;
        private DevExpress.XtraEditors.LabelControl resultcaptionLBL;
        private DevExpress.XtraEditors.LabelControl resultLBL;
        private DevExpress.XtraEditors.SimpleButton saveBTN;
        private DevExpress.XtraEditors.LabelControl lblConfirmPasswordCaption;
    }
}