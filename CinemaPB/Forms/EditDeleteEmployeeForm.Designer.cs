namespace CinemaPB.Forms
{
    partial class EditDeleteEmployeeForm
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDeleteEmployeeForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.resultcaptionLBL = new DevExpress.XtraEditors.LabelControl();
            this.passwordBE = new DevExpress.XtraEditors.ButtonEdit();
            this.extensionTE = new DevExpress.XtraEditors.TextEdit();
            this.contactnoTE = new DevExpress.XtraEditors.TextEdit();
            this.addressTE = new DevExpress.XtraEditors.TextEdit();
            this.firstnameTE = new DevExpress.XtraEditors.TextEdit();
            this.middlenameTE = new DevExpress.XtraEditors.TextEdit();
            this.lastnameTE = new DevExpress.XtraEditors.TextEdit();
            this.usernameTE = new DevExpress.XtraEditors.TextEdit();
            this.resultLBL = new DevExpress.XtraEditors.LabelControl();
            this.genderRG = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.positionRG = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.employeeRG = new DevExpress.XtraEditors.RadioGroup();
            this.availabilityLC = new DevExpress.XtraEditors.LabelControl();
            this.accountTS = new DevExpress.XtraEditors.ToggleSwitch();
            this.deleteBTN = new DevExpress.XtraEditors.SimpleButton();
            this.saveBTN = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.passwordBE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extensionTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactnoTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstnameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlenameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastnameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderRG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionRG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTS.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // resultcaptionLBL
            // 
            this.resultcaptionLBL.Location = new System.Drawing.Point(419, 289);
            this.resultcaptionLBL.Name = "resultcaptionLBL";
            this.resultcaptionLBL.Size = new System.Drawing.Size(0, 16);
            this.resultcaptionLBL.TabIndex = 35;
            // 
            // passwordBE
            // 
            this.passwordBE.EditValue = "Password";
            this.passwordBE.Location = new System.Drawing.Point(663, 155);
            this.passwordBE.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.passwordBE.Name = "passwordBE";
            this.passwordBE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBE.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.passwordBE.Properties.Appearance.Options.UseFont = true;
            this.passwordBE.Properties.Appearance.Options.UseForeColor = true;
            this.passwordBE.Properties.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.passwordBE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.passwordBE.Size = new System.Drawing.Size(187, 27);
            this.passwordBE.TabIndex = 34;
            this.passwordBE.Tag = "close";
            // 
            // extensionTE
            // 
            this.extensionTE.EditValue = "Extension";
            this.extensionTE.Location = new System.Drawing.Point(663, 103);
            this.extensionTE.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.extensionTE.Name = "extensionTE";
            this.extensionTE.Properties.Appearance.BorderColor = System.Drawing.Color.Maroon;
            this.extensionTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extensionTE.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.extensionTE.Properties.Appearance.Options.UseBorderColor = true;
            this.extensionTE.Properties.Appearance.Options.UseFont = true;
            this.extensionTE.Properties.Appearance.Options.UseForeColor = true;
            this.extensionTE.Properties.AutoHeight = false;
            this.extensionTE.Size = new System.Drawing.Size(187, 27);
            this.extensionTE.TabIndex = 30;
            // 
            // contactnoTE
            // 
            this.contactnoTE.EditValue = "Contact no.";
            this.contactnoTE.Location = new System.Drawing.Point(44, 155);
            this.contactnoTE.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.contactnoTE.Name = "contactnoTE";
            this.contactnoTE.Properties.Appearance.BorderColor = System.Drawing.Color.Maroon;
            this.contactnoTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactnoTE.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.contactnoTE.Properties.Appearance.Options.UseBorderColor = true;
            this.contactnoTE.Properties.Appearance.Options.UseFont = true;
            this.contactnoTE.Properties.Appearance.Options.UseForeColor = true;
            this.contactnoTE.Properties.AutoHeight = false;
            this.contactnoTE.Size = new System.Drawing.Size(187, 27);
            this.contactnoTE.TabIndex = 31;
            // 
            // addressTE
            // 
            this.addressTE.EditValue = "Address";
            this.addressTE.Location = new System.Drawing.Point(251, 155);
            this.addressTE.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addressTE.Name = "addressTE";
            this.addressTE.Properties.Appearance.BorderColor = System.Drawing.Color.Maroon;
            this.addressTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTE.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.addressTE.Properties.Appearance.Options.UseBorderColor = true;
            this.addressTE.Properties.Appearance.Options.UseFont = true;
            this.addressTE.Properties.Appearance.Options.UseForeColor = true;
            this.addressTE.Properties.AutoHeight = false;
            this.addressTE.Size = new System.Drawing.Size(187, 27);
            this.addressTE.TabIndex = 32;
            // 
            // firstnameTE
            // 
            this.firstnameTE.EditValue = "Firstname";
            this.firstnameTE.Location = new System.Drawing.Point(44, 103);
            this.firstnameTE.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.firstnameTE.Name = "firstnameTE";
            this.firstnameTE.Properties.Appearance.BorderColor = System.Drawing.Color.Maroon;
            this.firstnameTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameTE.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.firstnameTE.Properties.Appearance.Options.UseBorderColor = true;
            this.firstnameTE.Properties.Appearance.Options.UseFont = true;
            this.firstnameTE.Properties.Appearance.Options.UseForeColor = true;
            this.firstnameTE.Properties.AutoHeight = false;
            this.firstnameTE.Size = new System.Drawing.Size(187, 27);
            this.firstnameTE.TabIndex = 27;
            // 
            // middlenameTE
            // 
            this.middlenameTE.EditValue = "Middlename";
            this.middlenameTE.Location = new System.Drawing.Point(251, 103);
            this.middlenameTE.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.middlenameTE.Name = "middlenameTE";
            this.middlenameTE.Properties.Appearance.BorderColor = System.Drawing.Color.Maroon;
            this.middlenameTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middlenameTE.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.middlenameTE.Properties.Appearance.Options.UseBorderColor = true;
            this.middlenameTE.Properties.Appearance.Options.UseFont = true;
            this.middlenameTE.Properties.Appearance.Options.UseForeColor = true;
            this.middlenameTE.Properties.AutoHeight = false;
            this.middlenameTE.Size = new System.Drawing.Size(187, 27);
            this.middlenameTE.TabIndex = 28;
            // 
            // lastnameTE
            // 
            this.lastnameTE.EditValue = "Lastname";
            this.lastnameTE.Location = new System.Drawing.Point(457, 103);
            this.lastnameTE.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lastnameTE.Name = "lastnameTE";
            this.lastnameTE.Properties.Appearance.BorderColor = System.Drawing.Color.Maroon;
            this.lastnameTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameTE.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lastnameTE.Properties.Appearance.Options.UseBorderColor = true;
            this.lastnameTE.Properties.Appearance.Options.UseFont = true;
            this.lastnameTE.Properties.Appearance.Options.UseForeColor = true;
            this.lastnameTE.Properties.AutoHeight = false;
            this.lastnameTE.Size = new System.Drawing.Size(187, 27);
            this.lastnameTE.TabIndex = 29;
            // 
            // usernameTE
            // 
            this.usernameTE.EditValue = "Username";
            this.usernameTE.Location = new System.Drawing.Point(457, 155);
            this.usernameTE.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.usernameTE.Name = "usernameTE";
            this.usernameTE.Properties.Appearance.BorderColor = System.Drawing.Color.Maroon;
            this.usernameTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTE.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.usernameTE.Properties.Appearance.Options.UseBorderColor = true;
            this.usernameTE.Properties.Appearance.Options.UseFont = true;
            this.usernameTE.Properties.Appearance.Options.UseForeColor = true;
            this.usernameTE.Properties.AutoHeight = false;
            this.usernameTE.Size = new System.Drawing.Size(187, 27);
            this.usernameTE.TabIndex = 33;
            // 
            // resultLBL
            // 
            this.resultLBL.Location = new System.Drawing.Point(204, 310);
            this.resultLBL.Name = "resultLBL";
            this.resultLBL.Size = new System.Drawing.Size(0, 16);
            this.resultLBL.TabIndex = 40;
            // 
            // genderRG
            // 
            this.genderRG.Location = new System.Drawing.Point(272, 240);
            this.genderRG.Margin = new System.Windows.Forms.Padding(4);
            this.genderRG.Name = "genderRG";
            this.genderRG.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.genderRG.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.genderRG.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderRG.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.genderRG.Properties.Appearance.Options.UseBackColor = true;
            this.genderRG.Properties.Appearance.Options.UseBorderColor = true;
            this.genderRG.Properties.Appearance.Options.UseFont = true;
            this.genderRG.Properties.Appearance.Options.UseForeColor = true;
            this.genderRG.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.genderRG.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.genderRG.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.genderRG.Properties.Columns = 2;
            this.genderRG.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Male", "Male", true, "Male", "Male"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Female", "Female", true, "Female", "Female")});
            this.genderRG.Size = new System.Drawing.Size(166, 37);
            this.genderRG.TabIndex = 39;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(254, 211);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 23);
            this.labelControl4.TabIndex = 38;
            this.labelControl4.Text = "Gender";
            // 
            // positionRG
            // 
            this.positionRG.Location = new System.Drawing.Point(65, 240);
            this.positionRG.Margin = new System.Windows.Forms.Padding(4);
            this.positionRG.Name = "positionRG";
            this.positionRG.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.positionRG.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.positionRG.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionRG.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.positionRG.Properties.Appearance.Options.UseBackColor = true;
            this.positionRG.Properties.Appearance.Options.UseBorderColor = true;
            this.positionRG.Properties.Appearance.Options.UseFont = true;
            this.positionRG.Properties.Appearance.Options.UseForeColor = true;
            this.positionRG.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.positionRG.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.positionRG.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.positionRG.Properties.Columns = 2;
            this.positionRG.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Admin", true, "Admin", "Admin"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(2)), "Staff", true, "Staff", "Staff")});
            this.positionRG.Size = new System.Drawing.Size(166, 37);
            this.positionRG.TabIndex = 36;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(44, 211);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 23);
            this.labelControl3.TabIndex = 37;
            this.labelControl3.Text = "Position";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(30, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(280, 32);
            this.labelControl1.TabIndex = 41;
            this.labelControl1.Text = "Edit/Delete Employee";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(466, 211);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(127, 23);
            this.labelControl2.TabIndex = 42;
            this.labelControl2.Text = "Employee Status";
            // 
            // employeeRG
            // 
            this.employeeRG.Location = new System.Drawing.Point(488, 240);
            this.employeeRG.Margin = new System.Windows.Forms.Padding(4);
            this.employeeRG.Name = "employeeRG";
            this.employeeRG.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.employeeRG.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.employeeRG.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeRG.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.employeeRG.Properties.Appearance.Options.UseBackColor = true;
            this.employeeRG.Properties.Appearance.Options.UseBorderColor = true;
            this.employeeRG.Properties.Appearance.Options.UseFont = true;
            this.employeeRG.Properties.Appearance.Options.UseForeColor = true;
            this.employeeRG.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.employeeRG.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.employeeRG.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.employeeRG.Properties.Columns = 2;
            this.employeeRG.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Active", true, "Active", "Active"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "In-Active", true, "In-Active", "In-Active")});
            this.employeeRG.Size = new System.Drawing.Size(196, 37);
            this.employeeRG.TabIndex = 43;
            // 
            // availabilityLC
            // 
            this.availabilityLC.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availabilityLC.Appearance.ForeColor = System.Drawing.Color.White;
            this.availabilityLC.Appearance.Options.UseFont = true;
            this.availabilityLC.Appearance.Options.UseForeColor = true;
            this.availabilityLC.Location = new System.Drawing.Point(156, 346);
            this.availabilityLC.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.availabilityLC.Name = "availabilityLC";
            this.availabilityLC.Size = new System.Drawing.Size(56, 18);
            this.availabilityLC.TabIndex = 45;
            this.availabilityLC.Text = "Locked";
            // 
            // accountTS
            // 
            this.accountTS.EditValue = true;
            this.accountTS.Location = new System.Drawing.Point(35, 333);
            this.accountTS.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.accountTS.Name = "accountTS";
            this.accountTS.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTS.Properties.Appearance.Options.UseFont = true;
            this.accountTS.Properties.AutoHeight = false;
            this.accountTS.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.accountTS.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(89)))), ((int)(((byte)(142)))));
            this.accountTS.Properties.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.accountTS.Properties.LookAndFeel.SkinName = "The Bezier";
            this.accountTS.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.accountTS.Properties.OffText = "Off";
            this.accountTS.Properties.OnText = "On";
            this.accountTS.Properties.ThumbWidth = 10;
            this.accountTS.Size = new System.Drawing.Size(122, 43);
            this.accountTS.TabIndex = 44;
            // 
            // deleteBTN
            // 
            this.deleteBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.deleteBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBTN.Appearance.Options.UseBackColor = true;
            this.deleteBTN.Appearance.Options.UseFont = true;
            this.deleteBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.deleteBTN.Location = new System.Drawing.Point(727, 331);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(123, 45);
            this.deleteBTN.TabIndex = 46;
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // saveBTN
            // 
            this.saveBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.saveBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBTN.Appearance.Options.UseBackColor = true;
            this.saveBTN.Appearance.Options.UseFont = true;
            this.saveBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.saveBTN.Location = new System.Drawing.Point(585, 331);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(123, 45);
            this.saveBTN.TabIndex = 47;
            this.saveBTN.Text = "Save";
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // EditDeleteEmployeeForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 414);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.availabilityLC);
            this.Controls.Add(this.accountTS);
            this.Controls.Add(this.employeeRG);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.resultLBL);
            this.Controls.Add(this.genderRG);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.positionRG);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.resultcaptionLBL);
            this.Controls.Add(this.passwordBE);
            this.Controls.Add(this.extensionTE);
            this.Controls.Add(this.contactnoTE);
            this.Controls.Add(this.addressTE);
            this.Controls.Add(this.firstnameTE);
            this.Controls.Add(this.middlenameTE);
            this.Controls.Add(this.lastnameTE);
            this.Controls.Add(this.usernameTE);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EditDeleteEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit/Delete Employee";
            ((System.ComponentModel.ISupportInitialize)(this.passwordBE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extensionTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactnoTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstnameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlenameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastnameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderRG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionRG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTS.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl resultcaptionLBL;
        private DevExpress.XtraEditors.ButtonEdit passwordBE;
        private DevExpress.XtraEditors.TextEdit extensionTE;
        private DevExpress.XtraEditors.TextEdit contactnoTE;
        private DevExpress.XtraEditors.TextEdit addressTE;
        private DevExpress.XtraEditors.TextEdit middlenameTE;
        private DevExpress.XtraEditors.TextEdit lastnameTE;
        private DevExpress.XtraEditors.TextEdit usernameTE;
        private DevExpress.XtraEditors.LabelControl resultLBL;
        private DevExpress.XtraEditors.RadioGroup genderRG;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.RadioGroup positionRG;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.RadioGroup employeeRG;
        private DevExpress.XtraEditors.LabelControl availabilityLC;
        private DevExpress.XtraEditors.ToggleSwitch accountTS;
        private DevExpress.XtraEditors.SimpleButton deleteBTN;
        private DevExpress.XtraEditors.SimpleButton saveBTN;
        public DevExpress.XtraEditors.TextEdit firstnameTE;
    }
}