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
    public partial class FrmTipoProduto : DevExpress.XtraEditors.XtraForm
    {
        int idAlt = 0;
        public FrmTipoProduto()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (idAlt != 0)
            {
                TipoProduto tipoNew = new TipoProduto();
                tipoNew.TPR_ID = idAlt;
                tipoNew.TPR_DESCRICAO = F.toString(edTPR_DESCRICAO.EditValue);
                if (TipoProduto.Update(tipoNew))
                {
                    F.Aviso("Tipo de produto alterado com sucesso.");
                    btnAdicionar.Text = "Adicionar";
                    edTPR_DESCRICAO.EditValue = "";
                    idAlt = 0;
                    FrmTipoProduto_Load(null, null);
                }
                else
                {
                    F.Aviso("Erro ao salvar");
                }
            }
            else
            {


                TipoProduto tipo = new TipoProduto
                {
                    TPR_DESCRICAO = F.toString(edTPR_DESCRICAO.EditValue)
                };
                if (TipoProduto.Insert(tipo))
                {
                    btnAdicionar.Text = "Adicionar";
                    edTPR_DESCRICAO.EditValue = "";
                    edTPR_DESCRICAO.Focus();
                    FrmTipoProduto_Load(null, null);
                }
            }
        }

        private void FrmTipoProduto_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = TipoProduto.Get();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int TPR_ID = F.toInt(gridView1.GetFocusedRowCellValue("TPR_ID"));
            TipoProduto tipoAlt = TipoProduto.Get(TPR_ID);
            edTPR_DESCRICAO.EditValue = F.toString(tipoAlt.TPR_DESCRICAO);
            btnAdicionar.Text = "Salvar";
            idAlt = TPR_ID;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int TPR_ID = F.toInt(gridView1.GetFocusedRowCellValue("TPR_ID"));
            if (F.YesNo("Deletar", "Deseja realmente remover este tipo de produto?", 1))
            {
                if (TipoProduto.Delete(TipoProduto.Get(TPR_ID)))
                {
                    F.Aviso("Tipo de produto removido com suceso");
                    FrmTipoProduto_Load(null,null);
                }
            }
        }
    }
}