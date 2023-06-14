using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileChallenge
{
    public static class ReadWriteLogic
    {
        //public static List<UserModel> ReadUsers()
        //{
        //    List<UserModel> users = new List<UserModel>();
        //    List<string> lines = File.ReadAllLines(@"..\..\StandardDataSet.csv").ToList();

        //    lines.RemoveAt(0);

        //    foreach(string line in lines)
        //    {
        //        UserModel newUser = new UserModel();

        //        var values = line.Split(',');

        //        newUser.FirstName = values[0];
        //        newUser.LastName = values[1];
        //        newUser.Age = int.Parse(values[2]);

        //        if (values[3] == "1")
        //        {
        //            newUser.IsAlive = true;
        //        }
        //        else
        //        {
        //            newUser.IsAlive = false;
        //        }

        //        users.Add(newUser);
        //    }

        //    return users;
        //}

        //public static void WriteUsers(List<UserModel> users)
        //{
        //    List<string> lines = new List<string>();

        //    lines.Add("FirstName,LastName,Age,IsAlive");

        //    foreach(var user in users)
        //    {
        //        string isAlive = "0";

        //        if (user.IsAlive)
        //        {
        //            isAlive = "1";
        //        }

        //        lines.Add($"{ user.FirstName },{ user.LastName },{ user.Age },{ isAlive }");
        //    }

        //    File.WriteAllLines(@"..\..\StandardDataSet.csv", lines);
        //}

        public static (int firstNameIndex, int lastNameIndex, int ageIndex, int isAliveIndex) GetColumnIndexes()
        {
            List<string> lines = File.ReadAllLines(@"..\..\AdvancedDataSet.csv").ToList();

            int FirstNameIndex = 0;
            int LastNameIndex= 0;
            int AgeIndex = 0;
            int IsAliveIndex = 0;

            List<string> columns = lines[0].Split(',').ToList();

            for (int i = 0; i < columns.Count; i++)
            {
                switch (columns[i])
                {
                    case "FirstName":
                        FirstNameIndex = i;
                        break;
                    case "LastName":
                        LastNameIndex = i;
                        break;
                    case "Age":
                        AgeIndex = i;
                        break;
                    case "IsAlive":
                        IsAliveIndex = i;
                        break;
                }
            }

            return (FirstNameIndex, LastNameIndex, AgeIndex, IsAliveIndex);
        }

        public static List<UserModel> ReadUsers()
        {
            List<UserModel> users = new List<UserModel>();
            List<string> lines = File.ReadAllLines(@"..\..\AdvancedDataSet.csv").ToList();

            int FirstNameIndex = 0;
            int LastNameIndex= 0;
            int AgeIndex = 0;
            int IsAliveIndex = 0;

            (FirstNameIndex, LastNameIndex, AgeIndex, IsAliveIndex) = GetColumnIndexes();


            lines.RemoveAt(0);

            foreach(string line in lines)
            {
                UserModel newUser = new UserModel();

                var values = line.Split(',');

                newUser.FirstName = values[FirstNameIndex];
                newUser.LastName = values[LastNameIndex];
                newUser.Age = int.Parse(values[AgeIndex]);

                if (values[IsAliveIndex] == "1")
                {
                    newUser.IsAlive = true;
                }
                else
                {
                    newUser.IsAlive = false;
                }

                users.Add(newUser);
            }

            return users;
        }
    }
}
