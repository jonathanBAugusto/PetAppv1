namespace PetApp.View.UTL
{
    partial class FrmSelectCli
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
            this.pcBottom = new DevExpress.XtraEditors.PanelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlCli = new DevExpress.XtraGrid.GridControl();
            this.gridViewProdutos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pcTop = new DevExpress.XtraEditors.PanelControl();
            this.groupControl8 = new DevExpress.XtraEditors.GroupControl();
            this.rgCLI_PESTIPO = new DevExpress.XtraEditors.RadioGroup();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.edCLI_RAZAO = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.edCLI_INSCRICAO = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.rgPeriodo = new DevExpress.XtraEditors.RadioGroup();
            this.edDATAFIN = new DevExpress.XtraEditors.DateEdit();
            this.edDATAINI = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pcImg = new DevExpress.XtraEditors.PictureEdit();
            this.btnPesquisar = new DevExpress.XtraEditors.SimpleButton();
            this.gpRef = new DevExpress.XtraEditors.GroupControl();
            this.edCLI_ID = new DevExpress.XtraEditors.TextEdit();
            this.gpFor = new DevExpress.XtraEditors.GroupControl();
            this.edCLI_CNPJ = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBottom)).BeginInit();
            this.pcBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcTop)).BeginInit();
            this.pcTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).BeginInit();
            this.groupControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgCLI_PESTIPO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edCLI_RAZAO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edCLI_INSCRICAO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDATAFIN.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDATAFIN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDATAINI.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDATAINI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcImg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpRef)).BeginInit();
            this.gpRef.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edCLI_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpFor)).BeginInit();
            this.gpFor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edCLI_CNPJ.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pcBottom
            // 
            this.pcBottom.Controls.Add(this.btnCancelar);
            this.pcBottom.Controls.Add(this.btnOK);
            this.pcBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pcBottom.Location = new System.Drawing.Point(0, 379);
            this.pcBottom.Name = "pcBottom";
            this.pcBottom.Size = new System.Drawing.Size(780, 38);
            this.pcBottom.TabIndex = 575;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(404, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(311, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // gridControlCli
            // 
            this.gridControlCli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCli.Location = new System.Drawing.Point(0, 113);
            this.gridControlCli.MainView = this.gridViewProdutos;
            this.gridControlCli.Name = "gridControlCli";
            this.gridControlCli.Size = new System.Drawing.Size(780, 266);
            this.gridControlCli.TabIndex = 8;
            this.gridControlCli.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProdutos});
            // 
            // gridViewProdutos
            // 
            this.gridViewProdutos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridViewProdutos.GridControl = this.gridControlCli;
            this.gridViewProdutos.Name = "gridViewProdutos";
            this.gridViewProdutos.OptionsView.ColumnAutoWidth = false;
            this.gridViewProdutos.OptionsView.ShowAutoFilterRow = true;
            this.gridViewProdutos.OptionsView.ShowGroupPanel = false;
            this.gridViewProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewProdutos_KeyDown);
            this.gridViewProdutos.DoubleClick += new System.EventHandler(this.gridViewProdutos_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "CLI_ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 62;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Razão Social";
            this.gridColumn2.FieldName = "CLI_RAZAO";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 185;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "CPF/CNPJ";
            this.gridColumn3.FieldName = "CLI_CNPJ";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 118;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "IE/RG";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 116;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tipo Pessoa";
            this.gridColumn5.FieldName = "CLI_TIPODESC";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 120;
            // 
            // pcTop
            // 
            this.pcTop.Controls.Add(this.groupControl8);
            this.pcTop.Controls.Add(this.groupControl3);
            this.pcTop.Controls.Add(this.groupControl1);
            this.pcTop.Controls.Add(this.groupControl2);
            this.pcTop.Controls.Add(this.pcImg);
            this.pcTop.Controls.Add(this.btnPesquisar);
            this.pcTop.Controls.Add(this.gpRef);
            this.pcTop.Controls.Add(this.gpFor);
            this.pcTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcTop.Location = new System.Drawing.Point(0, 0);
            this.pcTop.Name = "pcTop";
            this.pcTop.Size = new System.Drawing.Size(780, 113);
            this.pcTop.TabIndex = 0;
            // 
            // groupControl8
            // 
            this.groupControl8.Controls.Add(this.rgCLI_PESTIPO);
            this.groupControl8.Location = new System.Drawing.Point(295, 5);
            this.groupControl8.Name = "groupControl8";
            this.groupControl8.Size = new System.Drawing.Size(107, 100);
            this.groupControl8.TabIndex = 2;
            this.groupControl8.Text = "Tipo de Pessoa";
            // 
            // rgCLI_PESTIPO
            // 
            this.rgCLI_PESTIPO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgCLI_PESTIPO.EditValue = "TOD";
            this.rgCLI_PESTIPO.EnterMoveNextControl = true;
            this.rgCLI_PESTIPO.Location = new System.Drawing.Point(2, 20);
            this.rgCLI_PESTIPO.Name = "rgCLI_PESTIPO";
            this.rgCLI_PESTIPO.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgCLI_PESTIPO.Properties.Appearance.Options.UseBackColor = true;
            this.rgCLI_PESTIPO.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgCLI_PESTIPO.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("FIS", "Pessoa Física"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("JUR", "Pessoa Jurídica"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("FOR", "Fornecedor"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("TOD", "Todos")});
            this.rgCLI_PESTIPO.Size = new System.Drawing.Size(103, 78);
            this.rgCLI_PESTIPO.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.edCLI_RAZAO);
            this.groupControl3.Location = new System.Drawing.Point(489, 5);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Padding = new System.Windows.Forms.Padding(2);
            this.groupControl3.Size = new System.Drawing.Size(124, 47);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "Razão Social";
            // 
            // edCLI_RAZAO
            // 
            this.edCLI_RAZAO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edCLI_RAZAO.EnterMoveNextControl = true;
            this.edCLI_RAZAO.Location = new System.Drawing.Point(4, 22);
            this.edCLI_RAZAO.Name = "edCLI_RAZAO";
            this.edCLI_RAZAO.Properties.Mask.EditMask = "\\d+";
            this.edCLI_RAZAO.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.edCLI_RAZAO.Properties.Mask.ShowPlaceHolders = false;
            this.edCLI_RAZAO.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.edCLI_RAZAO.Size = new System.Drawing.Size(116, 20);
            this.edCLI_RAZAO.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.edCLI_INSCRICAO);
            this.groupControl1.Location = new System.Drawing.Point(408, 58);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(2);
            this.groupControl1.Size = new System.Drawing.Size(124, 47);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "IE/RG";
            // 
            // edCLI_INSCRICAO
            // 
            this.edCLI_INSCRICAO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edCLI_INSCRICAO.EnterMoveNextControl = true;
            this.edCLI_INSCRICAO.Location = new System.Drawing.Point(4, 22);
            this.edCLI_INSCRICAO.Name = "edCLI_INSCRICAO";
            this.edCLI_INSCRICAO.Properties.Mask.EditMask = "\\d+";
            this.edCLI_INSCRICAO.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.edCLI_INSCRICAO.Properties.Mask.ShowPlaceHolders = false;
            this.edCLI_INSCRICAO.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.edCLI_INSCRICAO.Size = new System.Drawing.Size(116, 20);
            this.edCLI_INSCRICAO.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.rgPeriodo);
            this.groupControl2.Controls.Add(this.edDATAFIN);
            this.groupControl2.Controls.Add(this.edDATAINI);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Location = new System.Drawing.Point(111, 5);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Padding = new System.Windows.Forms.Padding(2);
            this.groupControl2.Size = new System.Drawing.Size(178, 100);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Período";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(93, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(13, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "De";
            // 
            // rgPeriodo
            // 
            this.rgPeriodo.EnterMoveNextControl = true;
            this.rgPeriodo.Location = new System.Drawing.Point(7, 22);
            this.rgPeriodo.Name = "rgPeriodo";
            this.rgPeriodo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgPeriodo.Properties.Appearance.Options.UseBackColor = true;
            this.rgPeriodo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgPeriodo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("CLI_DATA_CADASTRO", "Cadastro"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("CLI_NASC", "Nascimento")});
            this.rgPeriodo.Size = new System.Drawing.Size(81, 71);
            this.rgPeriodo.TabIndex = 0;
            // 
            // edDATAFIN
            // 
            this.edDATAFIN.EditValue = null;
            this.edDATAFIN.EnterMoveNextControl = true;
            this.edDATAFIN.Location = new System.Drawing.Point(93, 75);
            this.edDATAFIN.Name = "edDATAFIN";
            this.edDATAFIN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edDATAFIN.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edDATAFIN.Size = new System.Drawing.Size(70, 20);
            this.edDATAFIN.TabIndex = 2;
            // 
            // edDATAINI
            // 
            this.edDATAINI.EditValue = null;
            this.edDATAINI.EnterMoveNextControl = true;
            this.edDATAINI.Location = new System.Drawing.Point(93, 37);
            this.edDATAINI.Name = "edDATAINI";
            this.edDATAINI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edDATAINI.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edDATAINI.Size = new System.Drawing.Size(70, 20);
            this.edDATAINI.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(93, 59);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(17, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Até";
            // 
            // pcImg
            // 
            this.pcImg.Cursor = System.Windows.Forms.Cursors.Default;
            this.pcImg.EnterMoveNextControl = true;
            this.pcImg.Location = new System.Drawing.Point(5, 5);
            this.pcImg.Name = "pcImg";
            this.pcImg.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pcImg.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pcImg.Size = new System.Drawing.Size(100, 100);
            this.pcImg.TabIndex = 0;
            this.pcImg.TabStop = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(668, 58);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 47);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // gpRef
            // 
            this.gpRef.Controls.Add(this.edCLI_ID);
            this.gpRef.Location = new System.Drawing.Point(408, 5);
            this.gpRef.Name = "gpRef";
            this.gpRef.Padding = new System.Windows.Forms.Padding(2);
            this.gpRef.Size = new System.Drawing.Size(75, 47);
            this.gpRef.TabIndex = 3;
            this.gpRef.Text = "ID";
            // 
            // edCLI_ID
            // 
            this.edCLI_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edCLI_ID.EnterMoveNextControl = true;
            this.edCLI_ID.Location = new System.Drawing.Point(4, 22);
            this.edCLI_ID.Name = "edCLI_ID";
            this.edCLI_ID.Properties.Mask.EditMask = "\\d+";
            this.edCLI_ID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.edCLI_ID.Properties.Mask.ShowPlaceHolders = false;
            this.edCLI_ID.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.edCLI_ID.Size = new System.Drawing.Size(67, 20);
            this.edCLI_ID.TabIndex = 0;
            // 
            // gpFor
            // 
            this.gpFor.Controls.Add(this.edCLI_CNPJ);
            this.gpFor.Location = new System.Drawing.Point(619, 5);
            this.gpFor.Name = "gpFor";
            this.gpFor.Padding = new System.Windows.Forms.Padding(2);
            this.gpFor.Size = new System.Drawing.Size(124, 47);
            this.gpFor.TabIndex = 5;
            this.gpFor.Text = "CNPJ/CPF";
            // 
            // edCLI_CNPJ
            // 
            this.edCLI_CNPJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edCLI_CNPJ.EnterMoveNextControl = true;
            this.edCLI_CNPJ.Location = new System.Drawing.Point(4, 22);
            this.edCLI_CNPJ.Name = "edCLI_CNPJ";
            this.edCLI_CNPJ.Properties.Mask.EditMask = "\\d+";
            this.edCLI_CNPJ.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.edCLI_CNPJ.Properties.Mask.ShowPlaceHolders = false;
            this.edCLI_CNPJ.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.edCLI_CNPJ.Size = new System.Drawing.Size(116, 20);
            this.edCLI_CNPJ.TabIndex = 0;
            // 
            // FrmSelectCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 417);
            this.Controls.Add(this.gridControlCli);
            this.Controls.Add(this.pcTop);
            this.Controls.Add(this.pcBottom);
            this.Name = "FrmSelectCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pesquisar Clientes/Fornecedores";
            this.Load += new System.EventHandler(this.FrmSelectCli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcBottom)).EndInit();
            this.pcBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcTop)).EndInit();
            this.pcTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).EndInit();
            this.groupControl8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgCLI_PESTIPO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edCLI_RAZAO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edCLI_INSCRICAO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDATAFIN.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDATAFIN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDATAINI.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDATAINI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcImg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpRef)).EndInit();
            this.gpRef.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edCLI_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpFor)).EndInit();
            this.gpFor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edCLI_CNPJ.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl pcBottom;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraGrid.GridControl gridControlCli;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProdutos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.PanelControl pcTop;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.DateEdit edDATAFIN;
        private DevExpress.XtraEditors.DateEdit edDATAINI;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PictureEdit pcImg;
        private DevExpress.XtraEditors.SimpleButton btnPesquisar;
        private DevExpress.XtraEditors.GroupControl gpRef;
        private DevExpress.XtraEditors.TextEdit edCLI_ID;
        private DevExpress.XtraEditors.GroupControl gpFor;
        private DevExpress.XtraEditors.TextEdit edCLI_CNPJ;
        private DevExpress.XtraEditors.RadioGroup rgPeriodo;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit edCLI_RAZAO;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit edCLI_INSCRICAO;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.GroupControl groupControl8;
        private DevExpress.XtraEditors.RadioGroup rgCLI_PESTIPO;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}