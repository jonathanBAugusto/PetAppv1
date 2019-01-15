using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using PetApp.Model;

namespace PetApp.View.Relatorios
{
    public partial class REL_SERVICOS : DevExpress.XtraEditors.XtraForm
    {
        public REL_SERVICOS()
        {
            InitializeComponent();

        }

        private void REL_SERVICOS_Load(object sender, EventArgs e)
        {
            gridControlServicos.DataSource = Servicos.Get();
        }
    }
}
