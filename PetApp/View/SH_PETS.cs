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
            edCLI_ID.Properties.DisplayMember= "CLI_RAZAO";

            edPET_ID.Properties.DataSource = Pets.Get();
            edPET_ID.Properties.ValueMember = "PET_ID";
            edPET_ID.Properties.ValueMember = "PET_NOME";

            edPET_RACA.Properties.DataSource = Racas.Get();
            edPET_RACA.Properties.ValueMember = "PET_RACA_ID";
            edPET_RACA.Properties.DisplayMember = "PET_RACA_NOME";

            repositoryItemGridLookUpEditRaca.DataSource = Racas.Get();
            repositoryItemGridLookUpEditRaca.ValueMember = "PET_RACA_ID";
            repositoryItemGridLookUpEditRaca.DisplayMember = "PET_RACA_NOME";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FrmPets form = new FrmPets("A");
            form.PETID = F.toInt(layoutView1.GetFocusedRowCellValue("PET_ID"));
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                SH_PETS_Load(null,null);
            }
        }

        private void btnPesq_Click(object sender, EventArgs e)
        {
            StringBuilder filtro = new StringBuilder();
            if (F.toInt(edCLI_ID.EditValue) != 0)
            {
                filtro.Append(" AND CLI_ID = '" + F.toInt(edCLI_ID.EditValue) + "' ");
            }
            if (F.toString(edPET_COR.EditValue) != "")
            {
                filtro.Append(" AND PET_COR = '" + F.toString(edPET_COR.EditValue) + "' ");
            }
            if (F.toString(edPET_NAS.EditValue) != "")
            {
                filtro.Append(" AND PET_NAS = '" + F.toString(edPET_NAS.EditValue) + "' ");
            }
            if (F.toString(edPET_RACA.EditValue) != "")
            {
                filtro.Append(" AND PET_RACA = '" + F.toInt(edPET_RACA.EditValue) + "' ");
            }
            if (F.toString(edPET_ID.EditValue) != "")
            {
                filtro.Append(" AND PET_ID = '" + F.toInt(edPET_ID.EditValue) + "' ");
            }
            List<Pets> listPet = new List<Pets>();
            listPet = Pets.Get(filtro.ToString());
            gridControlPets.DataSource = listPet;
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPets form = new FrmPets("A");
            form.PETID = F.toInt(layoutView1.GetFocusedRowCellValue("PET_ID"));
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                SH_PETS_Load(null, null);
            }
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FrmPets form = new FrmPets();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                SH_PETS_Load(null,null);
            }
        }
    }
}