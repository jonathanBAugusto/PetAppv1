﻿using System;
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
    public partial class SH_ESTOQUE : DevExpress.XtraEditors.XtraForm
    {
        public SH_ESTOQUE()
        {
            InitializeComponent();
        }
        private void edPRO_REFERENCIA_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string refer = F.SearchProds();
            edPRO_REFERENCIA.EditValue = refer;
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
                    filter.Append(" AND LANCPRODS.LCP_QUANTIDADE > 0 ");
                    break;
                case "AB":
                    filter.Append(" AND LANCPRODS.LCP_QUANTIDADE < 0 ");
                    break;
            }
            if (ckIgualZero.Checked)
            {
                filter.Append(" AND LANCPRODS.LCP_QUANTIDADE = 0 ");
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

            List<EstoquePesquisa> objPesq = new List<EstoquePesquisa>();
            objPesq.AddRange(EstoquePesquisa.GetBySQL(sql.ToString()));
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FrmEstoque objFrmEstoque = new FrmEstoque();
            objFrmEstoque.ShowDialog();
            btnPesquisar_Click(null, null);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }
    }
}