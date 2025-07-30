namespace CinemaPB.Forms
{
    partial class SeatActionPromptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeatActionPromptForm));
            this.buyBTN = new DevExpress.XtraEditors.SimpleButton();
            this.reserveBTN = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // buyBTN
            // 
            this.buyBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.buyBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyBTN.Appearance.Options.UseBackColor = true;
            this.buyBTN.Appearance.Options.UseFont = true;
            this.buyBTN.Location = new System.Drawing.Point(31, 99);
            this.buyBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buyBTN.Name = "buyBTN";
            this.buyBTN.Size = new System.Drawing.Size(94, 32);
            this.buyBTN.TabIndex = 96;
            this.buyBTN.Text = "BUY";
            this.buyBTN.Click += new System.EventHandler(this.buyBTN_Click);
            // 
            // reserveBTN
            // 
            this.reserveBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.reserveBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveBTN.Appearance.Options.UseBackColor = true;
            this.reserveBTN.Appearance.Options.UseFont = true;
            this.reserveBTN.Location = new System.Drawing.Point(195, 99);
            this.reserveBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reserveBTN.Name = "reserveBTN";
            this.reserveBTN.Size = new System.Drawing.Size(94, 32);
            this.reserveBTN.TabIndex = 97;
            this.reserveBTN.Text = "RESERVE";
            this.reserveBTN.Click += new System.EventHandler(this.reserveBTN_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(31, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 17);
            this.labelControl1.TabIndex = 98;
            this.labelControl1.Text = "labelControl1";
            // 
            // SeatActionPromptForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 169);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.reserveBTN);
            this.Controls.Add(this.buyBTN);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SeatActionPromptForm.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeatActionPromptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buy/Reserve Seats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton buyBTN;
        private DevExpress.XtraEditors.SimpleButton reserveBTN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}