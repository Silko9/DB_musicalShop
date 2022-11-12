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
                connection.Open();
                string commandText = "CREATE TABLE musicial_instrument (" +
                    "id_instrument INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                    "name_instrument VARCHAR(20) NOT NULL);";
                Query(commandText);
                commandText = "CREATE TABLE type_ensemble (" +
                    "id_type_ensemble INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                    "name_type_ensemble VARCHAR(15) NOT NULL);";
                Query(commandText);
                commandText = "CREATE TABLE ensemble (" +
                    "id_ensemble INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                    "name_ensemble VARCHAR(20) NOT NULL," +
                    "id_type_ensemble INTEGER NOT NULL);";
                Query(commandText);
                commandText = "CREATE TABLE role (" +
                    "id_role INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                    "name_role VARCHAR(15) NOT NULL);";
                Query(commandText);
                commandText = "CREATE TABLE musician (" +
                    "id_musician INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                    "name_musician VARCHAR(15) NOT NULL," +
                    "surname_musician VARCHAR(15) NOT NULL," +
                    "patronymic_musician VARCHAR(15)," +
                    "phote_musician BLOB," +
                    "id_ensemble INTEGER NOT NULL," +
                    "id_instrument INTEGER NOT NULL);";
                Query(commandText);
                commandText = "CREATE TABLE relation_musician_role (" +
                    "id_musician INTEGER NOT NULL," +
                    "id_role INTEGER NOT NULL, " +
                    "CONSTRAINT id_relation_role_musician PRIMARY KEY (id_musician, id_role));";
                Query(commandText);
                commandText = "CREATE TABLE composition (" +
                    "id_composition INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                    "name_composition VARCHAR(20) NOT NULL, " +
                    "name_author VARCHAR(15) NOT NULL, " +
                    "surname_author VARCHAR(15) NOT NULL, " +
                    "patronymic_author VARCHAR(15), " +
                    "date_create TEXT NOT NULL);";
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
                connection.Open();
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
                commandText = "SELECT id_role FROM role ORDER BY rowid ASC LIMIT 1;";
                Query(commandText);
                commandText = "SELECT name_role FROM role ORDER BY rowid ASC LIMIT 1;";
                Query(commandText);
                commandText = "SELECT id_musician FROM musician ORDER BY rowid ASC LIMIT 1;";
                Query(commandText);
                commandText = "SELECT name_musician FROM musician ORDER BY rowid ASC LIMIT 1;";
                Query(commandText);
                commandText = "SELECT surname_musician FROM musician ORDER BY rowid ASC LIMIT 1;";
                Query(commandText);
                commandText = "SELECT patronymic_musician FROM musician ORDER BY rowid ASC LIMIT 1;";
                Query(commandText);
                commandText = "SELECT phote_musician FROM musician ORDER BY rowid ASC LIMIT 1;";
                Query(commandText);
                commandText = "SELECT id_ensemble FROM musician ORDER BY rowid ASC LIMIT 1;";
                Query(commandText);
                commandText = "SELECT id_instrument FROM musician ORDER BY rowid ASC LIMIT 1;";
                Query(commandText);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Open()
        {
            connection.Open();
        }
        public void Close()
        {
            connection.Close();
        }
        public void Query(string commandText)
        {
            SQLiteCommand Command = new SQLiteCommand(commandText, connection);
            Command.ExecuteNonQuery();
        }
        public DataTable SelectTable(string commandText)
        {
            DataTable dt = new DataTable();
            SQLiteCommand Command = new SQLiteCommand(commandText, connection);
            SQLiteDataReader sqlReader = Command.ExecuteReader();
            dt.Load(sqlReader);
            return dt;
        }
        public List<string> SelectList(string commandText)
        {
            List<string> result = new List<string>();
            SQLiteCommand Command = new SQLiteCommand(commandText, connection);
            SQLiteDataReader sqlReader = Command.ExecuteReader();
            while (sqlReader.Read())
                result.Add(sqlReader.GetString(0).ToString());
            return result;
        }
        public int GetID(string str)
        {
            try
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
            catch
            {
                if (str != "") return Convert.ToInt32(str);
                else return 0;
            }
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
