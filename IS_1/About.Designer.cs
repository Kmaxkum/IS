namespace IS_1
{
    partial class About
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
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Group = new System.Windows.Forms.Label();
            this.label_Num = new System.Windows.Forms.Label();
            this.label_First = new System.Windows.Forms.Label();
            this.label_Second = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(14, 9);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(127, 13);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Выполнил: Крутов М. В.";
            // 
            // label_Group
            // 
            this.label_Group.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Group.AutoSize = true;
            this.label_Group.Location = new System.Drawing.Point(14, 22);
            this.label_Group.Name = "label_Group";
            this.label_Group.Size = new System.Drawing.Size(91, 13);
            this.label_Group.TabIndex = 1;
            this.label_Group.Text = "Группа: ПИбд-41";
            // 
            // label_Num
            // 
            this.label_Num.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Num.AutoSize = true;
            this.label_Num.Location = new System.Drawing.Point(14, 35);
            this.label_Num.Name = "label_Num";
            this.label_Num.Size = new System.Drawing.Size(67, 13);
            this.label_Num.TabIndex = 2;
            this.label_Num.Text = "Вариант: 11";
            // 
            // label_First
            // 
            this.label_First.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_First.AutoSize = true;
            this.label_First.Location = new System.Drawing.Point(14, 48);
            this.label_First.Name = "label_First";
            this.label_First.Size = new System.Drawing.Size(360, 13);
            this.label_First.TabIndex = 3;
            this.label_First.Text = "Наличие латинских букв, символов кириллицы и знаков препинания.";
            // 
            // label_Second
            // 
            this.label_Second.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Second.AutoSize = true;
            this.label_Second.Location = new System.Drawing.Point(14, 61);
            this.label_Second.Name = "label_Second";
            this.label_Second.Size = new System.Drawing.Size(310, 13);
            this.label_Second.TabIndex = 4;
            this.label_Second.Text = "DES CFB с добавлением к ключу случаного значения,  MD5";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 82);
            this.Controls.Add(this.label_Second);
            this.Controls.Add(this.label_First);
            this.Controls.Add(this.label_Num);
            this.Controls.Add(this.label_Group);
            this.Controls.Add(this.label_Name);
            this.MinimumSize = new System.Drawing.Size(395, 120);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Group;
        private System.Windows.Forms.Label label_Num;
        private System.Windows.Forms.Label label_First;
        private System.Windows.Forms.Label label_Second;
    }
}