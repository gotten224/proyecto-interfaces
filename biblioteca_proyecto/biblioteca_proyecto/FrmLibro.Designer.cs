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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLibro));
            tabControl1 = new TabControl();
            TpAltaLibro = new TabPage();
            PbUbicacion = new PictureBox();
            MtbIdLibro = new MaskedTextBox();
            BtnAgragar = new PictureBox();
            groupBox1 = new GroupBox();
            RbAlmacen = new RadioButton();
            RbSala = new RadioButton();
            TbNombre = new TextBox();
            LbUbicacion = new Label();
            LbIdLibro = new Label();
            LbNombreLibro = new Label();
            TpListar = new TabPage();
            TpBuscar = new TabPage();
            tabControl1.SuspendLayout();
            TpAltaLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbUbicacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnAgragar).BeginInit();
            groupBox1.SuspendLayout();
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
            // 
            // TpAltaLibro
            // 
            TpAltaLibro.Controls.Add(PbUbicacion);
            TpAltaLibro.Controls.Add(MtbIdLibro);
            TpAltaLibro.Controls.Add(BtnAgragar);
            TpAltaLibro.Controls.Add(groupBox1);
            TpAltaLibro.Controls.Add(TbNombre);
            TpAltaLibro.Controls.Add(LbUbicacion);
            TpAltaLibro.Controls.Add(LbIdLibro);
            TpAltaLibro.Controls.Add(LbNombreLibro);
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
            MtbIdLibro.Mask = "99999";
            MtbIdLibro.Name = "MtbIdLibro";
            MtbIdLibro.Size = new Size(200, 23);
            MtbIdLibro.TabIndex = 19;
            MtbIdLibro.ValidatingType = typeof(int);
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
            // TbNombre
            // 
            TbNombre.Location = new Point(154, 99);
            TbNombre.Name = "TbNombre";
            TbNombre.Size = new Size(200, 23);
            TbNombre.TabIndex = 14;
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
            // LbNombreLibro
            // 
            LbNombreLibro.AutoSize = true;
            LbNombreLibro.Location = new Point(19, 110);
            LbNombreLibro.Name = "LbNombreLibro";
            LbNombreLibro.Size = new Size(51, 15);
            LbNombreLibro.TabIndex = 10;
            LbNombreLibro.Text = "Nombre";
            // 
            // TpListar
            // 
            TpListar.Location = new Point(4, 24);
            TpListar.Name = "TpListar";
            TpListar.Padding = new Padding(3);
            TpListar.Size = new Size(788, 430);
            TpListar.TabIndex = 1;
            TpListar.Text = "Listado";
            TpListar.UseVisualStyleBackColor = true;
            // 
            // TpBuscar
            // 
            TpBuscar.Location = new Point(4, 24);
            TpBuscar.Name = "TpBuscar";
            TpBuscar.Padding = new Padding(3);
            TpBuscar.Size = new Size(788, 430);
            TpBuscar.TabIndex = 2;
            TpBuscar.Text = "Buscar";
            TpBuscar.UseVisualStyleBackColor = true;
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
        private TextBox TbNombre;
        private Label LbUbicacion;
        private Label LbIdLibro;
        private Label LbNombreLibro;
        private TabPage TpListar;
        private TabPage TpBuscar;
    }
}