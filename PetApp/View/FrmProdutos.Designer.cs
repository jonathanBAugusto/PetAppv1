namespace PetApp.View
{
    partial class FrmProdutos
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.edPRO_DESCRICAO = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.edPRO_CUSTO = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.edPRO_CUSTOULTCOMPRA = new DevExpress.XtraEditors.TextEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.edTPR_ID = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.edPRO_FORNECEDOR = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.pic_IMAGEM = new DevExpress.XtraEditors.PictureEdit();
            this.edPRO_IMAGEM = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.edPRO_REFERENCIA = new DevExpress.XtraEditors.TextEdit();
            this.btnExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.openFileDialogImg = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_DESCRICAO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_CUSTO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_CUSTOULTCOMPRA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edTPR_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_FORNECEDOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_IMAGEM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_IMAGEM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_REFERENCIA.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.edPRO_DESCRICAO);
            this.groupControl1.Location = new System.Drawing.Point(266, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(2);
            this.groupControl1.Size = new System.Drawing.Size(164, 46);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Descrição";
            // 
            // edPRO_DESCRICAO
            // 
            this.edPRO_DESCRICAO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edPRO_DESCRICAO.EnterMoveNextControl = true;
            this.edPRO_DESCRICAO.Location = new System.Drawing.Point(4, 22);
            this.edPRO_DESCRICAO.Name = "edPRO_DESCRICAO";
            this.edPRO_DESCRICAO.Size = new System.Drawing.Size(156, 20);
            this.edPRO_DESCRICAO.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.edPRO_CUSTO);
            this.groupControl2.Location = new System.Drawing.Point(301, 66);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Padding = new System.Windows.Forms.Padding(2);
            this.groupControl2.Size = new System.Drawing.Size(127, 46);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Custo";
            // 
            // edPRO_CUSTO
            // 
            this.edPRO_CUSTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edPRO_CUSTO.EnterMoveNextControl = true;
            this.edPRO_CUSTO.Location = new System.Drawing.Point(4, 22);
            this.edPRO_CUSTO.Name = "edPRO_CUSTO";
            this.edPRO_CUSTO.Properties.Mask.EditMask = "c2";
            this.edPRO_CUSTO.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.edPRO_CUSTO.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.edPRO_CUSTO.Size = new System.Drawing.Size(119, 20);
            this.edPRO_CUSTO.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.edPRO_CUSTOULTCOMPRA);
            this.groupControl3.Location = new System.Drawing.Point(434, 66);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Padding = new System.Windows.Forms.Padding(2);
            this.groupControl3.Size = new System.Drawing.Size(143, 46);
            this.groupControl3.TabIndex = 6;
            this.groupControl3.Text = "Custo Ult. Compra";
            // 
            // edPRO_CUSTOULTCOMPRA
            // 
            this.edPRO_CUSTOULTCOMPRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edPRO_CUSTOULTCOMPRA.EnterMoveNextControl = true;
            this.edPRO_CUSTOULTCOMPRA.Location = new System.Drawing.Point(4, 22);
            this.edPRO_CUSTOULTCOMPRA.Name = "edPRO_CUSTOULTCOMPRA";
            this.edPRO_CUSTOULTCOMPRA.Properties.Mask.EditMask = "c2";
            this.edPRO_CUSTOULTCOMPRA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.edPRO_CUSTOULTCOMPRA.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.edPRO_CUSTOULTCOMPRA.Size = new System.Drawing.Size(135, 20);
            this.edPRO_CUSTOULTCOMPRA.TabIndex = 0;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.edTPR_ID);
            this.groupControl4.Location = new System.Drawing.Point(434, 12);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Padding = new System.Windows.Forms.Padding(2);
            this.groupControl4.Size = new System.Drawing.Size(143, 46);
            this.groupControl4.TabIndex = 3;
            this.groupControl4.Text = "Tipo";
            // 
            // edTPR_ID
            // 
            this.edTPR_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edTPR_ID.EnterMoveNextControl = true;
            this.edTPR_ID.Location = new System.Drawing.Point(4, 22);
            this.edTPR_ID.Name = "edTPR_ID";
            this.edTPR_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edTPR_ID.Properties.NullText = "";
            this.edTPR_ID.Properties.PopupView = this.gridLookUpEdit1View;
            this.edTPR_ID.Size = new System.Drawing.Size(135, 20);
            this.edTPR_ID.TabIndex = 1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "TPR_ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nome do tipo";
            this.gridColumn2.FieldName = "TPR_DESCRICAO";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.edPRO_FORNECEDOR);
            this.groupControl5.Location = new System.Drawing.Point(135, 66);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Padding = new System.Windows.Forms.Padding(2);
            this.groupControl5.Size = new System.Drawing.Size(160, 46);
            this.groupControl5.TabIndex = 4;
            this.groupControl5.Text = "Fornecedor";
            // 
            // edPRO_FORNECEDOR
            // 
            this.edPRO_FORNECEDOR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edPRO_FORNECEDOR.EnterMoveNextControl = true;
            this.edPRO_FORNECEDOR.Location = new System.Drawing.Point(4, 22);
            this.edPRO_FORNECEDOR.Name = "edPRO_FORNECEDOR";
            this.edPRO_FORNECEDOR.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edPRO_FORNECEDOR.Properties.NullText = "";
            this.edPRO_FORNECEDOR.Properties.PopupView = this.gridView1;
            this.edPRO_FORNECEDOR.Size = new System.Drawing.Size(152, 20);
            this.edPRO_FORNECEDOR.TabIndex = 0;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "ID";
            this.gridColumn3.FieldName = "CLI_ID";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 48;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "RAZAO SOCIAL";
            this.gridColumn4.FieldName = "CLI_RAZAO";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 170;
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.pic_IMAGEM);
            this.groupControl6.Controls.Add(this.edPRO_IMAGEM);
            this.groupControl6.Location = new System.Drawing.Point(12, 12);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(119, 141);
            this.groupControl6.TabIndex = 0;
            this.groupControl6.Text = "Imagem";
            // 
            // pic_IMAGEM
            // 
            this.pic_IMAGEM.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic_IMAGEM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_IMAGEM.Location = new System.Drawing.Point(2, 40);
            this.pic_IMAGEM.Name = "pic_IMAGEM";
            this.pic_IMAGEM.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_IMAGEM.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_IMAGEM.Size = new System.Drawing.Size(115, 99);
            this.pic_IMAGEM.TabIndex = 0;
            this.pic_IMAGEM.EditValueChanged += new System.EventHandler(this.pic_IMAGEM_EditValueChanged);
            this.pic_IMAGEM.DoubleClick += new System.EventHandler(this.pic_IMAGEM_DoubleClick);
            // 
            // edPRO_IMAGEM
            // 
            this.edPRO_IMAGEM.Dock = System.Windows.Forms.DockStyle.Top;
            this.edPRO_IMAGEM.EnterMoveNextControl = true;
            this.edPRO_IMAGEM.Location = new System.Drawing.Point(2, 20);
            this.edPRO_IMAGEM.Name = "edPRO_IMAGEM";
            this.edPRO_IMAGEM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.edPRO_IMAGEM.Size = new System.Drawing.Size(115, 20);
            this.edPRO_IMAGEM.TabIndex = 9;
            this.edPRO_IMAGEM.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.edPRO_IMAGEM_ButtonClick);
            // 
            // groupControl7
            // 
            this.groupControl7.Controls.Add(this.edPRO_REFERENCIA);
            this.groupControl7.Location = new System.Drawing.Point(135, 12);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Padding = new System.Windows.Forms.Padding(2);
            this.groupControl7.Size = new System.Drawing.Size(125, 46);
            this.groupControl7.TabIndex = 1;
            this.groupControl7.Text = "Referênia";
            // 
            // edPRO_REFERENCIA
            // 
            this.edPRO_REFERENCIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edPRO_REFERENCIA.EnterMoveNextControl = true;
            this.edPRO_REFERENCIA.Location = new System.Drawing.Point(4, 22);
            this.edPRO_REFERENCIA.Name = "edPRO_REFERENCIA";
            this.edPRO_REFERENCIA.Size = new System.Drawing.Size(117, 20);
            this.edPRO_REFERENCIA.TabIndex = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(434, 118);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(143, 35);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(301, 118);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 35);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(135, 118);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(160, 35);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 162);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.groupControl7);
            this.Controls.Add(this.groupControl6);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmProdutos";
            this.ShowIcon = false;
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_DESCRICAO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_CUSTO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_CUSTOULTCOMPRA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edTPR_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_FORNECEDOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_IMAGEM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_IMAGEM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_REFERENCIA.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit edPRO_DESCRICAO;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit edPRO_CUSTO;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit edPRO_CUSTOULTCOMPRA;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.PictureEdit pic_IMAGEM;
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private DevExpress.XtraEditors.TextEdit edPRO_REFERENCIA;
        private DevExpress.XtraEditors.SimpleButton btnExcluir;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.ButtonEdit edPRO_IMAGEM;
        private System.Windows.Forms.OpenFileDialog openFileDialogImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.GridLookUpEdit edTPR_ID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.GridLookUpEdit edPRO_FORNECEDOR;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}