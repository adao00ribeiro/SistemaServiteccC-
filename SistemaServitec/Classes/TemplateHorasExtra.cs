using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaServitec.Classes
{
    internal class TemplateHorasExtra
    {

        public string GetTxt (string Competencia, Employee empregado)
        {
            string txt =  "";
            txt = "10";
            txt += int.Parse ( empregado.codigo ).ToString ( "0000000000" );
            txt += Competencia;
            txt += 150.ToString ( "0000" ); 
            txt += "11";
            txt += int.Parse(empregado.HorasExtras ).ToString ( "000000000" );
            txt += 1.ToString ( "0000000000" );
            return txt;
        }
    }
}
