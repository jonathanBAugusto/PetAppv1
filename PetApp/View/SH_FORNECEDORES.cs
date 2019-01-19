using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PetApp.Model;

namespace PetApp.View
{
    public partial class SH_FORNECEDORES : DevExpress.XtraEditors.XtraForm
    {
        public SH_FORNECEDORES()
        {
            InitializeComponent();
        }

        private void SH_FORNECEDORES_Load(object sender, EventArgs e)
        {
            gridControlFornecedores.DataSource = Fornecedor.Get();
        }

        private void btnRemCli_Click(object sender, EventArgs e)
        {
            int IdFor = 0;
            IdFor = F.toInt(gridView1.GetFocusedRowCellValue("FOR_ID"));
            Fornecedor.Delete(Fornecedor.Get(IdFor));
            SH_FORNECEDORES_Load(null, null);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FrmCadCli form = new FrmCadCli();
            form.ShowDialog();
        }
    }
}