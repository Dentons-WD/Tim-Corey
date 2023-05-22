using DataAccessLibrary.DbAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Data
{
    public class SystemUserData
    {
        private readonly SqlDataAccess _db;

        public SystemUserData(SqlDataAccess db)
        {
            _db = db;
        }

        public IEnumerable<SystemUserModel> GetSystemUsers()
        {
            return _db.LoadData<SystemUserModel, dynamic>("dbo.spSystemUser_Get", new { });
        }

        public IEnumerable<SystemUserModel> GetFilteredSystemUser(string filter)
        {
            return _db.LoadData<SystemUserModel, dynamic>("dbo.spSystemUser_GetFiltered", new { Filter = filter });
        }

        public void InsertSystemUser(SystemUserModel user)
        {
            _db.SaveData("dbo.spSystemUser_Create", new { user.FirstName, user.LastName });
        }
    }
}
