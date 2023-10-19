using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using muchik.market.pay.domain.entities;

namespace muchik.market.pay.infrastructure.configurations.entityTypes
{
    public class OperationTypeConfiguration : IEntityTypeConfiguration<Operation>
    {
        public void Configure(EntityTypeBuilder<Operation> builder)
        {
            builder.ToTable("operation");

            builder.Property(e => e.Id).HasColumnName("id_operation");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.IdInvoice).HasColumnName("id_invoice");

            builder.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");

            builder.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
        }
    }
}
