using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;
using System.Runtime.Remoting.Contexts;
using System.IO;
using System.Diagnostics;

namespace DB_musicalShop
{
    public class ManagerDB
    {
        SQLiteConnection connection;
        public ManagerDB()
        {

        }
        public int CreateDB(string path)
        {
            try
            {
                SQLiteConnection.CreateFile(path);
            }
            catch
            {
                return 1;
            }
            try
            {
                connection = new SQLiteConnection($@"Data Source={path}; Version=3;");
                string commandText = "CREATE TABLE [musicial_instrument] (" +
                    "[id_instrument] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                    "[name_instrument] VARCHAR(15) NOT NULL);";
                Query(commandText);
                commandText = "CREATE TABLE [type_ensemble] (" +
                    "[id_type_ensemble] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                    "[name_type_ensemble] VARCHAR(15) NOT NULL);";
                Query(commandText);
                commandText = "CREATE TABLE [ensemble] (" +
                    "[id_ensemble] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                    "[name_ensemble] VARCHAR(20) NOT NULL," +
                    "[id_type_ensemble] INTEGER NOT NULL);";
                Query(commandText);
                return 0;
            }
            catch
            {
                return 2;
            }
        }
        public bool CheckDB(string path)
        {
            try
            {
                connection = new SQLiteConnection($@"Data Source={path}; Version=3;");
                string commandText = "SELECT * FROM [musicial_instrument];";
                Query(commandText);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Query(string commandText)
        {
            SQLiteCommand Command = new SQLiteCommand(commandText, connection);
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
        }
        public DataTable Select(string commandText)
        {
            DataTable dt = new DataTable();
            SQLiteCommand Command = new SQLiteCommand(commandText, connection);
            connection.Open();
            SQLiteDataReader sqlReader = Command.ExecuteReader();
            dt.Load(sqlReader);
            connection.Close();
            return dt;
        }
    }
}
