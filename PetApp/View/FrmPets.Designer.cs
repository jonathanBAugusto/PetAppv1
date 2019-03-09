namespace PetApp
{
    partial class FrmPets
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
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.edPET_NOME = new DevExpress.XtraEditors.TextEdit();
            this.edPET_COR = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.edCLI_ID = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.edPET_RACA = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.edPET_NAS = new DevExpress.XtraEditors.DateEdit();
            this.groupControl8 = new DevExpress.XtraEditors.GroupControl();
            this.edPET_OBS = new DevExpress.XtraEditors.MemoExEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.picPET_IMG = new DevExpress.XtraEditors.PictureEdit();
            this.edPET_IMAGEM = new DevExpress.XtraEditors.ButtonEdit();
            this.openFileDialogImg = new System.Windows.Forms.OpenFileDialog();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.edPET_NOME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPET_COR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edCLI_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edPET_RACA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edPET_NAS.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPET_NAS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).BeginInit();
            this.groupControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edPET_OBS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPET_IMG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPET_IMAGEM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(544, 23);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 117);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Cadastrar";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // edPET_NOME
            // 
            this.edPET_NOME.EnterMoveNextControl = true;
            this.edPET_NOME.Location = new System.Drawing.Point(4, 22);
            this.edPET_NOME.Margin = new System.Windows.Forms.Padding(2);
            this.edPET_NOME.Name = "edPET_NOME";
            this.edPET_NOME.Size = new System.Drawing.Size(98, 20);
            this.edPET_NOME.TabIndex = 3;
            // 
            // edPET_COR
            // 
            this.edPET_COR.EnterMoveNextControl = true;
            this.edPET_COR.Location = new System.Drawing.Point(4, 24);
            this.edPET_COR.Margin = new System.Windows.Forms.Padding(2);
            this.edPET_COR.Name = "edPET_COR";
            this.edPET_COR.Size = new System.Drawing.Size(127, 20);
            this.edPET_COR.TabIndex = 5;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(111, 24);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(20, 20);
            this.simpleButton2.TabIndex = 18;
            this.simpleButton2.TabStop = false;
            this.simpleButton2.Text = "+";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.edPET_NOME);
            this.groupControl2.Location = new System.Drawing.Point(130, 23);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(106, 48);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Nome do PET";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.edPET_COR);
            this.groupControl3.Location = new System.Drawing.Point(242, 23);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(135, 48);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Cor";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.edCLI_ID);
            this.groupControl4.Location = new System.Drawing.Point(383, 23);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Padding = new System.Windows.Forms.Padding(2);
            this.groupControl4.Size = new System.Drawing.Size(156, 48);
            this.groupControl4.TabIndex = 3;
            this.groupControl4.Text = "Dono do PET";
            // 
            // edCLI_ID
            // 
            this.edCLI_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edCLI_ID.EnterMoveNextControl = true;
            this.edCLI_ID.Location = new System.Drawing.Point(4, 22);
            this.edCLI_ID.Margin = new System.Windows.Forms.Padding(2);
            this.edCLI_ID.Name = "edCLI_ID";
            this.edCLI_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edCLI_ID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.edCLI_ID.Size = new System.Drawing.Size(148, 20);
            this.edCLI_ID.TabIndex = 15;
            this.edCLI_ID.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.edCLI_ID_ButtonClick);
            this.edCLI_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edCLI_ID_KeyDown);
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.edPET_RACA);
            this.groupControl6.Controls.Add(this.simpleButton2);
            this.groupControl6.Location = new System.Drawing.Point(242, 92);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(135, 48);
            this.groupControl6.TabIndex = 5;
            this.groupControl6.Text = "Raça";
            // 
            // edPET_RACA
            // 
            this.edPET_RACA.EnterMoveNextControl = true;
            this.edPET_RACA.Location = new System.Drawing.Point(4, 24);
            this.edPET_RACA.Name = "edPET_RACA";
            this.edPET_RACA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edPET_RACA.Properties.NullText = "";
            this.edPET_RACA.Properties.PopupView = this.gridLookUpEdit1View;
            this.edPET_RACA.Size = new System.Drawing.Size(102, 20);
            this.edPET_RACA.TabIndex = 17;
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
            this.gridColumn1.FieldName = "PET_RACA_ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nome";
            this.gridColumn2.FieldName = "PET_RACA_NOME";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // groupControl7
            // 
            this.groupControl7.Controls.Add(this.edPET_NAS);
            this.groupControl7.Location = new System.Drawing.Point(130, 92);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(106, 48);
            this.groupControl7.TabIndex = 4;
            this.groupControl7.Text = "Nascimento";
            // 
            // edPET_NAS
            // 
            this.edPET_NAS.EditValue = null;
            this.edPET_NAS.EnterMoveNextControl = true;
            this.edPET_NAS.Location = new System.Drawing.Point(6, 23);
            this.edPET_NAS.Name = "edPET_NAS";
            this.edPET_NAS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edPET_NAS.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edPET_NAS.Size = new System.Drawing.Size(95, 20);
            this.edPET_NAS.TabIndex = 0;
            // 
            // groupControl8
            // 
            this.groupControl8.Controls.Add(this.edPET_OBS);
            this.groupControl8.Location = new System.Drawing.Point(383, 92);
            this.groupControl8.Name = "groupControl8";
            this.groupControl8.Padding = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.groupControl8.Size = new System.Drawing.Size(156, 48);
            this.groupControl8.TabIndex = 6;
            this.groupControl8.Text = "Observações";
            // 
            // edPET_OBS
            // 
            this.edPET_OBS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edPET_OBS.EnterMoveNextControl = true;
            this.edPET_OBS.Location = new System.Drawing.Point(5, 24);
            this.edPET_OBS.Name = "edPET_OBS";
            this.edPET_OBS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edPET_OBS.Properties.ShowIcon = false;
            this.edPET_OBS.Size = new System.Drawing.Size(146, 20);
            this.edPET_OBS.TabIndex = 16;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.picPET_IMG);
            this.groupControl1.Controls.Add(this.edPET_IMAGEM);
            this.groupControl1.Location = new System.Drawing.Point(5, 23);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(119, 119);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Imagem";
            // 
            // picPET_IMG
            // 
            this.picPET_IMG.Cursor = System.Windows.Forms.Cursors.Default;
            this.picPET_IMG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPET_IMG.Location = new System.Drawing.Point(2, 40);
            this.picPET_IMG.Name = "picPET_IMG";
            this.picPET_IMG.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picPET_IMG.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picPET_IMG.Size = new System.Drawing.Size(115, 77);
            this.picPET_IMG.TabIndex = 0;
            this.picPET_IMG.DoubleClick += new System.EventHandler(this.PET_IMG_DoubleClick);
            // 
            // edPET_IMAGEM
            // 
            this.edPET_IMAGEM.Dock = System.Windows.Forms.DockStyle.Top;
            this.edPET_IMAGEM.EnterMoveNextControl = true;
            this.edPET_IMAGEM.Location = new System.Drawing.Point(2, 20);
            this.edPET_IMAGEM.Name = "edPET_IMAGEM";
            this.edPET_IMAGEM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.edPET_IMAGEM.Size = new System.Drawing.Size(115, 20);
            this.edPET_IMAGEM.TabIndex = 0;
            this.edPET_IMAGEM.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.edPET_IMAGEM_ButtonClick);
            this.edPET_IMAGEM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edPET_IMAGEM_KeyDown);
            // 
            // openFileDialogImg
            // 
            this.openFileDialogImg.FileName = "openFileDialog1";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.groupControl1);
            this.groupControl5.Controls.Add(this.btnAdd);
            this.groupControl5.Controls.Add(this.groupControl8);
            this.groupControl5.Controls.Add(this.groupControl2);
            this.groupControl5.Controls.Add(this.groupControl7);
            this.groupControl5.Controls.Add(this.groupControl3);
            this.groupControl5.Controls.Add(this.groupControl6);
            this.groupControl5.Controls.Add(this.groupControl4);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl5.Location = new System.Drawing.Point(0, 0);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(643, 154);
            this.groupControl5.TabIndex = 26;
            this.groupControl5.Text = "Cadastro";
            // 
            // FrmPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 154);
            this.Controls.Add(this.groupControl5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PETS";
            this.Load += new System.EventHandler(this.FrmPets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edPET_NOME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPET_COR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edCLI_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edPET_RACA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edPET_NAS.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPET_NAS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).EndInit();
            this.groupControl8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edPET_OBS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPET_IMG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPET_IMAGEM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit edPET_NOME;
        private DevExpress.XtraEditors.TextEdit edPET_COR;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private DevExpress.XtraEditors.GroupControl groupControl8;
        private DevExpress.XtraEditors.GridLookUpEdit edPET_RACA;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.DateEdit edPET_NAS;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PictureEdit picPET_IMG;
        private DevExpress.XtraEditors.ButtonEdit edPET_IMAGEM;
        private System.Windows.Forms.OpenFileDialog openFileDialogImg;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.MemoExEdit edPET_OBS;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.ButtonEdit edCLI_ID;
    }
}