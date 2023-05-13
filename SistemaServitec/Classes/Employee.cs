using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaServitec.Classes
{
    internal class Employee
    {
        public string codigo;
        public string Nome;
        public string HorasExtras;
        public string HorasFaltas;
        public string Adiantamento;
        public bool IsLancamento;

        public Employee ( )
        {
            codigo = "0";
            Nome = "";
            HorasExtras = "0";
            HorasFaltas = "0";
            Adiantamento = "0";
            IsLancamento = false;
        }

    }
}
