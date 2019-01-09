using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace WindowsFormsApp1.Model
{
    [Table("CLIENTE")]
    class Clientes
    {
        [PrimaryKey][AutoIncrement]
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
        public int PAISENDCLI{ get; set; }
        public int NASCLI { get; set; }
        public int PESTIPO { get; set; }

    }
}
