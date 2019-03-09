using PetApp.Control;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp.Model
{
    [Table("UNIDADE")]
    class Unidade
    {
        [PrimaryKey]
        [AutoIncrement]
        public int UNI_ID { get; set; }
        public string UNI_DESCRICAO { get; set; }
        public double UNI_MEDIDA { get; set; }

        private static Connection CONN;

        public static List<Unidade> Get(string Filtro = "")
        {
            CONN = new Connection();
            List<Unidade> list = new List<Unidade>();
            try
            {
                list = CONN.conn.Query<Unidade>("SELECT * FROM UNIDADE WHERE UNI_ID >= 0 " + Filtro);
            }
            catch
            {
                try
                {
                    list = CONN.conn.Query<Unidade>("SELECT * FROM UNIDADE WHERE UNI_ID >= 0 " + Filtro);
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    list = new List<Unidade>();
                }
            }
            return list;
        }

        public static Unidade Get(int ID)
        {
            CONN = new Connection();
            Unidade unids = new Unidade();

            try
            {
                unids = CONN.conn.Get<Unidade>(ID);
            }
            catch
            {
                try
                {
                    unids = CONN.conn.Get<Unidade>(ID);
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    unids = new Unidade();
                }
            }

            return unids;
        }

        public static bool Insert(Unidade unids)
        {
            CONN = new Connection();
            try
            {
                CONN.conn.Insert(unids);
            }
            catch
            {
                try
                {
                    CONN.conn.Insert(unids);
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    return false;
                }
            }
            return true;
        }

        public static bool Insert(List<Unidade> unids)
        {
            CONN = new Connection();
            try
            {
                CONN.conn.InsertAll(unids);
            }
            catch
            {
                try
                {
                    CONN.conn.InsertAll(unids);
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    return false;
                }
            }
            return true;
        }
        public static bool Update(Unidade unid)
        {
            CONN = new Connection();
            try
            {
                CONN.conn.Update(unid);
            }
            catch
            {
                try
                {
                    CONN.conn.Update(unid);
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    return false;
                }
            }
            return true;
        }

        public static bool Update(List<Unidade> unid)
        {
            CONN = new Connection();
            try
            {
                CONN.conn.UpdateAll(unid);
            }
            catch
            {
                try
                {
                    CONN.conn.UpdateAll(unid);
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    return false;
                }
            }
            return true;
        }

        public static bool Delete(Unidade unid)
        {
            CONN = new Connection();
            try
            {
                CONN.conn.Delete(unid);
            }
            catch
            {
                try
                {
                    CONN.conn.Delete(unid);
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    return false;
                }
            }
            return true;
        }

        public static bool Delete(List<Unidade> unids)
        {
            CONN = new Connection();
            try
            {
                foreach (Unidade unid in unids)
                {
                    CONN.conn.Delete(unid);
                }
            }
            catch (Exception ex)
            {
                F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                return false;

            }
            return true;
        }

        public static bool DeleteAll()
        {
            CONN = new Connection();
            try
            {
                CONN.conn.DeleteAll<Unidade>();
            }
            catch
            {
                try
                {
                    CONN.conn.DeleteAll<Unidade>();
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    return false;
                }
            }
            return true;
        }

    }
}
