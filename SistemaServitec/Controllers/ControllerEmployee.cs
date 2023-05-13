using SistemaServitec.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaServitec.Controllers
{
    internal class ControllerEmployee
    {
        private List<Employee> Empregados;

        public ControllerEmployee ( )
        {
            Empregados = new List<Employee> ( );
        }

        public void AddEmpregados ( Employee empregado)
        {
            Empregados.Add ( empregado);
        }

        public Employee GetEmpregado ( string codigo)
        {
            return Empregados.Find ( x => x.codigo == codigo );
        }

        internal string GetTxtExtras ( string competencia)
        {
            TemplateHorasExtra template = new TemplateHorasExtra();
            string txt = "";
            foreach ( Employee TempEmpregado in Empregados )
            {
                if (TempEmpregado.HorasExtras != "0" && TempEmpregado.HorasExtras != "00" )
                {
                    txt += template.GetTxt ( competencia , TempEmpregado ) + "\n";
                }
            }
            return txt;
        }

        internal void Print ( )
        {
            foreach ( Employee empregado in Empregados )
            {
                 Debug.WriteLine ( empregado.codigo + empregado.Nome + "   "+ empregado.HorasFaltas+ "   " + empregado.HorasExtras);
            }
        }

        public void SetLancamentosHorasExtras ( InformacoesExtras lancamento )
        {
           
            foreach ( Employee empregado in Empregados )
            {
               
                if ( empregado.Nome.Equals(lancamento.Nome))
                {
                    empregado.HorasExtras = lancamento.HorasExtras;
                    break;
                }
            }
        }
    }
}
