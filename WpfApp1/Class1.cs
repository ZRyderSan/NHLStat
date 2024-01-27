using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Data.SQLite;

namespace WpfApp1
{
    internal class Class1
    {
        
        //string selec = "SELECT * FROM List";
        public void sqlC(string Team, byte[] ima)
        {
            string gg = Environment.CurrentDirectory;
            gg = gg.Substring(0,gg.Length-24);
            string cstring = "Data Source="+gg+"db.db";
            string inser = "INSERT INTO Team Values(NULL,\""+Team+"\",\""+ima+ "\",NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL)";
            using (var constr = new SQLiteConnection())
            {
                SQLiteCommand command = new SQLiteCommand(inser, constr);
                constr.ConnectionString = cstring;
                constr.Open();
                SQLiteDataReader read = command.ExecuteReader();

            }
        }
        public void sqlS()
        {
            string cstring = "Data Source=C:\\Users\\dsank\\source\\repos\\ZRyderSan\\NHLStat\\WpfApp1\\db.db";
            string inser = "SELECT * FROM Team";
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
