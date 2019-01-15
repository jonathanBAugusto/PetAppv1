using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using PetApp.Model;

namespace PetApp.View.Relatorios
{
    public partial class REL_SERVICOS : DevExpress.XtraEditors.XtraForm
    {
        public REL_SERVICOS()
        {
            InitializeComponent();

        }

        private void REL_SERVICOS_Load(object sender, EventArgs e)
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
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
        }
    }
}
