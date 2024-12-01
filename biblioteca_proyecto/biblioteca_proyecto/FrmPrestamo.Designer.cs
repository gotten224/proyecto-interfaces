namespace biblioteca_proyecto
{
    partial class FrmPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrestamo));
            tabControl1 = new TabControl();
            TpAlta = new TabPage();
            PbTipo = new PictureBox();
            BtnAgregar = new PictureBox();
            groupBox1 = new GroupBox();
            RbDevolucion = new RadioButton();
            RbPrestamo = new RadioButton();
            TxtIsbn = new TextBox();
            TbNombre = new TextBox();
            LbTipo = new Label();
            LbDepart = new Label();
            LbNombre = new Label();
            TpListar = new TabPage();
            BtnBusc = new Button();
            TxtBusc = new TextBox();
            CbBuscar = new ComboBox();
            PbBorr = new PictureBox();
            LvListar = new ListView();
            Columna1 = new ColumnHeader();
            Columna2 = new ColumnHeader();
            Columna3 = new ColumnHeader();
            columna4 = new ColumnHeader();
            TpBuscar = new TabPage();
            PbModif = new PictureBox();
            groupBox2 = new GroupBox();
            RbDevBusc = new RadioButton();
            RbPrestBusc = new RadioButton();
            TxtIsbnBusc = new TextBox();
            TxtNomBusc = new TextBox();
            PbBusc = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            epTransacciones = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            TpAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbTipo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnAgregar).BeginInit();
            groupBox1.SuspendLayout();
            TpListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbBorr).BeginInit();
            TpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbModif).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbBusc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epTransacciones).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TpAlta);
            tabControl1.Controls.Add(TpListar);
            tabControl1.Controls.Add(TpBuscar);
            tabControl1.Location = new Point(2, -4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(796, 458);
            tabControl1.TabIndex = 11;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // TpAlta
            // 
            TpAlta.Controls.Add(PbTipo);
            TpAlta.Controls.Add(BtnAgregar);
            TpAlta.Controls.Add(groupBox1);
            TpAlta.Controls.Add(TxtIsbn);
            TpAlta.Controls.Add(TbNombre);
            TpAlta.Controls.Add(LbTipo);
            TpAlta.Controls.Add(LbDepart);
            TpAlta.Controls.Add(LbNombre);
            TpAlta.Location = new Point(4, 24);
            TpAlta.Name = "TpAlta";
            TpAlta.Padding = new Padding(3);
            TpAlta.Size = new Size(788, 430);
            TpAlta.TabIndex = 0;
            TpAlta.Text = "Alta";
            TpAlta.UseVisualStyleBackColor = true;
            // 
            // PbTipo
            // 
            PbTipo.Location = new Point(396, 18);
            PbTipo.Name = "PbTipo";
            PbTipo.Size = new Size(368, 402);
            PbTipo.SizeMode = PictureBoxSizeMode.StretchImage;
            PbTipo.TabIndex = 20;
            PbTipo.TabStop = false;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Image = (Image)resources.GetObject("BtnAgregar.Image");
            BtnAgregar.Location = new Point(16, 27);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(30, 30);
            BtnAgregar.SizeMode = PictureBoxSizeMode.StretchImage;
            BtnAgregar.TabIndex = 18;
            BtnAgregar.TabStop = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RbDevolucion);
            groupBox1.Controls.Add(RbPrestamo);
            groupBox1.Location = new Point(154, 237);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 70);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // RbDevolucion
            // 
            RbDevolucion.AutoSize = true;
            RbDevolucion.Location = new Point(20, 41);
            RbDevolucion.Name = "RbDevolucion";
            RbDevolucion.Size = new Size(85, 19);
            RbDevolucion.TabIndex = 1;
            RbDevolucion.Text = "Devolucion";
            RbDevolucion.UseVisualStyleBackColor = true;
            RbDevolucion.CheckedChanged += Rbtipo_CheckedChanged;
            // 
            // RbPrestamo
            // 
            RbPrestamo.AutoSize = true;
            RbPrestamo.Location = new Point(20, 16);
            RbPrestamo.Name = "RbPrestamo";
            RbPrestamo.Size = new Size(75, 19);
            RbPrestamo.TabIndex = 0;
            RbPrestamo.Text = "Prestamo";
            RbPrestamo.UseVisualStyleBackColor = true;
            RbPrestamo.CheckedChanged += Rbtipo_CheckedChanged;
            // 
            // TxtIsbn
            // 
            TxtIsbn.Location = new Point(154, 145);
            TxtIsbn.Name = "TxtIsbn";
            TxtIsbn.Size = new Size(200, 23);
            TxtIsbn.TabIndex = 16;
            TxtIsbn.Validated += TxtIsbn_Validated;
            // 
            // TbNombre
            // 
            TbNombre.Location = new Point(154, 107);
            TbNombre.Name = "TbNombre";
            TbNombre.Size = new Size(200, 23);
            TbNombre.TabIndex = 14;
            TbNombre.Validating += TbNombre_Validating;
            // 
            // LbTipo
            // 
            LbTipo.AutoSize = true;
            LbTipo.Location = new Point(19, 237);
            LbTipo.Name = "LbTipo";
            LbTipo.Size = new Size(31, 15);
            LbTipo.TabIndex = 13;
            LbTipo.Text = "Tipo";
            // 
            // LbDepart
            // 
            LbDepart.AutoSize = true;
            LbDepart.Location = new Point(19, 148);
            LbDepart.Name = "LbDepart";
            LbDepart.Size = new Size(59, 15);
            LbDepart.TabIndex = 11;
            LbDepart.Text = "ISBN libro";
            // 
            // LbNombre
            // 
            LbNombre.AutoSize = true;
            LbNombre.Location = new Point(19, 110);
            LbNombre.Name = "LbNombre";
            LbNombre.Size = new Size(51, 15);
            LbNombre.TabIndex = 10;
            LbNombre.Text = "Nombre";
            // 
            // TpListar
            // 
            TpListar.Controls.Add(BtnBusc);
            TpListar.Controls.Add(TxtBusc);
            TpListar.Controls.Add(CbBuscar);
            TpListar.Controls.Add(PbBorr);
            TpListar.Controls.Add(LvListar);
            TpListar.Location = new Point(4, 24);
            TpListar.Name = "TpListar";
            TpListar.Padding = new Padding(3);
            TpListar.Size = new Size(788, 430);
            TpListar.TabIndex = 1;
            TpListar.Text = "Listado";
            TpListar.UseVisualStyleBackColor = true;
            // 
            // BtnBusc
            // 
            BtnBusc.Location = new Point(487, 29);
            BtnBusc.Name = "BtnBusc";
            BtnBusc.Size = new Size(75, 23);
            BtnBusc.TabIndex = 34;
            BtnBusc.Text = "Buscar";
            BtnBusc.UseVisualStyleBackColor = true;
            BtnBusc.Click += BtnBusc_Click;
            // 
            // TxtBusc
            // 
            TxtBusc.Location = new Point(327, 29);
            TxtBusc.Name = "TxtBusc";
            TxtBusc.Size = new Size(154, 23);
            TxtBusc.TabIndex = 33;
            // 
            // CbBuscar
            // 
            CbBuscar.FormattingEnabled = true;
            CbBuscar.Items.AddRange(new object[] { "Tipo de movimiento", "Titulo", "Usuario", "Fecha", "Departamento" });
            CbBuscar.Location = new Point(10, 29);
            CbBuscar.Name = "CbBuscar";
            CbBuscar.Size = new Size(262, 23);
            CbBuscar.TabIndex = 20;
            // 
            // PbBorr
            // 
            PbBorr.Image = (Image)resources.GetObject("PbBorr.Image");
            PbBorr.Location = new Point(649, 17);
            PbBorr.Name = "PbBorr";
            PbBorr.Size = new Size(44, 49);
            PbBorr.SizeMode = PictureBoxSizeMode.StretchImage;
            PbBorr.TabIndex = 19;
            PbBorr.TabStop = false;
            // 
            // LvListar
            // 
            LvListar.Columns.AddRange(new ColumnHeader[] { Columna1, Columna2, Columna3, columna4 });
            LvListar.Location = new Point(6, 84);
            LvListar.Name = "LvListar";
            LvListar.Size = new Size(776, 336);
            LvListar.TabIndex = 0;
            LvListar.UseCompatibleStateImageBehavior = false;
            LvListar.View = View.Details;
            LvListar.DoubleClick += LvListar_DoubleClick;
            // 
            // Columna1
            // 
            Columna1.Text = "Tipo";
            Columna1.Width = 120;
            // 
            // Columna2
            // 
            Columna2.Text = "Libro";
            Columna2.Width = 180;
            // 
            // Columna3
            // 
            Columna3.Text = "Persona";
            Columna3.Width = 120;
            // 
            // columna4
            // 
            columna4.Text = "Fecha Devolucion";
            columna4.Width = 240;
            // 
            // TpBuscar
            // 
            TpBuscar.Controls.Add(PbModif);
            TpBuscar.Controls.Add(groupBox2);
            TpBuscar.Controls.Add(TxtIsbnBusc);
            TpBuscar.Controls.Add(TxtNomBusc);
            TpBuscar.Controls.Add(PbBusc);
            TpBuscar.Controls.Add(label1);
            TpBuscar.Controls.Add(label4);
            TpBuscar.Controls.Add(label3);
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
            PbModif.Location = new Point(23, 367);
            PbModif.Name = "PbModif";
            PbModif.Size = new Size(41, 42);
            PbModif.SizeMode = PictureBoxSizeMode.StretchImage;
            PbModif.TabIndex = 33;
            PbModif.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RbDevBusc);
            groupBox2.Controls.Add(RbPrestBusc);
            groupBox2.Location = new Point(158, 250);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 70);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            // 
            // RbDevBusc
            // 
            RbDevBusc.AutoSize = true;
            RbDevBusc.Location = new Point(20, 41);
            RbDevBusc.Name = "RbDevBusc";
            RbDevBusc.Size = new Size(85, 19);
            RbDevBusc.TabIndex = 1;
            RbDevBusc.Text = "Devolucion";
            RbDevBusc.UseVisualStyleBackColor = true;
            RbDevBusc.CheckedChanged += RbtipoBusc_CheckedChanged;
            // 
            // RbPrestBusc
            // 
            RbPrestBusc.AutoSize = true;
            RbPrestBusc.Location = new Point(20, 16);
            RbPrestBusc.Name = "RbPrestBusc";
            RbPrestBusc.Size = new Size(75, 19);
            RbPrestBusc.TabIndex = 0;
            RbPrestBusc.Text = "Prestamo";
            RbPrestBusc.UseVisualStyleBackColor = true;
            RbPrestBusc.CheckedChanged += RbtipoBusc_CheckedChanged;
            // 
            // TxtIsbnBusc
            // 
            TxtIsbnBusc.Location = new Point(158, 158);
            TxtIsbnBusc.Name = "TxtIsbnBusc";
            TxtIsbnBusc.Size = new Size(200, 23);
            TxtIsbnBusc.TabIndex = 25;
            // 
            // TxtNomBusc
            // 
            TxtNomBusc.Location = new Point(158, 120);
            TxtNomBusc.Name = "TxtNomBusc";
            TxtNomBusc.Size = new Size(200, 23);
            TxtNomBusc.TabIndex = 24;
            // 
            // PbBusc
            // 
            PbBusc.Location = new Point(400, 14);
            PbBusc.Name = "PbBusc";
            PbBusc.Size = new Size(368, 402);
            PbBusc.SizeMode = PictureBoxSizeMode.StretchImage;
            PbBusc.TabIndex = 30;
            PbBusc.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 250);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 23;
            label1.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 123);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 20;
            label4.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 161);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 21;
            label3.Text = "ISBN libro";
            // 
            // epTransacciones
            // 
            epTransacciones.ContainerControl = this;
            // 
            // FrmPrestamo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "FrmPrestamo";
            Text = "FrmPrestamo";
            tabControl1.ResumeLayout(false);
            TpAlta.ResumeLayout(false);
            TpAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbTipo).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnAgregar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            TpListar.ResumeLayout(false);
            TpListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbBorr).EndInit();
            TpBuscar.ResumeLayout(false);
            TpBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbModif).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbBusc).EndInit();
            ((System.ComponentModel.ISupportInitialize)epTransacciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage TpAlta;
        private PictureBox PbTipo;
        private PictureBox BtnAgregar;
        private GroupBox groupBox1;
        private RadioButton RbDevolucion;
        private RadioButton RbPrestamo;
        private TextBox TxtIsbn;
        private TextBox TbNombre;
        private Label LbTipo;
        private Label LbDepart;
        private Label LbNombre;
        private TabPage TpListar;
        private ComboBox CbBuscar;
        private PictureBox PbBorr;
        private ListView LvListar;
        private TabPage TpBuscar;
        private PictureBox PbModif;
        private PictureBox PbBusc;
        private MaskedTextBox MtbFechDevBusc;

        private GroupBox groupBox2;
        private RadioButton RbDevBusc;
        private RadioButton RbPrestBusc;
        private TextBox TxtIsbnBusc;
        private TextBox TxtNomBusc;
        private Label label1;
        private Label label4;
        private Label label3;
        private ErrorProvider epTransacciones;
        private ColumnHeader Columna1;
        private ColumnHeader Columna2;
        private ColumnHeader Columna3;
        private ColumnHeader columna4;
        private Button BtnBusc;
        private TextBox TxtBusc;
    }
}