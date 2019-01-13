namespace PetApp
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.acInicio = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement8 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement9 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.iSlider = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.acInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // acInicio
            // 
            this.acInicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.acInicio.Dock = System.Windows.Forms.DockStyle.Left;
            this.acInicio.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement2,
            this.accordionControlElement3,
            this.accordionControlElement4,
            this.accordionControlElement6});
            this.acInicio.Location = new System.Drawing.Point(0, 0);
            this.acInicio.Name = "acInicio";
            this.acInicio.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Auto;
            this.acInicio.Size = new System.Drawing.Size(159, 363);
            this.acInicio.TabIndex = 0;
            this.acInicio.Text = "accordionControl1";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement2.Text = "Clientes";
            this.accordionControlElement2.Click += new System.EventHandler(this.accordionControlElement2_Click);
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement3.Text = "Serviços";
            this.accordionControlElement3.Click += new System.EventHandler(this.accordionControlElement3_Click);
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement4.Text = "Pets";
            this.accordionControlElement4.Click += new System.EventHandler(this.accordionControlElement4_Click);
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement7,
            this.accordionControlElement8,
            this.accordionControlElement9,
            this.accordionControlElement1});
            this.accordionControlElement6.Expanded = true;
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Text = "Cadastros";
            // 
            // accordionControlElement7
            // 
            this.accordionControlElement7.Name = "accordionControlElement7";
            this.accordionControlElement7.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement7.Text = "Clientes";
            this.accordionControlElement7.Click += new System.EventHandler(this.accordionControlElement7_Click);
            // 
            // accordionControlElement8
            // 
            this.accordionControlElement8.Name = "accordionControlElement8";
            this.accordionControlElement8.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement8.Text = "Pets";
            this.accordionControlElement8.Click += new System.EventHandler(this.accordionControlElement8_Click);
            // 
            // accordionControlElement9
            // 
            this.accordionControlElement9.Name = "accordionControlElement9";
            this.accordionControlElement9.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement9.Text = "Tipos de serviço";
            this.accordionControlElement9.Click += new System.EventHandler(this.accordionControlElement9_Click);
            // 
            // iSlider
            // 
            this.iSlider.CurrentImageIndex = 0;
            this.iSlider.Cursor = System.Windows.Forms.Cursors.Default;
            this.iSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iSlider.Images.Add(((System.Drawing.Image)(resources.GetObject("iSlider.Images"))));
            this.iSlider.Images.Add(((System.Drawing.Image)(resources.GetObject("iSlider.Images1"))));
            this.iSlider.Location = new System.Drawing.Point(159, 0);
            this.iSlider.Name = "iSlider";
            this.iSlider.Size = new System.Drawing.Size(481, 363);
            this.iSlider.TabIndex = 1;
            this.iSlider.Text = "imageSlider1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 343);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(481, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement5.Text = "Cadastros";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::PetApp.Properties.Resources.s;
            this.pictureBox1.InitialImage = global::PetApp.Properties.Resources.s;
            this.pictureBox1.Location = new System.Drawing.Point(159, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement1.Text = "Produtos";
            this.accordionControlElement1.Click += new System.EventHandler(this.accordionControlElement1_Click_1);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(640, 363);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.iSlider);
            this.Controls.Add(this.acInicio);
            this.IsMdiContainer = true;
            this.Name = "FrmInicio";
            this.Text = "PetShop";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.acInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl acInicio;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraEditors.Controls.ImageSlider iSlider;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement8;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
    }
}

