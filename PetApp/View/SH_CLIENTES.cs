using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetApp.Model;

namespace PetApp
{
    public partial class SH_CLIENTES : DevExpress.XtraEditors.XtraForm
    {
        public SH_CLIENTES()
        {
            InitializeComponent();

        }

        private void btnAdcCli_Click(object sender, EventArgs e)
        {
            FrmCadCli frmcadcli = new FrmCadCli();
            frmcadcli.ShowDialog();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = Clientes.Get();
        }

        private void FrmCli_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = Clientes.Get();
        }

        private void btnRemCli_Click(object sender, EventArgs e)
        {
            int IdCli = 0;
            IdCli = F.toInt(gridView1.GetFocusedRowCellValue("CLI_ID"));
            Clientes.Delete( Clientes.Get(IdCli));
            FrmCli_Load(null, null);
        }
    }
}
