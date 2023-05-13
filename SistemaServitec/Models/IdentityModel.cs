using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaServitec.Models
{
    public class IdentityModel
    {
        public int Id { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string OrgaoExpedicao { get; set; }
        public string UF { get; set; }
        public string Data { get; set; }
        public int? PersonId { get; set; }
        public virtual PersonModel? Person { get; set; }
    }
}
