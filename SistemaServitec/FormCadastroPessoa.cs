using SistemaServitec.Controllers;
using SistemaServitec.Data;
using SistemaServitec.Interface;
using SistemaServitec.Models;
using SistemaServitec.Repositories;
using System.Data;
namespace SistemaServitec
{
    public partial class FormCadastroPessoa : Form , IMyForm
    {
        PersonRepository repoPerson;
        SistemaServitecDBContex contex;
        bool isBtnNovo;
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
                    buttonNovo.Text = "Novo";
                }
                else
                {
                    buttonNovo.Text = "Cancelar";
                }
            }
        }
        bool isBtnEditar;
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
                    buttonEditar.Text = "Editar";
                }
                else
                {
                    buttonEditar.Text = "Cancelar";
                }
            }
        }
        public FormCadastroPessoa ( )
        {   
            InitializeComponent ( );
            contex = new SistemaServitecDBContex ( );
            repoPerson = new PersonRepository ( contex );
            Task<PersonModel> data = repoPerson.TakeTheLast ( );
            data.Wait ( );
            if (data.IsFaulted)
            {
                MessageBox.Show ( "NAO ASLDKALSDKASLD");
            }
            else
            {
                SetComponents ( data.Result );
            }
           


            DisableComponents ( this.Controls );
            DisableComponents ( tabPageIdentity.Controls );
            DisableComponents ( tabPageEndereco.Controls );
            DisableComponents ( tabPageInformacoesPessoais.Controls );

            //BUSCA NO BANCO 

            //seta buttons
            buttonNovo.Enabled = true;
            buttonEditar.Enabled = true;
            buttonExcluir.Enabled = true;
            buttonGravar.Enabled = false;
            IsBtnNovo = true;
            IsBtnEditar = true;


        }
        public void SetComponents ( PersonModel data )
        {   
            if ( data == null)
            {
                MessageBox.Show ( "Nao Encontrado.");
                return;
            }
            try
            {
                textBoxCodigo.Text = data.Id.ToString ( );
                textBoxNome.Text = data.Name;
                //IDENTIDADE
                textBoxCpf.Text = data.Identidade.CPF;
                textBoxRg.Text = data.Identidade.RG;
                textBoxRgOrgaoExpedicao.Text = data.Identidade.OrgaoExpedicao;
                textBoxRgUf.Text = data.Identidade.UF;
                textBoxRgData.Text = data.Identidade.Data;
                //endereco
                comboBoxTipoEndereco.SelectedIndex = comboBoxTipoEndereco.FindString ( data.Endereco.Tipo);
                textBoxendereco.Text = data.Endereco.Residencia;
                textBoxendereconumero.Text = data.Endereco.Numero;
                textBoxenderecocomplemento.Text = data.Endereco.complemento;
                textBoxenderecobairro.Text = data.Endereco.Bairro;
                textBoxenderecomunicipio.Text = data.Endereco.Municipio;
                textBoxenderecouf.Text = data.Endereco.UF;
                textBoxenderecopais.Text = data.Endereco.Pais;
                textBoxenderecocep.Text = data.Endereco.CEP;
                //NASCIMENTO
                textBoxnascimentodata.Text = data.DataNascimento;
                textBoxnascimentopaisnacionalidade.Text = data.PaisNacionalidade;
                textBoxnascimentomunicipio.Text = data.Municipio;
                textBoxnascimentouf.Text = data.UF;
                textBoxnascimentopais.Text = data.Pais;
            }
            catch ( Exception ex )
            {

                MessageBox.Show ( ex.Message );
            }

            textBoxCodigo.Enabled = false;
        }
        private void SetEmptyComponents ( Control.ControlCollection control )
        {
            foreach ( TextBox item in control.OfType<TextBox> ( ) )
            {
                item.Text = "";
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
        private void EnableComponents ( Control.ControlCollection control )
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
        private void buttonNovo_Click ( object sender , EventArgs e )
        {
            Task<PersonModel> data = repoPerson.TakeTheLast ( );
            data.Wait ( );
            long codigotemp = data.Result.Id;
            if ( IsBtnNovo )
            {
                EnableComponents ( this.Controls );
                EnableComponents ( tabPageIdentity.Controls );
                EnableComponents ( tabPageEndereco.Controls );
                EnableComponents ( tabPageInformacoesPessoais.Controls );
                SetEmptyComponents ( this.Controls );
                SetEmptyComponents ( tabPageIdentity.Controls );
                SetEmptyComponents ( tabPageEndereco.Controls );
                SetEmptyComponents ( tabPageInformacoesPessoais.Controls );
                codigotemp += 1;
                textBoxCodigo.Text = codigotemp.ToString ( );
                textBoxCodigo.Enabled = false;
                buttonGravar.Enabled = true;
                buttonEditar.Enabled = false;
            }
            else
            {
                DisableComponents ( this.Controls );
                DisableComponents ( tabPageIdentity.Controls );
                DisableComponents ( tabPageEndereco.Controls );
                DisableComponents ( tabPageInformacoesPessoais.Controls );
                data = repoPerson.TakeTheLast ( );
                data.Wait ( );
                SetComponents ( data.Result );
                buttonGravar.Enabled = false;
                buttonEditar.Enabled = true;
            }

            IsBtnNovo = !IsBtnNovo;

        }



        private void buttonEditar_Click ( object sender , EventArgs e )
        {
            if ( IsBtnEditar )
            {
                EnableComponents ( this.Controls );
                EnableComponents ( tabPageIdentity.Controls );
                EnableComponents ( tabPageEndereco.Controls );
                EnableComponents ( tabPageInformacoesPessoais.Controls );
                SetEmptyComponents ( this.Controls );
                SetEmptyComponents ( tabPageIdentity.Controls );
                SetEmptyComponents ( tabPageEndereco.Controls );
                SetEmptyComponents ( tabPageInformacoesPessoais.Controls );

                buttonGravar.Enabled = true;
                buttonNovo.Enabled = false;
            }
            else
            {
                DisableComponents ( this.Controls );
                DisableComponents ( tabPageIdentity.Controls );
                DisableComponents ( tabPageEndereco.Controls );
                DisableComponents ( tabPageInformacoesPessoais.Controls );
                buttonGravar.Enabled = false;
                buttonNovo.Enabled = true;
            }

            IsBtnEditar = !IsBtnEditar;
        }

        private void buttonGravar_Click ( object sender , EventArgs e )
        {
            try
            {
                PersonModel TempPerson = new PersonModel();
                TempPerson.Id = int.Parse ( textBoxCodigo.Text );
                TempPerson.Name = textBoxNome.Text;
                //IDENTIDADE
                IdentityModel identity = new IdentityModel();
                identity.CPF = textBoxCpf.Text;
                identity.RG = textBoxRg.Text;
                identity.OrgaoExpedicao = textBoxRgOrgaoExpedicao.Text;
                identity.UF = textBoxRgUf.Text;
                identity.Data = textBoxRgData.Text;
                //endereco
                AddressModel address = new AddressModel();
                address.Tipo = comboBoxTipoEndereco.Text;
                address.Residencia = textBoxendereco.Text;
                address.Numero = textBoxendereconumero.Text;
                address.complemento = textBoxenderecocomplemento.Text;
                address.Bairro = textBoxenderecobairro.Text;
                address.Municipio = textBoxenderecomunicipio.Text;
                address.UF = textBoxenderecouf.Text;
                address.Pais = textBoxenderecopais.Text;
                address.CEP = textBoxenderecocep.Text;
                //NASCIMENTO
                TempPerson.DataNascimento = textBoxnascimentodata.Text;
                TempPerson.PaisNacionalidade = textBoxnascimentopaisnacionalidade.Text;
                TempPerson.Municipio = textBoxnascimentomunicipio.Text;
                TempPerson.UF = textBoxnascimentouf.Text;
                TempPerson.Pais = textBoxnascimentopais.Text;
                //set
                TempPerson.Identidade = identity;
                TempPerson.Endereco = address;

                Task<PersonModel> data = null;
                if ( !IsBtnEditar )
                {
                    data = repoPerson.Update ( TempPerson , TempPerson.Id);
                    data.Wait ( );
                    IsBtnEditar = !IsBtnEditar;
                   
                }
                if( !IsBtnNovo )
                {
                    data=  repoPerson.Add ( TempPerson );
                    data.Wait ( );
                    IsBtnNovo = !IsBtnNovo;
                }
                DisableComponents ( this.Controls );
                DisableComponents ( tabPageIdentity.Controls );
                DisableComponents ( tabPageEndereco.Controls );
                DisableComponents ( tabPageInformacoesPessoais.Controls );
                SetComponents ( data.Result );

                buttonGravar.Enabled = false;
                buttonEditar.Enabled = true;
                buttonNovo.Enabled = true;
            }
            catch ( Exception )
            {

                MessageBox.Show ( "ola mundo");
            }
            
        }

        private void button6_Click ( object sender , EventArgs e )
        {
            int codigo =0;
            if ( textBoxCodigo.Text == "" || !int.TryParse ( textBoxCodigo.Text , out codigo ) )
            {
                return;
            }
            codigo -= 1;
            if ( codigo == 0 )
            {
                return;
            }

            Task<PersonModel> data =repoPerson.SearchById ( codigo);
            data.Wait ( );
            SetComponents ( data.Result );


        }

        private void button7_Click ( object sender , EventArgs e )
        {
            int codigo =0;
            if ( textBoxCodigo.Text == "" || !int.TryParse ( textBoxCodigo.Text , out codigo ) )
            {
                return;
            }
            codigo += 1;
            Task<PersonModel> data = repoPerson.SearchById ( codigo);
            data.Wait ( );
            SetComponents ( data.Result );

        }

        private void buttonExcluir_Click ( object sender , EventArgs e )
        {
           Task<bool> result =  repoPerson.Delete ( int.Parse ( textBoxCodigo.Text ));

            if ( result .Result)
            {
                MessageBox.Show ( "sadadasd");
            }
            else
            {
                MessageBox.Show ( "aaaaaaaaaaaaa" );
            }
        }

        private void textBoxCodigo_KeyDown ( object sender , KeyEventArgs e )
        {
            if (e.KeyCode == Keys.F2)
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

       
    }
}
