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

namespace PetApp.View.UTL
{
    public partial class FrmSelectPro : DevExpress.XtraEditors.XtraForm
    {
        private string pro_referencia;

        public string PRO_REFERENCIA
        {
            get { return pro_referencia; }
            set { pro_referencia = value; }
        }

        List<Produtos> listProdutos = new List<Produtos>();
        public FrmSelectPro()
        {
            InitializeComponent();
            listProdutos.AddRange(Produtos.Get());
            gridControlProdutos.DataSource = listProdutos;
        }

        private void FrmSelectPro_Load(object sender, EventArgs e)
        {
            repositoryItemLookUpEditTipo.DataSource = TipoProduto.Get();
            repositoryItemLookUpEditTipo.ValueMember = "TPR_ID";
            repositoryItemLookUpEditTipo.DisplayMember = "TPR_DESCRICAO";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Produtos produtoF = gridViewProdutos.GetFocusedRow() as Produtos;
            if (produtoF == null)
            {
                return;
            }
            PRO_REFERENCIA = F.toString(produtoF.PRO_REFERENCIA);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();
            StringBuilder filtro = new StringBuilder();

            if (F.toString(edPRO_REFERENCIA.EditValue) != "")
            {
                filtro.Append(" AND PRODUTOS.PRO_REFERENCIA = '" + F.toString(edPRO_REFERENCIA.EditValue) + "' ");
            }
            if (F.toString(edPRO_FORNECEDOR.EditValue) != "")
            {
                filtro.Append(" AND PRODUTOS.PRO_FORNECEDOR = '" + F.toString(edPRO_FORNECEDOR.EditValue) + "' ");
            }
            if (F.toString(edDATAINI.EditValue) != "")
            {
                filtro.Append(" AND PRODUTOS.PRO_DATACADASTRO >= '" + F.toString(edDATAINI.EditValue) + "' ");
            }
            if (F.toString(edDATAFIN.EditValue) != "")
            {
                filtro.Append(" AND PRODUTOS.PRO_DATACADASTRO <= '" + F.toString(edDATAFIN.EditValue) + "' ");
            }
            if (F.toString(edPRO_CUSTOINI.EditValue) != "")
            {
                filtro.Append(" AND PRODUTOS.PRO_CUSTO >= " + F.toString(edPRO_CUSTOINI.EditValue).Replace(".", string.Empty).Replace(",", "."));
            }
            if (F.toString(edDATAFIN.EditValue) != "")
            {
                filtro.Append(" AND PRODUTOS.PRO_CUSTO <= " + F.toString(edPRO_CUSTOINI.EditValue).Replace(".", string.Empty).Replace(",", "."));
            }
            if (F.toString(edPRO_CUSTOULTCOMPRAINI.EditValue) != "")
            {
                filtro.Append(" AND PRODUTOS.PRO_CUSTOULTCOMPRA >= " + F.toString(edPRO_CUSTOULTCOMPRAINI.EditValue).Replace(".", string.Empty).Replace(",", "."));
            }
            if (F.toString(edPRO_CUSTOULTCOMPRAFIN.EditValue) != "")
            {
                filtro.Append(" AND PRODUTOS.PRO_CUSTOULTCOMPRA <= " + F.toString(edPRO_CUSTOULTCOMPRAFIN.EditValue).Replace(".", string.Empty).Replace(",", "."));
            }

            sql.Append("	SELECT		");
            sql.Append("		PRODUTOS.PRO_ID,	");
            sql.Append("		PRODUTOS.PRO_REFERENCIA,	");
            sql.Append("		PRODUTOS.PRO_DESCRICAO,	");
            sql.Append("		PRODUTOS.PRO_CUSTO,	");
            sql.Append("		PRODUTOS.PRO_CUSTOULTCOMPRA,	");
            sql.Append("		PRODUTOS.PRO_TIPO,	");
            sql.Append("		PRODUTOS.PRO_FORNECEDOR,	");
            sql.Append("		CLIENTE.CLI_NOME,	");
            sql.Append("		PRODUTOS.PRO_IMAGEM	");
            sql.Append("	FROM	");
            sql.Append("		PRODUTOS	");
            sql.Append("			JOIN CLIENTE ON (CLIENTE.CLI_ID = PRODUTOS.PRO_FORNECEDOR)	");
        }

        private void gridViewProdutos_Click(object sender, EventArgs e)
        {
            gridViewProdutos_FocusedRowChanged(null, null);
        }

        private void gridViewProdutos_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Produtos obj = gridViewProdutos.GetFocusedRow() as Produtos;
            if (obj != null)
            {
                pcImg.Image = obj.PRO_IMAGEMR;
            }
        }

        private void gridViewProdutos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridViewProdutos_FocusedRowChanged(null, null);
        }
    }
}