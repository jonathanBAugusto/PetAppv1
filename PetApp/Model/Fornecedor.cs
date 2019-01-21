using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using PetApp.Control;
using System.Drawing;

namespace PetApp.Model
{
    [Table("FORNECEDOR")]
    class Fornecedor
    {
        [PrimaryKey]
        [AutoIncrement]
        public int FOR_ID { get; set; }
        public string FOR_RAZAO { get; set; }
        public string FOR_FANTASIA { get; set; }
        public string FOR_CNPJ { get; set; }
        public string FOR_DDDCEL { get; set; }
        public string FOR_CEL { get; set; }
        public string FOR_DDDTEL { get; set; }
        public string FOR_TEL { get; set; }
        public string FOR_EMAIL { get; set; }
        public string FOR_CEP { get; set; }
        public string FOR_UF { get; set; }
        public string FOR_RUA { get; set; }
        public string FOR_BAIRRO { get; set; }
        public string FOR_COMPLEMENTO { get; set; }
        public string FOR_NUMERO { get; set; }
        public string FOR_DATA_CADASTRO { get; set; }
        public string FOR_IMG { get; set; }

        private Image for_IMAGEM;
        [Ignore]
        public Image FOR_IMAGEM
        {
            get
            {
                string pathImg = System.IO.Path.Combine(F.IMGPATH, F.toString(FOR_IMG));
                if (System.IO.File.Exists(pathImg))
                {
                    try
                    {
                        return Image.FromFile(pathImg);
                    }
                    catch
                    {
                        return for_IMAGEM;
                    }
                }
                return for_IMAGEM;
            }
            set { for_IMAGEM = value; }
        }

        private static Connection CONN;

        public static List<Fornecedor> Get()
        {
            CONN = new Connection();
            List<Fornecedor> list = new List<Fornecedor>();

            try
            {
                list = CONN.conn.Table<Fornecedor>().ToList<Fornecedor>();
            }
            catch
            {
                try
                {
                    list = CONN.conn.Table<Fornecedor>().ToList<Fornecedor>();
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    list = new List<Fornecedor>();
                }
            }

            return list;
        }

        public static Fornecedor Get(int ID)
        {
            CONN = new Connection();
            Fornecedor user = new Fornecedor();

            try
            {
                user = CONN.conn.Get<Fornecedor>(ID);
            }
            catch
            {
                try
                {
                    user = CONN.conn.Get<Fornecedor>(ID);
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    user = new Fornecedor();
                }
            }

            return user;
        }

        public static bool Insert(Fornecedor user)
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

        public static bool Insert(List<Fornecedor> user)
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

        public static bool Update(Fornecedor user)
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

        public static bool Update(List<Fornecedor> user)
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

        public static bool Delete(Fornecedor user)
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

        public static bool Delete(List<Fornecedor> users)
        {
            CONN = new Connection();
            try
            {
                foreach (Fornecedor user in users)
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
                CONN.conn.DeleteAll<Fornecedor>();
            }
            catch
            {
                try
                {
                    CONN.conn.DeleteAll<Fornecedor>();
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
