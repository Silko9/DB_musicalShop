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
        private SQLiteConnection connection;
        private string path;
        public string Path { get { return path; } }
        
        public ManagerDB()
        {

        }
        public int CreateDB(string path)
        {
            this.path = path;
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
                string commandText = "CREATE TABLE type_ensemble (" +
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
                    "phote_musician BLOB);";
                Query(commandText);
                commandText = "CREATE TABLE relation_musician_role (" +
                    "id_musician INTEGER NOT NULL," +
                    "id_role INTEGER NOT NULL, " +
                    "CONSTRAINT id_relation_role_musician PRIMARY KEY (id_musician, id_role));";
                Query(commandText);
                commandText = "CREATE TABLE relation_musician_ensemble (" +
                    "id_musician INTEGER NOT NULL," +
                    "id_ensemble INTEGER NOT NULL, " +
                    "CONSTRAINT id_relation_ensemble_musician PRIMARY KEY (id_musician, id_ensemble));";
                Query(commandText);
                commandText = "CREATE TABLE composition (" +
                    "id_composition INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                    "name_composition VARCHAR(20) NOT NULL, " +
                    "name_author VARCHAR(15) NOT NULL, " +
                    "surname_author VARCHAR(15) NOT NULL, " +
                    "patronymic_author VARCHAR(15), " +
                    "date_create TEXT NOT NULL);";
                Query(commandText);
                commandText = "CREATE TABLE performance (" +
                    "id_performance INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                    "date_performance TEXT NOT NULL, " +
                    "id_ensemble INTEGER NOT NULL, " +
                    "id_composition INTEGER NOT NULL, " +
                    "circumstances_execution VARCHAR(200));";
                Query(commandText);
                commandText = "CREATE TABLE record (" +
                    "number_record VARCHAR(10) PRIMARY KEY NOT NULL," +
                    "retail_price DOUBLE NOT NULL, " +
                    "wholesale_price DOUBLE NOT NULL, " +
                    "id_composition INTEGER NOT NULL);";
                Query(commandText);
                commandText = "CREATE TABLE relation_record_performance (" +
                    "number_record VARCHAR(10) NOT NULL," +
                    "id_performance INTEGER NOT NULL, " +
                    "CONSTRAINT id_relation_record_performance PRIMARY KEY (number_record, id_performance));";
                Query(commandText);
                commandText = "CREATE TABLE operation (" +
                    "id_operation INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                    "name_operation VARCHAR(15) NOT NULL);";
                Query(commandText);
                commandText = "INSERT INTO operation (name_operation) VALUES(\"Поступление\");";
                Query(commandText);
                commandText = "INSERT INTO operation (name_operation) VALUES(\"Продажа\");";
                Query(commandText);
                commandText = "CREATE TABLE logging (" +
                    "id_log INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                    "number_record VARCHAR(10) NOT NULL, " +
                    "id_operation INTEGER NOT NULL, " +
                    "date_log TEXT NOT NULL, " +
                    "year TEXT NOT NULL, " +
                    "amount INTEGER NOT NULL);";
                Query(commandText);
                commandText = "CREATE TRIGGER delete_musician BEFORE DELETE ON musician " +
                    "BEGIN " +
                    "DELETE FROM relation_musician_role WHERE id_musician = OLD.id_musician; " +
                    "DELETE FROM relation_musician_ensemble WHERE id_musician = OLD.id_musician; " +
                    "END;";
                Query(commandText);
                commandText = "CREATE TRIGGER delete_role BEFORE DELETE ON role " +
                    "BEGIN " +
                    "DELETE FROM relation_musician_role WHERE id_role = OLD.id_role; " +
                    "END;";
                Query(commandText);
                commandText = "CREATE TRIGGER delete_ensemble BEFORE DELETE ON ensemble " +
                    "BEGIN " +
                    "DELETE FROM relation_musician_ensemble WHERE id_ensemble = OLD.id_ensemble; " +
                    "END;";
                Query(commandText);
                commandText = "CREATE TRIGGER delete_record BEFORE DELETE ON record " +
                    "BEGIN " +
                    "DELETE FROM relation_record_performance WHERE number_record = OLD.number_record; " +
                    "END;";
                Query(commandText);
                commandText = "CREATE TRIGGER delete_performance BEFORE DELETE ON performance " +
                    "BEGIN " +
                    "DELETE FROM relation_record_performance WHERE id_performance = OLD.id_performance; " +
                    "END;";
                Query(commandText);
                commandText = "CREATE TRIGGER update_record AFTER UPDATE ON record " +
                    "BEGIN " +
                    "UPDATE relation_record_performance SET number_record = NEW.number_record WHERE number_record = OLD.number_record; " +
                    "UPDATE logging SET number_record = NEW.number_record WHERE number_record = OLD.number_record; " +
                    "END;";
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
            this.path = path;
            try
            {
                connection = new SQLiteConnection($@"Data Source={path}; Version=3;");
                connection.Open();
                string commandText = "SELECT id_type_ensemble FROM type_ensemble ORDER BY rowid ASC LIMIT 1;";
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
        public void QueryImg(string commandText, byte[] imageBytes)
        {
            SQLiteCommand Command = new SQLiteCommand(commandText, connection);
            Command.Parameters.AddWithValue("@phote", imageBytes);
            Command.ExecuteNonQuery();
        }
        public byte[] rgbytedreaderExecute(string FileData, string sSql)
        {
            byte[] data = null;
            SQLiteDataReader dr = null;
            using (SQLiteConnection con = new SQLiteConnection())
            {
                con.ConnectionString = @"Data Source=" + FileData;
                con.Open();
                using (SQLiteCommand sqlCommand = con.CreateCommand())
                {
                    sqlCommand.CommandText = sSql;
                    dr = sqlCommand.ExecuteReader();
                }
                dr.Read();
                data = GetBytes(dr);
                dr.Close();
                con.Close();
            }
            return data;
        }
        private static byte[] GetBytes(SQLiteDataReader reader)
        {
            byte[] bDate = new byte[1024];
            long lRead = 0;
            long lOffset = 0;
            using (MemoryStream memorystream = new MemoryStream())
            {
                while ((lRead = reader.GetBytes(0, lOffset, bDate, 0, bDate.Length)) > 0)
                {
                    byte[] bRead = new byte[lRead];
                    Buffer.BlockCopy(bDate, 0, bRead, 0, (int)lRead);
                    memorystream.Write(bRead, 0, bRead.Length); 
                    lOffset += lRead;
                }
                return memorystream.ToArray();
            }
        }
        public DataTable SelectTable(string commandText)
        {
            DataTable dt = new DataTable();
            SQLiteCommand Command = new SQLiteCommand(commandText, connection);
            SQLiteDataReader sqlReader = Command.ExecuteReader();
            dt.Load(sqlReader);
            return dt;
        }
    }
}
