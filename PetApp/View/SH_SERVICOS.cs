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
    public partial class SH_SERVICOS : DevExpress.XtraEditors.XtraForm
    {
        public SH_SERVICOS()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SH_SERVICOS_Load(object sender, EventArgs e)
        {
            gridControlServicos.DataSource = Servicos.Get();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetFocusedDataRow();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FrmServicos form = new FrmServicos();
            form.Show();
        }
    }
}