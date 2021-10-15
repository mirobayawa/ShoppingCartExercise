using System;
using System.Windows.Forms;

namespace WindowsFormsExercise1
{
    public partial class DashboardForm : Form
    {

        public DashboardForm()
        {
            InitializeComponent();
            addHomePanel();
            addUserListPanel();
        }

        private void addHomePanel()
        {
            HomeForm homeForm = new HomeForm();
            homeForm.TopLevel = false;
            homeForm.AutoScroll = true;
            homePanel.Controls.Add(homeForm);
            homeForm.Show();
        }

        private void addUserListPanel()
        {
            ShoppingListForm userListForm = new ShoppingListForm();
            userListForm.TopLevel = false;
            userListForm.AutoScroll = true;
            userListPanel.Controls.Add(userListForm);
            userListForm.Show();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            userListPanel.Hide();
            homePanel.Show();
        }

        private void userListButton_Click(object sender, EventArgs e)
        {
            userListPanel.Show();
            homePanel.Hide();
        }

    }
}
