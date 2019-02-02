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
            this.gridControlProdutos = new DevExpress.XtraGrid.GridControl();
            this.gridViewProdutos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pcTop = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.edDATAFIN = new DevExpress.XtraEditors.DateEdit();
            this.edDATAINI = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pcImg = new DevExpress.XtraEditors.PictureEdit();
            this.btnPesquisar = new DevExpress.XtraEditors.SimpleButton();
            this.gpRef = new DevExpress.XtraEditors.GroupControl();
            this.edCLI_ID = new DevExpress.XtraEditors.TextEdit();
            this.gpFor = new DevExpress.XtraEditors.GroupControl();
            this.edPRO_FORNECEDOR = new DevExpress.XtraEditors.TextEdit();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBottom)).BeginInit();
            this.pcBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcTop)).BeginInit();
            this.pcTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_FORNECEDOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
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
            this.pcBottom.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(282, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(189, 7);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            // 
            // gridControlProdutos
            // 
            this.gridControlProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProdutos.Location = new System.Drawing.Point(0, 113);
            this.gridControlProdutos.MainView = this.gridViewProdutos;
            this.gridControlProdutos.Name = "gridControlProdutos";
            this.gridControlProdutos.Size = new System.Drawing.Size(780, 266);
            this.gridControlProdutos.TabIndex = 2;
            this.gridControlProdutos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProdutos});
            // 
            // gridViewProdutos
            // 
            this.gridViewProdutos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridViewProdutos.GridControl = this.gridControlProdutos;
            this.gridViewProdutos.Name = "gridViewProdutos";
            this.gridViewProdutos.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "gridColumn3";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "gridColumn4";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "gridColumn5";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "gridColumn6";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // pcTop
            // 
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
            this.pcTop.TabIndex = 4;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.radioGroup1);
            this.groupControl2.Controls.Add(this.edDATAFIN);
            this.groupControl2.Controls.Add(this.edDATAINI);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Location = new System.Drawing.Point(111, 5);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Padding = new System.Windows.Forms.Padding(2);
            this.groupControl2.Size = new System.Drawing.Size(178, 100);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "Período";
            // 
            // edDATAFIN
            // 
            this.edDATAFIN.EditValue = null;
            this.edDATAFIN.Location = new System.Drawing.Point(99, 67);
            this.edDATAFIN.Name = "edDATAFIN";
            this.edDATAFIN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edDATAFIN.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edDATAFIN.Size = new System.Drawing.Size(70, 20);
            this.edDATAFIN.TabIndex = 13;
            // 
            // edDATAINI
            // 
            this.edDATAINI.EditValue = null;
            this.edDATAINI.Location = new System.Drawing.Point(99, 22);
            this.edDATAINI.Name = "edDATAINI";
            this.edDATAINI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edDATAINI.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edDATAINI.Size = new System.Drawing.Size(70, 20);
            this.edDATAINI.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(99, 48);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(17, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Até";
            // 
            // pcImg
            // 
            this.pcImg.Cursor = System.Windows.Forms.Cursors.Default;
            this.pcImg.Location = new System.Drawing.Point(5, 5);
            this.pcImg.Name = "pcImg";
            this.pcImg.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pcImg.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pcImg.Size = new System.Drawing.Size(100, 100);
            this.pcImg.TabIndex = 10;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(555, 58);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 47);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            // 
            // gpRef
            // 
            this.gpRef.Controls.Add(this.edCLI_ID);
            this.gpRef.Location = new System.Drawing.Point(295, 5);
            this.gpRef.Name = "gpRef";
            this.gpRef.Padding = new System.Windows.Forms.Padding(2);
            this.gpRef.Size = new System.Drawing.Size(75, 47);
            this.gpRef.TabIndex = 5;
            this.gpRef.Text = "ID";
            // 
            // edCLI_ID
            // 
            this.edCLI_ID.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.gpFor.Controls.Add(this.edPRO_FORNECEDOR);
            this.gpFor.Location = new System.Drawing.Point(506, 5);
            this.gpFor.Name = "gpFor";
            this.gpFor.Padding = new System.Windows.Forms.Padding(2);
            this.gpFor.Size = new System.Drawing.Size(124, 47);
            this.gpFor.TabIndex = 6;
            this.gpFor.Text = "CNPJ/CPF";
            // 
            // edPRO_FORNECEDOR
            // 
            this.edPRO_FORNECEDOR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edPRO_FORNECEDOR.Location = new System.Drawing.Point(4, 22);
            this.edPRO_FORNECEDOR.Name = "edPRO_FORNECEDOR";
            this.edPRO_FORNECEDOR.Properties.Mask.EditMask = "\\d+";
            this.edPRO_FORNECEDOR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.edPRO_FORNECEDOR.Properties.Mask.ShowPlaceHolders = false;
            this.edPRO_FORNECEDOR.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.edPRO_FORNECEDOR.Size = new System.Drawing.Size(116, 20);
            this.edPRO_FORNECEDOR.TabIndex = 0;
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(7, 22);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("CLI_DATA_CADASTRO", "Cadastro"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("CLI_NASC", "Nascimento")});
            this.radioGroup1.Size = new System.Drawing.Size(86, 71);
            this.radioGroup1.TabIndex = 14;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Location = new System.Drawing.Point(295, 58);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(2);
            this.groupControl1.Size = new System.Drawing.Size(124, 47);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "IE/RG";
            // 
            // textEdit1
            // 
            this.textEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEdit1.Location = new System.Drawing.Point(4, 22);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Mask.EditMask = "\\d+";
            this.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEdit1.Properties.Mask.ShowPlaceHolders = false;
            this.textEdit1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.textEdit1.Size = new System.Drawing.Size(116, 20);
            this.textEdit1.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.textEdit2);
            this.groupControl3.Location = new System.Drawing.Point(376, 5);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Padding = new System.Windows.Forms.Padding(2);
            this.groupControl3.Size = new System.Drawing.Size(124, 47);
            this.groupControl3.TabIndex = 8;
            this.groupControl3.Text = "Razão Social";
            // 
            // textEdit2
            // 
            this.textEdit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEdit2.Location = new System.Drawing.Point(4, 22);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Mask.EditMask = "\\d+";
            this.textEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEdit2.Properties.Mask.ShowPlaceHolders = false;
            this.textEdit2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.textEdit2.Size = new System.Drawing.Size(116, 20);
            this.textEdit2.TabIndex = 0;
            // 
            // FrmSelectCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 417);
            this.Controls.Add(this.gridControlProdutos);
            this.Controls.Add(this.pcTop);
            this.Controls.Add(this.pcBottom);
            this.Name = "FrmSelectCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cliente/Fornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.pcBottom)).EndInit();
            this.pcBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcTop)).EndInit();
            this.pcTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.edPRO_FORNECEDOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl pcBottom;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraGrid.GridControl gridControlProdutos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProdutos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
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
        private DevExpress.XtraEditors.TextEdit edPRO_FORNECEDOR;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}