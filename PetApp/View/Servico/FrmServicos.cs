using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetApp.View.Servicos;
using PetApp.Model;
namespace PetApp
{
    public partial class FrmServicos : DevExpress.XtraEditors.XtraForm
    {
        double valorTotal = 0;
        string estagio;
        public FrmServicos()
        {
            InitializeComponent();

        }

        private void FrmServicos_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (F.toDouble(edSER_VALOR_DESCONTO.EditValue) != 0.0)
            {
                valorTotal = F.toDouble(edSER_VALOR_BASE.EditValue) - F.toDouble(edSER_VALOR_DESCONTO.EditValue);
            }
            else
            {
                valorTotal = F.toDouble(edSER_VALOR_BASE.EditValue);
            }
            if (F.toString(cbEstagio.EditValue) == "N")
            {
                estagio = "Não iniciado";
            }
            if (F.toString(cbEstagio.EditValue) == "P")
            {
                estagio = "Em processo";
            }
            if (F.toString(cbEstagio.EditValue) == "F")
            {
                estagio = "Finalizado";
            }
            if (F.toString(cbEstagio.EditValue) == "C")
            {
                estagio = "Cancelado";
            }
            Servicos servico = new Servicos {
                CLI_ID = F.toInt(edCLI_NOME.EditValue),
                PET_ID = F.toInt(edPET_ID.EditValue),
                SER_VALOR_BASE = F.toDouble(edSER_VALOR_BASE.EditValue),
                SER_VALOR_DESCONTO = F.toDouble(edSER_VALOR_DESCONTO.EditValue),
                SER_VALOR_TOTAL = F.toDouble(valorTotal),
                SER_DATA_CAD = F.toString(DateTime.Now.ToShortDateString()),
                SER_DATA_PREV = F.toString(edSER_DATA_PREV.Text),
                SER_TIPO_ID = F.toInt(edSER_TIPO.EditValue),
                SER_OBSERVACAO = F.toString(edSER_OBSERVACAO.Text),
                SER_ESTAGIO = F.toString(estagio)
            };
            Servicos.Insert(servico);

        }

        private void edSER_OBSERVACAO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
