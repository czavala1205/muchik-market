using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using muchik.market.invoice.domain.entities;

namespace muchik.market.invoice.infrastructure.configurations.entityTypes
{
    public class InvoiceTypeConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable("invoice");

            builder.Property(e => e.Id).HasColumnName("id_invoice");

            builder.HasKey(c => c.Id);

            builder.Property(e => e.Amount).HasColumnName("amount");

            builder.Property(e => e.State).HasColumnName("state");
        }
    }
}
