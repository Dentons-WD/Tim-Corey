using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLibrary.Models;
using DataAccessLibrary.Data;
using DataAccessLibrary.DbAccess;

namespace WinFormApp
{
    public partial class Dashboard : Form
    {
        BindingList<SystemUserModel> users = new BindingList<SystemUserModel>();

        SystemUserData data = new SystemUserData(new SqlDataAccess());

        public Dashboard()
        {
            InitializeComponent();

            userDisplayList.DataSource = users;
            userDisplayList.DisplayMember = "FullName";

            var records = data.GetSystemUsers().ToList();

            users.Clear();
            records.ForEach(x => users.Add(x));
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            SystemUserModel user = new SystemUserModel
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text
            };

            data.InsertSystemUser(user);

            firstNameText.Text = "";
            lastNameText.Text = "";
            firstNameText.Focus();

            var records = data.GetSystemUsers().ToList();

            users.Clear();
            records.ForEach(x => users.Add(x));
        }

        private void applyFilterButton_Click(object sender, EventArgs e)
        {
            var records = data.GetFilteredSystemUser(filterUsersText.Text).ToList();

            users.Clear();
            records.ForEach(x => users.Add(x));
        }
    }
}
