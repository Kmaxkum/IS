namespace IS_1
{
    partial class ChangeUser
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
            this.label_Login = new System.Windows.Forms.Label();
            this.label_UserLogin = new System.Windows.Forms.Label();
            this.checkBox_Ban = new System.Windows.Forms.CheckBox();
            this.checkBox_PassRest = new System.Windows.Forms.CheckBox();
            this.button_Change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Login
            // 
            this.label_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Login.AutoSize = true;
            this.label_Login.Location = new System.Drawing.Point(12, 9);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(33, 13);
            this.label_Login.TabIndex = 0;
            this.label_Login.Text = "Login";
            // 
            // label_UserLogin
            // 
            this.label_UserLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_UserLogin.AutoSize = true;
            this.label_UserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_UserLogin.Location = new System.Drawing.Point(12, 22);
            this.label_UserLogin.Name = "label_UserLogin";
            this.label_UserLogin.Size = new System.Drawing.Size(111, 26);
            this.label_UserLogin.TabIndex = 1;
            this.label_UserLogin.Text = "UserLogin";
            // 
            // checkBox_Ban
            // 
            this.checkBox_Ban.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Ban.AutoSize = true;
            this.checkBox_Ban.Location = new System.Drawing.Point(15, 50);
            this.checkBox_Ban.Name = "checkBox_Ban";
            this.checkBox_Ban.Size = new System.Drawing.Size(45, 17);
            this.checkBox_Ban.TabIndex = 2;
            this.checkBox_Ban.Text = "Ban";
            this.checkBox_Ban.UseVisualStyleBackColor = true;
            // 
            // checkBox_PassRest
            // 
            this.checkBox_PassRest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_PassRest.AutoSize = true;
            this.checkBox_PassRest.Location = new System.Drawing.Point(15, 73);
            this.checkBox_PassRest.Name = "checkBox_PassRest";
            this.checkBox_PassRest.Size = new System.Drawing.Size(141, 17);
            this.checkBox_PassRest.TabIndex = 3;
            this.checkBox_PassRest.Text = "Add password restriction";
            this.checkBox_PassRest.UseVisualStyleBackColor = true;
            // 
            // button_Change
            // 
            this.button_Change.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Change.Location = new System.Drawing.Point(114, 96);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(89, 34);
            this.button_Change.TabIndex = 4;
            this.button_Change.Text = "Change";
            this.button_Change.UseVisualStyleBackColor = true;
            this.button_Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // ChangeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 137);
            this.Controls.Add(this.button_Change);
            this.Controls.Add(this.checkBox_PassRest);
            this.Controls.Add(this.checkBox_Ban);
            this.Controls.Add(this.label_UserLogin);
            this.Controls.Add(this.label_Login);
            this.MinimumSize = new System.Drawing.Size(225, 175);
            this.Name = "ChangeUser";
            this.Text = "ChangeUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_UserLogin;
        private System.Windows.Forms.CheckBox checkBox_Ban;
        private System.Windows.Forms.CheckBox checkBox_PassRest;
        private System.Windows.Forms.Button button_Change;
    }
}