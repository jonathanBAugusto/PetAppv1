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
    public partial class FrmCadCli : Form
    {
        DataTable infoPets;
        int id = 0;
        public FrmCadCli()
        {
            InitializeComponent();
            infoPets = new DataTable();
            infoPets.Columns.Add("IDPet", typeof(int));
            infoPets.Columns.Add("NomePet", typeof(string));
            infoPets.Columns.Add("RacaPet", typeof(string));
            infoPets.Columns.Add("CorPet", typeof(string));
            infoPets.Columns.Add("NasPet", typeof(string));
            infoPets.Columns.Add("IdadePet", typeof(int));
            gridControlPet.DataSource = infoPets;
            infoPets.PrimaryKey = new DataColumn[] {
                infoPets.Columns["IDPet"]
            };
        }

        private void FrmCadCli_Load(object sender, EventArgs e)
        {
            rgPesTipo.EditValue = "FIS";
        }

        private void rgPesTipo_EditValueChanged(object sender, EventArgs e)
        {
            if (F.toString(rgPesTipo.EditValue) == "JUR")
            {
                edNomeCli.Enabled = false;
                edNasCli.Enabled = false;
                edInsEsCli.Enabled = true;
                edCNPJCli.Enabled = true;
                edRazSoCli.Enabled = true;
            }
            else
            {
                edInsEsCli.Enabled = false;
                edCNPJCli.Enabled = false;
                edRazSoCli.Enabled = false;
                edNomeCli.Enabled = true;
                edNasCli.Enabled = true;
            }
        }

        private void edCEP_EditValueChanged(object sender, EventArgs e)
        {
          
        }

        private void edCEP_Validated(object sender, EventArgs e)
        {
            try
            {
                F.LocalizarCEP(F.toString(edCEP.EditValue),edEstado,edCidade,edBairro,edRua);
            }
            catch (Exception ex)
            {
                F.WriteLOG("-----------------------\n" + DateTime.Now.ToString() + " Erro: " + ex.Message);            }
          
        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            DataRow dr = infoPets.NewRow();
            dr["IDPet"] = id;
            id++;
            dr["NomePet"] = F.toString(edNomePet.Text);
            dr["RacaPet"] = F.toString(edRacaPet.Text);
            dr["CorPet"] = F.toString(edCorPet.Text);
            dr["NasPet"] = F.toString(edNasPet.Text);
            dr["IdadePet"] = F.toString(F.idade(Convert.ToDateTime(edNasPet.EditValue)));
            infoPets.Rows.Add(dr);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (F.toString(rgPesTipo.EditValue) == "FIS" ) 
            {
                if (F.toString(edNomeCli) == "")
                {
                    F.Aviso("Por Favor, Informe o Nome do Cliente.");
                }
                if (F.toString(edTelCli.EditValue) == "" && F.toString(edCelCli.EditValue) == ""
                && F.toString(edEmail.EditValue) == "")
                {
                    F.Aviso("Por favor, informa ao menos uma forma de contato.");
                }
                if (F.toString(edDDDCel.EditValue) == "" && F.toString(edCelCli.EditValue) != "") 
                {
                    F.Aviso("Por Favor, Informe o DDD do celular.");
                }
                if (F.toString(edDDDTel.EditValue) == "" && F.toString(edTelCli.EditValue) != "")
                {
                    F.Aviso("Por Favor, Informe o DDD do telefone.");
                }
            }
            if (F.toString(rgPesTipo.EditValue) == "JUR")
            {
                if (F.toString(edRazSoCli) == "")
                {
                    F.Aviso("Por favor, Informe a Razão Social do cliente");
                }
                if (F.toString(edInsEsCli) == "")
                {
                    F.Aviso("Por Favor, informe a Inscrição Estadual do cliente");
                }
                if (F.toString(edTelCli.EditValue) == "" && F.toString(edCelCli.EditValue) == ""
                && F.toString(edEmail.EditValue) == "")
                {
                    F.Aviso("Por favor, informa ao menos uma forma de contato.");
                }
                if (F.toString(edDDDCel.EditValue) == "" && F.toString(edCelCli.EditValue) != "")
                {
                    F.Aviso("Por Favor, Informe o DDD do celular.");
                }
                if (F.toString(edDDDTel.EditValue) == "" && F.toString(edTelCli.EditValue) != "")
                {
                    F.Aviso("Por Favor, Informe o DDD do telefone.");
                }
            }

            Clientes newCli = new Clientes()
            {
                CLI_NOME = F.toString(edNomeCli.EditValue),
                CLI_RAZAO = F.toString(edRazSoCli.EditValue),
                CLI_CNPJ = F.toString(edCNPJCli.EditValue),
                CLI_INSCRICAO = F.toString(edInsEsCli.EditValue),
                CLI_EMAIL = F.toString(edEmail.EditValue),
                CLI_NASC = F.toString(edNasCli.EditValue),
                CLI_DDDTEL = F.toString(edDDDTel.EditValue),
                CLI_TEL = F.toString(edTelCli.EditValue),
                CLI_DDDCEL = F.toString(edDDDCel.EditValue),
                CLI_CEL = F.toString(edCelCli.EditValue),
                CLI_PESTIPO = F.toString(rgPesTipo.EditValue),
                CLI_CEP = F.toString(edCEP.EditValue),
                CLI_RUA = F.toString(edRua.EditValue),
                CLI_BAIRRO = F.toString(edBairro.EditValue),
                CLI_NUMERO = F.toString(edNumero.EditValue),
                CLI_ENDCOMPLE = F.toString(edComplemento.EditValue),
                CID_ID = 1
            };

            if (Clientes.Insert(newCli))
                this.Close();
        }
    }
}
