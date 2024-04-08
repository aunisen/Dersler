using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Dersler.KutuphaneWpf.Classlar
{
   public class DbBaglanti
    {
        public static string Dbadres = $"Data Source={Environment.CurrentDirectory
            }\\..\\..\\..\\Database\\kutphaneDb.db; ";
         
        public static string VeriTabaninaBaglanti
        {
            get
            {
                
                try
                {
                    var connectionString = new SqliteConnectionStringBuilder(Dbadres)
                    {
                        
                        DataSource= @"C:\Projeler\Dersler\Dersler.KutuphaneWpf\Database\kutuphaneDb.db",
                        Mode = SqliteOpenMode.ReadWrite
                      
                    }.ToString();

                    using (SqliteConnection con = new SqliteConnection(connectionString))
                    {
                        con.Open();
                    }
                }
                catch (Exception ex)
                {

                    return ex.Message;
                }
               
                return "OK";
            }
        }
    }
}
