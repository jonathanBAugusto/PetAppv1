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

namespace PetApp.View.UTL
{
    public partial class FrmSelectPet : DevExpress.XtraEditors.XtraForm
    {
        private string result;

        public string Result
        {
            get { return result; }
            set { result = value; }
        }

        List<Pets> listPets;
        public FrmSelectPet()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            StringBuilder filtro = new StringBuilder();

            if (F.toString(edPET_NOME.EditValue) != "")
            {
                filtro.Append(" AND PET_NOME %" + "");
            }


            listPets = new List<Pets>();
            StringBuilder sql = new StringBuilder();
            sql.Append("	select	");
            sql.Append("		PET.PET_ID,	");
            sql.Append("		PET.PET_NOME,	");
            sql.Append("		PET.PET_RACA,	");
            sql.Append("		PET.PET_COR,	");
            sql.Append("		PET.PET_IMG,	");
            sql.Append("		PET.PET_NAS,	");
            sql.Append("		PET.PET_OBS,	");
            sql.Append("		PET.CLI_ID,	");
            sql.Append("		CLIENTE.CLI_NOME	");
            sql.Append("	from		");
            sql.Append("		PET	");
            sql.Append("			join CLIENTE on (CLIENTE.CLI_ID = PET.CLI_ID)	");
            
            listPets.AddRange(F.conn().Query<Pets>(sql.ToString()));

            gridControlPets.DataSource = listPets;
        }

        private void edCLI_ID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmSelectCli obj = new FrmSelectCli();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                edCLI_ID.EditValue = obj.Result;
            }
            
        }

        private void gridViewPets_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridViewPets_FocusedRowChanged(null, null);
        }

        private void gridViewPets_Click(object sender, EventArgs e)
        {
            gridViewPets_FocusedRowChanged(null, null);
        }

        private void gridViewPets_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Pets obj = new Pets();
            obj = gridViewPets.GetFocusedRow() as Pets;
            if (obj != null)
            {
                pcImg.Image = obj.PET_IMAGEM;
            }
        }

        private void edCLI_ID_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}