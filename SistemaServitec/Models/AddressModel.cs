using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaServitec.Models
{
    public class AddressModel
    {
        public int Id { get; set; }
        public string? Tipo { get; set; }
        public string? Residencia { get; set; }
        public string? Numero { get; set; }
        public string? complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Municipio { get; set; }
        public string? UF { get; set; }
        public string? Pais { get; set; }
        public string? CEP { get; set; }
        public int? PersonId { get; set; }
        public virtual PersonModel? Person { get; set; }

    }
}
