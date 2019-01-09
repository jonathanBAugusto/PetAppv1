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

            F.LocalizarCEP(F.toString(edCEP.EditValue),edEstado,edCidade,edBairro,edRua);
          
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
            dr["IdadePet"] = F.toString(F.idade(Convert.ToDateTime(edNasPet.Value)));
            infoPets.Rows.Add(dr);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (F.toString(rgPesTipo.EditValue) == "FIS" ) 
            {
                if (F.toString(edNomeCli) == "")
                {
                    F.Aviso("Por Favor, Informe o Nome do cliente.");
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
        }
    }
}
