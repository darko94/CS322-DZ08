using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS322_DZ08
{
    public class FacebookUserDaoImpl : FacebookUserDao
    {
        DBConnect db = new DBConnect();

        public bool AddFacebookUser(FacebookUser facebookUser)
        {
            string query = "INSERT INTO facebook_user (first_name, last_name, mobile_or_email, password, birthday, gender) VALUES ('"
                + facebookUser.FirstName + "', '" + facebookUser.LastName + "', '" + facebookUser.MobileOrEmail + "', '"
                + facebookUser.Password + "', '" + facebookUser.Birthday + "', '" + facebookUser.Gender + "')";
            
            if (db.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

                cmd.ExecuteNonQuery();

                db.CloseConnection();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<FacebookUser> GetAllFacebookUsers()
        {
            string query = "SELECT * FROM facebook_user";
            List<FacebookUser> list = new List<FacebookUser>();

            if (db.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

                MySqlDataReader dataReader = cmd.ExecuteReader();



                while (dataReader.Read())
                {
                    FacebookUser facebookUser = new FacebookUser();
                    facebookUser.FirstName = dataReader["first_name"].ToString();
                    facebookUser.LastName = dataReader["last_name"].ToString();
                    facebookUser.MobileOrEmail= dataReader["mobile_or_email"].ToString();
                    facebookUser.Password = dataReader["password"].ToString();
                    facebookUser.Birthday = dataReader["birthday"].ToString();
                    facebookUser.Gender = dataReader["gender"].ToString();

                    list.Add(facebookUser);
                }
                dataReader.Close();

                db.CloseConnection();

            }
            return list;
        }
    }
}