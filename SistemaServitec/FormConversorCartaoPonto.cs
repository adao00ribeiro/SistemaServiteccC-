using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaServitec.Classes;
using SistemaServitec.Controllers;
using DocumentFormat.OpenXml.Spreadsheet;
using SpreadsheetLight;

namespace SistemaServitec
{

    public struct Lancamentos
    {
        public string nome;
        public string HorasExtras;
        public string HorasFaltas;
    }
    public partial class FormConversorCartaoPonto : Form
    {
        int mes = 0;
        int ano = 2022;
        string registroEmpregados = "D:\\repos\\arcsolucoes\\arcsolucoes\\bin\\Debug\\net6.0-windows\\Empregados.xlsx";
        string ArquivoCartaoPonto = "";
        string ArquivoAdiantamento = "";
        string ArquivoDestino = "";
        ControllerEmployee ControllerEmpregado;
        public FormConversorCartaoPonto ( )
        {
            InitializeComponent ( );
             ControllerEmpregado = new ControllerEmployee();

            using ( SLDocument sl = new SLDocument ( registroEmpregados , "Empregado" ) )
            {
                var stats = sl.GetWorksheetStatistics(); //sheet::SLDocument

                int rows  = stats.NumberOfRows;
                int col  = stats.NumberOfColumns;

                for ( int i = 2 ; i < rows ; i++ )
                {
                 Employee temp = new Employee();
                 temp.codigo = sl.GetCellValueAsString ( i , 1);
                 temp.Nome = sl.GetCellValueAsString ( i , 2 );
                 ControllerEmpregado.AddEmpregados ( temp );
                }

            }
            
       
        }

        private void button1_Click ( object sender , EventArgs e )
        {

            using ( var dialog = new OpenFileDialog ( ) )
            {
                dialog.Title = "Arquivo Cartao Ponto";
                dialog.Filter = "xlsx files (*.xlsx)|*.xlsx";
                dialog.FilterIndex = 2;

                if ( dialog.ShowDialog ( ) == DialogResult.OK )
                {
                    textBoxArquivoCartaoPonto.Text = dialog.FileName;
                }
            }

        }

       

        private void button3_Click ( object sender , EventArgs e )
        {
            using ( var dialog = new System.Windows.Forms.FolderBrowserDialog ( ) )
            {

                System.Windows.Forms.DialogResult result = dialog.ShowDialog();

                if ( result == System.Windows.Forms.DialogResult.OK )
                {
                    textBoxArquivoDestino.Text = dialog.SelectedPath;

                }

            }
        }

        private void button2_Click ( object sender , EventArgs e )
        {
            using ( var dialog = new OpenFileDialog ( ) )
            {
                dialog.Title = "Arquivo Adiantamento";
                dialog.Filter = "xlsx files (*.xlsx)|*.xlsx";
                dialog.FilterIndex = 2;

                if ( dialog.ShowDialog ( ) == DialogResult.OK )
                {
                    textBoxArquivoAdiantamento.Text = dialog.FileName;
                }
            }
        }

        private void buttonCancelar_Click ( object sender , EventArgs e )
        {
            this.Close ( );
        }

        private async void buttonConverter_Click ( object sender , EventArgs e )
        {
            string[] competenciaseparado = maskedTextBoxCompetencia.Text.Split ("/");
            mes = int.Parse ( competenciaseparado[0] );
            ano = int.Parse ( competenciaseparado[1] );
            ArquivoCartaoPonto = textBoxArquivoCartaoPonto.Text;
            ArquivoAdiantamento = textBoxArquivoAdiantamento.Text;
            ArquivoDestino = textBoxArquivoDestino.Text;

            if ( String.IsNullOrEmpty(ArquivoCartaoPonto) )
            {
                textBoxArquivoCartaoPonto.Select ( );
                MessageBox.Show ( "Arquivo Cartao Ponto não foi selecionado." );
                return;
            }
            if ( String.IsNullOrEmpty ( ArquivoAdiantamento ) )
            {
                textBoxArquivoAdiantamento.Select ( );
                MessageBox.Show ( "Arquivo Adiantamento não foi selecionado." );
                return;
            }
            if ( String.IsNullOrEmpty ( ArquivoDestino ) )
            {
                textBoxArquivoDestino.Select ( );
                MessageBox.Show ( "Arquivo Destino não foi selecionado." );
                return;
            }

            List<InformacoesExtras> informacoeHorasExtras = await  Mineracao.GetHorasExtras(ArquivoCartaoPonto);
            List<InformacoesFaltas> informacoeFaltas= await  Mineracao.GetFaltas(ArquivoCartaoPonto);
            /*
            string texto = "";
            foreach ( var item in informacoeHorasExtras )
            {

                texto += item.Nome + "\n";
                texto += item.HorasExtras + "\n";
            }
            MessageBox.Show ( texto );

            
            string texto = "";
            foreach ( var item in informacoeFaltas )
            {
               
                    texto += item.Nome + "\n";
                    texto += item.HorasFaltas + "\n";

                    for ( int i = 0 ; i < item.diasfaltas.Count ; i++ )
                    {
                        texto += item.diasfaltas[i] + "\n";
                    }
                
            }
            MessageBox.Show (texto );
            /*
            return;
                int k = 0;

                while ( k < informacoes.Count - 3 )
                {

                    Lancamentos temp = new Lancamentos();
                    temp.Nome = informacoes[k];
                    temp.HorasExtras = informacoes[k + 1];
                    temp.HorasFaltas = informacoes[k + 2];
                    ControllerEmpregado.SetLancamentosHorasExtras ( temp );
                    k = k + 3;
                }
           */
            foreach ( var item in informacoeHorasExtras )
            {
                ControllerEmpregado.SetLancamentosHorasExtras ( item );
            }


            // ControllerEmpregado.Print ( );
            string fileName = ArquivoDestino + "\\extras.txt";
            FileInfo fi = new FileInfo(fileName);
            if ( File.Exists ( fileName ) )
            {
                File.Delete ( fileName );
            }
            using ( StreamWriter sw = fi.CreateText ( ) )
            {

                string competencia = ano.ToString ( "0000" ) + mes.ToString ( "00" ) ;

                sw.WriteLine ( ControllerEmpregado.GetTxtExtras ( competencia ) );
            }
            

        }
        private void button6_Click ( object sender , EventArgs e )
        {
            string[] competenciaseparado = maskedTextBoxCompetencia.Text.Split ("/");
            mes = int.Parse ( competenciaseparado[0] );
            ano = int.Parse ( competenciaseparado[1] );
            mes++;
            if ( mes > 12 )
            {
                mes = 01;
                ano++;
            }
            maskedTextBoxCompetencia.Text = mes.ToString ( "00" ) + ano.ToString ( "0000" );
        }
        private void button7_Click ( object sender , EventArgs e )
        {
            string[] competenciaseparado = maskedTextBoxCompetencia.Text.Split ("/");
            mes = int.Parse ( competenciaseparado[0] );
            ano = int.Parse ( competenciaseparado[1] );
            mes--;
            if ( mes < 1 )
            {
                mes = 12;
                ano--;
            }
            maskedTextBoxCompetencia.Text = mes.ToString ( "00" ) + ano.ToString ( "0000" );
        }
    }
}
