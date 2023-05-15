using DocumentFormat.OpenXml.Spreadsheet;
using SistemaServitec.Data;
using SistemaServitec.Interface;
using SistemaServitec.Models;
using SistemaServitec.Repositories;
using Control = System.Windows.Forms.Control;

namespace SistemaServitec
{
    public partial class FormContratoLocacao : Form, IMyForm
    {
        PersonRepository repoPerson;
        SistemaServitecDBContex contex;
        bool isBtnNovo;
        bool isBtnEditar;
        bool IsBtnNovo
        {
            get
            {
                return isBtnNovo;
            }
            set
            {
                isBtnNovo = value;
                if ( isBtnNovo )
                {
                    btnNovo.Text = "Novo";
                }
                else
                {
                    btnNovo.Text = "Cancelar";
                }
            }
        }

        bool IsBtnEditar
        {
            get
            {
                return isBtnEditar;
            }

            set
            {
                isBtnEditar = value;
                if ( isBtnEditar )
                {
                    btnEditar.Text = "Editar";
                }
                else
                {
                    btnEditar.Text = "Cancelar";
                }
            }
        }
        public FormContratoLocacao ( )
        {
            InitializeComponent ( );
            contex = new SistemaServitecDBContex ( );
            repoPerson = new PersonRepository ( contex );
            //seta buttons
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnGravar.Enabled = false;
            IsBtnNovo = true;
            IsBtnEditar = true;
        }
      
        private void label1_Click ( object sender , EventArgs e )
        {

        }

        private void button9_Click ( object sender , EventArgs e )
        {

        }

        private void button1_Click ( object sender , EventArgs e )
        {

        }

        private void btnNovo_Click ( object sender , EventArgs e )
        {

            long codigotemp = 0;

            if ( IsBtnNovo )
            {
                EnableComponents ( this.Controls );
                EnableComponents ( this.groupBox.Controls );

                SetEmptyComponents ( this.Controls );
                SetEmptyComponents ( this.groupBox.Controls );
              
                codigotemp += 1;
                textBoxCodigo.Text = codigotemp.ToString ( );
                textBoxCodigo.Enabled = false;
                btnGravar.Enabled = true;
                btnEditar.Enabled = false;
            }
            else
            {
                DisableComponents ( this.Controls );
                DisableComponents ( this.groupBox.Controls );
              
                //data = repoPerson.TakeTheLast ( );
               // data.Wait ( );
               // SetComponents ( data.Result );
                btnGravar.Enabled = false;
                btnEditar.Enabled = true;
            }

            IsBtnNovo = !IsBtnNovo;
        }
        private void SetEmptyComponents ( Control.ControlCollection control )
        {
            foreach ( TextBox item in control.OfType<TextBox> ( ) )
            {
                item.Text = "";
            }
        }
        public void EnableComponents ( Control.ControlCollection control )
        {
            foreach ( TextBox item in control.OfType<TextBox> ( ) )
            {
                item.Enabled = true;
            }
            foreach ( ComboBox item in control.OfType<ComboBox> ( ) )
            {
                item.Enabled = true;
            }
        }
        private void DisableComponents ( Control.ControlCollection control )
        {
            foreach ( TextBox item in control.OfType<TextBox> ( ) )
            {
                item.Enabled = false;
            }
            foreach ( ComboBox item in control.OfType<ComboBox> ( ) )
            {
                item.Enabled = false;
            }
        }

        private void textBoxCodigo_KeyDown ( object sender , KeyEventArgs e )
        {
         
        }

        private void textBoxCodigoLocador_KeyDown ( object sender , KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.F2 )
            {
                FormListPerson listPerson = new FormListPerson(this);
                listPerson.StartPosition = FormStartPosition.CenterScreen;
                listPerson.Show ( );
                return;
            }
            if ( e.KeyCode == Keys.Enter )
            {
                int codigo =0;
                if ( textBoxCodigo.Text == "" || !int.TryParse ( textBoxCodigo.Text , out codigo ) )
                {
                    return;
                }
                Task<PersonModel> data =repoPerson.SearchById ( codigo);
                data.Wait ( );
                SetComponents ( data.Result );
                return;
            }
        }

        private void textBoxCodigoLocatario_KeyDown ( object sender , KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.F2 )
            {
                FormListPerson listPerson = new FormListPerson(this);
                listPerson.StartPosition = FormStartPosition.CenterScreen;
                listPerson.Show ( );
                return;
            }
            if ( e.KeyCode == Keys.Enter )
            {
                int codigo =0;
                if ( textBoxCodigo.Text == "" || !int.TryParse ( textBoxCodigo.Text , out codigo ) )
                {
                    return;
                }
                Task<PersonModel> data =repoPerson.SearchById ( codigo);
                data.Wait ( );
                SetComponents ( data.Result );
                return;
            }
        }

        public void SetComponents ( PersonModel data )
        {
            throw new NotImplementedException ( );
        }

        private void FormContratoLocacao_Load ( object sender , EventArgs e )
        {

        }
    }
}
