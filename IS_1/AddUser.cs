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

namespace IS_1
{
    public partial class AddUser : Form
    {
        private AccessController accessController;

        public AccessController AccessController
        {
            set
            {
                accessController = value;
            }
        }

        public AddUser()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            String login = textBox_Login.Text;
            if (login.Equals(string.Empty))
            {
                var result = MessageBox.Show("Login is empty", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    Environment.Exit(0);
                }
                return;
            }
            if (accessController.UserIsExist(login))
            {
                var result = MessageBox.Show("Such a user exists", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    Environment.Exit(0);
                }
                return;
            }
            UserModel user = new UserModel();
            user.Login = login;
            user.PasswordRestriction = checkBox_PassRest.Checked;
            try
            {
                accessController.Register(user);
            }
            catch (Exception)
            {
                this.DialogResult = DialogResult.No;
                return;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
