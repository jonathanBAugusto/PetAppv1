namespace PetApp.View
{
    partial class FrmCadUnidade
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
            this.gridControlUnidade = new DevExpress.XtraGrid.GridControl();
            this.gridViewUnidade = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnAlter = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.edUNI_DESCRICAO = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUnidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUnidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edUNI_DESCRICAO.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlUnidade
            // 
            this.gridControlUnidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUnidade.Location = new System.Drawing.Point(0, 69);
            this.gridControlUnidade.MainView = this.gridViewUnidade;
            this.gridControlUnidade.Name = "gridControlUnidade";
            this.gridControlUnidade.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControlUnidade.Size = new System.Drawing.Size(513, 192);
            this.gridControlUnidade.TabIndex = 0;
            this.gridControlUnidade.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUnidade});
            // 
            // gridViewUnidade
            // 
            this.gridViewUnidade.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridViewUnidade.GridControl = this.gridControlUnidade;
            this.gridViewUnidade.Name = "gridViewUnidade";
            this.gridViewUnidade.OptionsView.ColumnAutoWidth = false;
            this.gridViewUnidade.OptionsView.ShowAutoFilterRow = true;
            this.gridViewUnidade.OptionsView.ShowGroupPanel = false;
            this.gridViewUnidade.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewUnidade_RowClick);
            this.gridViewUnidade.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewUnidade_FocusedRowChanged);
            this.gridViewUnidade.Click += new System.EventHandler(this.gridViewUnidade_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "UNI_ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 64;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Descrição";
            this.gridColumn2.FieldName = "UNI_DESCRICAO";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 207;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "c2";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnRemove);
            this.panelControl1.Controls.Add(this.btnAlter);
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(513, 69);
            this.panelControl1.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(325, 37);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remover";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(244, 37);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(75, 23);
            this.btnAlter.TabIndex = 3;
            this.btnAlter.Text = "Alterar";
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(163, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.edUNI_DESCRICAO);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(3);
            this.groupControl1.Size = new System.Drawing.Size(145, 48);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Descrição";
            // 
            // edUNI_DESCRICAO
            // 
            this.edUNI_DESCRICAO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edUNI_DESCRICAO.EnterMoveNextControl = true;
            this.edUNI_DESCRICAO.Location = new System.Drawing.Point(5, 23);
            this.edUNI_DESCRICAO.Name = "edUNI_DESCRICAO";
            this.edUNI_DESCRICAO.Size = new System.Drawing.Size(135, 20);
            this.edUNI_DESCRICAO.TabIndex = 0;
            // 
            // FrmCadUnidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 261);
            this.Controls.Add(this.gridControlUnidade);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmCadUnidade";
            this.Text = "Unidade";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUnidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUnidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edUNI_DESCRICAO.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlUnidade;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUnidade;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnAlter;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit edUNI_DESCRICAO;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}