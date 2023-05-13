using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaServitec.Models;


namespace SistemaServitec.Data.Map
{
    public class PersonMap : IEntityTypeConfiguration<PersonModel>
    {
        void IEntityTypeConfiguration<PersonModel>.Configure ( EntityTypeBuilder<PersonModel> builder )
        {
            builder.HasKey ( x=>x.Id);
            builder.Property ( x => x.Name ).HasMaxLength ( 255 );
            builder.Property ( x => x.DataNascimento ).HasMaxLength ( 255 );
            builder.Property ( x => x.PaisNacionalidade ).HasMaxLength ( 255 );
            builder.Property ( x => x.Municipio ).HasMaxLength ( 255 );
            builder.Property ( x => x.UF ).HasMaxLength ( 255 );
            builder.Property ( x => x.Pais ).HasMaxLength ( 255 );
           
        }
    }
}
