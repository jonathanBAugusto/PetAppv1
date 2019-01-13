using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetApp.Control;
using SQLite;

namespace PetApp.Model
{
    [Table("PRODUTOS")]
    class Produtos
    {
        [PrimaryKey, AutoIncrement]
        public int PRO_ID { get; set; }
        public string PRO_REFERENCIA { get; set; }
        public string PRO_DESCRICAO { get; set; }
        public double PRO_CUSTO { get; set; }
        public double PRO_CUSTOULTCOMPRA { get; set; }
        public string PRO_TIPO { get; set; }
        public int PRO_FORNECEDOR { get; set; }
        public string PRO_IMAGEM { get; set; }

        private static Connection CONN;

        public Produtos()
        {
            CONN = new Connection();
        }

        public static List<Produtos> Get()
        {
            CONN = new Connection();
            List<Produtos> list = new List<Produtos>();

            try
            {
                list = CONN.conn.Table<Produtos>().ToList<Produtos>();
            }
            catch
            {
                try
                {
                    list = CONN.conn.Table<Produtos>().ToList<Produtos>();
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    list = new List<Produtos>();
                }
            }

            return list;
        }

        public static Produtos Get(int ID)
        {
            CONN = new Connection();
            Produtos user = new Produtos();

            try
            {
                user = CONN.conn.Get<Produtos>(ID);
            }
            catch
            {
                try
                {
                    user = CONN.conn.Get<Produtos>(ID);
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    user = new Produtos();
                }
            }

            return user;
        }

        public static bool Insert(Produtos user)
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

        public static bool Insert(List<Produtos> user)
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

        public static bool Update(Produtos user)
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

        public static bool Update(List<Produtos> user)
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

        public static bool Delete(Produtos user)
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

        public static bool Delete(List<Produtos> users)
        {
            CONN = new Connection();
            try
            {
                foreach (Produtos user in users)
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
                CONN.conn.DeleteAll<Produtos>();
            }
            catch
            {
                try 
                {
                    CONN.conn.DeleteAll<Produtos>();
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
