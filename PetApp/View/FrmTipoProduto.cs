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
    public partial class FrmTipoProduto : DevExpress.XtraEditors.XtraForm
    {
        public FrmTipoProduto()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            TipoProduto tipo = new TipoProduto {
                TPR_DESCRICAO = F.toString(edTPR_DESCRICAO.EditValue)
        };
            TipoProduto.Insert(tipo);
            FrmTipoProduto_Load(null, null);

        }

        private void FrmTipoProduto_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = TipoProduto.Get();
        }
    }
}