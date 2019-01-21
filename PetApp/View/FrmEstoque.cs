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
    public partial class FrmEstoque : DevExpress.XtraEditors.XtraForm
    {
        List<Lancprods> listLancprods;
        public FrmEstoque()
        {
            InitializeComponent();
            listLancprods = new List<Lancprods>();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (F.toString(edPRO_REFEREMCIA.EditValue) == "")
            {
                F.Aviso("Selecione um Produto para lançar uma movimentação");
            }
            Lancprods obj = new Lancprods();
        }
    }
}