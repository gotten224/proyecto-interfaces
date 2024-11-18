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
            pictureBox1 = new PictureBox();
            listView1 = new ListView();
            TpBuscar = new TabPage();
            pictureBox2 = new PictureBox();
            maskedTextBox1 = new MaskedTextBox();
            groupBox2 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            tabControl1.SuspendLayout();
            TpAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbTipo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnAgragar).BeginInit();
            groupBox1.SuspendLayout();
            TpListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            TpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
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
            TpListar.Controls.Add(comboBox1);
            TpListar.Controls.Add(pictureBox1);
            TpListar.Controls.Add(listView1);
            TpListar.Location = new Point(4, 24);
            TpListar.Name = "TpListar";
            TpListar.Padding = new Padding(3);
            TpListar.Size = new Size(788, 430);
            TpListar.TabIndex = 1;
            TpListar.Text = "Listado";
            TpListar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(710, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            listView1.Location = new Point(6, 84);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 336);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // TpBuscar
            // 
            TpBuscar.Controls.Add(button2);
            TpBuscar.Controls.Add(textBox4);
            TpBuscar.Controls.Add(pictureBox2);
            TpBuscar.Controls.Add(maskedTextBox1);
            TpBuscar.Controls.Add(groupBox2);
            TpBuscar.Controls.Add(textBox2);
            TpBuscar.Controls.Add(textBox3);
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
            // pictureBox2
            // 
            pictureBox2.Location = new Point(400, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(368, 402);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(158, 175);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(200, 23);
            maskedTextBox1.TabIndex = 29;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Location = new Point(158, 230);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(20, 66);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(80, 19);
            radioButton1.TabIndex = 2;
            radioButton1.Text = "Estudiante";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(20, 41);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(43, 19);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Pas";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(20, 16);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(69, 19);
            radioButton3.TabIndex = 0;
            radioButton3.Text = "Profesor";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 26;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(158, 95);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 25;
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
            // textBox4
            // 
            textBox4.Location = new Point(23, 26);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(154, 23);
            textBox4.TabIndex = 31;
            // 
            // button2
            // 
            button2.Location = new Point(183, 26);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 32;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Estudiante", "Profesor", "Pas" });
            comboBox1.Location = new Point(10, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(262, 23);
            comboBox1.TabIndex = 20;
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
            TpListar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            TpBuscar.ResumeLayout(false);
            TpBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private PictureBox pictureBox1;
        private ListView listView1;
        private PictureBox pictureBox2;
        private MaskedTextBox maskedTextBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private TextBox textBox4;
        private ComboBox comboBox1;
    }
}