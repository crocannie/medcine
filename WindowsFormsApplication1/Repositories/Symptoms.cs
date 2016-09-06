using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using System.Data;

namespace WindowsFormsApplication1.Repositories
{
    public class Symptoms
    {
        public long id { get; private set; }
        public string title { get; private set; }

        public static IEnumerable<Symptoms> symptomsByDisease(DatabaseManager db, string idDisease)
        {
            var query = new DataTable();
            try
            {
                string sql = "select s.id, s.title ";
                sql += "from symptoms s, diseasesSymptoms d ";
                sql += "where s.id = d.idSymptoms and ";
                sql += "d.idDiseases = " + idDisease;
                query = db.ExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            var result = (from row in query.Select()
                          orderby row["title"]
                          select new Symptoms
                          {
                              id = (long)row["id"],
                              title = (string)row["title"]
                          }).ToList();
            return result;
        }

        public static void addSymptom(DatabaseManager db, string title)
        {
            string sql = "insert into symptoms (title) values ('" + title + "')";
            try
            {
                db.Insert(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void deleteSymptom(DatabaseManager db, long id)
        {
            try
            {
                string sql = "delete from DiseasesSymptoms where IDSymptoms = " + id.ToString();
                db.Delete(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            try
            {
                string sql = "delete from Symptoms where ID = " + id.ToString();
                db.Delete(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static IEnumerable<Symptoms> getAllSymptoms(DatabaseManager db)
        {
            var query = new DataTable();
            try
            {
                query = db.ExecuteQuery("select * from symptoms");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            var result = (from row in query.Select()
                          orderby row["title"]
                          select new Symptoms
                          {
                              id = (long)row["id"],
                              title = (string)row["title"]
                          }).ToList();


            return result;
        }



        public static void editSymptom(DatabaseManager db, long id, string title)
        {
            try
            {
                string sql = "update symptoms set title = '" + title + "' where id = " + id.ToString();
                db.Update(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}
