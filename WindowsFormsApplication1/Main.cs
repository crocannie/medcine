using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Main
    {
        public DatabaseManager db;
        public Boolean auth = false;
        public Main()
        {
            db = new DatabaseManager();
            auth = false;
        }

    }
}
