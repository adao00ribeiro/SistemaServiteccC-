namespace SistemaServitec
{
    partial class FormConversorCartaoPonto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose ( );
            }
            base.Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxArquivoCartaoPonto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxArquivoAdiantamento = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxArquivoDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConverter = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxCompetencia = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arquivo Cartão Ponto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arquivo Adiantamentos:";
            // 
            // textBoxArquivoCartaoPonto
            // 
            this.textBoxArquivoCartaoPonto.Location = new System.Drawing.Point(154, 22);
            this.textBoxArquivoCartaoPonto.Name = "textBoxArquivoCartaoPonto";
            this.textBoxArquivoCartaoPonto.Size = new System.Drawing.Size(285, 23);
            this.textBoxArquivoCartaoPonto.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(445, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxArquivoAdiantamento
            // 
            this.textBoxArquivoAdiantamento.Location = new System.Drawing.Point(154, 54);
            this.textBoxArquivoAdiantamento.Name = "textBoxArquivoAdiantamento";
            this.textBoxArquivoAdiantamento.Size = new System.Drawing.Size(285, 23);
            this.textBoxArquivoAdiantamento.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(448, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxArquivoDestino
            // 
            this.textBoxArquivoDestino.Location = new System.Drawing.Point(72, 29);
            this.textBoxArquivoDestino.Name = "textBoxArquivoDestino";
            this.textBoxArquivoDestino.Size = new System.Drawing.Size(370, 23);
            this.textBoxArquivoDestino.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Arquivo:";
            // 
            // buttonConverter
            // 
            this.buttonConverter.Location = new System.Drawing.Point(322, 287);
            this.buttonConverter.Name = "buttonConverter";
            this.buttonConverter.Size = new System.Drawing.Size(93, 30);
            this.buttonConverter.TabIndex = 9;
            this.buttonConverter.Text = "Converter";
            this.buttonConverter.UseVisualStyleBackColor = true;
            this.buttonConverter.Click += new System.EventHandler(this.buttonConverter_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(421, 287);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(93, 30);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxArquivoDestino);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 75);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destino";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxArquivoAdiantamento);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBoxArquivoCartaoPonto);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 98);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entrada";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.maskedTextBoxCompetencia);
            this.groupBox3.Location = new System.Drawing.Point(15, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(499, 73);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados do Informativo";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(210, 42);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(27, 12);
            this.button7.TabIndex = 5;
            this.button7.Text = ".";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(210, 31);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(27, 12);
            this.button6.TabIndex = 4;
            this.button6.Text = ".";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Competencia:";
            // 
            // maskedTextBoxCompetencia
            // 
            this.maskedTextBoxCompetencia.Location = new System.Drawing.Point(154, 31);
            this.maskedTextBoxCompetencia.Mask = "00/0000";
            this.maskedTextBoxCompetencia.Name = "maskedTextBoxCompetencia";
            this.maskedTextBoxCompetencia.Size = new System.Drawing.Size(52, 23);
            this.maskedTextBoxCompetencia.TabIndex = 6;
            this.maskedTextBoxCompetencia.Text = "000000";
            // 
            // FormConversorCartaoPonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 331);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonConverter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(545, 370);
            this.MinimumSize = new System.Drawing.Size(545, 370);
            this.Name = "FormConversorCartaoPonto";
            this.Text = "Converter Cartao Ponto WM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxArquivoCartaoPonto;
        private Button button1;
        private Button button2;
        private TextBox textBoxArquivoAdiantamento;
        private Button button3;
        private TextBox textBoxArquivoDestino;
        private Label label3;
        private Button buttonConverter;
        private Button buttonCancelar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button7;
        private Button button6;
        private Label label4;
        private MaskedTextBox maskedTextBoxCompetencia;
    }
}