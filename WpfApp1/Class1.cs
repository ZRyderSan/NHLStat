using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace WpfApp1
{
    internal class Class1
    {
        string inser = "INSERT INTO Teams Values(NULL,\"Dinamo.M\",NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL)";
        //string selec = "SELECT * FROM List";
        public void sqlC()
        {
            string cstring = "Data Source=C:\\Users\\dsank\\Desktop\\каледж\\БАЗА\\db.db";
            using (var constr = new SQLiteConnection())
            {
                SQLiteCommand command = new SQLiteCommand(inser, constr);
                constr.ConnectionString = cstring;
                constr.Open();
                SQLiteDataReader reader = command.ExecuteReader();

            }
        }
    }
}
