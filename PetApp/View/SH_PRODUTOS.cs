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
    public partial class SH_PRODUTOS : DevExpress.XtraEditors.XtraForm
    {
        int idProdEdit = 0;
        string img = "";
        int tipo = 0;
        public SH_PRODUTOS()
        {
            InitializeComponent();
  
        }

        private void SH_PRODUTOS_Load(object sender, EventArgs e)
        {
            gridControlProdutos.DataSource = Produtos.Get();

            repositoryItemGridLookUpEditTPR.DataSource = TipoProduto.Get();
            repositoryItemGridLookUpEditTPR.ValueMember = "TPR_ID";
            repositoryItemGridLookUpEditTPR.DisplayMember = "TPR_DESCRICAO";

            repositoryItemGridLookUpEditFornecedor.DataSource = Fornecedor.Get();
            repositoryItemGridLookUpEditFornecedor.ValueMember = "FOR_ID";
            repositoryItemGridLookUpEditFornecedor.DisplayMember = "FOR_RAZAO";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int IdCli = 0;
            IdCli = F.toInt(layoutView1.GetFocusedRowCellValue("PRO_ID"));
            Produtos.Delete(Produtos.Get(IdCli));
            SH_PRODUTOS_Load(null, null);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FrmProdutos form = new FrmProdutos();
            form.PROID = F.toInt(layoutView1.GetFocusedRowCellValue("PRO_ID"));
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                SH_PRODUTOS_Load(null, null);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmProdutos form = new FrmProdutos();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                SH_PRODUTOS_Load(null, null);
            }
        }
    }
}