using PdfSharpCore.Pdf;
using PdfSharpCore.Pdf.IO;

namespace SistemaServitec.Controllers
{
    internal class ControllerPdfs
    {
        public static string result;
        public static bool PdfMerge ( string pdfdestino , string FolderPdfs )
        {

            string[] pdfs = Directory.GetFiles(FolderPdfs,"*.pdf");

            try
            {
                PdfDocument destino = new PdfDocument();

                foreach ( string pdf in pdfs )
                {
                    using ( PdfDocument origem = PdfReader.Open ( pdf , PdfDocumentOpenMode.Import ) )
                    {
                        for ( int i = 0 ; i < origem.PageCount ; i++ )
                        {
                            PdfPage page = origem.Pages[i];
                            destino.AddPage ( page );
                        }

                    }
                }
                destino.Save ( pdfdestino + "\\Mesclado.pdf" );
               
                result = "Imprimindo...";
                return true;
            }
            catch ( Exception e )
            {

                result = e.ToString ( );
                return false;
            }

        }

        private string[] GetPathPdf ( string FolderPdfs )
        {
            string[] path = new string[5];


            return path;
        }



    }
}

