namespace PetApp.View
{
    partial class SH_PRODUTOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControlProdutos = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditTPR = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEditProd = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gpDesc = new DevExpress.XtraEditors.GroupControl();
            this.edPRO_DESCRICAO = new DevExpress.XtraEditors.TextEdit();
            this.gpRef = new DevExpress.XtraEditors.GroupControl();
            this.edPRO_REFERENCIA = new DevExpress.XtraEditors.TextEdit();
            this.gpFor = new DevExpress.XtraEditors.GroupControl();
            this.edPRO_FORNECEDOR = new DevExpress.XtraEditors.TextEdit();
            this.gpCus = new DevExpress.XtraEditors.GroupControl();
            this.edPRO_CUSTO = new DevExpress.XtraEditors.TextEdit();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.edPRO_CUSTOULTCOMPRA = new DevExpress.XtraEditors.TextEdit();
            this.btnPesq = new DevExpress.XtraEditors.SimpleButton();
            this.btnAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemover = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditTPR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEditProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpDesc)).BeginInit();
            this.gpDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_DESCRICAO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpRef)).BeginInit();
            this.gpRef.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_REFERENCIA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpFor)).BeginInit();
            this.gpFor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_FORNECEDOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpCus)).BeginInit();
            this.gpCus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_CUSTO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_CUSTOULTCOMPRA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlProdutos
            // 
            this.gridControlProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProdutos.Location = new System.Drawing.Point(2, 20);
            this.gridControlProdutos.MainView = this.gridView1;
            this.gridControlProdutos.Name = "gridControlProdutos";
            this.gridControlProdutos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEditProd,
            this.repositoryItemGridLookUpEditTPR});
            this.gridControlProdutos.Size = new System.Drawing.Size(702, 155);
            this.gridControlProdutos.TabIndex = 0;
            this.gridControlProdutos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridView1.GridControl = this.gridControlProdutos;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "PRO_ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Descrição";
            this.gridColumn2.FieldName = "PRO_DESCRICAO";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Referencia";
            this.gridColumn3.FieldName = "PRO_REFERENCIA";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Custo";
            this.gridColumn4.FieldName = "PRO_CUSTO";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Fornecedor";
            this.gridColumn5.FieldName = "PRO_FORNECEDOR";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tipo";
            this.gridColumn6.ColumnEdit = this.repositoryItemGridLookUpEditTPR;
            this.gridColumn6.FieldName = "PRO_TIPO";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // repositoryItemGridLookUpEditTPR
            // 
            this.repositoryItemGridLookUpEditTPR.AutoHeight = false;
            this.repositoryItemGridLookUpEditTPR.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditTPR.Name = "repositoryItemGridLookUpEditTPR";
            this.repositoryItemGridLookUpEditTPR.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Custo Ultima compra";
            this.gridColumn7.FieldName = "PRO_CUSTOULTCOMPRA";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Imagem";
            this.gridColumn8.ColumnEdit = this.repositoryItemPictureEditProd;
            this.gridColumn8.FieldName = "PRO_CUSTOULTCOMPRA";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // repositoryItemPictureEditProd
            // 
            this.repositoryItemPictureEditProd.Name = "repositoryItemPictureEditProd";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlProdutos);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 124);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(706, 177);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Lista";
            // 
            // gpDesc
            // 
            this.gpDesc.Controls.Add(this.edPRO_DESCRICAO);
            this.gpDesc.Location = new System.Drawing.Point(5, 23);
            this.gpDesc.Name = "gpDesc";
            this.gpDesc.Padding = new System.Windows.Forms.Padding(2);
            this.gpDesc.Size = new System.Drawing.Size(174, 47);
            this.gpDesc.TabIndex = 2;
            this.gpDesc.Text = "Descrição";
            // 
            // edPRO_DESCRICAO
            // 
            this.edPRO_DESCRICAO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edPRO_DESCRICAO.Location = new System.Drawing.Point(4, 22);
            this.edPRO_DESCRICAO.Name = "edPRO_DESCRICAO";
            this.edPRO_DESCRICAO.Size = new System.Drawing.Size(166, 20);
            this.edPRO_DESCRICAO.TabIndex = 0;
            // 
            // gpRef
            // 
            this.gpRef.Controls.Add(this.edPRO_REFERENCIA);
            this.gpRef.Location = new System.Drawing.Point(185, 23);
            this.gpRef.Name = "gpRef";
            this.gpRef.Padding = new System.Windows.Forms.Padding(2);
            this.gpRef.Size = new System.Drawing.Size(110, 47);
            this.gpRef.TabIndex = 3;
            this.gpRef.Text = "Referência";
            // 
            // edPRO_REFERENCIA
            // 
            this.edPRO_REFERENCIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edPRO_REFERENCIA.Location = new System.Drawing.Point(4, 22);
            this.edPRO_REFERENCIA.Name = "edPRO_REFERENCIA";
            this.edPRO_REFERENCIA.Size = new System.Drawing.Size(102, 20);
            this.edPRO_REFERENCIA.TabIndex = 0;
            // 
            // gpFor
            // 
            this.gpFor.Controls.Add(this.edPRO_FORNECEDOR);
            this.gpFor.Location = new System.Drawing.Point(301, 23);
            this.gpFor.Name = "gpFor";
            this.gpFor.Padding = new System.Windows.Forms.Padding(2);
            this.gpFor.Size = new System.Drawing.Size(147, 47);
            this.gpFor.TabIndex = 3;
            this.gpFor.Text = "Fornecedor";
            // 
            // edPRO_FORNECEDOR
            // 
            this.edPRO_FORNECEDOR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edPRO_FORNECEDOR.Location = new System.Drawing.Point(4, 22);
            this.edPRO_FORNECEDOR.Name = "edPRO_FORNECEDOR";
            this.edPRO_FORNECEDOR.Size = new System.Drawing.Size(139, 20);
            this.edPRO_FORNECEDOR.TabIndex = 0;
            // 
            // gpCus
            // 
            this.gpCus.Controls.Add(this.edPRO_CUSTO);
            this.gpCus.Location = new System.Drawing.Point(454, 23);
            this.gpCus.Name = "gpCus";
            this.gpCus.Padding = new System.Windows.Forms.Padding(2);
            this.gpCus.Size = new System.Drawing.Size(110, 47);
            this.gpCus.TabIndex = 3;
            this.gpCus.Text = "Custo";
            // 
            // edPRO_CUSTO
            // 
            this.edPRO_CUSTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edPRO_CUSTO.Location = new System.Drawing.Point(4, 22);
            this.edPRO_CUSTO.Name = "edPRO_CUSTO";
            this.edPRO_CUSTO.Size = new System.Drawing.Size(102, 20);
            this.edPRO_CUSTO.TabIndex = 0;
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.edPRO_CUSTOULTCOMPRA);
            this.groupControl6.Location = new System.Drawing.Point(570, 23);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Padding = new System.Windows.Forms.Padding(2);
            this.groupControl6.Size = new System.Drawing.Size(123, 47);
            this.groupControl6.TabIndex = 3;
            this.groupControl6.Text = "Custo Ultima compra";
            // 
            // edPRO_CUSTOULTCOMPRA
            // 
            this.edPRO_CUSTOULTCOMPRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edPRO_CUSTOULTCOMPRA.Location = new System.Drawing.Point(4, 22);
            this.edPRO_CUSTOULTCOMPRA.Name = "edPRO_CUSTOULTCOMPRA";
            this.edPRO_CUSTOULTCOMPRA.Size = new System.Drawing.Size(115, 20);
            this.edPRO_CUSTOULTCOMPRA.TabIndex = 0;
            // 
            // btnPesq
            // 
            this.btnPesq.Location = new System.Drawing.Point(570, 76);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(123, 42);
            this.btnPesq.TabIndex = 4;
            this.btnPesq.Text = "Pesquisar";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(301, 76);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(147, 42);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(185, 76);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(110, 42);
            this.simpleButton3.TabIndex = 6;
            this.simpleButton3.Text = "inserir";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(454, 76);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(110, 42);
            this.btnRemover.TabIndex = 7;
            this.btnRemover.Text = "Remover";
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gpDesc);
            this.groupControl2.Controls.Add(this.btnRemover);
            this.groupControl2.Controls.Add(this.gpRef);
            this.groupControl2.Controls.Add(this.simpleButton3);
            this.groupControl2.Controls.Add(this.gpFor);
            this.groupControl2.Controls.Add(this.btnAlterar);
            this.groupControl2.Controls.Add(this.gpCus);
            this.groupControl2.Controls.Add(this.btnPesq);
            this.groupControl2.Controls.Add(this.groupControl6);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(706, 124);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "Pesquisa";
            // 
            // SH_PRODUTOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 301);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "SH_PRODUTOS";
            this.Text = "Pesquisa de produtos";
            this.Load += new System.EventHandler(this.SH_PRODUTOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditTPR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEditProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gpDesc)).EndInit();
            this.gpDesc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_DESCRICAO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpRef)).EndInit();
            this.gpRef.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_REFERENCIA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpFor)).EndInit();
            this.gpFor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_FORNECEDOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpCus)).EndInit();
            this.gpCus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_CUSTO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_CUSTOULTCOMPRA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlProdutos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEditProd;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl gpDesc;
        private DevExpress.XtraEditors.TextEdit edPRO_DESCRICAO;
        private DevExpress.XtraEditors.GroupControl gpRef;
        private DevExpress.XtraEditors.TextEdit edPRO_REFERENCIA;
        private DevExpress.XtraEditors.GroupControl gpFor;
        private DevExpress.XtraEditors.TextEdit edPRO_FORNECEDOR;
        private DevExpress.XtraEditors.GroupControl gpCus;
        private DevExpress.XtraEditors.TextEdit edPRO_CUSTO;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.TextEdit edPRO_CUSTOULTCOMPRA;
        private DevExpress.XtraEditors.SimpleButton btnPesq;
        private DevExpress.XtraEditors.SimpleButton btnAlterar;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btnRemover;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditTPR;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
    }
}