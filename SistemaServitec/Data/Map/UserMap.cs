using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaServitec.Models;


namespace SistemaServitec.Data.Map
{
    public class UserMap : IEntityTypeConfiguration<UserModel>
    {
        void IEntityTypeConfiguration<UserModel>.Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(255);
            builder.Property(x => x.UserName).HasMaxLength(255);
            builder.Property(x => x.Password).HasMaxLength(255);
            builder.Property(x => x.IsActive);

            builder.HasIndex(x => x.UserName).IsUnique();
        }
    }
}
