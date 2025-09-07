namespace Ej1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            tbLargoOR = new TextBox();
            tbAltoCIL = new TextBox();
            tbAltoOR = new TextBox();
            tbRadioCIL = new TextBox();
            tbAnchoOR = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            rdbCilindro = new RadioButton();
            rdbtnOrtoedro = new RadioButton();
            btnCrearFigura = new Button();
            lbDescribir = new ListBox();
            btnActualizarListado = new Button();
            btnOrdenar = new Button();
            btnMostrarMasDatos = new Button();
            lbMostrarMas = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbLargoOR);
            groupBox1.Controls.Add(tbAltoCIL);
            groupBox1.Controls.Add(tbAltoOR);
            groupBox1.Controls.Add(tbRadioCIL);
            groupBox1.Controls.Add(tbAnchoOR);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(rdbCilindro);
            groupBox1.Controls.Add(rdbtnOrtoedro);
            groupBox1.Controls.Add(btnCrearFigura);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(608, 176);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // tbLargoOR
            // 
            tbLargoOR.AcceptsReturn = true;
            tbLargoOR.Location = new Point(493, 44);
            tbLargoOR.Name = "tbLargoOR";
            tbLargoOR.Size = new Size(38, 27);
            tbLargoOR.TabIndex = 12;
            // 
            // tbAltoCIL
            // 
            tbAltoCIL.Location = new Point(373, 100);
            tbAltoCIL.Name = "tbAltoCIL";
            tbAltoCIL.Size = new Size(44, 27);
            tbAltoCIL.TabIndex = 11;
            // 
            // tbAltoOR
            // 
            tbAltoOR.Location = new Point(373, 40);
            tbAltoOR.Name = "tbAltoOR";
            tbAltoOR.Size = new Size(44, 27);
            tbAltoOR.TabIndex = 10;
            // 
            // tbRadioCIL
            // 
            tbRadioCIL.Location = new Point(230, 97);
            tbRadioCIL.Name = "tbRadioCIL";
            tbRadioCIL.Size = new Size(54, 27);
            tbRadioCIL.TabIndex = 9;
            // 
            // tbAnchoOR
            // 
            tbAnchoOR.Location = new Point(230, 44);
            tbAnchoOR.Name = "tbAnchoOR";
            tbAnchoOR.Size = new Size(54, 27);
            tbAnchoOR.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(318, 104);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 7;
            label5.Text = "Alto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(173, 104);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 6;
            label4.Text = "Radio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(440, 49);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 5;
            label3.Text = "Largo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 47);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 4;
            label2.Text = "Alto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 49);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 3;
            label1.Text = "Ancho";
            // 
            // rdbCilindro
            // 
            rdbCilindro.AutoSize = true;
            rdbCilindro.Location = new Point(25, 100);
            rdbCilindro.Name = "rdbCilindro";
            rdbCilindro.Size = new Size(82, 24);
            rdbCilindro.TabIndex = 2;
            rdbCilindro.TabStop = true;
            rdbCilindro.Text = "Cilindro";
            rdbCilindro.UseVisualStyleBackColor = true;
            // 
            // rdbtnOrtoedro
            // 
            rdbtnOrtoedro.AutoSize = true;
            rdbtnOrtoedro.Location = new Point(25, 45);
            rdbtnOrtoedro.Name = "rdbtnOrtoedro";
            rdbtnOrtoedro.Size = new Size(95, 24);
            rdbtnOrtoedro.TabIndex = 1;
            rdbtnOrtoedro.TabStop = true;
            rdbtnOrtoedro.Text = "Ortoedro ";
            rdbtnOrtoedro.UseVisualStyleBackColor = true;
            // 
            // btnCrearFigura
            // 
            btnCrearFigura.Location = new Point(478, 131);
            btnCrearFigura.Name = "btnCrearFigura";
            btnCrearFigura.Size = new Size(124, 39);
            btnCrearFigura.TabIndex = 0;
            btnCrearFigura.Text = "Crear figura ";
            btnCrearFigura.UseVisualStyleBackColor = true;
            btnCrearFigura.Click += btnCrearFigura_Click;
            // 
            // lbDescribir
            // 
            lbDescribir.FormattingEnabled = true;
            lbDescribir.Location = new Point(29, 203);
            lbDescribir.Name = "lbDescribir";
            lbDescribir.Size = new Size(222, 224);
            lbDescribir.TabIndex = 1;
            // 
            // btnActualizarListado
            // 
            btnActualizarListado.Location = new Point(297, 226);
            btnActualizarListado.Name = "btnActualizarListado";
            btnActualizarListado.Size = new Size(94, 53);
            btnActualizarListado.TabIndex = 2;
            btnActualizarListado.Text = "Actualizar listado ";
            btnActualizarListado.UseVisualStyleBackColor = true;
            btnActualizarListado.Click += btnActualizarListado_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(449, 226);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(94, 53);
            btnOrdenar.TabIndex = 3;
            btnOrdenar.Text = "Ordenar por area ";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnMostrarMasDatos
            // 
            btnMostrarMasDatos.Location = new Point(297, 285);
            btnMostrarMasDatos.Name = "btnMostrarMasDatos";
            btnMostrarMasDatos.Size = new Size(94, 61);
            btnMostrarMasDatos.TabIndex = 4;
            btnMostrarMasDatos.Text = "Mostrar mas datos ";
            btnMostrarMasDatos.UseVisualStyleBackColor = true;
            btnMostrarMasDatos.Click += btnMostrarMasDatos_Click;
            // 
            // lbMostrarMas
            // 
            lbMostrarMas.AutoSize = true;
            lbMostrarMas.Location = new Point(296, 377);
            lbMostrarMas.Name = "lbMostrarMas";
            lbMostrarMas.Size = new Size(0, 20);
            lbMostrarMas.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 450);
            Controls.Add(lbMostrarMas);
            Controls.Add(btnMostrarMasDatos);
            Controls.Add(btnOrdenar);
            Controls.Add(btnActualizarListado);
            Controls.Add(lbDescribir);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton rdbCilindro;
        private RadioButton rdbtnOrtoedro;
        private Button btnCrearFigura;
        private TextBox tbAltoCIL;
        private TextBox tbAltoOR;
        private TextBox tbRadioCIL;
        private TextBox tbAnchoOR;
        private TextBox tbLargoOR;
        private ListBox lbDescribir;
        private Button btnActualizarListado;
        private Button btnOrdenar;
        private Button btnMostrarMasDatos;
        private Label lbMostrarMas;
    }
}
