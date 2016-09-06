using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace WindowsFormsApplication1
{
    public class DatabaseManager
    {
        public DataTable ExecuteQuery(string sqlQuery)
        {
            var query = new DataTable();
            try
            {
                using (var sqLiteConnection = new SQLiteConnection("data source=D:\\database.db; Version=3;"))
                {
                    sqLiteConnection.Open();
                    using (var cmd = new SQLiteCommand(sqLiteConnection) { CommandText = sqlQuery })
                    {
                        var reader = cmd.ExecuteReader();
                        query.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return query;
        }
        public void Delete(string sqlQuery)
        {
            try
            {
                using (var sqLiteConnection = new SQLiteConnection("data source=D:\\database.db; Version=3;"))
                {
                    sqLiteConnection.Open();
                    using (var cmd = new SQLiteCommand(sqLiteConnection) { CommandText = sqlQuery })
                    {
                        using (var transaction = sqLiteConnection.BeginTransaction())
                        {
                            cmd.ExecuteNonQuery();
                            transaction.Commit();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void Update(string sqlQuery)
        {
            try
            {
                using (var sqLiteConnection = new SQLiteConnection("data source=D:\\database.db; Version=3;"))
                {
                    sqLiteConnection.Open();
                    using (var cmd = new SQLiteCommand(sqLiteConnection) { CommandText = sqlQuery })
                    {
                        using (var transaction = sqLiteConnection.BeginTransaction())
                        {
                            cmd.ExecuteNonQuery();
                            transaction.Commit();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public long Insert(string sqlQuery)
        {
            long lastID = -1;
            try
            {
                using (var sqLiteConnection = new SQLiteConnection("data source=D:\\database.db; Version=3;"))
                {
                    sqLiteConnection.Open();
                    using (var cmd = new SQLiteCommand(sqLiteConnection) { CommandText = sqlQuery })
                    {
                        using (var transaction = sqLiteConnection.BeginTransaction())
                        {
                            cmd.ExecuteNonQuery();
                            transaction.Commit();
                        }
                    }
                    using (var cmd = new SQLiteCommand(sqLiteConnection) { CommandText = "SELECT last_insert_rowid()" })
                    {
                        lastID = (long) cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return lastID;
        }

        
    }
}
