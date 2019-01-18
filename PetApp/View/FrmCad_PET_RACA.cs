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
    public partial class FrmCad_PET_RACA : DevExpress.XtraEditors.XtraForm
    {
        public int ids = 0;
        public FrmCad_PET_RACA()
        {
            InitializeComponent();

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Racas raca = new Racas
            {
                PET_RACA_NOME = F.toString(edPET_RACA_NOME.EditValue),
                
            };
            Racas.Insert(raca);

            FrmCad_PET_RACA_Load(null, null);
            List<Racas> a = new List<Racas>();


            
        }

        private void FrmCad_PET_RACA_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = Racas.Get();
        }

        private void FrmCad_PET_RACA_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }
    }
}