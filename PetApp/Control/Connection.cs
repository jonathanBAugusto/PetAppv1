using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetApp.Model;
using PetApp.Control;

namespace PetApp.Control
{
    class Connection
    {
        public SQLiteConnection conn;

        public Connection()
        {
            try
            {
                conn = new SQLiteConnection("dbName.db");
            }
            catch
            {
                try
                {
                    conn = new SQLiteConnection("dbName.db");
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                }
            }
            CreateTables();
        }

        private void CreateTables()
        {
            try
            {
                conn.CreateTable<Clientes>();
            }
            catch
            {
                try
                {
                    conn.CreateTable<Clientes>();
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                }
            }
            try
            {
                conn.CreateTable<Pets>();
            }
            catch
            {
                try
                {
                    conn.CreateTable<Pets>();
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                }
            }
            try
            {
                conn.CreateTable<Servicos>();
            }
            catch
            {
                try
                {
                    conn.CreateTable<Servicos>();
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                }
            }
            try
            {
                conn.CreateTable<TipoServico>();
            }
            catch
            {
                try
                {
                    conn.CreateTable<TipoServico>();
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                }
            }

        }

        public bool ExecuteSQL(string sql)
        {
            bool result = false;

            int i = -1;

            try
            {
                i = conn.Execute(sql);

                result = (i != -1);
            }
            catch
            {
                try
                {
                    i = conn.Execute(sql);

                    result = (i != -1);
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                }

            }

            return result;
        }
    }
}
