namespace SistemaServitec
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.controleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aruivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesclarPdfsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.converterCartaoPontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.contratoLocaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 95);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(112, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(688, 56);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(112, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 39);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controleToolStripMenuItem,
            this.aruivosToolStripMenuItem,
            this.processosToolStripMenuItem,
            this.utilitariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(688, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // controleToolStripMenuItem
            // 
            this.controleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.controleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.controleToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.controleToolStripMenuItem.Name = "controleToolStripMenuItem";
            this.controleToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.controleToolStripMenuItem.Text = "Controle";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // aruivosToolStripMenuItem
            // 
            this.aruivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoasToolStripMenuItem,
            this.contratoLocaçãoToolStripMenuItem});
            this.aruivosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aruivosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.aruivosToolStripMenuItem.Name = "aruivosToolStripMenuItem";
            this.aruivosToolStripMenuItem.Size = new System.Drawing.Size(75, 35);
            this.aruivosToolStripMenuItem.Text = "Arquivos";
            // 
            // pessoasToolStripMenuItem
            // 
            this.pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            this.pessoasToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.pessoasToolStripMenuItem.Text = "Pessoas";
            this.pessoasToolStripMenuItem.Click += new System.EventHandler(this.pessoasToolStripMenuItem_Click);
            // 
            // processosToolStripMenuItem
            // 
            this.processosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locaçãoToolStripMenuItem});
            this.processosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.processosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.processosToolStripMenuItem.Name = "processosToolStripMenuItem";
            this.processosToolStripMenuItem.Size = new System.Drawing.Size(81, 35);
            this.processosToolStripMenuItem.Text = "Processos";
            // 
            // locaçãoToolStripMenuItem
            // 
            this.locaçãoToolStripMenuItem.Name = "locaçãoToolStripMenuItem";
            this.locaçãoToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.locaçãoToolStripMenuItem.Text = "Locação";
            this.locaçãoToolStripMenuItem.Click += new System.EventHandler(this.locaçãoToolStripMenuItem_Click);
            // 
            // utilitariosToolStripMenuItem
            // 
            this.utilitariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesclarPdfsToolStripMenuItem,
            this.converterCartaoPontoToolStripMenuItem});
            this.utilitariosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.utilitariosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.utilitariosToolStripMenuItem.Name = "utilitariosToolStripMenuItem";
            this.utilitariosToolStripMenuItem.Size = new System.Drawing.Size(79, 35);
            this.utilitariosToolStripMenuItem.Text = "Utilitarios";
            // 
            // mesclarPdfsToolStripMenuItem
            // 
            this.mesclarPdfsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mesclarPdfsToolStripMenuItem.Name = "mesclarPdfsToolStripMenuItem";
            this.mesclarPdfsToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.mesclarPdfsToolStripMenuItem.Text = "Mesclar Pdfs";
            this.mesclarPdfsToolStripMenuItem.Click += new System.EventHandler(this.mesclarPdfsToolStripMenuItem_Click);
            // 
            // converterCartaoPontoToolStripMenuItem
            // 
            this.converterCartaoPontoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.converterCartaoPontoToolStripMenuItem.Name = "converterCartaoPontoToolStripMenuItem";
            this.converterCartaoPontoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.converterCartaoPontoToolStripMenuItem.Text = "Converter Cartao Ponto WM";
            this.converterCartaoPontoToolStripMenuItem.Click += new System.EventHandler(this.converterCartaoPontoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soluções";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contratoLocaçãoToolStripMenuItem
            // 
            this.contratoLocaçãoToolStripMenuItem.Name = "contratoLocaçãoToolStripMenuItem";
            this.contratoLocaçãoToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.contratoLocaçãoToolStripMenuItem.Text = "Contrato Locação";
            this.contratoLocaçãoToolStripMenuItem.Click += new System.EventHandler(this.contratoLocaçãoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Servitec";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem controleToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem aruivosToolStripMenuItem;
        private ToolStripMenuItem processosToolStripMenuItem;
        private ToolStripMenuItem utilitariosToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem mesclarPdfsToolStripMenuItem;
        private ToolStripMenuItem converterCartaoPontoToolStripMenuItem;
        private ToolStripMenuItem pessoasToolStripMenuItem;
        private ToolStripMenuItem locaçãoToolStripMenuItem;
        private ToolStripMenuItem contratoLocaçãoToolStripMenuItem;
    }
}