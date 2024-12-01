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
            epTransacciones = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            TpAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbTipo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnAgregar).BeginInit();
            groupBox1.SuspendLayout();
            TpListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbBorr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epTransacciones).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TpAlta);
            tabControl1.Controls.Add(TpListar);
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
            PbBorr.Click += PbBorr_Click;
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
        private MaskedTextBox MtbFechDevBusc;
        private ErrorProvider epTransacciones;
        private ColumnHeader Columna1;
        private ColumnHeader Columna2;
        private ColumnHeader Columna3;
        private ColumnHeader columna4;
        private Button BtnBusc;
        private TextBox TxtBusc;
    }
}