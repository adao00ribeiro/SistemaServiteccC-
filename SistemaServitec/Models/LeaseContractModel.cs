using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaServitec.Models
{
    public class LeaseContractModel
    {
        public int Id { get; set; }
        public int PersonLocadorId { get; set; }
        public int PersonLocatarioId { get; set; }
        public string? TipoImovel { get; set; }
        public string? Endereco { get; set; }
        public string? Numero { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public string? CEP { get; set; }
        public string? TipoDuracao { get; set; }
        public string? Duracao { get; set; }
        public string? DuracaoExtenso { get; set; }
        public string? DataInicial { get; set; }
        public string? DataFinal { get; set; }
        public string? Valor { get; set; }
        public string? ValorExtenso { get; set; }
        public string? DataContrato { get; set; }
        public virtual PersonModel? PersonLocador { get; set; }
        public virtual PersonModel? PersonLocatario { get; set; }



    }
}
