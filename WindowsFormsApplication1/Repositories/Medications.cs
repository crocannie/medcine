using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace WindowsFormsApplication1.Repositories
{
    public class Medications
    {
        public long id { get; private set; }
        public string title { get; private set; }
        public string description { get; private set; }
        public long price { get; private set; }
        public string dose {get; private set; }
        public string search { get; private set; }

        public void setID(long id)
        {
            this.id = id;
        }

        public static IEnumerable<Medications> getAllMedications(DatabaseManager db)
        {
            var query = new DataTable();
            try
            {
                query = db.ExecuteQuery("select * from medications order by price");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            var result = (from row in query.Select()
                          select new Medications
                          {
                              id = (long)row["id"],
                              title = (string)row["title"],
                              description = (string)row["description"],
                              price = (long)row["price"],
                           //   dose = (string)row["dose"],
                          }).ToList();

            return result;
        }

        //Добавление нового ЛС в справочник
        public static long addMed(DatabaseManager db, string title, int price, string dose, string description, List<long> pokaz, List<long> protiv) 
        {
            long medID = -1;
            try
            {
                string lower_title = title.ToLower();
                string sql = "insert into medications (title, search, description, price, dose) values ";
                sql += "('" + title + "', '" + lower_title + "', ";
                sql += "'" + description + "', " + price + ", '" + dose +"')";
                medID = db.Insert(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            try
            {
                foreach (long id_disease in pokaz)
                {
                    string sql = "insert into DiseasesMedications (IDDiseases, IDMedications) ";
                    sql += "values (" + id_disease.ToString() + ", " + medID.ToString() + ")";
                    db.Insert(sql);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            try
            {
                foreach (long id_contr in protiv)
                {
                    string sql = "insert into Contraindications (IDMedications, IDDiseases) ";
                    sql += "values (" + medID.ToString() + ", " + id_contr.ToString() +")";
                    db.Insert(sql);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return medID;
        }


        public static void deleteMed(DatabaseManager db, long id)
        {
            try
            {
                string sql = "delete from Contraindications where IDMedications = " + id.ToString();
                db.Delete(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            try
            {
                string sql = "delete from DiseasesMedications where IDMedications = " + id.ToString();
                db.Delete(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            try
            {
                string sql = "delete from Medications where ID = " + id.ToString();
                db.Delete(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        //
        public static int countDiseasesByMed(DatabaseManager db, string diseases, string meds)
        {
            string sql = "select count(*) AS cnt from diseasesMedications ";
            sql += "where idMedications = " + meds + " and idDiseases in (" + diseases + ")";

            var query = new DataTable();
            try
            {
                query = db.ExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            var res = (from row in query.Select() select row["cnt"]).ToList();
            if (res.Count() == 0)
            {
                return 0;
            }
            return Int32.Parse(res[0].ToString());
        }

        public static string descriptionByMedId(DatabaseManager db, string id)
        {
            string sql = "select description from medications where id = " + id;

            var query = new DataTable();
            try
            {
                query = db.ExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            var res = (from row in query.Select() select row["description"]).ToList();
            if (res.Count() == 0)
            {
                return "";
            }
            return res[0].ToString();
        }
        public static string priceByMedId(DatabaseManager db, string id)
        {
            string sql = "select price from medications where id = " + id;

            var query = new DataTable();
            try
            {
                query = db.ExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            var res = (from row in query.Select() select row["price"]).ToList();
            if (res.Count() == 0)
            {
                return "";
            }
            return res[0].ToString();
        }

        //
        public static string doseByMeId(DatabaseManager db, string id)
        {
            string sql = "select dose from medications where id = " + id;
            
            var query = new DataTable();
            try
            {
                query = db.ExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            var res = (from row in query.Select() select row["dose"]).ToList();
            if (res.Count() == 0)
            {
                return "";
            }
            return res[0].ToString();
}
        //
        public static IEnumerable<Medications> getMedicationsByDiseases(DatabaseManager db, string diseases)
        {
            string sql = "select distinct m.id AS id, m.title AS title, m.description AS description, m.price AS price ";
            sql += "from medications m, diseasesMedications dm ";
            sql += "where m.id = dm.idMedications AND dm.idDiseases in (" + diseases + ") order by price";
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
                          select new Medications
                          {
                              id = (long)row["id"],
                              title = (string)row["title"],
                              description = (string)row["description"],
                              price = (long)row["price"]
                              //dose = (string)row["dose"]
                          }).ToList();
            return result;
        }

        public static IEnumerable<Medications> getGoodMedicationsByContraindications(DatabaseManager db, string contraindications)
        {
            string sql = "select distinct m.id AS id, m.title AS title, m.description AS description, m.price AS price from medications m ";
            sql += "where m.id not in (select idmedications from contraindications where iddiseases in (" + contraindications + ")) order by price";
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
                          select new Medications
                          {
                              id = (long)row["id"],
                              title = (string)row["title"],
                              description = (string)row["description"],
                              price = (long)row["price"]
                          }).ToList();
            return result;
        }

        public static IEnumerable<Medications> getByTitle(DatabaseManager db, string title)
        {
            title = title.ToLower();
            string sql = "select * from Medications ";
            sql += "where search like '%" + title + "%'";
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
                          select new Medications
                          {
                              id = (long)row["id"],
                              title = (string)row["title"],
                              description = (string)row["description"],
                              price = (long)row["price"]
                          }).ToList();

            return result;
        }
    }
}
