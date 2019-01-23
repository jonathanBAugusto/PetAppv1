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

namespace PetApp.View
{
    public partial class SH_ESTOQUE : DevExpress.XtraEditors.XtraForm
    {
        public SH_ESTOQUE()
        {
            InitializeComponent();
        }
        private void edPRO_REFERENCIA_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();
            StringBuilder filter = new StringBuilder();
            if (F.toString(edDataIni.EditValue) != "")
            {
                filter.Append(" AND LANCPRODS.LCP_DATA >= '" + F.toString(edDataIni.EditValue) + "' ");
            }
            if (F.toString(edDataFim.EditValue) != "")
            {
                filter.Append(" AND LANCPRODS.LCP_DATA >= '" + F.toString(edDataIni.EditValue) + "' ");
            }
            if (F.toString(edPRO_REFERENCIA.EditValue) != "")
            {
                filter.Append(" AND PRODUTOS.PRO_REFERENCIA = '" + F.toString(edPRO_REFERENCIA.EditValue) + "' ");
            }
            switch (F.toString(rgAbxAcm.EditValue))
            {
                case "AC":
                    break;
                case "AB":
                    break;

                default:
                    break;
            }
            if (F.toString(rgAbxAcm) != "" && F.toString(rgAbxAcm) != "AM")
            {
                
                filter.Append(" AND LANCPRODS.LCP_QUANTIDADE = '" + F.toString(edPRO_REFERENCIA.EditValue) + "' ");
            }


            sql.Append("	select 	");
            sql.Append("		LANCPRODS.LCP_ID,	");
            sql.Append("		LANCPRODS.PRO_ID,	");
            sql.Append("		PRODUTOS.PRO_REFERENCIA,	");
            sql.Append("		PRODUTOS.PRO_DESCRICAO,	");
            sql.Append("		PRODUTOS.PRO_CUSTO,	");
            sql.Append("		PRODUTOS.PRO_CUSTOULTCOMPRA,	");
            sql.Append("		LANCPRODS.LCP_DATA,	");
            sql.Append("		LANCPRODS.LCP_TIPO,	");
            sql.Append("		SUM(LANCPRODS.LCP_QUANTIDADE) LCP_QUANTIDADE	");
            sql.Append("	from	");
            sql.Append("		LANCPRODS	");
            sql.Append("			join PRODUTOS on (PRODUTOS.PRO_ID = LANCPRODS.PRO_ID)	");
            sql.Append("    where");
            sql.Append("        LANCPRODS.LCP_ID >= 0");
            sql.Append(filter.ToString());
            sql.Append("	group by	");
            sql.Append("		LANCPRODS.LCP_ID,	");
            sql.Append("		LANCPRODS.PRO_ID,	");
            sql.Append("		PRODUTOS.PRO_REFERENCIA,	");
            sql.Append("		PRODUTOS.PRO_DESCRICAO,	");
            sql.Append("		PRODUTOS.PRO_CUSTO,	");
            sql.Append("		PRODUTOS.PRO_CUSTOULTCOMPRA,	");
            sql.Append("		LANCPRODS.LCP_DATA,	");
            sql.Append("		LANCPRODS.LCP_TIPO	");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }
    }
}