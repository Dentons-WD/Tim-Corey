using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TextFileChallenge.ReadWriteLogic;

namespace TextFileChallenge
{
    public partial class ChallengeForm : Form
    {
        BindingList<UserModel> users = new BindingList<UserModel>();

        public ChallengeForm()
        {
            InitializeComponent();

            LoadUsers();

            WireUpDropDown();
        }

        private void WireUpDropDown()
        {
            usersListBox.DataSource = users;
            usersListBox.DisplayMember = nameof(UserModel.DisplayText);
        }

        private void LoadUsers()
        {
            users = new BindingList<UserModel>(ReadUsers());
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            UserModel newUser = new UserModel
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                Age = (int)agePicker.Value,
                IsAlive = isAliveCheckbox.Checked
            };

            users.Add(newUser);
            WireUpDropDown();
        }

        private void saveListButton_Click(object sender, EventArgs e)
        {
            WriteUsers(users.ToList());
        }
    }
}
