using DevExpress.XtraTabbedMdi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetApp.View.Servico;
using PetApp.View;
using PetApp.View.Relatorios;
using PetApp.Model;

namespace PetApp
{
    public partial class FrmInicio : DevExpress.XtraEditors.XtraForm
    {
        public FrmInicio()
        {
            InitializeComponent();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(skinRibbonGalleryBarItem1, true, true);
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            SH_CLIENTES frmcli = new SH_CLIENTES();
            frmcli.ShowDialog();
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            FrmServicos form = new FrmServicos();
            form.ShowDialog();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            FrmPets form = new FrmPets();
            form.ShowDialog();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            List<Pets> pets = Pets.Get();
            foreach (Pets pet in pets)
            {
                if (Convert.ToDateTime(pet.PET_NAS).Day == DateTime.Now.Day && Convert.ToDateTime(pet.PET_NAS).Month == DateTime.Now.Month)
                {
                    alertControl1.Show(this, "Aniversário" ,"O PET " + F.toString(pet.PET_NOME) + " de " + F.toString( Clientes.Get(F.toInt(pet.CLI_ID)).CLI_RAZAO) + " Está fazendo aniversário");
                }
            }
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            FrmCadCli form = new FrmCadCli();
            form.ShowDialog();
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            FrmPets form = new FrmPets();
            form.ShowDialog();
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            frmTipoServico form = new frmTipoServico();
            form.ShowDialog();
        }

        private void accordionControlElement1_Click_1(object sender, EventArgs e)
        {
            FrmProdutos form = new FrmProdutos();
            form.ShowDialog();
        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            REL_SERVICOS form = new REL_SERVICOS();
            form.ShowDialog();
        }

        private void accordionControlElement2_Click_1(object sender, EventArgs e)
        {
            FrmServicos form = new FrmServicos();
            form.ShowDialog();
        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {
            SH_CLIENTES form = new SH_CLIENTES();
            form.ShowDialog();
        }

        private void accordionControlElement13_Click(object sender, EventArgs e)
        {
            SH_PETS form = new SH_PETS();
            form.ShowDialog();
        }

        private void accordionControlElement4_Click_1(object sender, EventArgs e)
        {
            SH_SERVICOS form = new SH_SERVICOS();
            form.ShowDialog();
        }

        private void accordionControlElement14_Click(object sender, EventArgs e)
        {
            SH_PRODUTOS form = new SH_PRODUTOS();
            form.ShowDialog();
        }

        private void accordionControlElement3_Click_1(object sender, EventArgs e)
        {

        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement15_Click(object sender, EventArgs e)
        {
            FrmCad_PET_RACA form = new FrmCad_PET_RACA();
            form.ShowDialog();
        }

        private void accordionControlElement16_Click(object sender, EventArgs e)
        {
            FrmTipoProduto form = new FrmTipoProduto();
            form.ShowDialog();
        }

        private void accordionControlElement17_Click(object sender, EventArgs e)
        {
            SH_FORNECEDORES form = new SH_FORNECEDORES();
            form.ShowDialog();
        }

        private void accordionControlElementEstoque_Click(object sender, EventArgs e)
        {
            SH_ESTOQUE obj = new SH_ESTOQUE();
            obj.ShowDialog();
        }

        private void accordionControlElementEstoqueCad_Click(object sender, EventArgs e)
        {
            FrmEstoque obj = new FrmEstoque();
            obj.ShowDialog();
        }

        private void accordionControlElementUnidade_Click(object sender, EventArgs e)
        {
            FrmCadUnidade obj = new FrmCadUnidade();
            obj.ShowDialog();
        }
    }
}
