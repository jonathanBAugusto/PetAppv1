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
    public partial class SH_PRODUTOS : DevExpress.XtraEditors.XtraForm
    {
        public SH_PRODUTOS()
        {
            InitializeComponent();
  
        }

        private void SH_PRODUTOS_Load(object sender, EventArgs e)
        {
            gridControlProdutos.DataSource = Produtos.Get();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            FrmCadCli form = new FrmCadCli();
            form.ShowDialog();
        }
    }
}