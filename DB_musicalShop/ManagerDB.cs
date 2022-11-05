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
using System.Text.RegularExpressions;
using System.Xml.Linq;

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
                string commandText = "SELECT id_instrument FROM musicial_instrument ORDER BY rowid ASC LIMIT 1;";
                Query(commandText);
                commandText = "SELECT name_instrument FROM musicial_instrument ORDER BY rowid ASC LIMIT 1;";
                Query(commandText);
                commandText = "SELECT id_type_ensemble FROM type_ensemble ORDER BY rowid ASC LIMIT 1;";
                Query(commandText);
                commandText = "SELECT name_type_ensemble FROM type_ensemble ORDER BY rowid ASC LIMIT 1;";
                Query(commandText);
                commandText = "SELECT id_ensemble FROM ensemble ORDER BY rowid ASC LIMIT 1;";
                Query(commandText);
                commandText = "SELECT name_ensemble FROM ensemble ORDER BY rowid ASC LIMIT 1;";
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
        public DataTable SelectTable(string commandText)
        {
            DataTable dt = new DataTable();
            SQLiteCommand Command = new SQLiteCommand(commandText, connection);
            connection.Open();
            SQLiteDataReader sqlReader = Command.ExecuteReader();
            dt.Load(sqlReader);
            connection.Close();
            return dt;
        }
        public List<string> SelectList(string commandText)
        {
            List<string> result = new List<string>();
            SQLiteCommand Command = new SQLiteCommand(commandText, connection);
            connection.Open();
            SQLiteDataReader sqlReader = Command.ExecuteReader();
            string lol;
            while (sqlReader.Read())
                result.Add(sqlReader.GetString(0).ToString());
            connection.Close();
            return result;
        }
        public int GetID(string str)
        {
            string id = "";
            for (int i = 0; i < str.Length; i++)
                if (str[i] == '[')
                {
                    i += 3;
                    while (str[i] != ']')
                    {
                        id += str[i];
                        i++;
                    }
                }
            return Convert.ToInt32(id);
        }
        public bool IsMatch(string str)
        {
            Regex regex = new Regex(@"^[\w \s]+$");
            if (!regex.IsMatch(str))
                return false;
            return true;
        }
    }
}
