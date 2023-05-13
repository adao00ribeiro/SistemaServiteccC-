using SistemaServitec.Controllers;
using SistemaServitec.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaServitec
{
    public partial class FormListPerson : Form
    {
        IMyForm formpai;
        ControllerPerson controllerPerson;
        public FormListPerson (  IMyForm _formpai)
        {
            InitializeComponent ( );
            controllerPerson = new ControllerPerson ( );
            formpai = _formpai;
        }

        private void FormListPerson_Load ( object sender , EventArgs e )
        {
            Task<DataTable> data =  controllerPerson.ListAllHandle ( );
            data.Wait ( );
            dataGridView1.DataSource = data.Result;
        }

      

        private void dataGridView1_DoubleClick ( object sender , EventArgs e )
        {
            DataGridView dv = (DataGridView)sender;

            string idstring =  dv.SelectedRows[0].Cells[0].Value.ToString ( );

            Task<DataTable> data =  controllerPerson.GetPersonByIdHandle ( int.Parse( idstring ) );

            data.Wait ( );

            formpai.SetComponents ( data.Result);

            this.Close ( );

        }
    }
}
