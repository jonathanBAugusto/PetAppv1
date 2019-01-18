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
    public partial class SH_PETS : DevExpress.XtraEditors.XtraForm
    {
        public SH_PETS()
        {
            InitializeComponent();
        }

        private void SH_PETS_Load(object sender, EventArgs e)
        {
            gridControlPets.DataSource = Pets.Get();

            repositoryItemGridLookUpEditDono.DataSource = Clientes.Get();
            repositoryItemGridLookUpEditDono.ValueMember = "CLI_ID";
            repositoryItemGridLookUpEditDono.DisplayMember = "CLI_RAZAO";

            edCLI_ID.Properties.DataSource = Clientes.Get();
            edCLI_ID.Properties.ValueMember = "CLI_ID";
            edCLI_ID.Properties.DisplayMember= "CLI_NOME";

            edPET_ID.Properties.DataSource = Pets.Get();
            edPET_ID.Properties.ValueMember = "PET_ID";
            edPET_ID.Properties.ValueMember = "PET_NOME";

        }
    }
}