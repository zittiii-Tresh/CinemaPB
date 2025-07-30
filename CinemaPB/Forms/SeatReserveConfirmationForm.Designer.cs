namespace CinemaPB.Forms
{
    partial class SeatReserveConfirmationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeatReserveConfirmationForm));
            this.confirmBTN = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.usernameTE = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameTE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmBTN
            // 
            this.confirmBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.confirmBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBTN.Appearance.Options.UseBackColor = true;
            this.confirmBTN.Appearance.Options.UseFont = true;
            this.confirmBTN.Location = new System.Drawing.Point(112, 110);
            this.confirmBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmBTN.Name = "confirmBTN";
            this.confirmBTN.Size = new System.Drawing.Size(94, 32);
            this.confirmBTN.TabIndex = 101;
            this.confirmBTN.Text = "CONFIRM";
            this.confirmBTN.Click += new System.EventHandler(this.confirmBTN_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(31, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 16);
            this.labelControl1.TabIndex = 100;
            this.labelControl1.Text = "Customer Name:";
            // 
            // usernameTE
            // 
            this.usernameTE.Location = new System.Drawing.Point(31, 46);
            this.usernameTE.Name = "usernameTE";
            this.usernameTE.Size = new System.Drawing.Size(258, 28);
            this.usernameTE.TabIndex = 99;
            // 
            // SeatReserveConfirmationForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 169);
            this.Controls.Add(this.confirmBTN);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.usernameTE);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SeatReserveConfirmationForm.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeatReserveConfirmationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserve Confirmation";
            ((System.ComponentModel.ISupportInitialize)(this.usernameTE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton confirmBTN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit usernameTE;
    }
}