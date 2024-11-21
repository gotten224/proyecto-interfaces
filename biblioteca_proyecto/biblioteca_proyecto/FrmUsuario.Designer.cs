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
            BtnAgregar = new PictureBox();
            groupBox1 = new GroupBox();
            RbEstudinte = new RadioButton();
            RbPas = new RadioButton();
            RbProfesor = new RadioButton();
            TxtDepartamaento = new TextBox();
            TxtNombre = new TextBox();
            LbTipo = new Label();
            LbFechSan = new Label();
            LbDepart = new Label();
            LbNombre = new Label();
            TpListar = new TabPage();
            CbTipo = new ComboBox();
            PbBorr = new PictureBox();
            LvListar = new ListView();
            Nombre = new ColumnHeader();
            departamento = new ColumnHeader();
            FechaSan = new ColumnHeader();
            TpBuscar = new TabPage();
            PbModif = new PictureBox();
            BtnBusc = new Button();
            TxtBusc = new TextBox();
            PbBusc = new PictureBox();
            TxtBuscFech = new MaskedTextBox();
            GbBuscTip = new GroupBox();
            RbBuscEstu = new RadioButton();
            RbBuscPas = new RadioButton();
            RbBuscProf = new RadioButton();
            TxtBuscDept = new TextBox();
            TxtBuscNom = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            EpUsuario = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            TpAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbTipo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnAgregar).BeginInit();
            groupBox1.SuspendLayout();
            TpListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbBorr).BeginInit();
            TpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbModif).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbBusc).BeginInit();
            GbBuscTip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EpUsuario).BeginInit();
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
            TpAlta.Controls.Add(BtnAgregar);
            TpAlta.Controls.Add(groupBox1);
            TpAlta.Controls.Add(TxtDepartamaento);
            TpAlta.Controls.Add(TxtNombre);
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
            MtbFechSan.Validated += MtbFechSan_Validated;
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
            RbPas.Location = new Point(20, 41);
            RbPas.Name = "RbPas";
            RbPas.Size = new Size(43, 19);
            RbPas.TabIndex = 1;
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
            RbProfesor.Text = "Profesor";
            RbProfesor.UseVisualStyleBackColor = true;
            RbProfesor.CheckedChanged += Rbtipo_CheckedChanged;
            // 
            // TxtDepartamaento
            // 
            TxtDepartamaento.Location = new Point(154, 137);
            TxtDepartamaento.Name = "TxtDepartamaento";
            TxtDepartamaento.Size = new Size(200, 23);
            TxtDepartamaento.TabIndex = 16;
            TxtDepartamaento.Validated += TxtDepartamaento_Validated;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(154, 99);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(200, 23);
            TxtNombre.TabIndex = 14;
            TxtNombre.Validated += TxtNombre_Validated;
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
            TpListar.Controls.Add(CbTipo);
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
            // CbTipo
            // 
            CbTipo.FormattingEnabled = true;
            CbTipo.Items.AddRange(new object[] { "Estudiante", "Profesor", "Pas" });
            CbTipo.Location = new Point(10, 29);
            CbTipo.Name = "CbTipo";
            CbTipo.Size = new Size(262, 23);
            CbTipo.TabIndex = 20;
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
            LvListar.Columns.AddRange(new ColumnHeader[] { Nombre, departamento, FechaSan });
            LvListar.Location = new Point(6, 84);
            LvListar.Name = "LvListar";
            LvListar.Size = new Size(776, 336);
            LvListar.TabIndex = 0;
            LvListar.UseCompatibleStateImageBehavior = false;
            LvListar.View = View.Details;
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre";
            Nombre.Width = 250;
            // 
            // departamento
            // 
            departamento.Text = "Departamento";
            departamento.Width = 250;
            // 
            // FechaSan
            // 
            FechaSan.Text = "Fecha de sancion";
            FechaSan.Width = 270;
            // 
            // TpBuscar
            // 
            TpBuscar.Controls.Add(PbModif);
            TpBuscar.Controls.Add(BtnBusc);
            TpBuscar.Controls.Add(TxtBusc);
            TpBuscar.Controls.Add(PbBusc);
            TpBuscar.Controls.Add(TxtBuscFech);
            TpBuscar.Controls.Add(GbBuscTip);
            TpBuscar.Controls.Add(TxtBuscDept);
            TpBuscar.Controls.Add(TxtBuscNom);
            TpBuscar.Controls.Add(label1);
            TpBuscar.Controls.Add(label2);
            TpBuscar.Controls.Add(label3);
            TpBuscar.Controls.Add(label4);
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
            // BtnBusc
            // 
            BtnBusc.Location = new Point(183, 26);
            BtnBusc.Name = "BtnBusc";
            BtnBusc.Size = new Size(75, 23);
            BtnBusc.TabIndex = 32;
            BtnBusc.Text = "Buscar";
            BtnBusc.UseVisualStyleBackColor = true;
            // 
            // TxtBusc
            // 
            TxtBusc.Location = new Point(23, 26);
            TxtBusc.Name = "TxtBusc";
            TxtBusc.Size = new Size(154, 23);
            TxtBusc.TabIndex = 31;
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
            // TxtBuscFech
            // 
            TxtBuscFech.Location = new Point(158, 175);
            TxtBuscFech.Mask = "00/00/0000";
            TxtBuscFech.Name = "TxtBuscFech";
            TxtBuscFech.Size = new Size(200, 23);
            TxtBuscFech.TabIndex = 29;
            TxtBuscFech.ValidatingType = typeof(DateTime);
            // 
            // GbBuscTip
            // 
            GbBuscTip.Controls.Add(RbBuscEstu);
            GbBuscTip.Controls.Add(RbBuscPas);
            GbBuscTip.Controls.Add(RbBuscProf);
            GbBuscTip.Location = new Point(158, 230);
            GbBuscTip.Name = "GbBuscTip";
            GbBuscTip.Size = new Size(200, 100);
            GbBuscTip.TabIndex = 27;
            GbBuscTip.TabStop = false;
            // 
            // RbBuscEstu
            // 
            RbBuscEstu.AutoSize = true;
            RbBuscEstu.Location = new Point(20, 66);
            RbBuscEstu.Name = "RbBuscEstu";
            RbBuscEstu.Size = new Size(80, 19);
            RbBuscEstu.TabIndex = 2;
            RbBuscEstu.Text = "Estudiante";
            RbBuscEstu.UseVisualStyleBackColor = true;
            RbBuscEstu.CheckedChanged += Rbtipobusc_CheckedChanged;
            // 
            // RbBuscPas
            // 
            RbBuscPas.AutoSize = true;
            RbBuscPas.Location = new Point(20, 41);
            RbBuscPas.Name = "RbBuscPas";
            RbBuscPas.Size = new Size(43, 19);
            RbBuscPas.TabIndex = 1;
            RbBuscPas.Text = "Pas";
            RbBuscPas.UseVisualStyleBackColor = true;
            RbBuscPas.CheckedChanged += Rbtipobusc_CheckedChanged;
            // 
            // RbBuscProf
            // 
            RbBuscProf.AutoSize = true;
            RbBuscProf.Location = new Point(20, 16);
            RbBuscProf.Name = "RbBuscProf";
            RbBuscProf.Size = new Size(69, 19);
            RbBuscProf.TabIndex = 0;
            RbBuscProf.Text = "Profesor";
            RbBuscProf.UseVisualStyleBackColor = true;
            RbBuscProf.CheckedChanged += Rbtipobusc_CheckedChanged;
            // 
            // TxtBuscDept
            // 
            TxtBuscDept.Location = new Point(158, 133);
            TxtBuscDept.Name = "TxtBuscDept";
            TxtBuscDept.Size = new Size(200, 23);
            TxtBuscDept.TabIndex = 26;
            // 
            // TxtBuscNom
            // 
            TxtBuscNom.Location = new Point(158, 95);
            TxtBuscNom.Name = "TxtBuscNom";
            TxtBuscNom.Size = new Size(200, 23);
            TxtBuscNom.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 230);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 24;
            label1.Text = "Tipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 183);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 23;
            label2.Text = "Fecha sancion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 141);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 22;
            label3.Text = "Departamento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 103);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 21;
            label4.Text = "Nombre";
            // 
            // EpUsuario
            // 
            EpUsuario.ContainerControl = this;
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
            ((System.ComponentModel.ISupportInitialize)BtnAgregar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            TpListar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PbBorr).EndInit();
            TpBuscar.ResumeLayout(false);
            TpBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbModif).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbBusc).EndInit();
            GbBuscTip.ResumeLayout(false);
            GbBuscTip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EpUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage TpAlta;
        private PictureBox BtnAgregar;
        private GroupBox groupBox1;
        private RadioButton RbEstudinte;
        private RadioButton RbPas;
        private RadioButton RbProfesor;
        private TextBox TxtDepartamaento;
        private TextBox TxtNombre;
        private Label LbTipo;
        private Label LbFechSan;
        private Label LbDepart;
        private Label LbNombre;
        private TabPage TpListar;
        private TabPage TpBuscar;
        private MaskedTextBox MtbFechSan;
        private PictureBox PbTipo;
        private PictureBox PbBorr;
        private ListView LvListar;
        private PictureBox PbBusc;
        private MaskedTextBox TxtBuscFech;
        private GroupBox GbBuscTip;
        private RadioButton RbBuscEstu;
        private RadioButton RbBuscPas;
        private RadioButton RbBuscProf;
        private TextBox TxtBuscDept;
        private TextBox TxtBuscNom;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnBusc;
        private TextBox TxtBusc;
        private ComboBox CbTipo;
        private PictureBox PbModif;
        private ColumnHeader Nombre;
        private ColumnHeader departamento;
        private ColumnHeader FechaSan;
        private ErrorProvider EpUsuario;
    }
}