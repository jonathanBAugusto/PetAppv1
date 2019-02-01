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
        public FrmEstoque()
        {
            InitializeComponent();
            listLancprods = new List<Lancprods>();
            gridControlEstoque.DataSource = listLancprods;
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
            Lancprods obj = new Lancprods() { PRO_ID = pro_id, LCP_QUANTIDADE = F.toDouble(edLCP_QUANTIDADE.EditValue), LCP_DATA = edLCP_DATA.DateTime, LCP_TIPO = F.toString(rgLCP_TIPO.EditValue)};
            listLancprods.Add(obj);
            limparCampos(false);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Lancprods objFocused =  gridViewEstoque.GetFocusedRow() as Lancprods;

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
        {//é Produto!
            UTL.FrmSelectPro obj = new UTL.FrmSelectPro();
            obj.ShowDialog();
            string PRO_REFERENCIA = F.toString(obj.PRO_REFERENCIA);
            edPRO_REFERENCIA.EditValue = PRO_REFERENCIA; 
        }
    }
}