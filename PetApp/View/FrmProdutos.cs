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
    public partial class FrmProdutos : DevExpress.XtraEditors.XtraForm
    {
        private Produtos objProdutos;
        public FrmProdutos()
        {
            InitializeComponent();
            objProdutos = new Produtos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (F.toString(edPRO_REFERENCIA.EditValue) == "")
            {
                F.Aviso("Insira uma Referência");
                edPRO_REFERENCIA.Focus();
                return;
            }
            if (F.toString(edPRO_DESCRICAO.EditValue) == "")
            {
                F.Aviso("Insira uma Descrição");
                edPRO_REFERENCIA.Focus();
                return;
            }
            if (F.toString(edTPR_ID.EditValue) == "")
            {
                F.Aviso("Insira um Tipo");
                edPRO_REFERENCIA.Focus();
                return;
            }
            if (F.toString(edPRO_CUSTO.EditValue) == "")
            {
                F.Aviso("Insira um Tipo");
                edPRO_REFERENCIA.Focus();
                return;
            }

            objProdutos.PRO_REFERENCIA = F.toString(edPRO_REFERENCIA.EditValue);
            objProdutos.PRO_DESCRICAO = F.toString(edPRO_DESCRICAO.EditValue);
            objProdutos.PRO_TIPO = F.toString(edTPR_ID.EditValue);
            objProdutos.PRO_CUSTO = F.toDouble(edPRO_CUSTO.EditValue);
            objProdutos.PRO_CUSTOULTCOMPRA = F.toDouble(edPRO_CUSTOULTCOMPRA.EditValue);
            objProdutos.PRO_FORNECEDOR = F.toInt(edPRO_FORNECEDOR.EditValue);
            objProdutos.PRO_IMAGEM = F.toString(pic_IMAGEM.EditValue);

            if (objProdutos.PRO_ID == 0)
            {
                Produtos.Insert(objProdutos);
            }
            else
            {
                Produtos.Update(objProdutos);
            }
            F.Aviso("Produto cadastrado com sucesso!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            objProdutos = new Produtos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void edPRO_IMAGEM_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string pathImg = "";
            if (openFileDialogImg.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            pathImg = openFileDialogImg.FileName;
            string fileName = F.copyToImagePath(pathImg);

            if (fileName == "")
            {
                F.Aviso("Erro ao Salvar Imagem");
                return;
            }

            try
            {
                pic_IMAGEM.Image = Image.FromFile(fileName);
                pic_IMAGEM.Tag = fileName;
                edPRO_IMAGEM.EditValue = fileName;
            }
            catch (Exception ex)
            {
                F.WriteLOG("----------------------\nLOG WSCorreios - " + DateTime.Now.ToString() + " - Erro: " + ex.Message);
            }
        }

        private void pic_IMAGEM_DoubleClick(object sender, EventArgs e)
        {
            edPRO_IMAGEM_ButtonClick(null, null);
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            edTPR_ID.Properties.DataSource = TipoProduto.Get();
            edTPR_ID.Properties.ValueMember = "TPR_ID";
            edTPR_ID.Properties.DisplayMember = "TPR_DESCRICAO";
        }
    }
}