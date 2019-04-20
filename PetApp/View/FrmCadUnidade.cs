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
    public partial class FrmCadUnidade : DevExpress.XtraEditors.XtraForm
    {
        List<Unidade> listUnidade;
        public FrmCadUnidade()
        {
            InitializeComponent();
            listUnidade = new List<Unidade>();
            Reload();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (F.toString(edUNI_DESCRICAO.EditValue) == "")
            {
                F.Aviso("Preencha o campo Descrição!");
                edUNI_DESCRICAO.Focus();
                return;
            }
            if (Unidade.Insert(new Unidade() { UNI_DESCRICAO = F.toString(edUNI_DESCRICAO.EditValue) }))            {
                edUNI_DESCRICAO.EditValue = "";
                edUNI_DESCRICAO.Focus();
            }
            Reload();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            Unidade obj = (Unidade)gridViewUnidade.GetFocusedRow();
            if (obj == null)
            {
                return;
            }
            if (F.YesNo("Alterar", "Deseja mesmo Alterar este Registro?"))
            {
                Unidade.Update(new Unidade() { UNI_ID = obj.UNI_ID, UNI_DESCRICAO = F.toString(edUNI_DESCRICAO.EditValue) });
                edUNI_DESCRICAO.EditValue = "";
                edUNI_DESCRICAO.Focus();
            }
            Reload();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Unidade obj = (Unidade)gridViewUnidade.GetFocusedRow();
            if (obj == null)
            {
                return;
            }
            if (F.YesNo("Apagar", "Deseja mesmo apagar este Registro?"))
            {
                Unidade.Delete(obj);
            }
            Reload();
        }

        private void Reload()
        {
            listUnidade = Unidade.Get();
            gridControlUnidade.DataSource = listUnidade;
            gridViewUnidade.RefreshData();
        }

        private void gridViewUnidade_Click(object sender, EventArgs e)
        {
            Unidade row = (Unidade)gridViewUnidade.GetFocusedRow();
            if (row != null)
            {
                edUNI_DESCRICAO.EditValue = row.UNI_DESCRICAO;
            }
        }

        private void gridViewUnidade_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridViewUnidade_Click(null, null);
        }

        private void gridViewUnidade_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gridViewUnidade_Click(null, null);
        }
    }
}