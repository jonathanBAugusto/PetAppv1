using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetApp.View.Servico;
using PetApp.View.Relatorios;
using PetApp.Model;
using PetApp.View;

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
            edCLI_ID.Properties.DataSource = Clientes.Get();
            edCLI_ID.Properties.ValueMember = "CLI_ID";
            edCLI_ID.Properties.DisplayMember = "CLI_RAZAO";

            edTIPO_SER.Properties.DataSource = TipoServico.Get();
            edTIPO_SER.Properties.ValueMember = "TIPO_SER_ID";
            edTIPO_SER.Properties.DisplayMember = "TIPO_SER_NOME";

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
                CLI_ID = F.toInt(edCLI_ID.EditValue),
                PET_ID = F.toInt(edPET_ID.EditValue),
                SER_VALOR_BASE = F.toDouble(edSER_VALOR_BASE.EditValue),
                SER_VALOR_DESCONTO = F.toDouble(edSER_VALOR_DESCONTO.EditValue),
                SER_VALOR_TOTAL = F.toDouble(valorTotal),
                SER_DATA_CAD = F.toString(DateTime.Now.ToShortDateString()),
                SER_DATA_PREV = F.toString(edSER_DATA_PREV.Text),
                SER_TIPO_ID = F.toInt(edTIPO_SER.EditValue),
                SER_OBSERVACAO = F.toString(edSER_OBSERVACAO.Text),
                SER_ESTAGIO = F.toString(estagio)
            };
            Servicos.Insert(servico);
            F.Aviso("Serviço Cadastrado com Sucesso!");
        }

        private void edSER_OBSERVACAO_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            REL_SERVICOS rel = new REL_SERVICOS();
            rel.Show();
        }

        private void btnAddTipoServico_Click(object sender, EventArgs e)
        {
            frmTipoServico form = new frmTipoServico();
            form.Show();
        }

        private void btnAddCli_Click(object sender, EventArgs e)
        {
            FrmCadCli form = new FrmCadCli();
            form.Show();
        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            FrmPets form = new FrmPets();
            form.Show();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            SH_SERVICOS form = new SH_SERVICOS();
            form.Show();
        }
    }
}
