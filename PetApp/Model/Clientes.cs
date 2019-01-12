using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using PetApp.Control;

namespace PetApp.Model
{
    [Table("CLIENTE")]
    class Clientes
    {
        [PrimaryKey]
        [AutoIncrement]
        public int CLI_ID { get; set; }
        public int NOMECLI { get; set; }
        public int DDDTEL { get; set; }
        public int TELCLI { get; set; }
        public int DDDCEL { get; set; }
        public int CELCLI { get; set; }
        public int EMAILCLI { get; set; }
        public int RAZSOCLI { get; set; }
        public int INSESCLI { get; set; }
        public int CNPJCLI { get; set; }
        public int CEPEBDCLI { get; set; }
        public int RUAENDCLI { get; set; }
        public int BAIRROENDCLI { get; set; }
        public int NUMENDCLI { get; set; }
        public int ESTENDCLI { get; set; }
        public int PAISENDCLI { get; set; }
        public int NASCLI { get; set; }
        public int PESTIPO { get; set; }

        private static Connection CONN;

        public static List<Clientes> Get()
        {
            CONN = new Connection();
            List<Clientes> list = new List<Clientes>();

            try
            {
                list = CONN.conn.Table<Clientes>().ToList<Clientes>();
            }
            catch
            {
                try
                {
                    list = CONN.conn.Table<Clientes>().ToList<Clientes>();
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    list = new List<Clientes>();
                }
            }

            return list;
        }

        public static Clientes Get(int ID)
        {
            CONN = new Connection();
            Clientes user = new Clientes();

            try
            {
                user = CONN.conn.Get<Clientes>(ID);
            }
            catch
            {
                try
                {
                    user = CONN.conn.Get<Clientes>(ID);
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    user = new Clientes();
                }
            }

            return user;
        }

        public static bool Insert(Clientes user)
        {
            CONN = new Connection();
            try
            {
                CONN.conn.Insert(user);
            }
            catch
            {
                try
                {
                    CONN.conn.Insert(user);
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    return false;
                }
            }
            return true;
        }

        public static bool Insert(List<Clientes> user)
        {
            CONN = new Connection();
            try
            {
                CONN.conn.InsertAll(user);
            }
            catch
            {
                try
                {
                    CONN.conn.InsertAll(user);
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    return false;
                }
            }
            return true;
        }

        public static bool Update(Clientes user)
        {
            CONN = new Connection();
            try
            {
                CONN.conn.Update(user);
            }
            catch
            {
                try
                {
                    CONN.conn.Update(user);
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    return false;
                }
            }
            return true;
        }

        public static bool Update(List<Clientes> user)
        {
            CONN = new Connection();
            try
            {
                CONN.conn.UpdateAll(user);
            }
            catch
            {
                try
                {
                    CONN.conn.UpdateAll(user);
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    return false;
                }
            }
            return true;
        }

        public static bool Delete(Clientes user)
        {
            CONN = new Connection();
            try
            {
                CONN.conn.Delete(user);
            }
            catch
            {
                try
                {
                    CONN.conn.Delete(user);
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    return false;
                }
            }
            return true;
        }

        public static bool Delete(List<Clientes> users)
        {
            CONN = new Connection();
            try
            {
                foreach (Clientes user in users)
                {
                    CONN.conn.Delete(user);
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
                CONN.conn.DeleteAll<Clientes>();
            }
            catch
            {
                try
                {
                    CONN.conn.DeleteAll<Clientes>();
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
