using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetApp.Model;

namespace PetApp
{
    public partial class FrmPets : DevExpress.XtraEditors.XtraForm
    {
        List<Pets> listPets = new List<Pets>();
        public FrmPets()
        {
            InitializeComponent();            
        }

        private void FrmPets_Load(object sender, EventArgs e)
        {
            listPets = Pets.Get();
            gridControlPets.DataSource = listPets;
            edCLI_ID.Properties.DataSource = Clientes.Get();
            edCLI_ID.Properties.ValueMember = "CLI_ID";
            edCLI_ID.Properties.DisplayMember = "CLI_NOME";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Pets pet = new Pets { PET_NOME = F.toString(edPET_NOME.EditValue), PET_RACA = F.toString(edPET_RACA.EditValue), PET_OBS = F.toString(edPET_OBS.Text), PET_NAS = F.toString(edPET_NAS.EditValue), PET_COR = F.toString(edPET_COR.EditValue), CLI_ID = F.toInt(edCLI_ID.EditValue), PET_IMG = F.toString(PET_IMG.Image) };
            Pets.Insert(pet);
            listPets = Pets.Get();
        }
    }
}
