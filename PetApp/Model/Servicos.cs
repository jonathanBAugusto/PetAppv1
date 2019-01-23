using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using PetApp.Control;

namespace PetApp.Model
{
    [Table("SERVICO")]
    class Servicos
    {
        [PrimaryKey][AutoIncrement]
        public int SER_ID { get; set; }
        public double SER_VALOR_BASE { get; set; }
        public double SER_VALOR_DESCONTO { get; set; }
        public double SER_VALOR_TOTAL { get; set; }
        public int PET_ID { get; set; }
        public int CLI_ID { get; set; }
        public int TIPO_SER_ID { get; set; }
        public string SER_DATA_PREV { get; set; }
        public string SER_DATA_CAD { get; set; }
        public string SER_OBSERVACAO { get; set; }
        public string SER_ESTAGIO { get; set; }

        private static Connection CONN;

        public static List<Servicos> Get(string Filtro)
        {
            CONN = new Connection();
            List<Servicos> list = new List<Servicos>();
            list = CONN.conn.Query<Servicos>("SELECT * FROM SERVICO WHERE SER_ID >= 0 " + Filtro);
            return list;
        }

        public static List<Servicos> Get()
        {
            CONN = new Connection();
            List<Servicos> list = new List<Servicos>();

            try
            {
                list = CONN.conn.Table<Servicos>().ToList<Servicos>();
            }
            catch
            {
                try
                {
                    list = CONN.conn.Table<Servicos>().ToList<Servicos>();
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    list = new List<Servicos>();
                }
            }

            return list;
        }

        public static Servicos Get(int ID)
        {
            CONN = new Connection();
            Servicos user = new Servicos();

            try
            {
                user = CONN.conn.Get<Servicos>(ID);
            }
            catch
            {
                try
                {
                    user = CONN.conn.Get<Servicos>(ID);
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    user = new Servicos();
                }
            }

            return user;
        }

        public static bool Insert(Servicos user)
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

        public static bool Insert(List<Servicos> user)
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

        public static bool Update(Servicos user)
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

        public static bool Update(List<Servicos> user)
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

        public static bool Delete(Servicos user)
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

        public static bool Delete(List<Servicos> users)
        {
            CONN = new Connection();
            try
            {
                foreach (Servicos user in users)
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
                CONN.conn.DeleteAll<Servicos>();
            }
            catch
            {
                try
                {
                    CONN.conn.DeleteAll<Servicos>();
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
