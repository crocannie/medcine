using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using System.Data;


using System.Windows.Forms;
namespace WindowsFormsApplication1.Repositories
{
    public class Diseases
    {
        public long id { get; private set; }
        public string title { get; private set; }

        public static IEnumerable<Diseases> getAllDiseases(DatabaseManager db)
        {
            var query = new DataTable();
            try
            {
                query = db.ExecuteQuery("select * from diseases");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            var result = (from row in query.Select()
                          select new Diseases
                          {
                              id = (long)row["id"],
                              title = (string)row["title"]
                          }).ToList();
            return result;
        }


        public static IEnumerable<Diseases> diseasesByMed(DatabaseManager db, string med)
        {
            var query = new DataTable();
            try
            {
                string sql = "select d.id AS id, d.title AS title ";
                sql += "from diseases d, diseasesMedications dm ";
                sql += "where d.id = dm.IDDiseases and dm.idMedications = " + med;
                query = db.ExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            var result = (from row in query.Select()
                          select new Diseases
                          {
                              id = (long)row["id"],
                              title = (string)row["title"]
                          }).ToList();

            return result;
        }

        public static IEnumerable<Diseases> contrDiseasesByMed(DatabaseManager db, string med)
        {
            string sql = "select d.id, d.title ";
            sql += "from diseases d, contraindications c ";
            sql += "where d.id = c.idDiseases and c.idMedications = " + med;

            var query = new DataTable();
            try
            {
                query = db.ExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            var result = (from row in query.Select()
                          select new Diseases
                          {
                              id = (long)row["id"],
                              title = (string)row["title"]
                          }).ToList();
            return result;
        }

        public static void addDisease(DatabaseManager db, string title, List<long> symptoms) {
            
            long disID = -1;
            try
            {
                string sql = "insert into diseases (title) values ('" + title + "')";
                disID = db.Insert(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            try
            {
                foreach (long id_sympt in symptoms)
                {
                    string sql = "insert into DiseasesSymptoms (IDDiseases, IDSymptoms) ";
                    sql += "values (" + disID.ToString() + ", " + id_sympt.ToString() + ")";
                    db.Insert(sql);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void editDisease(DatabaseManager db, long id, string title, List<long> symptoms)
        {
            try
            {
                string sql = "delete from DiseasesSymptoms where IDDiseases = " + id.ToString();
                db.Delete(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            try
            {
                string sql = "update diseases set title = '" + title + "' where id = " + id.ToString();
                db.Update(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            try
            {
                foreach (long id_sympt in symptoms)
                {
                    string sql = "insert into DiseasesSymptoms (IDDiseases, IDSymptoms) ";
                    sql += "values (" + id.ToString() + ", " + id_sympt.ToString() + ")";
                    db.Insert(sql);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void deleteDisease(DatabaseManager db, long id)
        {
            try
            {
                string sql = "delete from Contraindications where IDDiseases = " + id.ToString();
                db.Delete(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            try
            {
                string sql = "delete from DiseasesMedications where IDDiseases = " + id.ToString();
                db.Delete(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            try
            {
                string sql = "delete from DiseasesSymptoms where IDDiseases = " + id.ToString();
                db.Delete(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            try
            {
                string sql = "delete from Diseases where ID = " + id.ToString();
                db.Delete(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static IEnumerable<Diseases> getDiseasesBySymptoms(DatabaseManager db, string symptoms)
        {
            string sql = "select distinct d.id AS id, d.title AS title ";
            sql += "from diseases d, diseasessymptoms ds ";
            sql += "where d.id = ds.iddiseases AND ds.idsymptoms in (" + symptoms + ")";


            var query = new DataTable();
            try
            {
                query = db.ExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            var result = (from row in query.Select()
                          select new Diseases
                          {
                              id = (long)row["id"],
                              title = (string)row["title"]
                          }).ToList();
            return result;
        }

        public static string getTitleById(DatabaseManager db, string id)
        {
            string sql = "select title AS title from diseases ";
            sql += "where id = " + id;

            var query = new DataTable();
            try
            {
                query = db.ExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            var res = (from row in query.Select() select row["title"]).ToList();
            return res[0].ToString();
        }
    }
}
