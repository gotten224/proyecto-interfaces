namespace biblioteca_proyecto
{
    partial class FrmModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificar));
            PbModif = new PictureBox();
            groupBox2 = new GroupBox();
            RbDevBusc = new RadioButton();
            RbPrestBusc = new RadioButton();
            TxtIsbnBusc = new TextBox();
            Txt1 = new TextBox();
            PbBusc = new PictureBox();
            label1 = new Label();
            labelCambiar = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)PbModif).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbBusc).BeginInit();
            SuspendLayout();
            // 
            // PbModif
            // 
            PbModif.Image = (Image)resources.GetObject("PbModif.Image");
            PbModif.Location = new Point(28, 377);
            PbModif.Name = "PbModif";
            PbModif.Size = new Size(41, 42);
            PbModif.SizeMode = PictureBoxSizeMode.StretchImage;
            PbModif.TabIndex = 41;
            PbModif.TabStop = false;
            PbModif.Click += PbModif_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RbDevBusc);
            groupBox2.Controls.Add(RbPrestBusc);
            groupBox2.Location = new Point(163, 260);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 70);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            // 
            // RbDevBusc
            // 
            RbDevBusc.AutoSize = true;
            RbDevBusc.Enabled = false;
            RbDevBusc.Location = new Point(20, 41);
            RbDevBusc.Name = "RbDevBusc";
            RbDevBusc.Size = new Size(85, 19);
            RbDevBusc.TabIndex = 1;
            RbDevBusc.Text = "Devolucion";
            RbDevBusc.UseVisualStyleBackColor = true;
            RbDevBusc.CheckedChanged += RbPrestBusc_CheckedChanged;
            // 
            // RbPrestBusc
            // 
            RbPrestBusc.AutoSize = true;
            RbPrestBusc.Enabled = false;
            RbPrestBusc.Location = new Point(20, 16);
            RbPrestBusc.Name = "RbPrestBusc";
            RbPrestBusc.Size = new Size(75, 19);
            RbPrestBusc.TabIndex = 0;
            RbPrestBusc.Text = "Prestamo";
            RbPrestBusc.UseVisualStyleBackColor = true;
            RbPrestBusc.CheckedChanged += RbPrestBusc_CheckedChanged;
            // 
            // TxtIsbnBusc
            // 
            TxtIsbnBusc.Location = new Point(163, 168);
            TxtIsbnBusc.Name = "TxtIsbnBusc";
            TxtIsbnBusc.Size = new Size(200, 23);
            TxtIsbnBusc.TabIndex = 38;
            // 
            // Txt1
            // 
            Txt1.Location = new Point(163, 130);
            Txt1.Name = "Txt1";
            Txt1.Size = new Size(200, 23);
            Txt1.TabIndex = 37;
            // 
            // PbBusc
            // 
            PbBusc.Location = new Point(405, 24);
            PbBusc.Name = "PbBusc";
            PbBusc.Size = new Size(368, 402);
            PbBusc.SizeMode = PictureBoxSizeMode.StretchImage;
            PbBusc.TabIndex = 40;
            PbBusc.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 260);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 36;
            label1.Text = "Tipo";
            // 
            // labelCambiar
            // 
            labelCambiar.AutoSize = true;
            labelCambiar.Location = new Point(28, 133);
            labelCambiar.Name = "labelCambiar";
            labelCambiar.Size = new Size(51, 15);
            labelCambiar.TabIndex = 34;
            labelCambiar.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 171);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 35;
            label3.Text = "ISBN libro";
            // 
            // FrmModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PbModif);
            Controls.Add(groupBox2);
            Controls.Add(TxtIsbnBusc);
            Controls.Add(Txt1);
            Controls.Add(PbBusc);
            Controls.Add(label1);
            Controls.Add(labelCambiar);
            Controls.Add(label3);
            Name = "FrmModificar";
            Text = "FrmModificar";
            ((System.ComponentModel.ISupportInitialize)PbModif).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbBusc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PbModif;
        private GroupBox groupBox2;
        private RadioButton RbDevBusc;
        private RadioButton RbPrestBusc;
        private TextBox TxtIsbnBusc;
        private TextBox Txt1;
        private PictureBox PbBusc;
        private Label label1;
        private Label labelCambiar;
        private Label label3;
    }
}