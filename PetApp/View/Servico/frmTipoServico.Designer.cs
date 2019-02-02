namespace PetApp.View.Servico
{
    partial class frmTipoServico
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
            this.edTIPO_SER_NOME = new DevExpress.XtraEditors.TextEdit();
            this.edTIPO_SER_VALOR = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnRemover = new DevExpress.XtraEditors.SimpleButton();
            this.btnAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnCadastrar = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.edTIPO_SER_NOME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edTIPO_SER_VALOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // edTIPO_SER_NOME
            // 
            this.edTIPO_SER_NOME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edTIPO_SER_NOME.Location = new System.Drawing.Point(4, 22);
            this.edTIPO_SER_NOME.Name = "edTIPO_SER_NOME";
            this.edTIPO_SER_NOME.Size = new System.Drawing.Size(245, 20);
            this.edTIPO_SER_NOME.TabIndex = 0;
            // 
            // edTIPO_SER_VALOR
            // 
            this.edTIPO_SER_VALOR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edTIPO_SER_VALOR.Location = new System.Drawing.Point(4, 22);
            this.edTIPO_SER_VALOR.Name = "edTIPO_SER_VALOR";
            this.edTIPO_SER_VALOR.Properties.Mask.EditMask = "c2";
            this.edTIPO_SER_VALOR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.edTIPO_SER_VALOR.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.edTIPO_SER_VALOR.Size = new System.Drawing.Size(109, 20);
            this.edTIPO_SER_VALOR.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnRemover);
            this.groupControl1.Controls.Add(this.btnAlterar);
            this.groupControl1.Controls.Add(this.groupControl4);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.btnCadastrar);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(665, 79);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Cadastrar Tipo de serviço";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(549, 23);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 46);
            this.btnRemover.TabIndex = 8;
            this.btnRemover.Text = "Remover";
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(468, 23);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 46);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.edTIPO_SER_VALOR);
            this.groupControl4.Location = new System.Drawing.Point(264, 23);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Padding = new System.Windows.Forms.Padding(2);
            this.groupControl4.Size = new System.Drawing.Size(117, 46);
            this.groupControl4.TabIndex = 6;
            this.groupControl4.Text = "Valor Base";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.edTIPO_SER_NOME);
            this.groupControl3.Location = new System.Drawing.Point(5, 23);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Padding = new System.Windows.Forms.Padding(2);
            this.groupControl3.Size = new System.Drawing.Size(253, 46);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "Nome do serviço";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(387, 23);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 46);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 79);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(665, 371);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Listagem";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(661, 349);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Nome ";
            this.gridColumn1.FieldName = "TIPO_SER_NOME";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Valor Base";
            this.gridColumn2.FieldName = "TIPO_SER_VALOR";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // frmTipoServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmTipoServico";
            this.Text = "Tipos de serviço";
            this.Load += new System.EventHandler(this.frmTipoServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edTIPO_SER_NOME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edTIPO_SER_VALOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit edTIPO_SER_NOME;
        private DevExpress.XtraEditors.TextEdit edTIPO_SER_VALOR;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnCadastrar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnRemover;
        private DevExpress.XtraEditors.SimpleButton btnAlterar;
    }
}