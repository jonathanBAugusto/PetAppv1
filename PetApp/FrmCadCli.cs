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

namespace WindowsFormsApp1
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

        }

        private void rgPesTipo_EditValueChanged(object sender, EventArgs e)
        {
            if (Funcoes.toString(rgPesTipo.EditValue) == "JUR")
            {
                edNomeCli.Enabled = false;
                edNasCli.Enabled = false;
                edInsEsCli.Enabled = true;
                edCNPJCli.Enabled = true;
                edRaSoCli.Enabled = true;
            }
            else
            {
                edInsEsCli.Enabled = false;
                edCNPJCli.Enabled = false;
                edRaSoCli.Enabled = false;
                edNomeCli.Enabled = true;
                edNasCli.Enabled = true;
            }
        }

        private void edCEP_EditValueChanged(object sender, EventArgs e)
        {
          
        }

        private void edCEP_Validated(object sender, EventArgs e)
        {

            Funcoes.LocalizarCEP(Funcoes.toString(edCEP.EditValue),edEstado,edCidade,edBairro,edRua);
          
        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            DataRow dr = infoPets.NewRow();
            dr["IDPet"] = id;
            id++;
            dr["NomePet"] = Funcoes.toString(edNomePet.Text);
            dr["RacaPet"] = Funcoes.toString(edRacaPet.Text);
            dr["CorPet"] = Funcoes.toString(edCorPet.Text);
            dr["NasPet"] = Funcoes.toString(edNasPet.Text);
            dr["IdadePet"] = Funcoes.toString(Funcoes.idade(Convert.ToDateTime(edNasPet.Value)));
            infoPets.Rows.Add(dr);
        }
    }
}
