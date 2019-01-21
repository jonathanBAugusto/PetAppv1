namespace PetApp.View
{
    partial class SH_ESTOQUE
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.rgLCP_TIPO = new DevExpress.XtraEditors.RadioGroup();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.edLCP_DATA = new DevExpress.XtraEditors.DateEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.edLCP_QUANTIDADE = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.edPRO_REFEREMCIA = new DevExpress.XtraEditors.ButtonEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnPesquisar = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemover = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdicionar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_REFEREMCIA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btnPesquisar);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnRemover);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnAdicionar);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl4);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl3);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(464, 316);
            this.splitContainerControl1.SplitterPosition = 113;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.rgLCP_TIPO);
            this.groupControl4.Location = new System.Drawing.Point(12, 61);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(234, 43);
            this.groupControl4.TabIndex = 7;
            this.groupControl4.Text = "Tipo de Movimento";
            // 
            // rgLCP_TIPO
            // 
            this.rgLCP_TIPO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgLCP_TIPO.EditValue = "S";
            this.rgLCP_TIPO.EnterMoveNextControl = true;
            this.rgLCP_TIPO.Location = new System.Drawing.Point(2, 20);
            this.rgLCP_TIPO.Name = "rgLCP_TIPO";
            this.rgLCP_TIPO.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgLCP_TIPO.Properties.Appearance.Options.UseBackColor = true;
            this.rgLCP_TIPO.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgLCP_TIPO.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("E", "Entrada"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Saída"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("A", "Ambos")});
            this.rgLCP_TIPO.Size = new System.Drawing.Size(230, 21);
            this.rgLCP_TIPO.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.edLCP_DATA);
            this.groupControl3.Location = new System.Drawing.Point(250, 12);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(109, 43);
            this.groupControl3.TabIndex = 6;
            this.groupControl3.Text = "Data";
            // 
            // edLCP_DATA
            // 
            this.edLCP_DATA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edLCP_DATA.EditValue = null;
            this.edLCP_DATA.Location = new System.Drawing.Point(2, 20);
            this.edLCP_DATA.Name = "edLCP_DATA";
            this.edLCP_DATA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edLCP_DATA.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edLCP_DATA.Properties.DisplayFormat.FormatString = "";
            this.edLCP_DATA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.edLCP_DATA.Properties.EditFormat.FormatString = "";
            this.edLCP_DATA.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.edLCP_DATA.Properties.Mask.EditMask = "";
            this.edLCP_DATA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.edLCP_DATA.Size = new System.Drawing.Size(105, 20);
            this.edLCP_DATA.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.edLCP_QUANTIDADE);
            this.groupControl2.Location = new System.Drawing.Point(133, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(111, 43);
            this.groupControl2.TabIndex = 5;
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
            this.edLCP_QUANTIDADE.Size = new System.Drawing.Size(107, 20);
            this.edLCP_QUANTIDADE.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.edPRO_REFEREMCIA);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(115, 43);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Produto";
            // 
            // edPRO_REFEREMCIA
            // 
            this.edPRO_REFEREMCIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edPRO_REFEREMCIA.Location = new System.Drawing.Point(2, 20);
            this.edPRO_REFEREMCIA.Name = "edPRO_REFEREMCIA";
            this.edPRO_REFEREMCIA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edPRO_REFEREMCIA.Size = new System.Drawing.Size(111, 20);
            this.edPRO_REFEREMCIA.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(464, 198);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(363, 11);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(95, 44);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "Pesquisar";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(363, 58);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(95, 46);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "Remover";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(252, 58);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(107, 46);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "Adicionar";
            // 
            // SH_ESTOQUE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 316);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "SH_ESTOQUE";
            this.Text = "SH_ESTOQUE";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_REFEREMCIA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.RadioGroup rgLCP_TIPO;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.DateEdit edLCP_DATA;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit edLCP_QUANTIDADE;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ButtonEdit edPRO_REFEREMCIA;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnPesquisar;
        private DevExpress.XtraEditors.SimpleButton btnRemover;
        private DevExpress.XtraEditors.SimpleButton btnAdicionar;
    }
}