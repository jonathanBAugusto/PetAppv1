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

            PET_ID.Properties.DataSource = Pets.Get();
            PET_ID.Properties.ValueMember = "PET_ID";
            PET_ID.Properties.DisplayMember = "PET_NOME";

            CLI_ID.Properties.DataSource = Clientes.Get();
            CLI_ID.Properties.ValueMember = "CLI_ID";
            CLI_ID.Properties.DisplayMember = "CLI_RAZAO";
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
    }
}