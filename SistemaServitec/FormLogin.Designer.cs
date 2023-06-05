namespace SistemaServitec
{
    partial class FormLogin
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
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Location = new System.Drawing.Point(12, 214);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(284, 41);
            this.buttonEntrar.TabIndex = 5;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsuario.Location = new System.Drawing.Point(12, 84);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(284, 29);
            this.textBoxUsuario.TabIndex = 2;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSenha.Location = new System.Drawing.Point(12, 158);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(284, 29);
            this.textBoxSenha.TabIndex = 4;
            this.textBoxSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSenha_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(88, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Servitec";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 267);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(324, 306);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(324, 306);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonEntrar;
        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private Label label3;
    }
}