using SistemaServitec.Controllers;
using SistemaServitec.Data;
using SistemaServitec.Models;
using SistemaServitec.Repositories;
using SistemaServitec.Repositories.Interfaces;
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
    public partial class FormLogin : Form
    {
       
        public FormLogin ( )
        {
            InitializeComponent ( );

            LoginController.VerificaAdmin ( );
            
        }

        private void buttonEntrar_Click ( object sender , EventArgs e )
        {
            if ( LoginController.Login ( this.textBoxUsuario , this.textBoxSenha )){
                this.Visible = false;
            }
        }

        private void textBoxSenha_KeyDown ( object sender , KeyEventArgs e )
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }
            if ( LoginController.Login ( this.textBoxUsuario , this.textBoxSenha ) )
            {
                this.Visible = false;
            }
        }
    }
}
