using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Data.SQLite;
using System.IO;
using System.Windows;

namespace WpfApp1
{
    internal class Class1
    {
        
        //string selec = "SELECT * FROM List";
        public void sqlC(string Team, string ima)
        {
            
            using (var constr = new SQLiteConnection())
            {
                string finalfile = CurDir() + "TeamLogos" + "\\" + Team + ".png";
                string inser = "INSERT INTO Team Values(NULL,\"" + Team + "\",\"" + finalfile + "\",NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL)";
                SQLiteCommand command = new SQLiteCommand(inser, constr);
                constr.ConnectionString = ConStrin();
                if (CheckExist(finalfile)==true)
                {
                    MessageBox.Show("Дакая команда уже существует");
                    return;
                }
                else
                {
                    if (Directory.Exists(CurDir() + "\\TeamLogos"))
                    {
                        File.Copy(ima, finalfile);
                    }
                    else
                    {
                        Directory.CreateDirectory(CurDir() + "\\TeamLogos");
                        File.Copy(ima, finalfile);
                    }
                }
                constr.Open();
                SQLiteDataReader read = command.ExecuteReader();
                MessageBox.Show("Команда успешно добавлена", "Оповещение", MessageBoxButton.OK);
                

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
        private string CurDir()
        {
            string gg = Environment.CurrentDirectory;
            gg = gg.Substring(0, gg.Length - 24);
            return gg;
        }
        private string ConStrin()
        {
            string gg = Environment.CurrentDirectory;
            gg = gg.Substring(0, gg.Length - 24);
            gg = "Data Source=" + gg + "\\db.db";
            return gg;
        }
        private bool CheckExist(string file)
        {
            bool itog;
            if (System.IO.File.Exists(file))
            {
                itog = true;
            }
            else
            {
                itog = false;
            }
            return itog;
        }
    }
}
