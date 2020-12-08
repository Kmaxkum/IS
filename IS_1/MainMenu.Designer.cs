namespace IS_1
{
    partial class MainMenu
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
            this.button_ResetPassword = new System.Windows.Forms.Button();
            this.button_UserList = new System.Windows.Forms.Button();
            this.button_About = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_ResetPassword
            // 
            this.button_ResetPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ResetPassword.Location = new System.Drawing.Point(12, 12);
            this.button_ResetPassword.Name = "button_ResetPassword";
            this.button_ResetPassword.Size = new System.Drawing.Size(160, 60);
            this.button_ResetPassword.TabIndex = 0;
            this.button_ResetPassword.Text = "Reset Password";
            this.button_ResetPassword.UseVisualStyleBackColor = true;
            this.button_ResetPassword.Click += new System.EventHandler(this.button_ResetPassword_Click);
            // 
            // button_UserList
            // 
            this.button_UserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_UserList.Location = new System.Drawing.Point(12, 77);
            this.button_UserList.Name = "button_UserList";
            this.button_UserList.Size = new System.Drawing.Size(160, 60);
            this.button_UserList.TabIndex = 1;
            this.button_UserList.Text = "User List";
            this.button_UserList.UseVisualStyleBackColor = true;
            this.button_UserList.Click += new System.EventHandler(this.button_UserList_Click);
            // 
            // button_About
            // 
            this.button_About.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_About.Location = new System.Drawing.Point(12, 143);
            this.button_About.Name = "button_About";
            this.button_About.Size = new System.Drawing.Size(160, 60);
            this.button_About.TabIndex = 2;
            this.button_About.Text = "About";
            this.button_About.UseVisualStyleBackColor = true;
            this.button_About.Click += new System.EventHandler(this.button_About_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 212);
            this.Controls.Add(this.button_About);
            this.Controls.Add(this.button_UserList);
            this.Controls.Add(this.button_ResetPassword);
            this.MinimumSize = new System.Drawing.Size(200, 250);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_ResetPassword;
        private System.Windows.Forms.Button button_UserList;
        private System.Windows.Forms.Button button_About;
    }
}