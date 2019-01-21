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

namespace PetApp.View
{
    public partial class FrmYN : DevExpress.XtraEditors.XtraForm
    {
        //1 - Sim
        //2 - Não
        public FrmYN(string Titulo, string Conteudo, int Foco = 2)
        {
            InitializeComponent();
            this.Text = Titulo;
            edConteudo.EditValue = Conteudo;
            switch (Foco)
            {
                case 1:
                    btnSim.Focus();
                    break;
                case 2:
                    btnNao.Focus();
                    break;
                default:
                    btnNao.Focus();
                    break;
            }
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}