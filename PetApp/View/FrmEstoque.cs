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
    public partial class FrmEstoque : DevExpress.XtraEditors.XtraForm
    {
        List<Lancprods> listLancprods;
        List<Unidade> listUnidade;
        public FrmEstoque()
        {
            InitializeComponent();
            listLancprods = new List<Lancprods>();
            gridControlEstoque.DataSource = listLancprods;

            DataTable temp = new DataTable();
            temp.Columns.Add("LCP_TIPO");
            temp.Columns.Add("LCP_TIPODESC");
            temp.Rows.Add("E", "ENTRADA");
            temp.Rows.Add("S", "SAÍDA");


            repLkTipoMov.DataSource = temp;
            repLkTipoMov.ValueMember = "LCP_TIPO";
            repLkTipoMov.DisplayMember = "LCP_TIPODESC";

            listUnidade = new List<Unidade>();
            listUnidade = Unidade.Get();

            repositoryItemLookUpEdit1.DataSource = listUnidade;
            repositoryItemLookUpEdit1.ValueMember = "UNI_ID";
            repositoryItemLookUpEdit1.DisplayMember = "UNI_DESCRICAO";

        }
        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (F.toString(edPRO_REFERENCIA.EditValue) == "")
            {
                F.Aviso("Selecione um Produto para lançar uma movimentação");
                edPRO_REFERENCIA.Focus();
            }
            if (F.toString(edLCP_QUANTIDADE.EditValue) == "")
            {
                F.Aviso("Informe a quantidade para lançar a movimentação");
                edLCP_QUANTIDADE.Focus();
            }
            if (F.toString(edLCP_DATA.EditValue) == "")
            {
                F.Aviso("Informe a data para lançar a movimentação");
                edLCP_DATA.Focus();
            }
            int pro_id = Lancprods.getIDByRef(F.toString(edPRO_REFERENCIA.EditValue));
            if (pro_id == -1)
            {
                F.Aviso("Produto não encontrado");
                return;
            }
            double Quantidade = 0;
            Quantidade = F.toDouble(edLCP_QUANTIDADE.EditValue);
            Lancprods obj = new Lancprods() { PRO_ID = pro_id, LCP_QUANTIDADE = F.toDouble(Quantidade), LCP_DATA = edLCP_DATA.DateTime, LCP_TIPO = F.toString(rgLCP_TIPO.EditValue) };
            listLancprods.Add(obj);
            limparCampos(false);
            gridViewEstoque.RefreshData();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Lancprods objFocused = gridViewEstoque.GetFocusedRow() as Lancprods;

            if (F.toString(objFocused.PRO_ID) != "")
            {
                listLancprods.Remove(objFocused);
            }
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            if (F.YesNo("Atenção", "Deseja confirmar os lançamentos?", 2))
            {
                if (Lancprods.Insert(listLancprods))
                {
                    F.Aviso("Lançamentos feitos com sucesso!");
                    limparCampos(true);
                    this.Close();
                }
            }
        }

        private void limparCampos(bool limpaGrid)
        {
            if (limpaGrid)
            {
                listLancprods = null;
            }

            edLCP_DATA.DateTime = DateTime.Now;
            edLCP_QUANTIDADE.EditValue = null;
            edPRO_REFERENCIA.EditValue = null;
            edPRO_REFERENCIA.Focus();
        }

        private void edPRO_REFERENCIA_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            edPRO_REFERENCIA.EditValue = F.SearchProds();
        }

        private void edPRO_REFERENCIA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                edPRO_REFERENCIA_ButtonClick(null, null);
            }
        }
    }
}