using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace HelperLibrary
{
    public static class BusinessLogic
    {
        public static List<SystemUserModel> GetAllUsers()
        {
            return DataAccess.ReadData<SystemUserModel>("spSystemUser_Get", new { });
        }

        public static List<SystemUserModel> GetUsersFiltered(string filter)
        {
            var p = new
            {
                Filter = filter
            };

            return DataAccess.ReadData<SystemUserModel>("spSystemUser_GetFiltered", p);
        }

        public static void CreateUser(string firstName, string lastName)
        {
            var p = new
            {
                FirstName = firstName,
                LastName = lastName
            };

            DataAccess.WriteData<SystemUserModel>("dbo.spSystemUser_Create", p);
        }
    }
}
