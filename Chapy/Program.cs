using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Data.Common;
using Microsoft.Win32;

namespace Chapy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                string keyLink = "";
                /*read registry */
                if (Environment.Is64BitOperatingSystem)
                {
                    keyLink = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Child\\勤務割";
                }
                else
                {
                    keyLink = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Child\\勤務割";
                }

                string displayName = (string)Registry.GetValue(keyLink, "DisplayName", "");
                if (displayName == "")
                {
                    MessageBox.Show("正しくインストールされていません。お問い合わせは、担当のコンピュータ部運営所まで、お電話をおかけて下さい。");
                    return;
                }

                /*end read registry */

                string serverName = Environment.MachineName;
                string instance = "";
                string preFix = "CTaskSchedule";
                string sufFix = "";
                string user = "sa";
                string pass = "_ChildDB";
                string port = "2346";
                string loginMode = "";
                string[] args = Environment.GetCommandLineArgs();
                //Environment.GetEnvironmentVariable();

                for (int i = 0; i < args.Length; i++)
                {
                    if (i < args.Length)
                    {
                        string arg = args[i];

                        //get serverName
                        if (arg.ToLower() == "-s")
                        {
                            serverName = args[i + 1];
                        }

                        //get instance
                        if (arg.ToLower() == "-i")
                        {
                            instance = args[i + 1];
                        }

                        //get PreFix
                        if (arg.ToLower() == "-d")
                        {
                            preFix = args[i + 1];
                        }

                        //get sufFix
                        if (arg.ToLower() == "-f")
                        {
                            sufFix = args[i + 1];
                        }


                        //get user
                        if (arg.ToLower() == "-u")
                        {
                            user = args[i + 1];
                        }

                        //get pass
                        if (arg.ToLower() == "-p")
                        {
                            pass = args[i + 1];
                        }

                        if (arg.ToLower() == "-po")
                        {
                            port = args[i + 1];
                        }

                        if (arg.ToLower() == "-l")
                        {
                            loginMode = args[i + 1];
                        }
                    }
                }


                /* khoi tao thong tin server*/
                //string machineName = Environment.MachineName;
                //string sqlInstanceDefault = instance;

                //string prefix = "CTaskSchedule";
                //dbName = dbName != "" ? dbName : "Child";
                //string userSql = user != "" ? user : "sa";
                //string passSql = pass != "" ? pass : "CHILDDB12";

                //string serverName = sqlInstanceDefault != "" ? machineName + "\\" + sqlInstanceDefault : machineName;
                //string databaseName = prefix + "_" + dbName;
                string databaseName = preFix + "_Child" + sufFix;
                string serverSql = instance != "" ? serverName + "\\" + instance : serverName;

                string connectionString = "Server=" + serverSql + ";";
                connectionString += "Database=" + databaseName + ";";

                if (loginMode == "window")
                {
                    connectionString += "Trusted_Connection=True;";
                }
                else
                {
                    connectionString += "User Id=" + user + ";Password=" + pass + ";";
                }

                string connectionStringMaster = "Server=" + serverSql + ";";
                connectionStringMaster += "Database=;";
                if (loginMode == "window")
                {
                    connectionStringMaster += "Trusted_Connection=True;";
                }
                else
                {
                    connectionStringMaster += "User Id=" + user + ";Password=" + pass + ";";
                }


                /* end khoi tao thong tin server*/

                /* connect to master database
                 * check database exsit?
                 * neu chua ton tai se tao db moi
                 */
                //databaseName = "BanHang";
                string sqlCheckDb = "IF EXISTS (SELECT * FROM sysdatabases WHERE name = N'" + databaseName + "') BEGIN  SELECT 1;  END";
                SqlConnection conn = new SqlConnection(connectionStringMaster);
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    //if(conn.State == 
                    SqlCommand sqlCommand = new SqlCommand(sqlCheckDb, conn);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    var exist = "0";
                    while (reader.Read())
                    {
                        exist = reader[0].ToString();
                        break;
                    }
                    reader.Dispose();
                    /* chua ton tai */
                    if (exist == "0")
                    {
                        /* create database */
                        string sqlCreateDb = "IF NOT EXISTS( SELECT * FROM sysdatabases WHERE name = \'" + databaseName + "\')"
                                       + " BEGIN "
                                       + " CREATE DATABASE " + databaseName + "; "
                                       + " END";
                        SqlCommand cmdCreateDb = new SqlCommand(sqlCreateDb, conn);
                        var data = cmdCreateDb.ExecuteNonQuery();

                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }

                        /* create table 
                         change connect to 
                         */
                        SqlConnection connChild = new SqlConnection(connectionString);
                        string linkScript = Application.StartupPath + "\\script.sql";
                        FileInfo file = new FileInfo(@linkScript);

                        string script = file.OpenText().ReadToEnd();

                        if (connChild.State == ConnectionState.Closed)
                        {
                            connChild.Open();
                        }

                        SqlCommand cmdCreatTables = new SqlCommand(script, connChild);
                        cmdCreatTables.ExecuteNonQuery();
                        if (connChild.State == ConnectionState.Open)
                        {
                            connChild.Close();
                        }

                    }

                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(connectionString);
                    MessageBox.Show(ex.Message);
                    return;
                }

                string dbConnString = @"data source=" + serverSql + ";initial catalog=" + databaseName + ";User Id=" + user + ";Password=" + pass + ";integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

                /*end check database*/

                VariableGlobal.connectionString = dbConnString;

                chapyEntities db = new chapyEntities(dbConnString);

                /* run single instance */
                if (SingleApplication.Run() == false)
                {
                 
                    return;
                }
                /* end run single instance */

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var List_School = from s in db.CpSchools select s;

                if (List_School.Any())
                {
                    Application.Run(new FrmSchoolSelect());
                }
                else
                {
                    Application.Run(new FrmMain());
                }

              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }


        }

    }
}
