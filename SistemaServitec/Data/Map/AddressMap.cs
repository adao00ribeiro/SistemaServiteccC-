using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaServitec.Models;


namespace SistemaServitec.Data.Map
{
    public class AddressMap: IEntityTypeConfiguration<AddressModel>
    {
        void IEntityTypeConfiguration<AddressModel>.Configure ( EntityTypeBuilder<AddressModel> builder )
        {
            builder.HasKey ( x=>x.Id);
            builder.Property ( x => x.Tipo ).HasMaxLength ( 255 );
            builder.Property ( x => x.Residencia ).HasMaxLength ( 255 );
            builder.Property ( x => x.Numero ).HasMaxLength ( 255 );
            builder.Property ( x => x.complemento ).HasMaxLength ( 255 );
            builder.Property ( x => x.Bairro ).HasMaxLength ( 255 );
            builder.Property ( x => x.Municipio ).HasMaxLength ( 255 );
            builder.Property ( x => x.UF ).HasMaxLength ( 255 );
            builder.Property ( x => x.Pais ).HasMaxLength ( 255 );
            builder.Property ( x => x.CEP ).HasMaxLength ( 255 );
            builder.Property ( x => x.PersonId );
            builder.HasOne ( x => x.Person );
           
        }
    }
}
