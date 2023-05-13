namespace SistemaServitec
{
    partial class FormCadastroPessoa
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
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.tabControlPessoais = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPageIdentity = new System.Windows.Forms.TabPage();
            this.textBoxRgData = new System.Windows.Forms.TextBox();
            this.textBoxRgUf = new System.Windows.Forms.TextBox();
            this.textBoxRgOrgaoExpedicao = new System.Windows.Forms.TextBox();
            this.textBoxRg = new System.Windows.Forms.TextBox();
            this.textBoxCpf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageEndereco = new System.Windows.Forms.TabPage();
            this.comboBoxTipoEndereco = new System.Windows.Forms.ComboBox();
            this.textBoxendereconumero = new System.Windows.Forms.TextBox();
            this.textBoxendereco = new System.Windows.Forms.TextBox();
            this.textBoxenderecobairro = new System.Windows.Forms.TextBox();
            this.textBoxenderecouf = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBoxenderecopais = new System.Windows.Forms.TextBox();
            this.textBoxenderecomunicipio = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBoxenderecocomplemento = new System.Windows.Forms.TextBox();
            this.textBoxenderecocep = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageInformacoesPessoais = new System.Windows.Forms.TabPage();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBoxnascimentouf = new System.Windows.Forms.TextBox();
            this.textBoxnascimentopais = new System.Windows.Forms.TextBox();
            this.textBoxnascimentomunicipio = new System.Windows.Forms.TextBox();
            this.textBoxnascimentopaisnacionalidade = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBoxnascimentodata = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tabControlPessoais.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPageIdentity.SuspendLayout();
            this.tabPageEndereco.SuspendLayout();
            this.tabPageInformacoesPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(71, 21);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(89, 23);
            this.textBoxCodigo.TabIndex = 1;
            this.textBoxCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCodigo_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(71, 50);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(304, 23);
            this.textBoxNome.TabIndex = 3;
            // 
            // tabControlPessoais
            // 
            this.tabControlPessoais.Controls.Add(this.tabPage2);
            this.tabControlPessoais.Location = new System.Drawing.Point(12, 89);
            this.tabControlPessoais.Name = "tabControlPessoais";
            this.tabControlPessoais.SelectedIndex = 0;
            this.tabControlPessoais.Size = new System.Drawing.Size(714, 211);
            this.tabControlPessoais.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(706, 183);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pessoais";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPageIdentity);
            this.tabControl2.Controls.Add(this.tabPageEndereco);
            this.tabControl2.Controls.Add(this.tabPageInformacoesPessoais);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(690, 167);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPageIdentity
            // 
            this.tabPageIdentity.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageIdentity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageIdentity.Controls.Add(this.textBoxRgData);
            this.tabPageIdentity.Controls.Add(this.textBoxRgUf);
            this.tabPageIdentity.Controls.Add(this.textBoxRgOrgaoExpedicao);
            this.tabPageIdentity.Controls.Add(this.textBoxRg);
            this.tabPageIdentity.Controls.Add(this.textBoxCpf);
            this.tabPageIdentity.Controls.Add(this.label7);
            this.tabPageIdentity.Controls.Add(this.label6);
            this.tabPageIdentity.Controls.Add(this.label5);
            this.tabPageIdentity.Controls.Add(this.label4);
            this.tabPageIdentity.Controls.Add(this.label3);
            this.tabPageIdentity.Location = new System.Drawing.Point(4, 24);
            this.tabPageIdentity.Name = "tabPageIdentity";
            this.tabPageIdentity.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIdentity.Size = new System.Drawing.Size(682, 139);
            this.tabPageIdentity.TabIndex = 0;
            this.tabPageIdentity.Text = "Identidade";
            // 
            // textBoxRgData
            // 
            this.textBoxRgData.Location = new System.Drawing.Point(46, 100);
            this.textBoxRgData.Name = "textBoxRgData";
            this.textBoxRgData.Size = new System.Drawing.Size(85, 23);
            this.textBoxRgData.TabIndex = 1;
            // 
            // textBoxRgUf
            // 
            this.textBoxRgUf.Location = new System.Drawing.Point(46, 68);
            this.textBoxRgUf.Name = "textBoxRgUf";
            this.textBoxRgUf.Size = new System.Drawing.Size(84, 23);
            this.textBoxRgUf.TabIndex = 1;
            // 
            // textBoxRgOrgaoExpedicao
            // 
            this.textBoxRgOrgaoExpedicao.Location = new System.Drawing.Point(380, 39);
            this.textBoxRgOrgaoExpedicao.Name = "textBoxRgOrgaoExpedicao";
            this.textBoxRgOrgaoExpedicao.Size = new System.Drawing.Size(85, 23);
            this.textBoxRgOrgaoExpedicao.TabIndex = 1;
            // 
            // textBoxRg
            // 
            this.textBoxRg.Location = new System.Drawing.Point(46, 39);
            this.textBoxRg.Name = "textBoxRg";
            this.textBoxRg.Size = new System.Drawing.Size(205, 23);
            this.textBoxRg.TabIndex = 1;
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.Location = new System.Drawing.Point(46, 10);
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.Size = new System.Drawing.Size(153, 23);
            this.textBoxCpf.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Data:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "UF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Orgão expedição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "RG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "CPF:";
            // 
            // tabPageEndereco
            // 
            this.tabPageEndereco.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageEndereco.Controls.Add(this.comboBoxTipoEndereco);
            this.tabPageEndereco.Controls.Add(this.textBoxendereconumero);
            this.tabPageEndereco.Controls.Add(this.textBoxendereco);
            this.tabPageEndereco.Controls.Add(this.textBoxenderecobairro);
            this.tabPageEndereco.Controls.Add(this.textBoxenderecouf);
            this.tabPageEndereco.Controls.Add(this.textBox12);
            this.tabPageEndereco.Controls.Add(this.textBoxenderecopais);
            this.tabPageEndereco.Controls.Add(this.textBoxenderecomunicipio);
            this.tabPageEndereco.Controls.Add(this.textBox10);
            this.tabPageEndereco.Controls.Add(this.textBoxenderecocomplemento);
            this.tabPageEndereco.Controls.Add(this.textBoxenderecocep);
            this.tabPageEndereco.Controls.Add(this.label11);
            this.tabPageEndereco.Controls.Add(this.label13);
            this.tabPageEndereco.Controls.Add(this.label16);
            this.tabPageEndereco.Controls.Add(this.label17);
            this.tabPageEndereco.Controls.Add(this.label15);
            this.tabPageEndereco.Controls.Add(this.label12);
            this.tabPageEndereco.Controls.Add(this.label10);
            this.tabPageEndereco.Controls.Add(this.label9);
            this.tabPageEndereco.Controls.Add(this.label8);
            this.tabPageEndereco.Location = new System.Drawing.Point(4, 24);
            this.tabPageEndereco.Name = "tabPageEndereco";
            this.tabPageEndereco.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEndereco.Size = new System.Drawing.Size(682, 139);
            this.tabPageEndereco.TabIndex = 1;
            this.tabPageEndereco.Text = "Endereço";
            // 
            // comboBoxTipoEndereco
            // 
            this.comboBoxTipoEndereco.FormattingEnabled = true;
            this.comboBoxTipoEndereco.Items.AddRange(new object[] {
            "RUA",
            "AVENIDA",
            "LOTE"});
            this.comboBoxTipoEndereco.Location = new System.Drawing.Point(117, 9);
            this.comboBoxTipoEndereco.Name = "comboBoxTipoEndereco";
            this.comboBoxTipoEndereco.Size = new System.Drawing.Size(57, 23);
            this.comboBoxTipoEndereco.TabIndex = 2;
            // 
            // textBoxendereconumero
            // 
            this.textBoxendereconumero.Location = new System.Drawing.Point(604, 9);
            this.textBoxendereconumero.Name = "textBoxendereconumero";
            this.textBoxendereconumero.Size = new System.Drawing.Size(77, 23);
            this.textBoxendereconumero.TabIndex = 1;
            // 
            // textBoxendereco
            // 
            this.textBoxendereco.Location = new System.Drawing.Point(247, 9);
            this.textBoxendereco.Name = "textBoxendereco";
            this.textBoxendereco.Size = new System.Drawing.Size(288, 23);
            this.textBoxendereco.TabIndex = 1;
            // 
            // textBoxenderecobairro
            // 
            this.textBoxenderecobairro.Location = new System.Drawing.Point(401, 38);
            this.textBoxenderecobairro.Name = "textBoxenderecobairro";
            this.textBoxenderecobairro.Size = new System.Drawing.Size(280, 23);
            this.textBoxenderecobairro.TabIndex = 1;
            // 
            // textBoxenderecouf
            // 
            this.textBoxenderecouf.Location = new System.Drawing.Point(604, 69);
            this.textBoxenderecouf.Name = "textBoxenderecouf";
            this.textBoxenderecouf.Size = new System.Drawing.Size(77, 23);
            this.textBoxenderecouf.TabIndex = 1;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(117, 101);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(59, 23);
            this.textBox12.TabIndex = 1;
            // 
            // textBoxenderecopais
            // 
            this.textBoxenderecopais.Location = new System.Drawing.Point(182, 101);
            this.textBoxenderecopais.Name = "textBoxenderecopais";
            this.textBoxenderecopais.Size = new System.Drawing.Size(353, 23);
            this.textBoxenderecopais.TabIndex = 1;
            // 
            // textBoxenderecomunicipio
            // 
            this.textBoxenderecomunicipio.Location = new System.Drawing.Point(182, 69);
            this.textBoxenderecomunicipio.Name = "textBoxenderecomunicipio";
            this.textBoxenderecomunicipio.Size = new System.Drawing.Size(353, 23);
            this.textBoxenderecomunicipio.TabIndex = 1;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(117, 69);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(59, 23);
            this.textBox10.TabIndex = 1;
            // 
            // textBoxenderecocomplemento
            // 
            this.textBoxenderecocomplemento.Location = new System.Drawing.Point(117, 38);
            this.textBoxenderecocomplemento.Name = "textBoxenderecocomplemento";
            this.textBoxenderecocomplemento.Size = new System.Drawing.Size(231, 23);
            this.textBoxenderecocomplemento.TabIndex = 1;
            // 
            // textBoxenderecocep
            // 
            this.textBoxenderecocep.Location = new System.Drawing.Point(581, 104);
            this.textBoxenderecocep.Name = "textBoxenderecocep";
            this.textBoxenderecocep.Size = new System.Drawing.Size(100, 23);
            this.textBoxenderecocep.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(541, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Número:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(354, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Bairro:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(544, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "UF:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "País:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Município:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Complemento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(182, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Endereço:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tipo do endereço:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(544, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "CEP:";
            // 
            // tabPageInformacoesPessoais
            // 
            this.tabPageInformacoesPessoais.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageInformacoesPessoais.Controls.Add(this.textBox18);
            this.tabPageInformacoesPessoais.Controls.Add(this.textBoxnascimentouf);
            this.tabPageInformacoesPessoais.Controls.Add(this.textBoxnascimentopais);
            this.tabPageInformacoesPessoais.Controls.Add(this.textBoxnascimentomunicipio);
            this.tabPageInformacoesPessoais.Controls.Add(this.textBoxnascimentopaisnacionalidade);
            this.tabPageInformacoesPessoais.Controls.Add(this.textBox16);
            this.tabPageInformacoesPessoais.Controls.Add(this.textBox14);
            this.tabPageInformacoesPessoais.Controls.Add(this.textBoxnascimentodata);
            this.tabPageInformacoesPessoais.Controls.Add(this.label22);
            this.tabPageInformacoesPessoais.Controls.Add(this.label21);
            this.tabPageInformacoesPessoais.Controls.Add(this.label20);
            this.tabPageInformacoesPessoais.Controls.Add(this.label19);
            this.tabPageInformacoesPessoais.Controls.Add(this.label18);
            this.tabPageInformacoesPessoais.Location = new System.Drawing.Point(4, 24);
            this.tabPageInformacoesPessoais.Name = "tabPageInformacoesPessoais";
            this.tabPageInformacoesPessoais.Size = new System.Drawing.Size(682, 139);
            this.tabPageInformacoesPessoais.TabIndex = 2;
            this.tabPageInformacoesPessoais.Text = "Informaçoes Pessoais";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(141, 107);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(83, 23);
            this.textBox18.TabIndex = 1;
            // 
            // textBoxnascimentouf
            // 
            this.textBoxnascimentouf.Location = new System.Drawing.Point(619, 75);
            this.textBoxnascimentouf.Name = "textBoxnascimentouf";
            this.textBoxnascimentouf.Size = new System.Drawing.Size(60, 23);
            this.textBoxnascimentouf.TabIndex = 1;
            // 
            // textBoxnascimentopais
            // 
            this.textBoxnascimentopais.Location = new System.Drawing.Point(232, 107);
            this.textBoxnascimentopais.Name = "textBoxnascimentopais";
            this.textBoxnascimentopais.Size = new System.Drawing.Size(339, 23);
            this.textBoxnascimentopais.TabIndex = 1;
            // 
            // textBoxnascimentomunicipio
            // 
            this.textBoxnascimentomunicipio.Location = new System.Drawing.Point(232, 75);
            this.textBoxnascimentomunicipio.Name = "textBoxnascimentomunicipio";
            this.textBoxnascimentomunicipio.Size = new System.Drawing.Size(339, 23);
            this.textBoxnascimentomunicipio.TabIndex = 1;
            // 
            // textBoxnascimentopaisnacionalidade
            // 
            this.textBoxnascimentopaisnacionalidade.Location = new System.Drawing.Point(232, 45);
            this.textBoxnascimentopaisnacionalidade.Name = "textBoxnascimentopaisnacionalidade";
            this.textBoxnascimentopaisnacionalidade.Size = new System.Drawing.Size(339, 23);
            this.textBoxnascimentopaisnacionalidade.TabIndex = 1;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(141, 45);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(83, 23);
            this.textBox16.TabIndex = 1;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(141, 78);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(83, 23);
            this.textBox14.TabIndex = 1;
            // 
            // textBoxnascimentodata
            // 
            this.textBoxnascimentodata.Location = new System.Drawing.Point(141, 13);
            this.textBoxnascimentodata.Name = "textBoxnascimentodata";
            this.textBoxnascimentodata.Size = new System.Drawing.Size(155, 23);
            this.textBoxnascimentodata.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(580, 78);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(24, 15);
            this.label22.TabIndex = 0;
            this.label22.Text = "UF:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 110);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 15);
            this.label21.TabIndex = 0;
            this.label21.Text = "País:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(11, 81);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 15);
            this.label20.TabIndex = 0;
            this.label20.Text = "Município:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 48);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(124, 15);
            this.label19.TabIndex = 0;
            this.label19.Text = "País de nacionalidade:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(116, 15);
            this.label18.TabIndex = 0;
            this.label18.Text = "Data do nascimento:";
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(12, 306);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(75, 34);
            this.buttonNovo.TabIndex = 5;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(93, 306);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 34);
            this.buttonEditar.TabIndex = 5;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonGravar
            // 
            this.buttonGravar.Location = new System.Drawing.Point(255, 306);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(75, 34);
            this.buttonGravar.TabIndex = 5;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = true;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(174, 306);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 34);
            this.buttonExcluir.TabIndex = 5;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(166, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "<";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(205, 21);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "<<";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(244, 21);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = ">>";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(283, 21);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 23);
            this.button8.TabIndex = 6;
            this.button8.Text = ">";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // FormCadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 351);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.tabControlPessoais);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormCadastroPessoa";
            this.Text = "Cadastro de Pessoas";
            this.tabControlPessoais.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPageIdentity.ResumeLayout(false);
            this.tabPageIdentity.PerformLayout();
            this.tabPageEndereco.ResumeLayout(false);
            this.tabPageEndereco.PerformLayout();
            this.tabPageInformacoesPessoais.ResumeLayout(false);
            this.tabPageInformacoesPessoais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxCodigo;
        private Label label2;
        private TextBox textBoxNome;
        private TabControl tabControlPessoais;
        private TabPage tabPage2;
        private TabControl tabControl2;
        private TabPage tabPageIdentity;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TabPage tabPageEndereco;
        private Label label11;
        private Label label13;
        private Label label16;
        private Label label17;
        private Label label15;
        private Label label12;
        private Label label10;
        private Label label9;
        private Label label8;
        private TabPage tabPageInformacoesPessoais;
        private Button buttonNovo;
        private Button buttonEditar;
        private Button buttonGravar;
        private Button buttonExcluir;
        private TextBox textBoxendereconumero;
        private TextBox textBoxendereco;
        private TextBox textBoxenderecobairro;
        private TextBox textBoxenderecouf;
        private TextBox textBox10;
        private TextBox textBoxenderecocomplemento;
        private TextBox textBoxenderecocep;
        private TextBox textBox12;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private TextBox textBox18;
        private TextBox textBoxnascimentouf;
        private TextBox textBox16;
        private TextBox textBox14;
        private TextBox textBoxnascimentodata;
        private TextBox textBoxenderecopais;
        private TextBox textBoxenderecomunicipio;
        private TextBox textBoxnascimentopais;
        private TextBox textBoxnascimentomunicipio;
        private TextBox textBoxnascimentopaisnacionalidade;
        private TextBox textBoxRgData;
        private TextBox textBoxRgUf;
        private TextBox textBoxRgOrgaoExpedicao;
        private TextBox textBoxRg;
        private TextBox textBoxCpf;
        private ComboBox comboBoxTipoEndereco;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}