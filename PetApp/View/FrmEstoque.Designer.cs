namespace PetApp.View
{
    partial class FrmEstoque
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnConcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemover = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdicionar = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.rgLCP_TIPO = new DevExpress.XtraEditors.RadioGroup();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.edLCP_DATA = new DevExpress.XtraEditors.DateEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.edLCP_QUANTIDADE = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.edPRO_REFERENCIA = new DevExpress.XtraEditors.ButtonEdit();
            this.gridControlEstoque = new DevExpress.XtraGrid.GridControl();
            this.gridViewEstoque = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgLCP_TIPO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edLCP_DATA.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edLCP_DATA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edLCP_QUANTIDADE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_REFERENCIA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnConcluir);
            this.panelControl1.Controls.Add(this.btnRemover);
            this.panelControl1.Controls.Add(this.btnAdicionar);
            this.panelControl1.Controls.Add(this.groupControl4);
            this.panelControl1.Controls.Add(this.groupControl3);
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(552, 91);
            this.panelControl1.TabIndex = 0;
            // 
            // btnConcluir
            // 
            this.btnConcluir.Location = new System.Drawing.Point(465, 61);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(75, 23);
            this.btnConcluir.TabIndex = 7;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(384, 61);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "Remover";
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(303, 61);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.rgLCP_TIPO);
            this.groupControl4.Location = new System.Drawing.Point(365, 12);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(175, 43);
            this.groupControl4.TabIndex = 3;
            this.groupControl4.Text = "Tipo de Movimento";
            // 
            // rgLCP_TIPO
            // 
            this.rgLCP_TIPO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgLCP_TIPO.EditValue = "E";
            this.rgLCP_TIPO.EnterMoveNextControl = true;
            this.rgLCP_TIPO.Location = new System.Drawing.Point(2, 20);
            this.rgLCP_TIPO.Name = "rgLCP_TIPO";
            this.rgLCP_TIPO.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgLCP_TIPO.Properties.Appearance.Options.UseBackColor = true;
            this.rgLCP_TIPO.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgLCP_TIPO.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("E", "Entrada"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Saída")});
            this.rgLCP_TIPO.Size = new System.Drawing.Size(171, 21);
            this.rgLCP_TIPO.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.edLCP_DATA);
            this.groupControl3.Location = new System.Drawing.Point(250, 12);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(109, 43);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Data";
            // 
            // edLCP_DATA
            // 
            this.edLCP_DATA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edLCP_DATA.EditValue = null;
            this.edLCP_DATA.EnterMoveNextControl = true;
            this.edLCP_DATA.Location = new System.Drawing.Point(2, 20);
            this.edLCP_DATA.Name = "edLCP_DATA";
            this.edLCP_DATA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edLCP_DATA.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edLCP_DATA.Size = new System.Drawing.Size(105, 20);
            this.edLCP_DATA.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.edLCP_QUANTIDADE);
            this.groupControl2.Location = new System.Drawing.Point(133, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(111, 43);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Quantidade";
            // 
            // edLCP_QUANTIDADE
            // 
            this.edLCP_QUANTIDADE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edLCP_QUANTIDADE.EnterMoveNextControl = true;
            this.edLCP_QUANTIDADE.Location = new System.Drawing.Point(2, 20);
            this.edLCP_QUANTIDADE.Name = "edLCP_QUANTIDADE";
            this.edLCP_QUANTIDADE.Properties.Mask.EditMask = "n3";
            this.edLCP_QUANTIDADE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.edLCP_QUANTIDADE.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.edLCP_QUANTIDADE.Size = new System.Drawing.Size(107, 20);
            this.edLCP_QUANTIDADE.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.edPRO_REFERENCIA);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(115, 43);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Produto";
            // 
            // edPRO_REFERENCIA
            // 
            this.edPRO_REFERENCIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edPRO_REFERENCIA.Location = new System.Drawing.Point(2, 20);
            this.edPRO_REFERENCIA.Name = "edPRO_REFERENCIA";
            this.edPRO_REFERENCIA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edPRO_REFERENCIA.Size = new System.Drawing.Size(111, 20);
            this.edPRO_REFERENCIA.TabIndex = 0;
            this.edPRO_REFERENCIA.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.edPRO_REFERENCIA_ButtonClick);
            // 
            // gridControlEstoque
            // 
            this.gridControlEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEstoque.Location = new System.Drawing.Point(0, 91);
            this.gridControlEstoque.MainView = this.gridViewEstoque;
            this.gridControlEstoque.Name = "gridControlEstoque";
            this.gridControlEstoque.Size = new System.Drawing.Size(552, 258);
            this.gridControlEstoque.TabIndex = 7;
            this.gridControlEstoque.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEstoque});
            // 
            // gridViewEstoque
            // 
            this.gridViewEstoque.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridViewEstoque.GridControl = this.gridControlEstoque;
            this.gridViewEstoque.Name = "gridViewEstoque";
            this.gridViewEstoque.OptionsView.ColumnAutoWidth = false;
            this.gridViewEstoque.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "LCP_ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Width = 41;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ref.";
            this.gridColumn2.FieldName = "PRO_REFERENCIA";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 73;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Descrição";
            this.gridColumn3.FieldName = "PRO_DESCRICAO";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 177;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Estoque";
            this.gridColumn4.FieldName = "LCP_QUANTIDADE";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Data";
            this.gridColumn5.FieldName = "LCP_DATA";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tipo";
            this.gridColumn6.FieldName = "LCP_TIPO";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // FrmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 349);
            this.Controls.Add(this.gridControlEstoque);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entrada/Saída de Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgLCP_TIPO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edLCP_DATA.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edLCP_DATA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edLCP_QUANTIDADE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_REFERENCIA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControlEstoque;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEstoque;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.RadioGroup rgLCP_TIPO;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit edLCP_QUANTIDADE;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.ButtonEdit edPRO_REFERENCIA;
        private DevExpress.XtraEditors.SimpleButton btnConcluir;
        private DevExpress.XtraEditors.SimpleButton btnRemover;
        private DevExpress.XtraEditors.SimpleButton btnAdicionar;
        private DevExpress.XtraEditors.DateEdit edLCP_DATA;
    }
}