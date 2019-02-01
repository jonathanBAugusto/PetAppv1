using System;
using System.Collections.Generic;
using System.Drawing;
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
        public string PRO_DATACADASTRO { get; set; }
        public double PRO_CUSTOULTCOMPRA { get; set; }
        public int PRO_TIPO { get; set; }
        public int PRO_FORNECEDOR { get; set; }
        public string PRO_IMAGEM { get; set; }

        private Image pro_IMAGEM;
        [Ignore]
        public Image PRO_IMAGEMR
        {
            get
            {
                string pathImg = System.IO.Path.Combine(F.IMGPATH, F.toString(PRO_IMAGEM));
                if (System.IO.File.Exists(pathImg))
                {
                    try
                    {
                        return Image.FromFile(pathImg);
                    }
                    catch
                    {
                        return pro_IMAGEM;
                    }
                }
                return pro_IMAGEM;
            }
            set { pro_IMAGEM = value; }
        }

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

        public static Produtos GetByID(int PRO_ID)
        {
            CONN = new Connection();
            Produtos user = new Produtos();
            StringBuilder sql = new StringBuilder();
            sql.Append("	SELECT 	");
            sql.Append("		MAX(PRODUTOS.PRO_ID),	");
            sql.Append("		PRODUTOS.*	");
            sql.Append("	FROM	");
            sql.Append("		PRODUTOS 	");
            sql.Append("	WHERE 	");
            sql.Append("		PRO_ID = :PRO_ID	");
            sql.Replace(":PRO_ID", PRO_ID.ToString());
            try
            {
                user = CONN.conn.Query<Produtos>(sql.ToString()).FirstOrDefault();
            }
            catch
            {
                try
                {
                    user = CONN.conn.Query<Produtos>(sql.ToString()).FirstOrDefault();
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

    [Table("LANCPRODS")]
    class Lancprods
    {
        [PrimaryKey][AutoIncrement]
        public int LCP_ID { get; set; }
        public double LCP_QUANTIDADE { get; set; }
        public DateTime LCP_DATA { get; set; }
        public string LCP_TIPO { get; set; }
        public int PRO_ID { get; set; }



        private string pro_REFERENCIA;
        [Ignore]
        public string PRO_REFERENCIA
        {
            get
            {
                string result = "";
                try
                {
                    result = F.toString(CONN.conn.Query<List<string>>("SELECT MAX(PRO_REFERENCIA) PRO_REFERENCIA FROM PRODUTOS WHERE PRO_ID = " + PRO_ID).LastOrDefault());
                    return result;
                }
                catch
                {
                    return pro_REFERENCIA;
                }
            }
            set { pro_REFERENCIA = value; }
        }
        private static Connection CONN;

        public Lancprods()
        {
            CONN = new Connection();
        }

        public static int getIDByRef(string Referencia)
        {
            CONN = new Connection();
            int pro_id = -1;
            try
            {
                Produtos obj = CONN.conn.Get<Produtos>(prod => prod.PRO_REFERENCIA == Referencia);
                pro_id = F.toInt(obj.PRO_ID, -1);
            }
            catch(Exception ex) 
            {
                string e = ex.Message;
                return -1;
            }
            return pro_id;
        }

        public static List<Lancprods> Get()
        {
            CONN = new Connection();
            List<Lancprods> list = new List<Lancprods>();

            try
            {
                list = CONN.conn.Table<Lancprods>().ToList<Lancprods>();
            }
            catch
            {
                try
                {
                    list = CONN.conn.Table<Lancprods>().ToList<Lancprods>();
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    list = new List<Lancprods>();
                }
            }

            return list;
        }

        public static Lancprods Get(int ID)
        {
            CONN = new Connection();
            Lancprods user = new Lancprods();

            try
            {
                user = CONN.conn.Get<Lancprods>(ID);
            }
            catch
            {
                try
                {
                    user = CONN.conn.Get<Lancprods>(ID);
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                    user = new Lancprods();
                }
            }

            return user;
        }

        public static bool Insert(Lancprods user)
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

        public static bool Insert(List<Lancprods> user)
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

        public static bool Update(Lancprods user)
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

        public static bool Update(List<Lancprods> user)
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

        public static bool Delete(Lancprods user)
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

        public static bool Delete(List<Lancprods> users)
        {
            CONN = new Connection();
            try
            {
                foreach (Lancprods user in users)
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
                CONN.conn.DeleteAll<Lancprods>();
            }
            catch
            {
                try
                {
                    CONN.conn.DeleteAll<Lancprods>();
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

    class EstoquePesquisa
    {
        public int LCP_ID { get; set; }
        public int PRO_ID { get; set; }
        public string PRO_REFERENCIA { get; set; }
        public string PRO_DESCRICAO { get; set; }
        public double PRO_CUSTO { get; set; }
        public double PRO_CUSTOULTCOMPRA { get; set; }
        public DateTime LCP_DATA { get; set; }
        public string LCP_TIPO { get; set; }
        private string lcp_TIPOVIEW;

        public string LCP_TIPOVIEW
        {
            get
            {
                string final = "";
                if (LCP_TIPO == "E")
                {
                    final = "ENTRADA";
                }
                else if (LCP_TIPO == "S")
                {
                    final = "SAÍDA";
                }

                return final;
            }
            set { lcp_TIPOVIEW = value; }
        }

        private static Connection CONN;
        public Connection conn;
        public EstoquePesquisa()
        {
            CONN = new Connection();
        }

        public static List<EstoquePesquisa> GetBySQL(string sql)
        {
            CONN = new Connection();
            try
            {
                return CONN.conn.Query<EstoquePesquisa>(sql);
            }
            catch
            {
                try
                {
                    return CONN.conn.Query<EstoquePesquisa>(sql);
                }
                catch (Exception ex)
                {
                    F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                }
            }
            return new List<EstoquePesquisa>();
        }
    }
}
