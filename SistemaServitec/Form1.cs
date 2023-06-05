using SistemaServitec.Classes;

namespace SistemaServitec
{
    public partial class Form1 : Form
    {
        public Form1 ( )
        {
            InitializeComponent ( );



        }
        private void mesclarPdfsToolStripMenuItem_Click ( object sender , EventArgs e )
        {
            FormMesclarPdf FormMesclarPdf = new FormMesclarPdf();
            FormMesclarPdf.MdiParent = this;
            FormMesclarPdf.StartPosition = FormStartPosition.CenterScreen;
            FormMesclarPdf.Show ( );
        }

        private void converterCartaoPontoToolStripMenuItem_Click ( object sender , EventArgs e )
        {
            FormConversorCartaoPonto FormConversorCartaoPonto = new FormConversorCartaoPonto();
            FormConversorCartaoPonto.MdiParent = this;
            FormConversorCartaoPonto.StartPosition = FormStartPosition.CenterScreen;
            FormConversorCartaoPonto.Show ( );
        }

        private void sairToolStripMenuItem_Click ( object sender , EventArgs e )
        {
            Application.Exit ( );
        }

        private void pessoasToolStripMenuItem_Click ( object sender , EventArgs e )
        {
            FormCadastroPessoa FormCadastroPessoa = new FormCadastroPessoa();
            FormCadastroPessoa.MdiParent = this;
            FormCadastroPessoa.StartPosition = FormStartPosition.CenterScreen;
            FormCadastroPessoa.Show ( );
        }

        private void locaçãoToolStripMenuItem_Click ( object sender , EventArgs e )
        {
           
        }

        private void contratoLocaçãoToolStripMenuItem_Click ( object sender , EventArgs e )
        {
            FormContratoLocacao formContratoLocacao = new FormContratoLocacao();
            formContratoLocacao.MdiParent = this;
            formContratoLocacao.StartPosition = FormStartPosition.CenterScreen;
            formContratoLocacao.Show ( );
        }

       
    }
}