using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SistemaServitec.Controllers
{
    public struct InformacoesAdiantamento
    {
        public string Nome;
        public string Adiantamento;
    }
    public struct InformacoesExtras
    {
        public string Nome;
        public string HorasExtras;
    }
    public struct InformacoesFaltas
    {
        public string Nome;
        public string HorasFaltas;
        public List<string> diasfaltas;

        public InformacoesFaltas ( )
        {
            Nome = "";
            HorasFaltas = "";
            diasfaltas = new List<string> ( );
        }
    }
    internal class Mineracao
    {
        
        public static async Task<List<InformacoesExtras>> GetHorasExtras ( string ArquivoCartaoPonto )
        {
            List<InformacoesExtras> informacoes = new List<InformacoesExtras>();

            await Task.Run ( ( ) =>
            {
                using ( SLDocument sl = new SLDocument ( ArquivoCartaoPonto , "Cartão Ponto" ) )
                {
                    var stats = sl.GetWorksheetStatistics(); //sheet::SLDocument
                    int rows  = stats.NumberOfRows;
                    int col  = stats.NumberOfColumns;
                    InformacoesExtras temp = new InformacoesExtras ( );
                    for ( int i = 1 ; i < rows ; i++ )
                    {
                        for ( int j = 1 ; j < col ; j++ )
                        {
                            if ( sl.GetCellValueAsString ( i , j ) == "Nome" )
                            {
                                temp = new InformacoesExtras ( );
                                temp.Nome = sl.GetCellValueAsString ( i , j + 1 );
                                
                            }
                            if ( sl.GetCellValueAsString ( i , j ) == "Extras" )
                            {
                               
                                temp.HorasExtras = sl.GetCellValueAsDateTime ( i + 1 , j  ).Hour.ToString ( ) + sl.GetCellValueAsDateTime ( i + 1 , j ).Minute.ToString ( );
                                informacoes.Add (temp);
                            }
                          
                        }
                    }

                }
            } );
            
            return  informacoes;
        }
        public static async Task<List<InformacoesFaltas>> GetFaltas ( string ArquivoCartaoPonto )
        {
            List<InformacoesFaltas> informacoes = new List<InformacoesFaltas>();

            await Task.Run ( ( ) =>
            {
                using ( SLDocument sl = new SLDocument ( ArquivoCartaoPonto , "Cartão Ponto" ) )
                {
                    var stats = sl.GetWorksheetStatistics(); //sheet::SLDocument
                    int rows  = stats.NumberOfRows;
                    int col  = stats.NumberOfColumns;
                    InformacoesFaltas temp = new InformacoesFaltas ( );
                    for ( int i = 1 ; i < rows ; i++ )
                    {
                        for ( int j = 1 ; j < col ; j++ )
                        {
                            if ( sl.GetCellValueAsString ( i , j ) == "Nome" )
                            {
                                temp = new InformacoesFaltas ( );
                                temp.Nome = sl.GetCellValueAsString ( i , j + 1 );
                            }

                            if ( sl.GetCellValueAsString ( i , j ) == "Faltas" )
                            {
                               
                                TimeSpan horasFaltas = new TimeSpan(sl.GetCellValueAsDateTime ( i + 1 , j ).Hour, sl.GetCellValueAsDateTime ( i + 1 , j ).Minute,0);
                                if ( horasFaltas .Hours != 0 && horasFaltas.Minutes != 0) {
                                  
                                    for ( int r = i + 2 ; r < i + 34 ; r++ )
                                    {
                                        string hor = sl.GetCellValueAsDateTime ( r , j ).Hour + ":" + sl.GetCellValueAsDateTime ( r , j ).Minute;
                                        if ( hor == "8:48" )
                                        {
                                            temp.diasfaltas.Add ( sl.GetCellValueAsString ( r , 1) +":"+"1");
                                            //dateHorasFaltas.AddHours ( - sl.GetCellValueAsDateTime ( r , j ).Hour );
                                            //dateHorasFaltas.AddMinutes ( -sl.GetCellValueAsDateTime ( r , j ).Minute );
                                           
                                            horasFaltas=  horasFaltas.Subtract (new TimeSpan(8,48,0));
                                           
                                            int s = r;

                                            while (true)
                                            {
                                                if ( sl.GetCellValueAsString ( s , 1 ).Contains ( "dom" ))
                                                {

                                             temp.diasfaltas.Add ( sl.GetCellValueAsString ( s , 1 ) + ":" + "2" );
                                             break;
                                                }
                                                s++;
                                            }
                                            temp.HorasFaltas = horasFaltas.Hours.ToString ( ) + ":" + horasFaltas.Minutes.ToString ( );
                                        }
                                    }
                            }

                                //informacoes.Add ( sl.GetCellValueAsDateTime ( i + 1 , j ).Hour.ToString ( ) + sl.GetCellValueAsDateTime ( i + 1 , j ).Minute.ToString ( ) );
                            }
                            if ( sl.GetCellValueAsString ( i , j ) == "DIRETOR" )
                            {
                                informacoes.Add ( temp);
                                
                            }
                        }

                    }

                }
            } );

            return informacoes;
        }

    }
}
