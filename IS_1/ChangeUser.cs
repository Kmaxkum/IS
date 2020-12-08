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
    public partial class ChangeUser : Form
    {
        private UserModel user;
        private AccessController accessController;

        public AccessController AccessController
        {
            set
            {
                accessController = value;
            }
        }

        public UserModel SeletedUser
        {
            set
            {
                user = value;
                checkBox_Ban.Checked = (user.AuthCnt >= accessController.BanCnt() ? true : false);
                if (user.Rule)
                {
                    checkBox_Ban.Visible = false;
                }
                checkBox_PassRest.Checked = user.PasswordRestriction;
                label_UserLogin.Text = user.Login;
            }
        }

        public ChangeUser()
        {
            InitializeComponent();
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            try
            {
                accessController.UpdateAccountAccessRights(user.Login,(checkBox_Ban.Checked ? 3 : 0), checkBox_PassRest.Checked);
            }
            catch (Exception)
            {
                DialogResult = DialogResult.No;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
