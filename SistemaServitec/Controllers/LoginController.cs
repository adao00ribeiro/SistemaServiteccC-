using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Vml;
using SistemaServitec.Data;
using SistemaServitec.Models;
using SistemaServitec.Repositories;
using SistemaServitec.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBox = System.Windows.Forms.TextBox;

namespace SistemaServitec.Controllers
{
    public static class LoginController
    {
      
        private static SistemaServitecDBContex contex = new SistemaServitecDBContex ( );
        private static IUserRepository repoUser =new UserRepository ( contex );


        public static bool Login ( TextBox textboxuser , TextBox textboxsenha )
        {
            string user =  textboxuser.Text;
            string senha =  textboxsenha.Text;


            if ( string.IsNullOrEmpty ( user ) )
            {
                textboxuser.Focus ( );
                MessageBox.Show ( "Campo Usuario Vazio." );

                return false;
            }
            if ( string.IsNullOrEmpty ( senha ) )
            {
                textboxsenha.Focus ( );
                MessageBox.Show ( "Campo Senha Vazio." );
                return false;
            }

            Task<UserModel> data =  repoUser.SearchByUserName ( user,senha );
            data.Wait ( );

            if ( data.Result == null )
            {
                MessageBox.Show ( "Usuario nao existe!" );
                return false;
            }

            Form1 form =   new Form1 ( );
            form.Visible = true;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.WindowState = FormWindowState.Maximized;
            return true;
        }

       

        internal async static void VerificaAdmin ( )
        {
            Task<UserModel> data =   repoUser.SearchByUserName ( "admin" );

            await data;

            if ( data.Result == null )
            {
                MessageBox.Show ( "admin nao encontrado" );
                repoUser.Add (

                    new UserModel
                    {
                        Name = "admin" ,
                        UserName = "admin" ,
                        Password = "admin" ,
                        IsActive = true
                    } ).Wait ( );
            }
        }
    }
}
