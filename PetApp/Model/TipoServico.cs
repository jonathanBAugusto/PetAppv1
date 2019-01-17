using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using PetApp.Control;

namespace PetApp.Model
{
    [Table("TIPOSERVICO")]
    class TipoServico
    {
        [PrimaryKey][AutoIncrement]
        public int TIPO_SER_ID { get; set; }
        public string TIPO_SER_NOME { get; set; }
        public double TIPO_SER_VALOR { get; set; }

        private static Connection CONN;

        public static List<TipoServico> Get()
        {
            CONN = new Connection();
            List<TipoServico> list = new List<TipoServico>();

            try
            {
                list = CONN.conn.Table<TipoServico>().ToList<TipoServico>();
            }
            catch
            {
                try
                {
                    list = CONN.conn.Table<TipoServico>().ToList<TipoServico>();
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    list = new List<TipoServico>();
                }
            }

            return list;
        }

        public static TipoServico Get(int ID)
        {
            CONN = new Connection();
            TipoServico user = new TipoServico();

            try
            {
                user = CONN.conn.Get<TipoServico>(ID);
            }
            catch
            {
                try
                {
                    user = CONN.conn.Get<TipoServico>(ID);
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    user = new TipoServico();
                }
            }

            return user;
        }

        public static bool Insert(TipoServico user)
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

        public static bool Insert(List<TipoServico> user)
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

        public static bool Update(TipoServico user)
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

        public static bool Update(List<TipoServico> user)
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

        public static bool Delete(TipoServico user)
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

        public static bool Delete(List<TipoServico> users)
        {
            CONN = new Connection();
            try
            {
                foreach (TipoServico user in users)
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
                CONN.conn.DeleteAll<TipoServico>();
            }
            catch
            {
                try
                {
                    CONN.conn.DeleteAll<TipoServico>();
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
