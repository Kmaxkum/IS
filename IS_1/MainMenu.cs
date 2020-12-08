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
    public partial class MainMenu : Form
    {
        private bool rule;
        private AccessController accessController;

        public AccessController AccessController
        {
            set
            {
                accessController = value;
                rule = accessController.AuthorizedUser.Rule;
                if (!rule)
                {
                    button_UserList.Visible = false;
                }
            }
        }

        public MainMenu()
        {
            InitializeComponent();
        }

        private void button_ResetPassword_Click(object sender, EventArgs e)
        {
            var dialog = new ResetPassword();
            dialog.User = accessController.AuthorizedUser;
            dialog.accessController = accessController;
            if (dialog.ShowDialog() == DialogResult.No)
            {
                var result = MessageBox.Show("Error when changing password", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    Environment.Exit(0);
                }

            }
        }

        private void button_UserList_Click(object sender, EventArgs e)
        {
            var form = new UserList();
            form.AccessController = accessController;
            form.Show();
        }

        private void button_About_Click(object sender, EventArgs e)
        {
            var form = new About();
            form.Show();
        }
    }
}
