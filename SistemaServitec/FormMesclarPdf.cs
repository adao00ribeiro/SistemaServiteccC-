using SistemaServitec.Controllers;
using System.Security.AccessControl;
using System.Security.Principal;


namespace SistemaServitec
{
    public partial class FormMesclarPdf : Form
    {
       // Print print;
         
        string nomePasta = "//NOVAPASTA";
        public FormMesclarPdf ( )
        {
            InitializeComponent ( );

            buttonMesclar.Enabled = false;
        }

        private void button1_Click ( object sender , EventArgs e )
        {
            using ( var dialog = new System.Windows.Forms.FolderBrowserDialog ( ) )
            {

                System.Windows.Forms.DialogResult result = dialog.ShowDialog();

                if ( result == System.Windows.Forms.DialogResult.OK )
                {
                    textBox1.Text = dialog.SelectedPath;

                    buttonMesclar.Enabled = true;
                    //------pegar pdfs e fazer merge
                    string[] pdfs = Directory.GetFiles(textBox1.Text, "*.pdf");

                    listBox1.Items.Clear ( );
                    for ( int i = 0 ; i < pdfs.Length ; i++ )
                    {
                        listBox1.Items.Add ( pdfs[i]);
                    }
                }

            }
        }

        private void buttonMesclar_Click ( object sender , EventArgs e )
        {
            string path = textBox1.Text + nomePasta;

            if ( !Directory.Exists ( path ) )
            {

                DirectorySecurity dSecurity = Directory.CreateDirectory(path).GetAccessControl();
                dSecurity.AddAccessRule ( new FileSystemAccessRule ( new SecurityIdentifier ( WellKnownSidType.WorldSid , null ) , FileSystemRights.FullControl , InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit , PropagationFlags.NoPropagateInherit , AccessControlType.Allow ) );
                Directory.CreateDirectory ( path ).SetAccessControl ( dSecurity );
            }

            if ( ControllerPdfs.PdfMerge ( path , textBox1.Text ) )
            {
                MessageBox.Show ( "PDFS MESCLADOS\n" );
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
