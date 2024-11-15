namespace biblioteca_proyecto
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            tabControl1 = new TabControl();
            TpAlta = new TabPage();
            PbTipo = new PictureBox();
            MtbFechSan = new MaskedTextBox();
            BtnAgragar = new PictureBox();
            groupBox1 = new GroupBox();
            RbEstudinte = new RadioButton();
            RbPas = new RadioButton();
            RbProfesor = new RadioButton();
            TbDepartamaento = new TextBox();
            TbNombre = new TextBox();
            LbTipo = new Label();
            LbFechSan = new Label();
            LbDepart = new Label();
            LbNombre = new Label();
            TpListar = new TabPage();
            TpBuscar = new TabPage();
            ILtipo = new ImageList(components);
            tabControl1.SuspendLayout();
            TpAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbTipo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnAgragar).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TpAlta);
            tabControl1.Controls.Add(TpListar);
            tabControl1.Controls.Add(TpBuscar);
            tabControl1.Location = new Point(2, -6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(796, 458);
            tabControl1.TabIndex = 10;
            // 
            // TpAlta
            // 
            TpAlta.Controls.Add(PbTipo);
            TpAlta.Controls.Add(MtbFechSan);
            TpAlta.Controls.Add(BtnAgragar);
            TpAlta.Controls.Add(groupBox1);
            TpAlta.Controls.Add(TbDepartamaento);
            TpAlta.Controls.Add(TbNombre);
            TpAlta.Controls.Add(LbTipo);
            TpAlta.Controls.Add(LbFechSan);
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
            // MtbFechSan
            // 
            MtbFechSan.Location = new Point(154, 179);
            MtbFechSan.Mask = "00/00/0000";
            MtbFechSan.Name = "MtbFechSan";
            MtbFechSan.Size = new Size(200, 23);
            MtbFechSan.TabIndex = 19;
            MtbFechSan.ValidatingType = typeof(DateTime);
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
            groupBox1.Controls.Add(RbEstudinte);
            groupBox1.Controls.Add(RbPas);
            groupBox1.Controls.Add(RbProfesor);
            groupBox1.Location = new Point(154, 234);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // RbEstudinte
            // 
            RbEstudinte.AutoSize = true;
            RbEstudinte.Location = new Point(20, 66);
            RbEstudinte.Name = "RbEstudinte";
            RbEstudinte.Size = new Size(80, 19);
            RbEstudinte.TabIndex = 2;
            RbEstudinte.Text = "Estudiante";
            RbEstudinte.UseVisualStyleBackColor = true;
            RbEstudinte.CheckedChanged += Rbtipo_CheckedChanged;
            // 
            // RbPas
            // 
            RbPas.AutoSize = true;
            RbPas.Checked = true;
            RbPas.Location = new Point(20, 41);
            RbPas.Name = "RbPas";
            RbPas.Size = new Size(43, 19);
            RbPas.TabIndex = 1;
            RbPas.TabStop = true;
            RbPas.Text = "Pas";
            RbPas.UseVisualStyleBackColor = true;
            RbPas.CheckedChanged += Rbtipo_CheckedChanged;
            // 
            // RbProfesor
            // 
            RbProfesor.AutoSize = true;
            RbProfesor.Location = new Point(20, 16);
            RbProfesor.Name = "RbProfesor";
            RbProfesor.Size = new Size(69, 19);
            RbProfesor.TabIndex = 0;
            RbProfesor.TabStop = true;
            RbProfesor.Text = "Profesor";
            RbProfesor.UseVisualStyleBackColor = true;
            RbProfesor.CheckedChanged += Rbtipo_CheckedChanged;
            // 
            // TbDepartamaento
            // 
            TbDepartamaento.Location = new Point(154, 137);
            TbDepartamaento.Name = "TbDepartamaento";
            TbDepartamaento.Size = new Size(200, 23);
            TbDepartamaento.TabIndex = 16;
            // 
            // TbNombre
            // 
            TbNombre.Location = new Point(154, 99);
            TbNombre.Name = "TbNombre";
            TbNombre.Size = new Size(200, 23);
            TbNombre.TabIndex = 14;
            // 
            // LbTipo
            // 
            LbTipo.AutoSize = true;
            LbTipo.Location = new Point(16, 234);
            LbTipo.Name = "LbTipo";
            LbTipo.Size = new Size(31, 15);
            LbTipo.TabIndex = 13;
            LbTipo.Text = "Tipo";
            // 
            // LbFechSan
            // 
            LbFechSan.AutoSize = true;
            LbFechSan.Location = new Point(16, 187);
            LbFechSan.Name = "LbFechSan";
            LbFechSan.Size = new Size(82, 15);
            LbFechSan.TabIndex = 12;
            LbFechSan.Text = "Fecha sancion";
            // 
            // LbDepart
            // 
            LbDepart.AutoSize = true;
            LbDepart.Location = new Point(16, 145);
            LbDepart.Name = "LbDepart";
            LbDepart.Size = new Size(83, 15);
            LbDepart.TabIndex = 11;
            LbDepart.Text = "Departamento";
            // 
            // LbNombre
            // 
            LbNombre.AutoSize = true;
            LbNombre.Location = new Point(16, 107);
            LbNombre.Name = "LbNombre";
            LbNombre.Size = new Size(51, 15);
            LbNombre.TabIndex = 10;
            LbNombre.Text = "Nombre";
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
            // ILtipo
            // 
            ILtipo.ColorDepth = ColorDepth.Depth32Bit;
            ILtipo.ImageStream = (ImageListStreamer)resources.GetObject("ILtipo.ImageStream");
            ILtipo.TransparentColor = Color.Transparent;
            ILtipo.Images.SetKeyName(0, "profe.jpg");
            ILtipo.Images.SetKeyName(1, "pas.jpg");
            ILtipo.Images.SetKeyName(2, "estu.jpg");
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            tabControl1.ResumeLayout(false);
            TpAlta.ResumeLayout(false);
            TpAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbTipo).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnAgragar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage TpAlta;
        private PictureBox BtnAgragar;
        private GroupBox groupBox1;
        private RadioButton RbEstudinte;
        private RadioButton RbPas;
        private RadioButton RbProfesor;
        private TextBox TbDepartamaento;
        private TextBox TbNombre;
        private Label LbTipo;
        private Label LbFechSan;
        private Label LbDepart;
        private Label LbNombre;
        private TabPage TpListar;
        private TabPage TpBuscar;
        private MaskedTextBox MtbFechSan;
        private PictureBox PbTipo;
        private ImageList ILtipo;
    }
}