using SistemaServitec.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaServitec.Models
{
    public class PersonModel
    {
        public  int Id { get; set; }
        public  string? Name { get; set; }
        public  string? DataNascimento { get; set; }
        public  string? PaisNacionalidade { get; set; }
        public  string? Municipio { get; set; }
        public  string? UF { get; set; }
        public  string? Pais { get; set; }
        public virtual IdentityModel? Identidade { get; set; }
        public virtual AddressModel? Endereco { get; set; }
    }
}
