using SistemaServitec.Data;
using SistemaServitec.Interface;
using SistemaServitec.Models;
using SistemaServitec.Repositories;
using System.Data;


namespace SistemaServitec
{
    public partial class FormListPerson : Form
    {
        IMyForm formpai;
        SistemaServitecDBContex contex;
        PersonRepository repoPerson;
        public FormListPerson (  IMyForm _formpai)
        {
            InitializeComponent ( );
            contex = new SistemaServitecDBContex ( );
            repoPerson = new PersonRepository ( contex );
            formpai = _formpai;
        }

        private void FormListPerson_Load ( object sender , EventArgs e )
        {
            Task<List < PersonModel >> data =  repoPerson.ListAll ( );
            data.Wait ( );
            dataGridView1.DataSource = data.Result;
        }

      

        private void dataGridView1_DoubleClick ( object sender , EventArgs e )
        {
            DataGridView dv = (DataGridView)sender;

            string idstring =  dv.SelectedRows[0].Cells[0].Value.ToString ( );

            Task<PersonModel> data =  repoPerson.SearchById ( int.Parse( idstring ) );

            data.Wait ( );

            formpai.SetComponents ( data.Result);

            this.Close ( );

        }
    }
}
