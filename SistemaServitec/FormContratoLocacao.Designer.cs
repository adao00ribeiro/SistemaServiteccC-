namespace SistemaServitec
{
    partial class FormContratoLocacao
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
            this.textBoxCodigoLocador = new System.Windows.Forms.TextBox();
            this.textBoxNomeLocador = new System.Windows.Forms.TextBox();
            this.textBoxCodigoLocatario = new System.Windows.Forms.TextBox();
            this.textBoxNomeLocatario = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxTipoDuracao = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoImovel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxnumero = new System.Windows.Forms.TextBox();
            this.textBoxCep = new System.Windows.Forms.TextBox();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.textBoxExtensoDuracao = new System.Windows.Forms.TextBox();
            this.textBoxDataContrato = new System.Windows.Forms.TextBox();
            this.textBoxValorExtenso = new System.Windows.Forms.TextBox();
            this.textBoxValorContrato = new System.Windows.Forms.TextBox();
            this.textBoxDataFinal = new System.Windows.Forms.TextBox();
            this.textBoxDataInicial = new System.Windows.Forms.TextBox();
            this.textBoxDuracaoContrato = new System.Windows.Forms.TextBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Locatario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Locador:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxCodigoLocador
            // 
            this.textBoxCodigoLocador.Enabled = false;
            this.textBoxCodigoLocador.Location = new System.Drawing.Point(79, 55);
            this.textBoxCodigoLocador.Name = "textBoxCodigoLocador";
            this.textBoxCodigoLocador.Size = new System.Drawing.Size(71, 23);
            this.textBoxCodigoLocador.TabIndex = 1;
            this.textBoxCodigoLocador.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCodigoLocador_KeyDown);
            // 
            // textBoxNomeLocador
            // 
            this.textBoxNomeLocador.Enabled = false;
            this.textBoxNomeLocador.Location = new System.Drawing.Point(156, 55);
            this.textBoxNomeLocador.Name = "textBoxNomeLocador";
            this.textBoxNomeLocador.Size = new System.Drawing.Size(426, 23);
            this.textBoxNomeLocador.TabIndex = 1;
            // 
            // textBoxCodigoLocatario
            // 
            this.textBoxCodigoLocatario.Enabled = false;
            this.textBoxCodigoLocatario.Location = new System.Drawing.Point(79, 84);
            this.textBoxCodigoLocatario.Name = "textBoxCodigoLocatario";
            this.textBoxCodigoLocatario.Size = new System.Drawing.Size(71, 23);
            this.textBoxCodigoLocatario.TabIndex = 1;
            this.textBoxCodigoLocatario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCodigoLocatario_KeyDown);
            // 
            // textBoxNomeLocatario
            // 
            this.textBoxNomeLocatario.Enabled = false;
            this.textBoxNomeLocatario.Location = new System.Drawing.Point(156, 84);
            this.textBoxNomeLocatario.Name = "textBoxNomeLocatario";
            this.textBoxNomeLocatario.Size = new System.Drawing.Size(426, 23);
            this.textBoxNomeLocatario.TabIndex = 1;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label16);
            this.groupBox.Controls.Add(this.comboBoxTipoDuracao);
            this.groupBox.Controls.Add(this.comboBoxTipoImovel);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.textBoxnumero);
            this.groupBox.Controls.Add(this.textBoxCep);
            this.groupBox.Controls.Add(this.textBoxBairro);
            this.groupBox.Controls.Add(this.textBoxEstado);
            this.groupBox.Controls.Add(this.textBoxExtensoDuracao);
            this.groupBox.Controls.Add(this.textBoxDataContrato);
            this.groupBox.Controls.Add(this.textBoxValorExtenso);
            this.groupBox.Controls.Add(this.textBoxValorContrato);
            this.groupBox.Controls.Add(this.textBoxDataFinal);
            this.groupBox.Controls.Add(this.textBoxDataInicial);
            this.groupBox.Controls.Add(this.textBoxDuracaoContrato);
            this.groupBox.Controls.Add(this.textBoxCidade);
            this.groupBox.Controls.Add(this.textBoxEndereco);
            this.groupBox.Controls.Add(this.label17);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label13);
            this.groupBox.Controls.Add(this.label12);
            this.groupBox.Controls.Add(this.label15);
            this.groupBox.Controls.Add(this.label11);
            this.groupBox.Controls.Add(this.label14);
            this.groupBox.Controls.Add(this.label9);
            this.groupBox.Controls.Add(this.label8);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox.Location = new System.Drawing.Point(18, 124);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(564, 320);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Contrato";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 15);
            this.label16.TabIndex = 2;
            this.label16.Text = "Tipo Imovel:";
            // 
            // comboBoxTipoDuracao
            // 
            this.comboBoxTipoDuracao.Enabled = false;
            this.comboBoxTipoDuracao.FormattingEnabled = true;
            this.comboBoxTipoDuracao.Items.AddRange(new object[] {
            "DIA",
            "MES",
            "ANO"});
            this.comboBoxTipoDuracao.Location = new System.Drawing.Point(437, 149);
            this.comboBoxTipoDuracao.Name = "comboBoxTipoDuracao";
            this.comboBoxTipoDuracao.Size = new System.Drawing.Size(121, 23);
            this.comboBoxTipoDuracao.TabIndex = 1;
            // 
            // comboBoxTipoImovel
            // 
            this.comboBoxTipoImovel.Enabled = false;
            this.comboBoxTipoImovel.FormattingEnabled = true;
            this.comboBoxTipoImovel.Items.AddRange(new object[] {
            "Residencial",
            "Comercial"});
            this.comboBoxTipoImovel.Location = new System.Drawing.Point(92, 28);
            this.comboBoxTipoImovel.Name = "comboBoxTipoImovel";
            this.comboBoxTipoImovel.Size = new System.Drawing.Size(121, 23);
            this.comboBoxTipoImovel.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Estado:";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxnumero
            // 
            this.textBoxnumero.Enabled = false;
            this.textBoxnumero.Location = new System.Drawing.Point(312, 65);
            this.textBoxnumero.Name = "textBoxnumero";
            this.textBoxnumero.Size = new System.Drawing.Size(58, 23);
            this.textBoxnumero.TabIndex = 1;
            // 
            // textBoxCep
            // 
            this.textBoxCep.Enabled = false;
            this.textBoxCep.Location = new System.Drawing.Point(435, 104);
            this.textBoxCep.Name = "textBoxCep";
            this.textBoxCep.Size = new System.Drawing.Size(123, 23);
            this.textBoxCep.TabIndex = 1;
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Enabled = false;
            this.textBoxBairro.Location = new System.Drawing.Point(435, 65);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(123, 23);
            this.textBoxBairro.TabIndex = 1;
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Enabled = false;
            this.textBoxEstado.Location = new System.Drawing.Point(336, 104);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(46, 23);
            this.textBoxEstado.TabIndex = 1;
            // 
            // textBoxExtensoDuracao
            // 
            this.textBoxExtensoDuracao.Enabled = false;
            this.textBoxExtensoDuracao.Location = new System.Drawing.Point(205, 149);
            this.textBoxExtensoDuracao.Name = "textBoxExtensoDuracao";
            this.textBoxExtensoDuracao.Size = new System.Drawing.Size(214, 23);
            this.textBoxExtensoDuracao.TabIndex = 1;
            // 
            // textBoxDataContrato
            // 
            this.textBoxDataContrato.Enabled = false;
            this.textBoxDataContrato.Location = new System.Drawing.Point(264, 287);
            this.textBoxDataContrato.Name = "textBoxDataContrato";
            this.textBoxDataContrato.Size = new System.Drawing.Size(107, 23);
            this.textBoxDataContrato.TabIndex = 1;
            // 
            // textBoxValorExtenso
            // 
            this.textBoxValorExtenso.Enabled = false;
            this.textBoxValorExtenso.Location = new System.Drawing.Point(195, 241);
            this.textBoxValorExtenso.Name = "textBoxValorExtenso";
            this.textBoxValorExtenso.Size = new System.Drawing.Size(363, 23);
            this.textBoxValorExtenso.TabIndex = 1;
            // 
            // textBoxValorContrato
            // 
            this.textBoxValorContrato.Enabled = false;
            this.textBoxValorContrato.Location = new System.Drawing.Point(61, 241);
            this.textBoxValorContrato.Name = "textBoxValorContrato";
            this.textBoxValorContrato.Size = new System.Drawing.Size(71, 23);
            this.textBoxValorContrato.TabIndex = 1;
            // 
            // textBoxDataFinal
            // 
            this.textBoxDataFinal.Enabled = false;
            this.textBoxDataFinal.Location = new System.Drawing.Point(377, 200);
            this.textBoxDataFinal.Name = "textBoxDataFinal";
            this.textBoxDataFinal.Size = new System.Drawing.Size(89, 23);
            this.textBoxDataFinal.TabIndex = 1;
            // 
            // textBoxDataInicial
            // 
            this.textBoxDataInicial.Enabled = false;
            this.textBoxDataInicial.Location = new System.Drawing.Point(163, 200);
            this.textBoxDataInicial.Name = "textBoxDataInicial";
            this.textBoxDataInicial.Size = new System.Drawing.Size(83, 23);
            this.textBoxDataInicial.TabIndex = 1;
            // 
            // textBoxDuracaoContrato
            // 
            this.textBoxDuracaoContrato.Enabled = false;
            this.textBoxDuracaoContrato.Location = new System.Drawing.Point(92, 149);
            this.textBoxDuracaoContrato.Name = "textBoxDuracaoContrato";
            this.textBoxDuracaoContrato.Size = new System.Drawing.Size(50, 23);
            this.textBoxDuracaoContrato.TabIndex = 1;
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Enabled = false;
            this.textBoxCidade.Location = new System.Drawing.Point(92, 104);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(187, 23);
            this.textBoxCidade.TabIndex = 1;
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Enabled = false;
            this.textBoxEndereco.Location = new System.Drawing.Point(92, 65);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(187, 23);
            this.textBoxEndereco.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(388, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "CEP:";
            this.label17.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cidade:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bairro:";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nº";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Valor:";
            this.label13.Click += new System.EventHandler(this.label1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(312, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Data Final";
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(174, 290);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Data Contrato:";
            this.label15.Click += new System.EventHandler(this.label1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(92, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Data Inicial";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(138, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Extenso:";
            this.label14.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Extenso:";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Duracao:";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Endereço:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Location = new System.Drawing.Point(288, 460);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(83, 23);
            this.btnGravar.TabIndex = 3;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(199, 460);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(83, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Codigo:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Enabled = false;
            this.textBoxCodigo.Location = new System.Drawing.Point(79, 17);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(58, 23);
            this.textBoxCodigo.TabIndex = 1;
            this.textBoxCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCodigo_KeyDown);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(143, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(181, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(223, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = ">>";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(260, 17);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = ">";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(18, 460);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(83, 23);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(110, 460);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(83, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.button9_Click);
            // 
            // FormContratoLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 495);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.textBoxNomeLocatario);
            this.Controls.Add(this.textBoxCodigoLocatario);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.textBoxNomeLocador);
            this.Controls.Add(this.textBoxCodigoLocador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormContratoLocacao";
            this.Text = "Contrato Locação";
            this.Load += new System.EventHandler(this.FormContratoLocacao_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxCodigoLocador;
        private TextBox textBoxNomeLocador;
        private TextBox textBoxCodigoLocatario;
        private TextBox textBoxNomeLocatario;
        private GroupBox groupBox;
        private Label label16;
        private ComboBox comboBoxTipoDuracao;
        private ComboBox comboBoxTipoImovel;
        private Label label7;
        private TextBox textBoxnumero;
        private TextBox textBoxCep;
        private TextBox textBoxBairro;
        private TextBox textBoxEstado;
        private TextBox textBoxExtensoDuracao;
        private TextBox textBoxDataContrato;
        private TextBox textBoxValorExtenso;
        private TextBox textBoxValorContrato;
        private TextBox textBoxDataFinal;
        private TextBox textBoxDataInicial;
        private TextBox textBoxDuracaoContrato;
        private TextBox textBoxCidade;
        private TextBox textBoxEndereco;
        private Label label17;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label13;
        private Label label12;
        private Label label15;
        private Label label11;
        private Label label14;
        private Label label9;
        private Label label8;
        private Label label3;
        private Button btnGravar;
        private Button btnExcluir;
        private Label label10;
        private TextBox textBoxCodigo;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button btnNovo;
        private Button btnEditar;
    }
}