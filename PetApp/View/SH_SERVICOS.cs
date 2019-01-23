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
    public partial class SH_SERVICOS : DevExpress.XtraEditors.XtraForm
    {
        public SH_SERVICOS()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SH_SERVICOS_Load(object sender, EventArgs e)
        {
            gridControlServicos.DataSource = Servicos.Get();
            repositoryItemGridLookUpEditClientes.DataSource = Clientes.Get();
            repositoryItemGridLookUpEditClientes.ValueMember = "CLI_ID";
            repositoryItemGridLookUpEditClientes.DisplayMember = "CLI_RAZAO";

            repositoryItemGridLookUpEditTipoSer.DataSource = TipoServico.Get();
            repositoryItemGridLookUpEditTipoSer.ValueMember = "TIPO_SER_ID";
            repositoryItemGridLookUpEditTipoSer.DisplayMember = "TIPO_SER_NOME";

            repositoryItemGridLookUpEditPets.DataSource = Pets.Get();
            repositoryItemGridLookUpEditPets.ValueMember = "PET_ID";
            repositoryItemGridLookUpEditPets.DisplayMember = "PET_NOME";

            edPET_ID.Properties.DataSource = Pets.Get();
            edPET_ID.Properties.ValueMember = "PET_ID";
            edPET_ID.Properties.DisplayMember = "PET_NOME";

            edCLI_ID.Properties.DataSource = Clientes.Get();
            edCLI_ID.Properties.ValueMember = "CLI_ID";
            edCLI_ID.Properties.DisplayMember = "CLI_RAZAO";

            edTIPO_SER_ID.Properties.DataSource = TipoServico.Get();
            edTIPO_SER_ID.Properties.ValueMember = "TIPO_SER_ID";
            edTIPO_SER_ID.Properties.DisplayMember = "TIPO_SER_NOME";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetFocusedDataRow();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FrmServicos form = new FrmServicos();
            form.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            StringBuilder filtro = new StringBuilder();
            if (F.toString(edCLI_ID.EditValue) != "")
            {
                filtro.Append(" AND CLI_ID = '" + F.toInt(edCLI_ID.EditValue) + "' ");
            }
            if (F.toString(edPET_ID.EditValue) != "")
            {
                filtro.Append(" AND PET_ID = '" + F.toInt(edPET_ID.EditValue) + "' ");
            }
            if (F.toString(edSER_DATA_CAD.EditValue) != "")
            {
                filtro.Append(" AND SER_DATA_CAD = '" + F.toString(edSER_DATA_CAD.EditValue) + "' ");
            }
            if (F.toString(edSER_VALOR_TOTAL.EditValue) != "")
            {
                filtro.Append(" AND SER_VALOR_TOTAL = '" + F.toDouble(edSER_VALOR_TOTAL.EditValue) + "' ");
            }
            if (F.toString(edTIPO_SER_ID.EditValue) != "")
            {
                filtro.Append(" AND TIPO_SER_ID = '" + F.toInt(edTIPO_SER_ID.EditValue) + "' ");
            }
            List<Servicos> listServico = new List<Servicos>();
            listServico = Servicos.Get(filtro.ToString());
            gridControlServicos.DataSource = listServico;
        }
    }
}