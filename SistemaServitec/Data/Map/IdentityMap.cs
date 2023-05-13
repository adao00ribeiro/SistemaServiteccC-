using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaServitec.Models;


namespace SistemaServitec.Data.Map
{
    public class IdentityMap: IEntityTypeConfiguration<IdentityModel>
    {
        void IEntityTypeConfiguration<IdentityModel>.Configure ( EntityTypeBuilder<IdentityModel> builder )
        {
            builder.HasKey ( x=>x.Id);
            builder.Property ( x => x.CPF ).IsRequired().HasMaxLength ( 255 );
            builder.Property ( x => x.RG ).IsRequired ( ).HasMaxLength ( 255 );
            builder.Property ( x => x.OrgaoExpedicao ).HasMaxLength ( 255 );
            builder.Property ( x => x.UF ).HasMaxLength ( 255 );
            builder.Property ( x => x.Data ).HasMaxLength ( 255 );
            builder.Property ( x => x.PersonId ).IsRequired();
            builder.HasOne ( x => x.Person );
           
        }
    }
}
