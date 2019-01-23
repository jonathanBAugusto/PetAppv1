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
    public partial class SH_FORNECEDORES : DevExpress.XtraEditors.XtraForm
    {
        public SH_FORNECEDORES()
        {
            InitializeComponent();
        }

        private void SH_FORNECEDORES_Load(object sender, EventArgs e)
        {
            gridControlFornecedores.DataSource = Clientes.Get(" AND CLI_PESTIPO = 'FOR'");
        }

        private void btnRemCli_Click(object sender, EventArgs e)
        {
            int IdFor = 0;
            IdFor = F.toInt(gridView1.GetFocusedRowCellValue("CLI_ID"));
            Clientes.Delete(Clientes.Get(IdFor));
            SH_FORNECEDORES_Load(null, null);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FrmCadCli form = new FrmCadCli();
            form.ShowDialog();
        }

        private void btnAltCli_Click(object sender, EventArgs e)
        {

        }

        private void gridControlFornecedores_DoubleClick(object sender, EventArgs e)
        {

        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int IdFor = 0;
            IdFor = F.toInt(gridView1.GetFocusedRowCellValue("CLI_ID"));
            Clientes.Delete(Clientes.Get(IdFor));
            SH_FORNECEDORES_Load(null, null);
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCli form = new FrmCadCli();
            form.IdCliAlt = F.toInt(gridView1.GetFocusedRowCellValue("CLI_ID"));
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                SH_FORNECEDORES_Load(null, null);
            }
        }

        private void btnPesq_Click(object sender, EventArgs e)
        {

            StringBuilder filtro = new StringBuilder();
            if (F.toString(edCLI_RAZAO.EditValue) != "")
            {
                filtro.Append(" AND CLI_RAZAO = '" + F.toString(edCLI_FANTASIA.EditValue) + "' ");
            }
            if (F.toString(edCLI_FANTASIA.EditValue) != "")
            {
                filtro.Append(" AND CLI_FANTASIA = '" + F.toString(edCLI_FANTASIA.EditValue) + "' ");
            }
            if (F.toString(edCLI_EMAIL.EditValue) != "")
            {
                filtro.Append(" AND CLI_EMAIL = '" + F.toString(edCLI_FANTASIA.EditValue) + "' ");
            }
            if (F.toString(edCLI_CNPJ.EditValue) != "")
            {
                filtro.Append(" AND CLI_CNPJ = '" + F.toString(edCLI_FANTASIA.EditValue) + "' ");
            }
            if (F.toString(edCLI_CEP.EditValue) != "")
            {
                filtro.Append(" AND CLI_CEP = '" + F.toString(edCLI_FANTASIA.EditValue) + "' ");
            }
            filtro.Append("AND CLI_PESTIPO = 'FOR'");
            List<Clientes> listCliente = new List<Clientes>();
            listCliente = Clientes.Get(filtro.ToString());
            gridControlFornecedores.DataSource = listCliente;
        }
    }
}