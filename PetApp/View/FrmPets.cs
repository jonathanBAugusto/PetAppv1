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
using PetApp.View;

namespace PetApp
{
    public partial class FrmPets : DevExpress.XtraEditors.XtraForm
    {
        /*
         * C - Cadastro Normal 
         * M - Cadastro na Memória
         * A - Alterar
         */
        private Pets newPet;

        public Pets NewPet
        {
            get { return newPet; }
            set { newPet = value; }
        }
        Pets pet;
        private int donoTemp;

        public int DonoTemp
        {
            get { return donoTemp; }
            set { donoTemp = value; }
        }

        private int PetId;

        public int PETID
        {
            get { return PetId; }
            set { PetId = value; }
        }


        private string TIPO;
        public FrmPets(string tipo = "C")
        {
            InitializeComponent();
            this.TIPO = tipo;
            switch (this.TIPO)
            {
                case "C":
                    btnAdd.Text = "Cadastrar";
                    break;
                case "M":
                    btnAdd.Text = "Adicionar";
                    break;
                case "A":
                    btnAdd.Text = "Alterar";
                    break;
                default:
                    btnAdd.Text = "Cadastrar";
                    break;
            }
        }

        private void FrmPets_Load(object sender, EventArgs e)
        {

            edPET_RACA.Properties.DataSource = Racas.Get();
            edPET_RACA.Properties.ValueMember = "PET_RACA_ID";
            edPET_RACA.Properties.DisplayMember = "PET_RACA_NOME";

            edCLI_ID.Properties.DataSource = Clientes.Get();
            edCLI_ID.Properties.ValueMember = "CLI_ID";
            edCLI_ID.Properties.DisplayMember = "CLI_RAZAO";
            if (DonoTemp > 0)
            {
                edCLI_ID.EditValue = DonoTemp;
                edCLI_ID.ReadOnly = true;
            }
            if (TIPO == "A" || PETID != 0)
            {
                pet = Pets.Get(F.toInt(PETID));
                edCLI_ID.EditValue = F.toInt(pet.CLI_ID);
                edPET_COR.EditValue = F.toString(pet.PET_COR);
                edPET_NAS.EditValue = Convert.ToDateTime(pet.PET_NAS);
                edPET_NOME.EditValue = F.toString(F.toString(pet.PET_NOME));
                edPET_OBS.EditValue = F.toString(pet.PET_OBS);
                edPET_RACA.EditValue = F.toInt(pet.PET_RACA);
                edPET_IMAGEM.EditValue = F.toString(pet.PET_IMG);
                picPET_IMG.Image = pet.PET_IMAGEM;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (F.toString(edPET_NOME.EditValue) == "")
            {
                F.Aviso("Informe o NOME do Pet");
                edPET_NOME.Focus();
                return;
            }
            if (F.toString(edPET_COR.EditValue) == "")
            {
                F.Aviso("Informe a COR do Pet");
                edPET_COR.Focus();
                return;
            }
            if (F.toString(edCLI_ID.EditValue) == "")
            {
                F.Aviso("Informe o DONO do Pet");
                edCLI_ID.Focus();
                return;
            }
            if (F.toString(edPET_NAS.EditValue) == "")
            {
                F.Aviso("Informe o NASCIMENTO do Pet");
                edPET_NAS.Focus();
                return;
            }
            if (F.toString(edPET_RACA.EditValue) == "")
            {
                F.Aviso("Informe a RAÇA do Pet");
                edPET_RACA.Focus();
                return;
            }
            pet = new Pets {
                PET_NOME = F.toString(edPET_NOME.EditValue),
                PET_RACA = F.toString(edPET_RACA.EditValue),
                PET_OBS = F.toString(edPET_OBS.Text),
                PET_NAS = F.toString(edPET_NAS.EditValue),
                PET_COR = F.toString(edPET_COR.EditValue),
                CLI_ID = F.toInt(edCLI_ID.EditValue),
                PET_IMG = F.toString(edPET_IMAGEM.EditValue) };
            bool result = false;
            string msg = "";
            switch (TIPO)
            {
                case "C":
                    if (Pets.Insert(pet))
                    {
                        NewPet = pet;
                        result = true;
                        msg = "Pet Cadastrado com Sucesso!";
                    }
                    break;
                case "A":
                        pet.PET_ID = PETID;
                    if (Pets.Update(pet))
                    {
                        NewPet = pet;
                        result = true;
                        msg = "Pet Alterado com Sucesso!";
                    }
                    break;
                case "M":
                        NewPet = pet;
                        result = true;
                    break;
            }
            if (msg != "")
            {
                F.Aviso(result ? msg : "Erro ao completar ação!");
            }
            if (result)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void PET_IMG_DoubleClick(object sender, EventArgs e)
        {
            edPET_IMAGEM_ButtonClick(null, null);
        }

        private void edPET_IMAGEM_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string pathImg = "";
            if (openFileDialogImg.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            pathImg = openFileDialogImg.FileName;
            string fileName = F.copyToImagePath(pathImg);

            if (fileName == "")
            {
                F.Aviso("Erro ao Salvar Imagem");
                return;
            }

            try
            {
                picPET_IMG.Image = Image.FromFile(fileName);
                picPET_IMG.Tag = fileName;
                edPET_IMAGEM.EditValue = System.IO.Path.GetFileName(fileName);
            }
            catch (Exception ex)
            {
                F.WriteLOG("----------------------\nLOG Imagem Pet - " + DateTime.Now.ToString() + " - Erro: " + ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FrmCad_PET_RACA form = new FrmCad_PET_RACA();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                FrmPets_Load(null, null);
                edPET_RACA.EditValue = F.toInt(form.ids);
            }
        }
    }
}
