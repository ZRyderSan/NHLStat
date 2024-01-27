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
        
        //string selec = "SELECT * FROM List";
        public void sqlC(string Team,BitmapImage ima)
        {
            string cstring = "Data Source=\\db.db";
            string inser = $"INSERT INTO Teams Values(NULL,{0},{1},NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL)";{Team,ima};
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
