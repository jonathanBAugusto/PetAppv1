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

namespace PetApp.View.UTL
{
    public partial class FrmSelectCli : DevExpress.XtraEditors.XtraForm
    {
        private string result;

        public string Result
        {
            get { return result; }
            set { result = value; }
        }

        private bool getInLoad = false;

        public bool GetInLoad
        {
            get { return getInLoad; }
            set { getInLoad = value; }
        }


        public FrmSelectCli()
        {
            InitializeComponent();
        }

        private void FrmSelectCli_Load(object sender, EventArgs e)
        {
            if (GetInLoad)
            {
                btnPesquisar_Click(null, null);
                gridViewProdutos.Focus();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            StringBuilder filtro = new StringBuilder();
            if (F.toString(edDATAINI.EditValue) != "")
            {
                filtro.Append(" AND " + F.toString(rgPeriodo.EditValue) + " >= '" + F.toString(edDATAINI.DateTime) + "' ");
            }
            if (F.toString(edDATAFIN.EditValue) != "")
            {
                filtro.Append(" AND " + F.toString(rgPeriodo.EditValue) + " <= '" + F.toString(edDATAFIN.DateTime) + "' ");
            }
            if (F.toString(edCLI_ID.EditValue) != "")
            {
                filtro.Append(" AND CLI_ID = " + F.toString(edCLI_ID.EditValue));
            }
            if (F.toString(edCLI_RAZAO.EditValue) != "")
            {
                filtro.Append(" AND CLI_RAZAO = '" + F.toString(edCLI_RAZAO.EditValue) + "' ");
            }
            if (F.toString(edCLI_CNPJ.EditValue) != "")
            {
                filtro.Append(" AND CLI_CNPJ = '" + F.toString(edCLI_CNPJ.EditValue) + "' ");
            }
            if (F.toString(edCLI_INSCRICAO.EditValue) != "")
            {
                filtro.Append(" AND CLI_INSCRICAO = '" + F.toString(edCLI_INSCRICAO.EditValue) + "' ");
            }
            if (F.toString(rgCLI_PESTIPO.EditValue) != "" && F.toString(rgCLI_PESTIPO.EditValue) != "TOD")
            {
                filtro.Append(" AND CLI_PESTIPO = '" + F.toString(rgCLI_PESTIPO.EditValue) + "' ");
            }

            List<Clientes> listCliente = new List<Clientes>();
            listCliente = Clientes.Get(filtro?.ToString());
            gridControlCli.DataSource = listCliente;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Clientes cliFocused = (Clientes)gridViewProdutos.GetFocusedRow();
            if (cliFocused != null)
            {
                Result = F.toString(cliFocused.CLI_ID);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void gridViewProdutos_DoubleClick(object sender, EventArgs e)
        {
            btnOK_Click(null, null);
        }

        private void gridViewProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                btnOK_Click(null, null);
            }
        }
    }
}