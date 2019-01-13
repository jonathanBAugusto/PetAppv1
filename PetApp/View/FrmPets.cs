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
    public partial class FrmPets : Form
    {
        int id = 0;
        public FrmPets()
        {
            InitializeComponent();

            
        }

        private void FrmPets_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<Pets> listPets = new List<Pets>();

            listPets.Add(new Pets() { PET_ID = id, PET_NOME = F.toString(edPET_NOME.EditValue), PET_RACA = F.toString(edPET_RACA.EditValue), PET_OBS = F.toString(edPET_OBS.Text), PET_NAS = edPET_NAS.Value, PET_COR = F.toString(edPET_COR.EditValue), CLI_NOME = F.toString(edCLI_ID.EditValue),PET_IMG = F.toString(PET_IMG.Image)});
            id++;
            gridControlPets.DataSource = listPets;
        }
    }
}
