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
        DataTable clientes;
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

            clientes.Columns.Add("CLI_ID", typeof(int));
            clientes.Columns.Add("CLI_RAZSO", typeof(string));
            clientes.Columns.Add("CLI_INSES", typeof(string));
            clientes.Columns.Add("CLI_NAS", typeof(DateTime));
            clientes.Columns.Add("CLI_CEL", typeof(string));
            clientes.Columns.Add("CLI_TEL", typeof(string));
            clientes.Columns.Add("CLI_EMAIL", typeof(string));
            clientes.Columns.Add("CLI_CNPJ", typeof(string));
            clientes.PrimaryKey = new DataColumn[]
            {
                clientes.Columns["CLI_ID"]
            };
        }
        //
        private void FrmCadCli_Load(object sender, EventArgs e)
        {
            rgPesTipo.EditValue = "FIS";
        }

        private void rgPesTipo_EditValueChanged(object sender, EventArgs e)
        {
            if (F.toString(rgPesTipo.EditValue) == "JUR")
            {
                edCLI_NAS.Enabled = false;
                edCLI_INSES.Enabled = true;
                edCLI_FANTASIA.Enabled = true;
                edCLI_CNPJ.Enabled = true;
                edCLI_RAZAO.Enabled = true;
            }
            else
            {
                edCLI_INSES.Enabled = false;
                edCLI_CNPJ.Enabled = false;
                edCLI_RAZAO.Enabled = false;
                edCLI_FANTASIA.Enabled = false;
                edCLI_NAS.Enabled = true;
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
            if (F.toString(rgPesTipo.EditValue) == "FIS" ) 
            {
                if (F.toString(edCLI_RAZAO) == "")
                {
                    F.Aviso("Por Favor, Informe o Nome do cliente.");
                }
                if (F.toString(edCLI_TEL.EditValue) == "" && F.toString(edCLI_CEL.EditValue) == ""
                && F.toString(edCLI_EMAIL.EditValue) == "")
                {
                    F.Aviso("Por favor, informa ao menos uma forma de contato.");
                }
                if (F.toString(edDDDCel.EditValue) == "" && F.toString(edCLI_CEL.EditValue) != "") 
                {
                    F.Aviso("Por Favor, Informe o DDD do celular.");
                }
                if (F.toString(edDDDTel.EditValue) == "" && F.toString(edCLI_TEL.EditValue) != "")
                {
                    F.Aviso("Por Favor, Informe o DDD do telefone.");
                }
            }
            if (F.toString(rgPesTipo.EditValue) == "JUR")
            {
                if (F.toString(edCLI_RAZAO) == "")
                {
                    F.Aviso("Por favor, Informe a Razão Social do cliente");
                }
                if (F.toString(edCLI_FANTASIA.EditValue) == "")
                {
                    F.Aviso("Por favor, informe o nome fantasia do cliente");
                }
                if (F.toString(edCLI_INSES) == "")
                {
                    F.Aviso("Por Favor, informe a Inscrição Estadual do cliente");
                }
                if (F.toString(edCLI_TEL.EditValue) == "" && F.toString(edCLI_CEL.EditValue) == ""
                && F.toString(edCLI_EMAIL.EditValue) == "")
                {
                    F.Aviso("Por favor, informa ao menos uma forma de contato.");
                }
                if (F.toString(edDDDCel.EditValue) == "" && F.toString(edCLI_CEL.EditValue) != "")
                {
                    F.Aviso("Por Favor, Informe o DDD do celular.");
                }
                if (F.toString(edDDDTel.EditValue) == "" && F.toString(edCLI_TEL.EditValue) != "")
                {
                    F.Aviso("Por Favor, Informe o DDD do telefone.");
                }
            }
            int idc = 0;
            DataRow dr = clientes.NewRow();
            dr["CLI_ID"] = F.toInt(idc);
            idc++;
            dr["CLI_RAZSO"] = F.toString(edCLI_RAZAO.EditValue);
            dr["CLI_INSES"] = F.toString(edCLI_INSES.EditValue);
            dr["CLI_NAS"] = edCLI_NAS.EditValue;
            dr["CLI_CEL"] = F.toString(edDDDCel.EditValue) + F.toString(edCLI_CEL.EditValue);
            dr["CLI_TEL"] = F.toString(edDDDTel.EditValue) + F.toString(edCLI_TEL.EditValue);
            dr["CLI_FANTASIA"] = F.toString(edCLI_FANTASIA.EditValue);
            dr["CLI_EMAIL"] = F.toString(edCLI_EMAIL.EditValue);
        }
    }
}
