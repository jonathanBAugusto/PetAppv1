namespace PetApp
{
    partial class FrmServicos
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
            this.components = new System.ComponentModel.Container();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.edSER_VALOR_BASE = new DevExpress.XtraEditors.TextEdit();
            this.btnCadastrar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddTipoServico = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddPet = new DevExpress.XtraEditors.SimpleButton();
            this.edPET_ID = new DevExpress.XtraEditors.LookUpEdit();
            this.edCLI_NOME = new DevExpress.XtraEditors.LookUpEdit();
            this.btnAddCli = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl10 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl9 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl8 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.edSER_VALOR_DESCONTO = new DevExpress.XtraEditors.TextEdit();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.edSER_TIPO = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.edSER_OBSERVACAO = new DevExpress.XtraEditors.MemoEdit();
            this.edSER_DATA_PREV = new DevExpress.XtraEditors.DateEdit();
            this.cbEstagio = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSER_VALOR_BASE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPET_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edCLI_NOME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl10)).BeginInit();
            this.groupControl10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl9)).BeginInit();
            this.groupControl9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).BeginInit();
            this.groupControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edSER_VALOR_DESCONTO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edSER_TIPO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edSER_OBSERVACAO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSER_DATA_PREV.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSER_DATA_PREV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstagio.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "ribbonPage5";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "ribbonPage4";
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            // 
            // edSER_VALOR_BASE
            // 
            this.edSER_VALOR_BASE.Location = new System.Drawing.Point(4, 22);
            this.edSER_VALOR_BASE.Margin = new System.Windows.Forms.Padding(2);
            this.edSER_VALOR_BASE.Name = "edSER_VALOR_BASE";
            this.edSER_VALOR_BASE.Properties.Mask.EditMask = "c";
            this.edSER_VALOR_BASE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.edSER_VALOR_BASE.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.edSER_VALOR_BASE.Size = new System.Drawing.Size(95, 20);
            this.edSER_VALOR_BASE.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(596, 75);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 67);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAddTipoServico
            // 
            this.btnAddTipoServico.Location = new System.Drawing.Point(75, 22);
            this.btnAddTipoServico.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTipoServico.Name = "btnAddTipoServico";
            this.btnAddTipoServico.Size = new System.Drawing.Size(24, 21);
            this.btnAddTipoServico.TabIndex = 36;
            this.btnAddTipoServico.Text = "+";
            // 
            // btnAddPet
            // 
            this.btnAddPet.Location = new System.Drawing.Point(75, 21);
            this.btnAddPet.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(22, 21);
            this.btnAddPet.TabIndex = 32;
            this.btnAddPet.Text = "+";
            // 
            // edPET_ID
            // 
            this.edPET_ID.Location = new System.Drawing.Point(4, 22);
            this.edPET_ID.Margin = new System.Windows.Forms.Padding(2);
            this.edPET_ID.Name = "edPET_ID";
            this.edPET_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edPET_ID.Properties.NullText = "Pet";
            this.edPET_ID.Size = new System.Drawing.Size(67, 20);
            this.edPET_ID.TabIndex = 2;
            // 
            // edCLI_NOME
            // 
            this.edCLI_NOME.Location = new System.Drawing.Point(4, 22);
            this.edCLI_NOME.Margin = new System.Windows.Forms.Padding(2);
            this.edCLI_NOME.Name = "edCLI_NOME";
            this.edCLI_NOME.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edCLI_NOME.Properties.NullText = "Cliente";
            this.edCLI_NOME.Size = new System.Drawing.Size(74, 20);
            this.edCLI_NOME.TabIndex = 1;
            // 
            // btnAddCli
            // 
            this.btnAddCli.Location = new System.Drawing.Point(82, 22);
            this.btnAddCli.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCli.Name = "btnAddCli";
            this.btnAddCli.Size = new System.Drawing.Size(24, 20);
            this.btnAddCli.TabIndex = 29;
            this.btnAddCli.Text = "+";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupControl10);
            this.groupControl2.Controls.Add(this.groupControl9);
            this.groupControl2.Controls.Add(this.groupControl8);
            this.groupControl2.Controls.Add(this.groupControl7);
            this.groupControl2.Controls.Add(this.groupControl6);
            this.groupControl2.Controls.Add(this.groupControl5);
            this.groupControl2.Controls.Add(this.groupControl4);
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Controls.Add(this.btnCadastrar);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(678, 150);
            this.groupControl2.TabIndex = 43;
            this.groupControl2.Text = "Cadastrar Serviço";
            // 
            // groupControl10
            // 
            this.groupControl10.Controls.Add(this.cbEstagio);
            this.groupControl10.Location = new System.Drawing.Point(340, 75);
            this.groupControl10.Name = "groupControl10";
            this.groupControl10.Padding = new System.Windows.Forms.Padding(2);
            this.groupControl10.Size = new System.Drawing.Size(251, 67);
            this.groupControl10.TabIndex = 51;
            this.groupControl10.Text = "Estágio";
            // 
            // groupControl9
            // 
            this.groupControl9.Controls.Add(this.edSER_OBSERVACAO);
            this.groupControl9.Location = new System.Drawing.Point(5, 75);
            this.groupControl9.Name = "groupControl9";
            this.groupControl9.Size = new System.Drawing.Size(329, 67);
            this.groupControl9.TabIndex = 52;
            this.groupControl9.Text = "Observações";
            // 
            // groupControl8
            // 
            this.groupControl8.Controls.Add(this.edSER_DATA_PREV);
            this.groupControl8.Location = new System.Drawing.Point(558, 23);
            this.groupControl8.Name = "groupControl8";
            this.groupControl8.Size = new System.Drawing.Size(113, 46);
            this.groupControl8.TabIndex = 51;
            this.groupControl8.Text = "Data de previsão";
            // 
            // groupControl7
            // 
            this.groupControl7.Controls.Add(this.edSER_VALOR_DESCONTO);
            this.groupControl7.Location = new System.Drawing.Point(449, 23);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(103, 46);
            this.groupControl7.TabIndex = 50;
            this.groupControl7.Text = "Desconto";
            // 
            // edSER_VALOR_DESCONTO
            // 
            this.edSER_VALOR_DESCONTO.Location = new System.Drawing.Point(4, 22);
            this.edSER_VALOR_DESCONTO.Margin = new System.Windows.Forms.Padding(2);
            this.edSER_VALOR_DESCONTO.Name = "edSER_VALOR_DESCONTO";
            this.edSER_VALOR_DESCONTO.Properties.Mask.EditMask = "c";
            this.edSER_VALOR_DESCONTO.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.edSER_VALOR_DESCONTO.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.edSER_VALOR_DESCONTO.Size = new System.Drawing.Size(95, 20);
            this.edSER_VALOR_DESCONTO.TabIndex = 5;
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.edSER_VALOR_BASE);
            this.groupControl6.Location = new System.Drawing.Point(340, 23);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(103, 46);
            this.groupControl6.TabIndex = 49;
            this.groupControl6.Text = "Valor";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.edSER_TIPO);
            this.groupControl5.Controls.Add(this.btnAddTipoServico);
            this.groupControl5.Location = new System.Drawing.Point(231, 23);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(103, 46);
            this.groupControl5.TabIndex = 48;
            this.groupControl5.Text = "Tipo de Serviço";
            // 
            // edSER_TIPO
            // 
            this.edSER_TIPO.EditValue = "S";
            this.edSER_TIPO.Location = new System.Drawing.Point(5, 23);
            this.edSER_TIPO.Name = "edSER_TIPO";
            this.edSER_TIPO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edSER_TIPO.Properties.NullText = "Selecione";
            this.edSER_TIPO.Properties.PopupView = this.gridLookUpEdit1View;
            this.edSER_TIPO.Size = new System.Drawing.Size(67, 20);
            this.edSER_TIPO.TabIndex = 44;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.edPET_ID);
            this.groupControl4.Controls.Add(this.btnAddPet);
            this.groupControl4.Location = new System.Drawing.Point(122, 23);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(103, 46);
            this.groupControl4.TabIndex = 47;
            this.groupControl4.Text = "Pet";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.edCLI_NOME);
            this.groupControl3.Controls.Add(this.btnAddCli);
            this.groupControl3.Location = new System.Drawing.Point(5, 23);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(111, 46);
            this.groupControl3.TabIndex = 46;
            this.groupControl3.Text = "Cliente";
            // 
            // edSER_OBSERVACAO
            // 
            this.edSER_OBSERVACAO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edSER_OBSERVACAO.Location = new System.Drawing.Point(2, 20);
            this.edSER_OBSERVACAO.Name = "edSER_OBSERVACAO";
            this.edSER_OBSERVACAO.Size = new System.Drawing.Size(325, 45);
            this.edSER_OBSERVACAO.TabIndex = 0;
            // 
            // edSER_DATA_PREV
            // 
            this.edSER_DATA_PREV.EditValue = null;
            this.edSER_DATA_PREV.Location = new System.Drawing.Point(5, 22);
            this.edSER_DATA_PREV.Name = "edSER_DATA_PREV";
            this.edSER_DATA_PREV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edSER_DATA_PREV.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edSER_DATA_PREV.Size = new System.Drawing.Size(102, 20);
            this.edSER_DATA_PREV.TabIndex = 0;
            // 
            // cbEstagio
            // 
            this.cbEstagio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEstagio.Location = new System.Drawing.Point(4, 22);
            this.cbEstagio.Name = "cbEstagio";
            this.cbEstagio.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("N", "Não Iniciado"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Em processo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("F", "Finalizado"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("C", "Cancelado")});
            this.cbEstagio.Size = new System.Drawing.Size(243, 41);
            this.cbEstagio.TabIndex = 0;
            // 
            // FrmServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 150);
            this.Controls.Add(this.groupControl2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmServicos";
            this.Text = "Serviços";
            this.Load += new System.EventHandler(this.FrmServicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSER_VALOR_BASE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPET_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edCLI_NOME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl10)).EndInit();
            this.groupControl10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl9)).EndInit();
            this.groupControl9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).EndInit();
            this.groupControl8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edSER_VALOR_DESCONTO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edSER_TIPO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edSER_OBSERVACAO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSER_DATA_PREV.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSER_DATA_PREV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstagio.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraEditors.TextEdit edSER_VALOR_BASE;
        private DevExpress.XtraEditors.SimpleButton btnCadastrar;
        private DevExpress.XtraEditors.SimpleButton btnAddTipoServico;
        private DevExpress.XtraEditors.SimpleButton btnAddPet;
        private DevExpress.XtraEditors.LookUpEdit edPET_ID;
        private DevExpress.XtraEditors.LookUpEdit edCLI_NOME;
        private DevExpress.XtraEditors.SimpleButton btnAddCli;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit edSER_VALOR_DESCONTO;
        private DevExpress.XtraEditors.GroupControl groupControl9;
        private DevExpress.XtraEditors.GroupControl groupControl8;
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GridLookUpEdit edSER_TIPO;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GroupControl groupControl10;
        private DevExpress.XtraEditors.RadioGroup cbEstagio;
        private DevExpress.XtraEditors.MemoEdit edSER_OBSERVACAO;
        private DevExpress.XtraEditors.DateEdit edSER_DATA_PREV;
    }
}