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
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (idProdEdit == 0)
            {
                FrmCadCli form = new FrmCadCli();
                form.ShowDialog();
            }
            else
            {
                if (F.toString(edPRO_CUSTO.EditValue) != "" && F.toString(edPRO_CUSTOULTCOMPRA.EditValue) != ""
                    && F.toString(edPRO_DESCRICAO.EditValue) != "" && F.toString(edPRO_FORNECEDOR.EditValue) != ""
                    && F.toString(edPRO_REFERENCIA.EditValue) != "")
                {
                    Produtos prodEdited = new Produtos
                    {
                        PRO_ID = idProdEdit,
                        PRO_CUSTO = F.toDouble(edPRO_CUSTO.EditValue),
                        PRO_CUSTOULTCOMPRA = F.toDouble(edPRO_CUSTOULTCOMPRA.EditValue),
                        PRO_DESCRICAO = F.toString(edPRO_DESCRICAO.EditValue),
                        PRO_FORNECEDOR = F.toInt(edPRO_FORNECEDOR.EditValue),
                        PRO_REFERENCIA = F.toString(edPRO_REFERENCIA.EditValue),
                        PRO_TIPO = tipo,
                        PRO_IMAGEM = img
                        
                    };
                    Produtos.Update(prodEdited);
                    SH_PRODUTOS_Load(null, null);
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int IdCli = 0;
            IdCli = F.toInt(gridView1.GetFocusedRowCellValue("PRO_ID"));
            Produtos.Delete(Produtos.Get(IdCli));
            SH_PRODUTOS_Load(null, null);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            idProdEdit = F.toInt(gridView1.GetFocusedRowCellValue("PRO_ID"));
            edPRO_DESCRICAO.EditValue = F.toString(gridView1.GetFocusedRowCellValue("PRO_DESCRICAO"));
            edPRO_REFERENCIA.EditValue = F.toString(gridView1.GetFocusedRowCellValue("PRO_REFERENCIA"));
            edPRO_FORNECEDOR.EditValue = F.toString(gridView1.GetFocusedRowCellValue("PRO_FORNECEDOR"));
            edPRO_CUSTO.EditValue = F.toDouble(gridView1.GetFocusedRowCellValue("PRO_CUSTO"));
            edPRO_CUSTOULTCOMPRA.EditValue = F.toDouble(gridView1.GetFocusedRowCellValue("PRO_CUSTOULTCOMPRA"));
            img = F.toString(gridView1.GetFocusedRowCellValue("PRO_IMAGEM"));
            tipo = F.toInt(gridView1.GetFocusedRowCellValue("PRO_TIPO"));

        }
    }
}