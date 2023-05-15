using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace DonSigaron.Classes
{
    public class DBFunctions
    {
        DataBase database = new DataBase();

        public int getUserID()
        {
            DataTable tableTakingUserID = new DataTable();
            tableTakingUserID = sqlSelect($"SELECT id FROM customers WHERE username = '{VariableStorage.userName}'");
            int userID = Convert.ToInt32(tableTakingUserID.Rows[0][0]);
            return userID;
        }

        public DataTable sqlSelect(String request)
        {
            SqlCommand command = new SqlCommand(request);
            command.Connection = database.GetConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public SqlCommand sqlInsert(String querystring)
        {
            database.openConnection();
            SqlCommand command = new SqlCommand(querystring);
            command.Connection = database.GetConnection();
            return command;
            //I know that it's bullshit but i don't want to rewrite code
            database.closeConnection();
        }

        public Boolean CheckAccauntInExistDB(string chaeckUsername, string checkEmail)
        {
            if (sqlSelect($"select username, email from customers where username = '{chaeckUsername}' OR email = '{checkEmail}'").Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<string> GetTableNamesFromDatabase()
        {
            List<string> tableNames = new List<string>();

            DataTable tables = new DataTable();
            tables = sqlSelect("SELECT name FROM sys.tables WHERE type = 'U'");


            foreach (DataRow row in tables.Rows)
            {
                tableNames.Add(row["name"].ToString());
            }

            return tableNames;
        }
        public List<string> GetNamesFromTable()
        {
            List<string> namesList = new List<string>();

            using (SqlConnection connection = new SqlConnection(DataBase.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT name FROM products", connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    namesList.Add(reader["name"].ToString());
                }

                reader.Close();
            }

            return namesList;
        }
    }
}
