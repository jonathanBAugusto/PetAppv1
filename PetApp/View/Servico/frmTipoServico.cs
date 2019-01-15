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

namespace PetApp.View.Servico
{
    public partial class frmTipoServico : DevExpress.XtraEditors.XtraForm
    {
        public frmTipoServico()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TipoServico tipo = new TipoServico
            {
                TIPO_SER_NOME = F.toString(edTIPO_SER_NOME.EditValue),
                TIPO_SER_VALOR = F.toDouble(edTIPO_SER_VALOR.EditValue)
            };
            TipoServico.Insert(tipo);
        }

        private void frmTipoServico_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = TipoServico.Get();
        }
    }
}
