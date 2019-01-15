using PetApp.Control;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp.Model
{
    [Table("PET")]
    class Pets
    {
        [PrimaryKey]
        [AutoIncrement]
        public int PET_ID { get; set; }
        public string PET_IMG { get; set; }
        public string PET_NOME { get; set; }
        public string PET_NAS { get; set; }
        public string PET_RACA { get; set; }
        public string PET_COR { get; set; }
        public string PET_OBS { get; set; }
        public int CLI_ID { get; set; }

        private static Connection CONN;

        public static List<Pets> Get()
        {
            CONN = new Connection();
            List<Pets> list = new List<Pets>();

            try
            {
                list = CONN.conn.Table<Pets>().ToList<Pets>();
            }
            catch
            {
                try
                {
                    list = CONN.conn.Table<Pets>().ToList<Pets>();
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    list = new List<Pets>();
                }
            }

            return list;
        }

        public static Pets Get(int ID)
        {
            CONN = new Connection();
            Pets user = new Pets();

            try
            {
                user = CONN.conn.Get<Pets>(ID);
            }
            catch
            {
                try
                {
                    user = CONN.conn.Get<Pets>(ID);
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    user = new Pets();
                }
            }

            return user;
        }

        public static bool Insert(Pets user)
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

        public static bool Insert(List<Pets> user)
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

        public static bool Update(Pets user)
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

        public static bool Update(List<Pets> user)
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

        public static bool Delete(Pets user)
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

        public static bool Delete(List<Pets> users)
        {
            CONN = new Connection();
            try
            {
                foreach (Pets user in users)
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
                CONN.conn.DeleteAll<Pets>();
            }
            catch
            {
                try
                {
                    CONN.conn.DeleteAll<Pets>();
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
