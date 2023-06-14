using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextFileChallenge
{
    public partial class ChallengeForm : Form
    {
        BindingList<UserModel> users = new BindingList<UserModel>();
        int firstNameOrder = 0;
        int lastNameOrder = 0;
        int ageOrder = 0;
        int isAliveOrder = 0;
        string fileName = "StandardDataSet.csv";

        public ChallengeForm()
        {
            InitializeComponent();

            LoadListFromFile();

            WireUpDropDown();
        }

        private void LoadListFromFile()
        {
            // Load the file
            string[] lines = File.ReadAllLines(fileName);

            string[] headers = lines[0].Split(',');

            for (int i = 0; i < headers.Length; i++)
            {
                if (headers[i] == "FirstName")
                {
                    firstNameOrder = i;
                }
                else if (headers[i] == "LastName")
                {
                    lastNameOrder = i;
                }
                else if (headers[i] == "Age")
                {
                    ageOrder = i;
                }
                else if (headers[i] == "IsAlive")
                {
                    isAliveOrder = i;
                }
            }

            // Parse each line
            for (int i = 1; i < lines.Length; i++)
            {
                string[] columns = lines[i].Split(',');
                bool isAlive = false;

                if (columns[isAliveOrder] == "1")
                {
                    isAlive = true;
                }

                // Create a model from the line
                // Add model to list
                users.Add(new UserModel
                {
                    FirstName = columns[firstNameOrder],
                    LastName = columns[lastNameOrder],
                    Age = int.Parse(columns[ageOrder]),
                    IsAlive = isAlive
                });
            }
        }

        private void WireUpDropDown()
        {
            usersListBox.DataSource = users;
            usersListBox.DisplayMember = nameof(UserModel.DisplayText);
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            users.Add(new UserModel
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                Age = (int)agePicker.Value,
                IsAlive = isAliveCheckbox.Checked
            });

            firstNameText.Text = "";
            lastNameText.Text = "";
            agePicker.Value = 0;
            isAliveCheckbox.Checked = false;
        }

        private void saveListButton_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            string line = "";

            //lines.Add("FirstName,LastName,Age,IsAlive");

            for (int i = 0; i < 4; i++)
            {
                if(firstNameOrder == i)
                {
                    line += "FirstName";
                }
                else if (lastNameOrder == i)
                {
                    line += "LastName";
                }
                else if (ageOrder == i)
                {
                    line += "Age";
                }
                else if (isAliveOrder == i)
                {
                    line += "IsAlive";
                }

                line += ",";
            }

            line = line.Substring(0, line.Length -1);

            lines.Add(line);

            foreach (UserModel user in users)
            {
                int isAliveValue = 0;
                line = "";

                if (user.IsAlive == true)
                {
                    isAliveValue = 1;
                }

                for (int i = 0; i < 4; i++)
                {
                    if(firstNameOrder == i)
                    {
                        line += user.FirstName;
                    }
                    else if (lastNameOrder == i)
                    {
                        line += user.LastName;
                    }
                    else if (ageOrder == i)
                    {
                        line += user.Age;
                    }
                    else if (isAliveOrder == i)
                    {
                        line += isAliveValue;
                    }

                    line += ",";
                }

            line = line.Substring(0, line.Length -1);

            lines.Add(line);

                //lines.Add($"{ user.FirstName },{ user.LastName },{ user.Age },{ isAliveValue }");
            }

            File.WriteAllLines(fileName, lines);

            MessageBox.Show("Save Complete");
        }
    }
}
