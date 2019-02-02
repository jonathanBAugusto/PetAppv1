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
        int idAlt = 0;
        public FrmCad_PET_RACA()
        {
            InitializeComponent();

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (idAlt != 0)
            {
                Racas racaNew = new Racas();
                racaNew.PET_RACA_ID = idAlt;
                racaNew.PET_RACA_NOME = F.toString(edPET_RACA_NOME.EditValue);
                if (Racas.Update(racaNew))
                {
                    F.Aviso("Raça alterada com sucesso");
                    btnAdicionar.Text = "Adicionar";
                    edPET_RACA_NOME.EditValue = "";
                    FrmCad_PET_RACA_Load(null, null);
                    return;
                }
                else
                {
                    F.Aviso("Erro ao salvar Raça");
                    return;
                }
            }
            else
            {


                Racas raca = new Racas
                {
                    PET_RACA_NOME = F.toString(edPET_RACA_NOME.EditValue),

                };
                Racas.Insert(raca);

                FrmCad_PET_RACA_Load(null, null);
                List<Racas> a = new List<Racas>();


            }
        }

        private void FrmCad_PET_RACA_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = Racas.Get();
        }

        private void FrmCad_PET_RACA_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int PET_RACA_ID = F.toInt(gridView1.GetFocusedRowCellValue("PET_RACA_ID"));
            if (F.YesNo("Deletar","Deseja realmente remover esta Raça?", 1))
            {
                if(Racas.Delete(Racas.Get(PET_RACA_ID)))
                {
                    F.Aviso("Raça removida com sucesso.");
                    FrmCad_PET_RACA_Load(null,null);
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int PET_RACA_ID = F.toInt(gridView1.GetFocusedRowCellValue("PET_RACA_ID"));
            Racas raca = Racas.Get(PET_RACA_ID);
            edPET_RACA_NOME.EditValue = F.toString(raca.PET_RACA_NOME);
            idAlt = F.toInt(raca.PET_RACA_ID);
            btnAdicionar.Text = "Salvar";
        }
    }
}