namespace ITProject
{
    partial class MomoQR
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
            this.pb_qr = new System.Windows.Forms.PictureBox();
            this.bt_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.lb_money = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_qr)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_qr
            // 
            this.pb_qr.Location = new System.Drawing.Point(137, 145);
            this.pb_qr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_qr.Name = "pb_qr";
            this.pb_qr.Size = new System.Drawing.Size(313, 289);
            this.pb_qr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_qr.TabIndex = 10;
            this.pb_qr.TabStop = false;
            this.pb_qr.Click += new System.EventHandler(this.pb_qr_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.AutoRoundedCorners = true;
            this.bt_cancel.BackColor = System.Drawing.Color.Transparent;
            this.bt_cancel.BorderRadius = 27;
            this.bt_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_cancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancel.ForeColor = System.Drawing.Color.White;
            this.bt_cancel.Location = new System.Drawing.Point(213, 521);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(157, 57);
            this.bt_cancel.TabIndex = 54;
            this.bt_cancel.Text = "Back";
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // lb_money
            // 
            this.lb_money.AutoSize = true;
            this.lb_money.Location = new System.Drawing.Point(268, 487);
            this.lb_money.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_money.Name = "lb_money";
            this.lb_money.Size = new System.Drawing.Size(44, 16);
            this.lb_money.TabIndex = 55;
            this.lb_money.Text = "label1";
            this.lb_money.Visible = false;
            // 
            // MomoQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ITProject.Properties.Resources.bgr_momo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(585, 660);
            this.Controls.Add(this.lb_money);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.pb_qr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MomoQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MomoQR";
            this.Load += new System.EventHandler(this.MomoQR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_qr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_qr;
        private Guna.UI2.WinForms.Guna2Button bt_cancel;
        public System.Windows.Forms.Label lb_money;
    }
}