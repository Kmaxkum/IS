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
    public partial class UserList : Form
    {
        private AccessController accessController;

        public AccessController AccessController
        {
            set
            {
                accessController = value;
                FilledDataGridView();
            }
        }

        public UserList()
        {
            InitializeComponent();
        }

        public void FilledDataGridView()
        {
            dataGridView_Users.DataSource = accessController.GetUsers().Users;
            dataGridView_Users.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView_Users.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView_Users.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView_Users.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView_Users.Columns[3].Visible = false;
            dataGridView_Users.ReadOnly = true;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            var dialog = new AddUser();
            dialog.AccessController = accessController;
            if (dialog.ShowDialog() == DialogResult.No)
            {
                var result = MessageBox.Show("Add user error occured", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                dataGridView_Users.DataSource = null;
                FilledDataGridView();
            }

            dataGridView_Users.Refresh();
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            int selected = dataGridView_Users.SelectedCells[0].RowIndex;
            
            try
            {
                var user = accessController.FindUser(dataGridView_Users.Rows[selected].Cells["Login"].Value.ToString());
                var dialog = new ChangeUser();
                dialog.AccessController = accessController;
                dialog.SeletedUser = user;
                if (dialog.ShowDialog() == DialogResult.No)
                {
                    var result = MessageBox.Show("Change user error occured", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        Environment.Exit(0);
                    }
                }
            }
            catch (Exception)
            {
                var result = MessageBox.Show("Select user error occured", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    Environment.Exit(0);
                }
            }

            dataGridView_Users.Refresh();
        }
    }
}
