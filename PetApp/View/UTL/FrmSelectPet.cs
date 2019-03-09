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

        private bool getInLoad = false;

        public bool GetInLoad
        {
            get { return getInLoad = false; }
            set { getInLoad = value; }
        }


        List<Pets> listPets;
        public FrmSelectPet()
        {
            InitializeComponent();
        }

        private void FrmSelectPet_Load(object sender, EventArgs e)
        {
            if (GetInLoad)
            {
                btnPesquisar_Click(null, null);
                gridViewPets.Focus();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            StringBuilder filtro = new StringBuilder();

            if (F.toString(edDATAINI.EditValue) != "")
            {
                filtro.Append(" AND PET." + F.toString(rgPeriodo.EditValue) + " >= '" + F.toString(edDATAINI.DateTime) + "'");
            }
            if (F.toString(edDATAFIN.EditValue) != "")
            {
                filtro.Append(" AND PET." + F.toString(rgPeriodo.EditValue) + " <= '" + F.toString(edDATAFIN.EditValue) + "'");
            }

            if (F.toString(edPET_NOME.EditValue) != "")
            {
                filtro.Append(" AND PET.PET_NOME LIKE '%" + F.toString(edPET_NOME.EditValue) + "%'");
            }
            if (F.toString(edPET_COR.EditValue) != "")
            {
                filtro.Append(" AND PET.PET_COR LIKE '%" + F.toString(edPET_COR.EditValue) + "%'");
            }
            if (F.toString(edCLI_ID.EditValue) != "")
            {
                filtro.Append(" AND PET.CLI_ID = '" + F.toString(edCLI_ID.EditValue) + "'");
            }
            if (F.toString(edPET_RACA.EditValue) != "")
            {
                filtro.Append(" AND PET.PET_RACA = '" + F.toString(edPET_RACA.EditValue) + "'");
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
            sql.Append("	where");
            sql.Append("		PET.PET_ID > -1	");
            sql.Append(filtro.ToString());
            
            listPets.AddRange(F.conn().Query<Pets>(sql.ToString()));

            gridControlPets.DataSource = listPets;
        }

        private void edCLI_ID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            edCLI_ID.EditValue = F.SearchCli();
        }

        private void edCLI_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                edCLI_ID_ButtonClick(null, null);
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            Pets obj = new Pets();
            obj = gridViewPets.GetFocusedRow() as Pets;
            if (obj != null)
            {
                Result = obj.PET_ID.ToString() ?? "";
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void gridViewPets_DoubleClick(object sender, EventArgs e)
        {
            btnOK_Click(null, null);
        }

        private void gridViewPets_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                btnOK_Click(null, null);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}