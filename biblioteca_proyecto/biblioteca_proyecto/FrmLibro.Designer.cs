namespace biblioteca_proyecto
{
    partial class FrmLibro
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLibro));
            tabControl1 = new TabControl();
            TpAltaLibro = new TabPage();
            PbUbicacion = new PictureBox();
            MtbIdLibro = new MaskedTextBox();
            BtnAgragar = new PictureBox();
            groupBox1 = new GroupBox();
            RbAlmacen = new RadioButton();
            RbSala = new RadioButton();
            TbTitulo = new TextBox();
            LbUbicacion = new Label();
            LbIdLibro = new Label();
            LbNombreLibr = new Label();
            TpListar = new TabPage();
            PbBorr = new PictureBox();
            LvListar = new ListView();
            id = new ColumnHeader();
            titulo = new ColumnHeader();
            ubicacion = new ColumnHeader();
            CbUbi = new ComboBox();
            TpBuscar = new TabPage();
            PbModif = new PictureBox();
            mskTbIdBusc = new MaskedTextBox();
            groupBox2 = new GroupBox();
            RbAlmaBusc = new RadioButton();
            RbSalaBusc = new RadioButton();
            TbtituloBusc = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            PbBusc = new PictureBox();
            BtnBusc = new Button();
            TxtBusc = new TextBox();
            EpLibro = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            TpAltaLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbUbicacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnAgragar).BeginInit();
            groupBox1.SuspendLayout();
            TpListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbBorr).BeginInit();
            TpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbModif).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbBusc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EpLibro).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TpAltaLibro);
            tabControl1.Controls.Add(TpListar);
            tabControl1.Controls.Add(TpBuscar);
            tabControl1.Location = new Point(2, -4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(796, 458);
            tabControl1.TabIndex = 11;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // TpAltaLibro
            // 
            TpAltaLibro.Controls.Add(PbUbicacion);
            TpAltaLibro.Controls.Add(MtbIdLibro);
            TpAltaLibro.Controls.Add(BtnAgragar);
            TpAltaLibro.Controls.Add(groupBox1);
            TpAltaLibro.Controls.Add(TbTitulo);
            TpAltaLibro.Controls.Add(LbUbicacion);
            TpAltaLibro.Controls.Add(LbIdLibro);
            TpAltaLibro.Controls.Add(LbNombreLibr);
            TpAltaLibro.Location = new Point(4, 24);
            TpAltaLibro.Name = "TpAltaLibro";
            TpAltaLibro.Padding = new Padding(3);
            TpAltaLibro.Size = new Size(788, 430);
            TpAltaLibro.TabIndex = 0;
            TpAltaLibro.Text = "Alta";
            TpAltaLibro.UseVisualStyleBackColor = true;
            TpAltaLibro.Click += TpAltaLibro_Click;
            // 
            // PbUbicacion
            // 
            PbUbicacion.Location = new Point(396, 18);
            PbUbicacion.Name = "PbUbicacion";
            PbUbicacion.Size = new Size(368, 402);
            PbUbicacion.SizeMode = PictureBoxSizeMode.StretchImage;
            PbUbicacion.TabIndex = 20;
            PbUbicacion.TabStop = false;
            // 
            // MtbIdLibro
            // 
            MtbIdLibro.Location = new Point(154, 164);
            MtbIdLibro.Mask = "9999";
            MtbIdLibro.Name = "MtbIdLibro";
            MtbIdLibro.Size = new Size(200, 23);
            MtbIdLibro.TabIndex = 19;
            MtbIdLibro.ValidatingType = typeof(int);
            MtbIdLibro.Validated += MtbIdLibro_Validated;
            // 
            // BtnAgragar
            // 
            BtnAgragar.Image = (Image)resources.GetObject("BtnAgragar.Image");
            BtnAgragar.Location = new Point(16, 27);
            BtnAgragar.Name = "BtnAgragar";
            BtnAgragar.Size = new Size(30, 30);
            BtnAgragar.SizeMode = PictureBoxSizeMode.StretchImage;
            BtnAgragar.TabIndex = 18;
            BtnAgragar.TabStop = false;
            BtnAgragar.Click += BtnAgragar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RbAlmacen);
            groupBox1.Controls.Add(RbSala);
            groupBox1.Location = new Point(154, 234);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // RbAlmacen
            // 
            RbAlmacen.AutoSize = true;
            RbAlmacen.Checked = true;
            RbAlmacen.Location = new Point(20, 60);
            RbAlmacen.Name = "RbAlmacen";
            RbAlmacen.Size = new Size(72, 19);
            RbAlmacen.TabIndex = 1;
            RbAlmacen.TabStop = true;
            RbAlmacen.Text = "Almacen";
            RbAlmacen.UseVisualStyleBackColor = true;
            RbAlmacen.CheckedChanged += RbSala_CheckedChanged;
            // 
            // RbSala
            // 
            RbSala.AutoSize = true;
            RbSala.Location = new Point(20, 22);
            RbSala.Name = "RbSala";
            RbSala.Size = new Size(46, 19);
            RbSala.TabIndex = 0;
            RbSala.TabStop = true;
            RbSala.Text = "Sala";
            RbSala.UseVisualStyleBackColor = true;
            RbSala.CheckedChanged += RbSala_CheckedChanged;
            // 
            // TbTitulo
            // 
            TbTitulo.Location = new Point(154, 99);
            TbTitulo.Name = "TbTitulo";
            TbTitulo.Size = new Size(200, 23);
            TbTitulo.TabIndex = 14;
            TbTitulo.Validated += TbTitulo_Validated;
            // 
            // LbUbicacion
            // 
            LbUbicacion.AutoSize = true;
            LbUbicacion.Location = new Point(19, 237);
            LbUbicacion.Name = "LbUbicacion";
            LbUbicacion.Size = new Size(60, 15);
            LbUbicacion.TabIndex = 13;
            LbUbicacion.Text = "Ubicacion";
            // 
            // LbIdLibro
            // 
            LbIdLibro.AutoSize = true;
            LbIdLibro.Location = new Point(19, 175);
            LbIdLibro.Name = "LbIdLibro";
            LbIdLibro.Size = new Size(74, 15);
            LbIdLibro.TabIndex = 12;
            LbIdLibro.Text = "Identificador";
            // 
            // LbNombreLibr
            // 
            LbNombreLibr.AutoSize = true;
            LbNombreLibr.Location = new Point(19, 110);
            LbNombreLibr.Name = "LbNombreLibr";
            LbNombreLibr.Size = new Size(38, 15);
            LbNombreLibr.TabIndex = 10;
            LbNombreLibr.Text = "Titulo";
            // 
            // TpListar
            // 
            TpListar.Controls.Add(PbBorr);
            TpListar.Controls.Add(LvListar);
            TpListar.Controls.Add(CbUbi);
            TpListar.Location = new Point(4, 24);
            TpListar.Name = "TpListar";
            TpListar.Padding = new Padding(3);
            TpListar.Size = new Size(788, 430);
            TpListar.TabIndex = 1;
            TpListar.Text = "Listado";
            TpListar.UseVisualStyleBackColor = true;
            // 
            // PbBorr
            // 
            PbBorr.Image = (Image)resources.GetObject("PbBorr.Image");
            PbBorr.Location = new Point(702, 16);
            PbBorr.Name = "PbBorr";
            PbBorr.Size = new Size(44, 49);
            PbBorr.SizeMode = PictureBoxSizeMode.StretchImage;
            PbBorr.TabIndex = 23;
            PbBorr.TabStop = false;
            // 
            // LvListar
            // 
            LvListar.Columns.AddRange(new ColumnHeader[] { id, titulo, ubicacion });
            LvListar.Location = new Point(6, 82);
            LvListar.Name = "LvListar";
            LvListar.Size = new Size(776, 336);
            LvListar.TabIndex = 22;
            LvListar.UseCompatibleStateImageBehavior = false;
            LvListar.View = View.Details;
            // 
            // id
            // 
            id.Text = "ID";
            // 
            // titulo
            // 
            titulo.Text = "Titulo";
            titulo.Width = 180;
            // 
            // ubicacion
            // 
            ubicacion.Text = "Ubicacion";
            ubicacion.Width = 120;
            // 
            // CbUbi
            // 
            CbUbi.FormattingEnabled = true;
            CbUbi.Items.AddRange(new object[] { "sala", "almacen" });
            CbUbi.Location = new Point(6, 30);
            CbUbi.Name = "CbUbi";
            CbUbi.Size = new Size(262, 23);
            CbUbi.TabIndex = 21;
            CbUbi.SelectedIndexChanged += CbUbi_SelectedIndexChanged;
            // 
            // TpBuscar
            // 
            TpBuscar.Controls.Add(PbModif);
            TpBuscar.Controls.Add(mskTbIdBusc);
            TpBuscar.Controls.Add(groupBox2);
            TpBuscar.Controls.Add(TbtituloBusc);
            TpBuscar.Controls.Add(label1);
            TpBuscar.Controls.Add(label2);
            TpBuscar.Controls.Add(label3);
            TpBuscar.Controls.Add(PbBusc);
            TpBuscar.Controls.Add(BtnBusc);
            TpBuscar.Controls.Add(TxtBusc);
            TpBuscar.Location = new Point(4, 24);
            TpBuscar.Name = "TpBuscar";
            TpBuscar.Padding = new Padding(3);
            TpBuscar.Size = new Size(788, 430);
            TpBuscar.TabIndex = 2;
            TpBuscar.Text = "Buscar";
            TpBuscar.UseVisualStyleBackColor = true;
            // 
            // PbModif
            // 
            PbModif.Image = (Image)resources.GetObject("PbModif.Image");
            PbModif.Location = new Point(37, 366);
            PbModif.Name = "PbModif";
            PbModif.Size = new Size(41, 42);
            PbModif.SizeMode = PictureBoxSizeMode.StretchImage;
            PbModif.TabIndex = 42;
            PbModif.TabStop = false;
            // 
            // mskTbIdBusc
            // 
            mskTbIdBusc.Location = new Point(162, 152);
            mskTbIdBusc.Mask = "99999";
            mskTbIdBusc.Name = "mskTbIdBusc";
            mskTbIdBusc.Size = new Size(200, 23);
            mskTbIdBusc.TabIndex = 41;
            mskTbIdBusc.ValidatingType = typeof(int);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RbAlmaBusc);
            groupBox2.Controls.Add(RbSalaBusc);
            groupBox2.Location = new Point(162, 222);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 40;
            groupBox2.TabStop = false;
            // 
            // RbAlmaBusc
            // 
            RbAlmaBusc.AutoSize = true;
            RbAlmaBusc.Checked = true;
            RbAlmaBusc.Location = new Point(20, 60);
            RbAlmaBusc.Name = "RbAlmaBusc";
            RbAlmaBusc.Size = new Size(72, 19);
            RbAlmaBusc.TabIndex = 1;
            RbAlmaBusc.TabStop = true;
            RbAlmaBusc.Text = "Almacen";
            RbAlmaBusc.UseVisualStyleBackColor = true;
            // 
            // RbSalaBusc
            // 
            RbSalaBusc.AutoSize = true;
            RbSalaBusc.Location = new Point(20, 22);
            RbSalaBusc.Name = "RbSalaBusc";
            RbSalaBusc.Size = new Size(46, 19);
            RbSalaBusc.TabIndex = 0;
            RbSalaBusc.TabStop = true;
            RbSalaBusc.Text = "Sala";
            RbSalaBusc.UseVisualStyleBackColor = true;
            RbSalaBusc.CheckedChanged += RbSalaBusc_CheckedChanged;
            // 
            // TbtituloBusc
            // 
            TbtituloBusc.Location = new Point(162, 87);
            TbtituloBusc.Name = "TbtituloBusc";
            TbtituloBusc.Size = new Size(200, 23);
            TbtituloBusc.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 225);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 38;
            label1.Text = "Ubicacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 163);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 37;
            label2.Text = "Identificador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 98);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 36;
            label3.Text = "Titulo";
            // 
            // PbBusc
            // 
            PbBusc.Location = new Point(404, 6);
            PbBusc.Name = "PbBusc";
            PbBusc.Size = new Size(368, 402);
            PbBusc.SizeMode = PictureBoxSizeMode.StretchImage;
            PbBusc.TabIndex = 35;
            PbBusc.TabStop = false;
            // 
            // BtnBusc
            // 
            BtnBusc.Location = new Point(166, 19);
            BtnBusc.Name = "BtnBusc";
            BtnBusc.Size = new Size(75, 23);
            BtnBusc.TabIndex = 34;
            BtnBusc.Text = "Buscar";
            BtnBusc.UseVisualStyleBackColor = true;
            // 
            // TxtBusc
            // 
            TxtBusc.Location = new Point(6, 19);
            TxtBusc.Name = "TxtBusc";
            TxtBusc.Size = new Size(154, 23);
            TxtBusc.TabIndex = 33;
            // 
            // EpLibro
            // 
            EpLibro.ContainerControl = this;
            // 
            // FrmLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "FrmLibro";
            Text = "FrmLibro";
            tabControl1.ResumeLayout(false);
            TpAltaLibro.ResumeLayout(false);
            TpAltaLibro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbUbicacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnAgragar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            TpListar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PbBorr).EndInit();
            TpBuscar.ResumeLayout(false);
            TpBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbModif).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbBusc).EndInit();
            ((System.ComponentModel.ISupportInitialize)EpLibro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage TpAltaLibro;
        private PictureBox PbUbicacion;
        private MaskedTextBox MtbIdLibro;
        private PictureBox BtnAgragar;
        private GroupBox groupBox1;
        private RadioButton RbEstudinte;
        private RadioButton RbPas;
        private RadioButton RbAlmacen;
        private RadioButton RbSala;
        private TextBox TbTitulo;
        private Label LbUbicacion;
        private Label LbIdLibro;
        private Label LbNombreLibr;
        private TabPage TpListar;
        private TabPage TpBuscar;
        private ComboBox CbUbi;
        private ListView LvListar;
        private ColumnHeader id;
        private ColumnHeader titulo;
        private ColumnHeader ubicacion;
        private PictureBox PbBorr;
        private Button BtnBusc;
        private TextBox TxtBusc;
        private PictureBox PbBusc;
        private MaskedTextBox mskTbIdBusc;
        private GroupBox groupBox2;
        private RadioButton RbAlmaBusc;
        private RadioButton RbSalaBusc;
        private TextBox TbtituloBusc;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox PbModif;
        private ErrorProvider EpLibro;
    }
}