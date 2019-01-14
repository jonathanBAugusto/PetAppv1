using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios.Net;
using PetApp.Model;

namespace PetApp
{
    public partial class FrmCadCli : DevExpress.XtraEditors.XtraForm
    {
        DataTable infoPets;
        int id = 0;
        public FrmCadCli()
        {
            InitializeComponent();
            infoPets = new DataTable();
            infoPets.Columns.Add("PET_ID", typeof(int));
            infoPets.Columns.Add("PET_NOME", typeof(string));
            infoPets.Columns.Add("PET_RACA", typeof(string));
            infoPets.Columns.Add("PET_COR", typeof(string));
            infoPets.Columns.Add("PET_NAS", typeof(string));
            infoPets.Columns.Add("PET_IDADE", typeof(int));
            gridControlPet.DataSource = infoPets;
            infoPets.PrimaryKey = new DataColumn[] {
                infoPets.Columns["PET_ID"]
            };

            List<Clientes> clientes = new List<Clientes>();
            clientes.Add(new Clientes {
                CLI_RAZAO = F.toString(edCLI_RAZAO.EditValue),
                CLI_FANTASIA = F.toString(edCLI_FANTASIA),
                CLI_INSCRICAO = F.toString(edCLI_INSCRICAO),
                CLI_CNPJ = F.toString(edCLI_CNPJ.EditValue),
                CLI_EMAIL = F.toString(edCLI_EMAIL.EditValue),
                CLI_TEL = F.toString(edCLI_TEL.EditValue),
                CLI_CEL = F.toString(edCLI_CEL.EditValue),
                CLI_NASC = F.toString(edCLI_NASC.EditValue),
                CLI_CEP = F.toString(edCEP.EditValue),
                CLI_BAIRRO = F.toString(edBairro.EditValue),
                CLI_NUMERO = F.toString(edNumero.EditValue),
                CLI_PESTIPO = F.toString(rgCLI_PESTIPO.EditValue),
                CLI_RUA = F.toString(edRua.EditValue),
            });

        }
        //
        private void FrmCadCli_Load(object sender, EventArgs e)
        {
            rgCLI_PESTIPO.EditValue = "FIS";
        }

        private void rgPesTipo_EditValueChanged(object sender, EventArgs e)
        {
            if (F.toString(rgCLI_PESTIPO.EditValue) == "JUR")
            {
                edCLI_NASC.Enabled = false;
                edCLI_INSCRICAO.Enabled = true;
                edCLI_FANTASIA.Enabled = true;
                edCLI_CNPJ.Enabled = true;
                edCLI_RAZAO.Enabled = true;
            }
            else
            {
                edCLI_INSCRICAO.Enabled = false;
                edCLI_CNPJ.Enabled = false;
                edCLI_RAZAO.Enabled = false;
                edCLI_FANTASIA.Enabled = false;
                edCLI_NASC.Enabled = true;
            }
        }

        private void edCEP_EditValueChanged(object sender, EventArgs e)
        {
          
        }

        private void edCEP_Validated(object sender, EventArgs e)
        {

            F.LocalizarCEP(F.toString(edCEP.EditValue),edEstado,edCidade,edBairro,edRua);
          
        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            DataRow dr = infoPets.NewRow();
            dr["PET_ID"] = id;
            id++;
            dr["PET_NOME"] = F.toString(edPET_NOME.Text);
            dr["PET_RACA"] = F.toString(edPET_RACA.Text);
            dr["PET_COR"] = F.toString(edPET_COR.Text);
            dr["PET_NAS"] = F.toString(edPET_NAS.Text);
            dr["PET_IDADE"] = F.toString(F.idade(Convert.ToDateTime(edPET_NAS.EditValue)));
            infoPets.Rows.Add(dr);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (F.toString(rgCLI_PESTIPO.EditValue) == "FIS" ) 
            {
                if (F.toString(edCLI_RAZAO) == "")
                {
                    F.Aviso("Por Favor, Informe o Nome do cliente.");
                    edCLI_RAZAO.Focus();
                }
                if (F.toString(edCLI_TEL.EditValue) == "" && F.toString(edCLI_CEL.EditValue) == ""
                && F.toString(edCLI_EMAIL.EditValue) == "")
                {
                    F.Aviso("Por favor, informa ao menos uma forma de contato.");
                }
                if (F.toString(edDDDCel.EditValue) == "" && F.toString(edCLI_CEL.EditValue) != "") 
                {
                    F.Aviso("Por Favor, Informe o DDD do celular.");
                    edDDDCel.Focus();
                }
                if (F.toString(edDDDTel.EditValue) == "" && F.toString(edCLI_TEL.EditValue) != "")
                {
                    F.Aviso("Por Favor, Informe o DDD do telefone.");
                    edDDDTel.Focus();
                }
            }
            if (F.toString(rgCLI_PESTIPO.EditValue) == "JUR")
            {
                if (F.toString(edCLI_RAZAO) == "")
                {
                    F.Aviso("Por favor, Informe a Razão Social do cliente");
                    edCLI_RAZAO.Focus();
                }
                if (F.toString(edCLI_FANTASIA.EditValue) == "")
                {
                    F.Aviso("Por favor, informe o nome fantasia do cliente");
                    edCLI_FANTASIA.Focus();
                }
                if (F.toString(edCLI_INSCRICAO) == "")
                {
                    F.Aviso("Por Favor, informe a Inscrição Estadual do cliente");
                    edCLI_INSCRICAO.Focus();
                }
                if (F.toString(edCLI_TEL.EditValue) == "" && F.toString(edCLI_CEL.EditValue) == ""
                && F.toString(edCLI_EMAIL.EditValue) == "")
                {
                    F.Aviso("Por favor, informa ao menos uma forma de contato.");
                }
                if (F.toString(edDDDCel.EditValue) == "" && F.toString(edCLI_CEL.EditValue) != "")
                {
                    F.Aviso("Por Favor, Informe o DDD do celular.");
                    edDDDCel.Focus();
                }
                if (F.toString(edDDDTel.EditValue) == "" && F.toString(edCLI_TEL.EditValue) != "")
                {
                    F.Aviso("Por Favor, Informe o DDD do telefone.");
                    edDDDTel.Focus();
                }
            }
            F.Aviso("Cliente Cadastrado com Sucesso!");
        }

        private void peImgPET_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
