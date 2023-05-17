using SistemaServitec.Controllers;
using System.Diagnostics;
using System.IO.Compression;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;


namespace SistemaServitec
{
    public partial class FormMesclarPdf : Form
    {
        string FolderOutput = "";
        public FormMesclarPdf ( )
        {
            InitializeComponent ( );
            buttonMesclar.Enabled = false;
            FolderOutput = Path.Combine ( AppDomain.CurrentDomain.BaseDirectory , "FolderOutput");
     
        }
        private void button1_Click ( object sender , EventArgs e )
        {
            using ( FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog () )
            {
                System.Windows.Forms.DialogResult result = dialog.ShowDialog();
                if ( result == System.Windows.Forms.DialogResult.OK )
                {
                    textBox1.Text = dialog.SelectedPath;

                    buttonMesclar.Enabled = true;
                    //------pegar pdfs 
                    string[] pdfs = Directory.GetFiles(textBox1.Text, "*.pdf");

                    listBox1.Items.Clear ( );
                    for ( int i = 0 ; i < pdfs.Length ; i++ )
                    {
                        listBox1.Items.Add ( pdfs[i]);
                    }
                }
            }
        }

       

        private void button2_Click ( object sender , EventArgs e )
        {
            Directory.Delete ( FolderOutput , true );
            using ( OpenFileDialog dialog = new System.Windows.Forms.OpenFileDialog ( ) )
            {
                dialog.Filter = "Zip Rar Files |*.zip";
                System.Windows.Forms.DialogResult result = dialog.ShowDialog();

                if ( result == System.Windows.Forms.DialogResult.OK )
                {
                   textBox1.Text = dialog.FileName ;
                   Tools.ExtractToDirectory ( dialog.FileName , FolderOutput );
                   Task t =  Tools.Esperar();
                   t.Wait ();
                    var arquivos = Directory.GetFiles( FolderOutput ,"*.pdf",SearchOption.AllDirectories);
                    //pega os pdfs e move eles 
                    for ( int i = 0 ; i < arquivos.Length ; i++ )
                    {
                      File.Move ( arquivos[i] , FolderOutput + "\\"+ Path.GetFileName ( arquivos[i] ) );
                    }
                   
                    t.Wait ( );
                    string[] pdfs = Directory.GetFiles( FolderOutput, "*.pdf");
                    listBox1.Items.Clear ( );
                    for ( int i = 0 ; i < pdfs.Length ; i++ )
                    {
                        listBox1.Items.Add ( pdfs[i] );
                    }
                    buttonMesclar.Enabled = true;
                }

            }
        }
        private void buttonMesclar_Click ( object sender , EventArgs e )
        {

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string pdfFinal = ControllerPdfs.PdfMerge ( path , FolderOutput );
             Task t =  Tools.Esperar();
             t.Wait ();
            if ( pdfFinal != "")
            {
              
                ProcessStartInfo startInfo = new ProcessStartInfo("explorer.exe",pdfFinal);
                Process.Start ( startInfo );

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show ( "Concluido" , "Mesclagem" , buttons );
                if ( result == System.Windows.Forms.DialogResult.OK )
                {
                    // Closes the parent form.
                    this.Close ( );
                }

                //BtnImprimir.Enabled = true;
            }
            else
            {
                MessageBox.Show ( "ERRO\n" );
            }
        }

        private void buttonCancelar_Click ( object sender , EventArgs e )
        {
            this.Close ( );
        }
    }
}
