using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using muchik.market.security.domain.entities;

namespace muchik.market.security.infraestructure.configurations.entityTypes
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("user");

            builder.Property(e => e.Id).HasColumnName("id_user");

            builder.HasKey(c => c.Id);

            builder.Property(e => e.Username).HasColumnName("username");

            builder.Property(e => e.Password).HasColumnName("password");

           
        }
    }
}
