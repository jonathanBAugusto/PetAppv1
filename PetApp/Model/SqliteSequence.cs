using PetApp.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp.Model
{
    public class SqliteSequence
    {
        public int SEQ { get; set; }

        private static Connection CONN;
        public static int LastID(string Table)
        {
            CONN = new Connection();
            int deft = -1;

            string sql = string.Format("SELECT SEQ FROM SQLITE_SEQUENCE WHERE NAME = '{0}'", Table);

            SqliteSequence sequence = new SqliteSequence();
            try
            {
                sequence = CONN.conn.Query<SqliteSequence>(sql).FirstOrDefault();
                return sequence.SEQ;
            }
            catch (Exception ex)
            {
                F.WriteLOG("---------------------------\n" + DateTime.Now.ToString() + " Error: " + ex.Message);
                return deft;
            }
        }
    }
}
