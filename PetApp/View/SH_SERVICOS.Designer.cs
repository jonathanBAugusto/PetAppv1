namespace PetApp.View
{
    partial class SH_SERVICOS
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
            this.gridControlServicos = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.btnInserir = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.CLI_ID = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.PET_ID = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.edSER_DATA_CAD = new DevExpress.XtraEditors.DateEdit();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.edSER_VALOR_TOTAL = new DevExpress.XtraEditors.TextEdit();
            this.groupControl10 = new DevExpress.XtraEditors.GroupControl();
            this.cbEstagio = new DevExpress.XtraEditors.RadioGroup();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLI_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PET_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edSER_DATA_CAD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSER_DATA_CAD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edSER_VALOR_TOTAL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl10)).BeginInit();
            this.groupControl10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstagio.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlServicos);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 128);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(777, 153);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Relatórios de serviços";
            // 
            // gridControlServicos
            // 
            this.gridControlServicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlServicos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlServicos.Location = new System.Drawing.Point(2, 20);
            this.gridControlServicos.MainView = this.gridView1;
            this.gridControlServicos.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlServicos.Name = "gridControlServicos";
            this.gridControlServicos.Size = new System.Drawing.Size(773, 131);
            this.gridControlServicos.TabIndex = 1;
            this.gridControlServicos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11});
            this.gridView1.GridControl = this.gridControlServicos;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "SER_ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 41;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Cliente";
            this.gridColumn2.FieldName = "CLI_ID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 87;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tipo de serviço";
            this.gridColumn3.FieldName = "SER_TIPO";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 87;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "PET";
            this.gridColumn4.FieldName = "PET_ID";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 87;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Data de cadastro";
            this.gridColumn5.FieldName = "SER_DATA_CAD";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 87;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Previsão";
            this.gridColumn6.FieldName = "SER_DATA_PREV";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 87;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Valor";
            this.gridColumn7.FieldName = "SER_VALOR_BASE";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 72;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Valor de desconto";
            this.gridColumn8.FieldName = "SER_VALOR_DESCONTO";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 90;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Valor total";
            this.gridColumn9.FieldName = "SER_VALOR_TOTAL";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            this.gridColumn9.Width = 90;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Estágio do Serviço";
            this.gridColumn10.FieldName = "SER_ESTAGIO";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 10;
            this.gridColumn10.Width = 98;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Observações";
            this.gridColumn11.FieldName = "SER_OBSERVACAO";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 9;
            this.gridColumn11.Width = 90;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(681, 66);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 57);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(585, 66);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(90, 57);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.CLI_ID);
            this.groupControl2.Location = new System.Drawing.Point(13, 13);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Padding = new System.Windows.Forms.Padding(2);
            this.groupControl2.Size = new System.Drawing.Size(137, 47);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Cliente";
            // 
            // CLI_ID
            // 
            this.CLI_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CLI_ID.Location = new System.Drawing.Point(4, 22);
            this.CLI_ID.Name = "CLI_ID";
            this.CLI_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CLI_ID.Properties.PopupView = this.gridLookUpEdit1View;
            this.CLI_ID.Size = new System.Drawing.Size(129, 20);
            this.CLI_ID.TabIndex = 0;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.PET_ID);
            this.groupControl3.Location = new System.Drawing.Point(156, 13);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Padding = new System.Windows.Forms.Padding(2);
            this.groupControl3.Size = new System.Drawing.Size(137, 47);
            this.groupControl3.TabIndex = 7;
            this.groupControl3.Text = "PET";
            // 
            // PET_ID
            // 
            this.PET_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PET_ID.Location = new System.Drawing.Point(4, 22);
            this.PET_ID.Name = "PET_ID";
            this.PET_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PET_ID.Properties.PopupView = this.gridLookUpEdit2View;
            this.PET_ID.Size = new System.Drawing.Size(129, 20);
            this.PET_ID.TabIndex = 0;
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.edSER_DATA_CAD);
            this.groupControl4.Location = new System.Drawing.Point(299, 13);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Padding = new System.Windows.Forms.Padding(2);
            this.groupControl4.Size = new System.Drawing.Size(137, 47);
            this.groupControl4.TabIndex = 7;
            this.groupControl4.Text = "Data de cadastro";
            // 
            // edSER_DATA_CAD
            // 
            this.edSER_DATA_CAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edSER_DATA_CAD.EditValue = null;
            this.edSER_DATA_CAD.Location = new System.Drawing.Point(4, 22);
            this.edSER_DATA_CAD.Name = "edSER_DATA_CAD";
            this.edSER_DATA_CAD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edSER_DATA_CAD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edSER_DATA_CAD.Size = new System.Drawing.Size(129, 20);
            this.edSER_DATA_CAD.TabIndex = 0;
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.edSER_VALOR_TOTAL);
            this.groupControl5.Location = new System.Drawing.Point(442, 13);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Padding = new System.Windows.Forms.Padding(2);
            this.groupControl5.Size = new System.Drawing.Size(137, 47);
            this.groupControl5.TabIndex = 7;
            this.groupControl5.Text = "Valor";
            // 
            // edSER_VALOR_TOTAL
            // 
            this.edSER_VALOR_TOTAL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edSER_VALOR_TOTAL.Location = new System.Drawing.Point(4, 22);
            this.edSER_VALOR_TOTAL.Name = "edSER_VALOR_TOTAL";
            this.edSER_VALOR_TOTAL.Size = new System.Drawing.Size(129, 20);
            this.edSER_VALOR_TOTAL.TabIndex = 0;
            // 
            // groupControl10
            // 
            this.groupControl10.Controls.Add(this.cbEstagio);
            this.groupControl10.Location = new System.Drawing.Point(13, 66);
            this.groupControl10.Name = "groupControl10";
            this.groupControl10.Padding = new System.Windows.Forms.Padding(2);
            this.groupControl10.Size = new System.Drawing.Size(566, 57);
            this.groupControl10.TabIndex = 52;
            this.groupControl10.Text = "Estágio";
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
            this.cbEstagio.Size = new System.Drawing.Size(558, 31);
            this.cbEstagio.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(585, 13);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(186, 47);
            this.simpleButton1.TabIndex = 53;
            this.simpleButton1.Text = "Pesquisar";
            // 
            // SH_SERVICOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 281);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupControl10);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.groupControl1);
            this.Name = "SH_SERVICOS";
            this.ShowIcon = false;
            this.Text = "Pesquisa de Serviços";
            this.Load += new System.EventHandler(this.SH_SERVICOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CLI_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PET_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edSER_DATA_CAD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSER_DATA_CAD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edSER_VALOR_TOTAL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl10)).EndInit();
            this.groupControl10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbEstagio.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlServicos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.SimpleButton btnAlterar;
        private DevExpress.XtraEditors.SimpleButton btnInserir;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GridLookUpEdit CLI_ID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GridLookUpEdit PET_ID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.DateEdit edSER_DATA_CAD;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.TextEdit edSER_VALOR_TOTAL;
        private DevExpress.XtraEditors.GroupControl groupControl10;
        private DevExpress.XtraEditors.RadioGroup cbEstagio;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}