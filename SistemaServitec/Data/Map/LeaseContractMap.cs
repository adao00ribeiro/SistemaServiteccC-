using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaServitec.Models;


namespace SistemaServitec.Data.Map
{
    public class LeaseContractMap : IEntityTypeConfiguration<LeaseContractModel>
    {
        void IEntityTypeConfiguration<LeaseContractModel>.Configure ( EntityTypeBuilder<LeaseContractModel> builder )
        {
            builder.HasKey ( x=>x.Id);
            builder.Property ( x => x.PersonLocadorId ).HasMaxLength ( 255 );
            builder.Property ( x => x.PersonLocatarioId ).HasMaxLength ( 255 );
            builder.Property ( x => x.TipoImovel ).HasMaxLength ( 255 );
            builder.Property ( x => x.Endereco ).HasMaxLength ( 255 );
            builder.Property ( x => x.Numero ).HasMaxLength ( 255 );
            builder.Property ( x => x.Bairro ).HasMaxLength ( 255 );
            builder.Property ( x => x.Cidade ).HasMaxLength ( 255 );
            builder.Property ( x => x.Estado ).HasMaxLength ( 255 );
            builder.Property ( x => x.CEP ).HasMaxLength ( 255 );
            builder.Property ( x => x.TipoDuracao ).HasMaxLength ( 255 );
            builder.Property ( x => x.Duracao ).HasMaxLength ( 255 );
            builder.Property ( x => x.DuracaoExtenso ).HasMaxLength ( 255 );
            builder.Property ( x => x.DataInicial ).HasMaxLength ( 255 );
            builder.Property ( x => x.DataFinal ).HasMaxLength ( 255 );
            builder.Property ( x => x.Valor ).HasMaxLength ( 255 );
            builder.Property ( x => x.ValorExtenso ).HasMaxLength ( 255 );
            builder.Property ( x => x.DataContrato ).HasMaxLength ( 255 );
            builder.HasOne ( x => x.PersonLocador );
            builder.HasOne ( x => x.PersonLocatario );
        }
    }
}
