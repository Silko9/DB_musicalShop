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
                Open();
                StreamReader streamReader = new StreamReader("createDB.txt");
                string commandText = streamReader.ReadToEnd();
                streamReader.Close();
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
                Open();
                StreamReader streamReader = new StreamReader("checkDB.txt");
                string[] check = streamReader.ReadToEnd().Split('\n');
                for (int i = 0; i < check.Length - 1; i++)
                {
                    check[i] = check[i].Remove(check[i].Length - 1);
                }
                streamReader.Close();
                DataTable table = SelectTable("select name from sqlite_master;");
                string tableStr = "";
                DataRow row;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    row = table.Rows[i];
                    tableStr = row["name"].ToString();
                    if (tableStr != check[i])
                        return false;
                }
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
            if(connection != null)
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
