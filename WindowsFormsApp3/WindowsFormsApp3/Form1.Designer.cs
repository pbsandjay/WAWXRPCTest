namespace WindowsFormsApp3
{
    partial class Form1
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
            this.btConnect = new DevComponents.DotNetBar.ButtonX();
            this.btAmmo = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // btConnect
            // 
            this.btConnect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btConnect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btConnect.Location = new System.Drawing.Point(12, 26);
            this.btConnect.Name = "btConnect";
            this.btConnect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btConnect.Size = new System.Drawing.Size(75, 23);
            this.btConnect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btConnect.TabIndex = 0;
            this.btConnect.Text = "Connect";
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btAmmo
            // 
            this.btAmmo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btAmmo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btAmmo.Location = new System.Drawing.Point(12, 121);
            this.btAmmo.Name = "btAmmo";
            this.btAmmo.Size = new System.Drawing.Size(75, 23);
            this.btAmmo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btAmmo.TabIndex = 1;
            this.btAmmo.Text = "Max Ammo";
            this.btAmmo.Click += new System.EventHandler(this.btSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 401);
            this.Controls.Add(this.btAmmo);
            this.Controls.Add(this.btConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btConnect;
        private DevComponents.DotNetBar.ButtonX btAmmo;
    }
}

