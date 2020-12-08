using IS_1.Controllers;
using IS_1.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace IS_1
{
    public partial class ResetPassword : Form
    {
        public AccessController accessController { get; set; }
        public UserModel User { get; set; }
        public String NewPassword { get { return newPassword; } }

        private String newPassword;

        public ResetPassword()
        {
            InitializeComponent();

            textBox_OldPassword.PasswordChar = '*';
            textBox_FirstInput.PasswordChar = '*';
            textBox_SecondInput.PasswordChar = '*';

            textBox_OldPassword.MaxLength = 16;
            textBox_FirstInput.MaxLength = 16;
            textBox_SecondInput.MaxLength = 16;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            label_Check.Visible = false;

            if (User == null)
            {
                this.DialogResult = DialogResult.No;
                return;
            }

            String oldPasswordValue = textBox_OldPassword.Text;
            if (textBox_FirstInput.Text != textBox_SecondInput.Text)
            {
                label_Check.Text = "New passwords don't match";
                label_Check.Visible = true;
                return;
            }
            String newPasswordValue = textBox_FirstInput.Text;

            if (User.Password.Equals(string.Empty) || User.Password == null)
            {
                if (!oldPasswordValue.Equals(string.Empty) || newPasswordValue.Equals(string.Empty))
                {
                    this.DialogResult = DialogResult.No;
                    return;
                }
            }
            else
            {
                if (oldPasswordValue.Equals(string.Empty) || newPasswordValue.Equals(string.Empty))
                {
                    this.DialogResult = DialogResult.No;
                    return;
                }
                var oldHash = accessController.GetPasswordHash(oldPasswordValue);
                if (!oldHash.Equals(User.Password))
                {
                    this.DialogResult = DialogResult.No;
                    return;
                }
                if (oldPasswordValue.Equals(newPasswordValue))
                {
                    this.DialogResult = DialogResult.No;
                    return;
                }
            }
            if (User.PasswordRestriction)
            {
                if (!Regex.IsMatch(newPasswordValue, @"^(?=.*[,.!?;:\-()])(?=.*[а-яА-ЯёЁ])(?=.*[a-zA-Z])(?!.*\s).*$"))
                {
                    this.DialogResult = DialogResult.No;
                    return;
                }
            }
            try
            {
                accessController.UpdatePassword(User, newPasswordValue, oldPasswordValue);
            }
            catch (Exception)
            {
                this.DialogResult = DialogResult.No;
                return;
            }
            newPassword = newPasswordValue;
            DialogResult = DialogResult.OK;
        }
    }
}
