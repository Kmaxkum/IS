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
    public partial class Auth : Form
    {
        private AccessController accessController;

        public Auth()
        {
            InitializeComponent();

            textBox_Password.PasswordChar = '*';
            textBox_Password.MaxLength = 16;

            accessController = new AccessController();
        }

        private void button_SingIn_Click(object sender, EventArgs e)
        {
            UserModel user = null;
            try
            {
                user = accessController.FindUser(textBox_Login.Text);
                if (user.AuthCnt >= accessController.BanCnt())
                {
                    var result = MessageBox.Show("You accaunt is ban", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) {
                        Environment.Exit(0);
                    }
                    return;
                }
                if (user.Password.Equals(string.Empty) || user.Password == null)
                {
                    var dialog = new ResetPassword();
                    dialog.User = user;
                    dialog.accessController = accessController;
                    if (dialog.ShowDialog() == DialogResult.No)
                    {
                        var result = MessageBox.Show("Error when changing password", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                        {
                            Environment.Exit(0);
                        }

                    }
                    return;
                }
            }
            catch (Exception)
            {
                var result = MessageBox.Show("Incorrect login", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    Environment.Exit(0);
                }
                return;
            }
            if (user != null)
            {
                try
                {
                    if (!accessController.Login(textBox_Login.Text, textBox_Password.Text))
                    {
                        var result = MessageBox.Show("Incorrect password", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                        {
                            Environment.Exit(0);
                        }
                        return;
                    }
                    if (user.PasswordRestriction)
                    {
                        if (!Regex.IsMatch(textBox_Password.Text, @"^(?=.*[,.!?;:\-()])(?=.*[а-яА-ЯёЁ])(?=.*[a-zA-Z])(?!.*\s).*$"))
                        {
                            var dialog = new ResetPassword();
                            dialog.User = user;
                            dialog.accessController = accessController;
                            if (dialog.ShowDialog() == DialogResult.No)
                            {
                                var result = MessageBox.Show("Error when changing password", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.No)
                                {
                                    Environment.Exit(0);
                                }

                            }
                            return;
                        }
                    }
                }
                catch (Exception)
                {
                    var result = MessageBox.Show("You ran out of login attempts", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        Environment.Exit(0);
                    }
                    return;
                }
                var main = new MainMenu();
                main.AccessController = accessController;
                main.Show();
            }
        }
    }
}
