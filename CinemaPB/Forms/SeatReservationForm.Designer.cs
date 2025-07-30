namespace CinemaPB.Forms
{
    partial class SeatReservationForm
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
            this.usernameTE = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.reserveBTN = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.usernameTE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameTE
            // 
            this.usernameTE.Location = new System.Drawing.Point(31, 52);
            this.usernameTE.Name = "usernameTE";
            this.usernameTE.Size = new System.Drawing.Size(258, 28);
            this.usernameTE.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(31, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Customer Name:";
            // 
            // reserveBTN
            // 
            this.reserveBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.reserveBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveBTN.Appearance.Options.UseBackColor = true;
            this.reserveBTN.Appearance.Options.UseFont = true;
            this.reserveBTN.Location = new System.Drawing.Point(112, 116);
            this.reserveBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reserveBTN.Name = "reserveBTN";
            this.reserveBTN.Size = new System.Drawing.Size(94, 32);
            this.reserveBTN.TabIndex = 98;
            this.reserveBTN.Text = "RESERVE";
            this.reserveBTN.Click += new System.EventHandler(this.reserveBTN_Click);
            // 
            // SeatReservationForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 169);
            this.Controls.Add(this.reserveBTN);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.usernameTE);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeatReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeatReservationForm";
            ((System.ComponentModel.ISupportInitialize)(this.usernameTE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit usernameTE;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton reserveBTN;
    }
}