using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using System.Data;

namespace WindowsFormsApplication1.Repositories
{
    public class Test
    {
        public long ID { get; private set; }
        public string Title { get; private set; }
        // классы в папке Repositories описывают таблицы в базе
        // вот в базе есть Test и там два поля Id и Title

        //  лол

        // тут методы для получения значений из базы (или вставке или удаления)

        // "select * from Test" - сам запрос, получает все из базы и возвращает массив

        // в общем делаешь Creatte table сначала, потом тут описываешь классами и методами, ок?

        // напиши тут - дальше
        public static IEnumerable<Test> select(DatabaseManager db)
        {
            var query = new DataTable();
            try
            {
                query = db.ExecuteQuery("select * from Test");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            var result = (from row in query.Select()
                          select new Test
                          {
                              ID = (long)row["id"],
                              Title = (string)row["title"]
                          }).ToList();
            return result;
        }

    }
}
