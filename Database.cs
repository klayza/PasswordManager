// Clayton Wieberg
// 12-9-21
// Password Manager
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    class Database
    {
        // Gets a list of users from database
        public static List<User> GetUsers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("Users")))
            {
                var output = cnn.Query<User>("select * from Users", new DynamicParameters());
                return output.ToList();
            }
        }

        // Saves a user to the database
        public static void SaveUser(User user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("Users")))
            {
                cnn.Execute("insert into Users (Username, Password) values (@Username, @Password)", user);
            }
        }

        // Gets a list of passwords from database
        public static List<UserPasswordInfo> GetPasswordInfo()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("Users")))
            {
                var output = cnn.Query<UserPasswordInfo>("select * from Passwords", new DynamicParameters());
                return output.ToList();
            }
        }

        // Saves a users password info to the database
        public static void SavePasswordInfo(UserPasswordInfo userpasswordinfo)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("Users")))
            {
                cnn.Execute("insert into Passwords(Title, Username, Password, DateCreated, DateLastViewed, Note, Owner) values (@Title, @Username, @Password, @DateCreated, @DateLastViewed, @Note, @Owner)", userpasswordinfo);
            }
        }


        // Loads the connection string
        private static string LoadConnectionString(string id)
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
