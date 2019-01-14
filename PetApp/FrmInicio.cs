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
using PetApp.View.Servicos;
using PetApp.View;

namespace PetApp
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            FrmCli frmcli = new FrmCli();
            frmcli.ShowDialog();
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            FrmServicos form = new FrmServicos();
            form.Show();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            FrmPets form = new FrmPets();
            form.Show();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            FrmCadCli form = new FrmCadCli();
            form.Show();
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            FrmPets form = new FrmPets();
            form.Show();
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            frmTipoServico form = new frmTipoServico();
            form.Show();
        }

        private void accordionControlElement1_Click_1(object sender, EventArgs e)
        {
            FrmProdutos form = new FrmProdutos();
            form.Show();
        }
    }
}
