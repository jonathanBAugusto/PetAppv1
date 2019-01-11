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
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition4 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan2 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan3 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement5 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement6 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement7 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.layoutViewColumn1 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gridControlPets = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.tileViewColumn1 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.PET_IMG = new DevExpress.XtraEditors.PictureEdit();
            this.edPET_NOME = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edPET_COR = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.edPET_OBS = new DevExpress.XtraEditors.TextEdit();
            this.edCLI_ID = new DevExpress.XtraEditors.LookUpEdit();
            this.edPET_RACA = new DevExpress.XtraEditors.LookUpEdit();
            this.edPET_NAS = new System.Windows.Forms.DateTimePicker();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PET_IMG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPET_NOME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPET_COR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPET_OBS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edCLI_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPET_RACA.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutViewColumn1
            // 
            this.layoutViewColumn1.Caption = "Foto";
            this.layoutViewColumn1.ColumnEdit = this.repositoryItemPictureEdit1;
            this.layoutViewColumn1.FieldName = "PET_IMG";
            this.layoutViewColumn1.Name = "layoutViewColumn1";
            this.layoutViewColumn1.Visible = true;
            this.layoutViewColumn1.VisibleIndex = 0;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "PET_ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nome do PET";
            this.gridColumn2.FieldName = "PET_NOME";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Nascimento";
            this.gridColumn3.FieldName = "PET_NAS";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Dono";
            this.gridColumn5.FieldName = "CLI_NOME";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Raça";
            this.gridColumn4.FieldName = "PET_RACA";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Observação";
            this.gridColumn6.FieldName = "PET_OBS";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            // 
            // gridControlPets
            // 
            this.gridControlPets.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlPets.Location = new System.Drawing.Point(0, 136);
            this.gridControlPets.MainView = this.tileView1;
            this.gridControlPets.Name = "gridControlPets";
            this.gridControlPets.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.repositoryItemImageEdit1});
            this.gridControlPets.Size = new System.Drawing.Size(721, 314);
            this.gridControlPets.TabIndex = 0;
            this.gridControlPets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            // 
            // tileView1
            // 
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.layoutViewColumn1,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.tileViewColumn1});
            this.tileView1.GridControl = this.gridControlPets;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tileView1.OptionsTiles.IndentBetweenGroups = 0;
            this.tileView1.OptionsTiles.IndentBetweenItems = 0;
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(456, 114);
            this.tileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.tileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileView1.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.tileView1.OptionsTiles.RowCount = 0;
            tableColumnDefinition1.Length.Value = 106D;
            tableColumnDefinition2.Length.Value = 116D;
            tableColumnDefinition3.Length.Value = 119D;
            tableColumnDefinition4.Length.Value = 91D;
            this.tileView1.TileColumns.Add(tableColumnDefinition1);
            this.tileView1.TileColumns.Add(tableColumnDefinition2);
            this.tileView1.TileColumns.Add(tableColumnDefinition3);
            this.tileView1.TileColumns.Add(tableColumnDefinition4);
            tableRowDefinition1.Length.Value = 28D;
            tableRowDefinition2.Length.Value = 36D;
            tableRowDefinition3.Length.Value = 37D;
            this.tileView1.TileRows.Add(tableRowDefinition1);
            this.tileView1.TileRows.Add(tableRowDefinition2);
            this.tileView1.TileRows.Add(tableRowDefinition3);
            tableSpan1.RowSpan = 3;
            tableSpan2.ColumnIndex = 3;
            tableSpan2.RowSpan = 3;
            tableSpan3.ColumnIndex = 1;
            tableSpan3.ColumnSpan = 2;
            this.tileView1.TileSpans.Add(tableSpan1);
            this.tileView1.TileSpans.Add(tableSpan2);
            this.tileView1.TileSpans.Add(tableSpan3);
            tileViewItemElement1.Column = this.gridColumn2;
            tileViewItemElement1.ColumnIndex = 1;
            tileViewItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement1.Text = "gridColumn2";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Column = this.gridColumn3;
            tileViewItemElement2.ColumnIndex = 1;
            tileViewItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement2.RowIndex = 1;
            tileViewItemElement2.Text = "gridColumn3";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.Column = this.gridColumn5;
            tileViewItemElement3.ColumnIndex = 2;
            tileViewItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement3.RowIndex = 1;
            tileViewItemElement3.Text = "gridColumn5";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.Column = this.gridColumn4;
            tileViewItemElement4.ColumnIndex = 1;
            tileViewItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement4.RowIndex = 2;
            tileViewItemElement4.Text = "gridColumn4";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.Column = this.gridColumn6;
            tileViewItemElement5.ColumnIndex = 3;
            tileViewItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement5.Text = "gridColumn6";
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement6.Column = this.layoutViewColumn1;
            tileViewItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement6.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement6.Text = "layoutViewColumn1";
            tileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement7.Column = this.tileViewColumn1;
            tileViewItemElement7.ColumnIndex = 2;
            tileViewItemElement7.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement7.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement7.RowIndex = 2;
            tileViewItemElement7.Text = "tileViewColumn1";
            tileViewItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView1.TileTemplate.Add(tileViewItemElement1);
            this.tileView1.TileTemplate.Add(tileViewItemElement2);
            this.tileView1.TileTemplate.Add(tileViewItemElement3);
            this.tileView1.TileTemplate.Add(tileViewItemElement4);
            this.tileView1.TileTemplate.Add(tileViewItemElement5);
            this.tileView1.TileTemplate.Add(tileViewItemElement6);
            this.tileView1.TileTemplate.Add(tileViewItemElement7);
            // 
            // tileViewColumn1
            // 
            this.tileViewColumn1.Caption = "Cor";
            this.tileViewColumn1.FieldName = "PET_COR";
            this.tileViewColumn1.Name = "tileViewColumn1";
            this.tileViewColumn1.Visible = true;
            this.tileViewColumn1.VisibleIndex = 7;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(578, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 76);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Cadastrar";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // PET_IMG
            // 
            this.PET_IMG.Cursor = System.Windows.Forms.Cursors.Default;
            this.PET_IMG.Location = new System.Drawing.Point(27, 12);
            this.PET_IMG.Name = "PET_IMG";
            this.PET_IMG.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PET_IMG.Size = new System.Drawing.Size(100, 96);
            this.PET_IMG.TabIndex = 2;
            // 
            // edPET_NOME
            // 
            this.edPET_NOME.Location = new System.Drawing.Point(133, 32);
            this.edPET_NOME.Name = "edPET_NOME";
            this.edPET_NOME.Size = new System.Drawing.Size(143, 26);
            this.edPET_NOME.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome do PET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cor";
            // 
            // edPET_COR
            // 
            this.edPET_COR.Location = new System.Drawing.Point(133, 82);
            this.edPET_COR.Name = "edPET_COR";
            this.edPET_COR.Size = new System.Drawing.Size(143, 26);
            this.edPET_COR.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dono do PET";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Raça";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nascimento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Observações";
            // 
            // edPET_OBS
            // 
            this.edPET_OBS.Location = new System.Drawing.Point(429, 82);
            this.edPET_OBS.Name = "edPET_OBS";
            this.edPET_OBS.Size = new System.Drawing.Size(143, 26);
            this.edPET_OBS.TabIndex = 13;
            // 
            // edCLI_ID
            // 
            this.edCLI_ID.Location = new System.Drawing.Point(280, 32);
            this.edCLI_ID.Name = "edCLI_ID";
            this.edCLI_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edCLI_ID.Size = new System.Drawing.Size(143, 26);
            this.edCLI_ID.TabIndex = 15;
            // 
            // edPET_RACA
            // 
            this.edPET_RACA.Location = new System.Drawing.Point(282, 82);
            this.edPET_RACA.Name = "edPET_RACA";
            this.edPET_RACA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edPET_RACA.Size = new System.Drawing.Size(111, 26);
            this.edPET_RACA.TabIndex = 16;
            // 
            // edPET_NAS
            // 
            this.edPET_NAS.Location = new System.Drawing.Point(429, 32);
            this.edPET_NAS.Name = "edPET_NAS";
            this.edPET_NAS.Size = new System.Drawing.Size(143, 26);
            this.edPET_NAS.TabIndex = 17;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(399, 82);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(23, 26);
            this.simpleButton2.TabIndex = 18;
            this.simpleButton2.Text = "+";
            // 
            // FrmPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.edPET_NAS);
            this.Controls.Add(this.edPET_RACA);
            this.Controls.Add(this.edCLI_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edPET_OBS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edPET_COR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edPET_NOME);
            this.Controls.Add(this.PET_IMG);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridControlPets);
            this.Name = "FrmPets";
            this.Text = "PETS";
            this.Load += new System.EventHandler(this.FrmPets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PET_IMG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPET_NOME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPET_COR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPET_OBS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edCLI_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPET_RACA.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlPets;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Columns.TileViewColumn layoutViewColumn1;
        private DevExpress.XtraGrid.Columns.TileViewColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.TileViewColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.TileViewColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.TileViewColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.TileViewColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.TileViewColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.PictureEdit PET_IMG;
        private DevExpress.XtraEditors.TextEdit edPET_NOME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit edPET_COR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit edPET_OBS;
        private DevExpress.XtraEditors.LookUpEdit edCLI_ID;
        private DevExpress.XtraEditors.LookUpEdit edPET_RACA;
        private System.Windows.Forms.DateTimePicker edPET_NAS;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn1;
    }
}