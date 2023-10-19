using IoTSharp.EntityFrameworkCore.MongoDB.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MongoDB.Bson;
using muchik.market.transaction.domain.entities;

namespace muchik.market.transaction.infrastructure.configurations.entityTypes
{
    public class TransactionTypeConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToContainer("transaction");
            
            builder.Property(e => e.Id)
               .ToJsonProperty("id_transaction");

            builder.Property(e => e.IdInvoice)
                 .ToJsonProperty("id_invoice");

            builder.Property(e => e.Amount)
                .ToJsonProperty("amount");

            builder.Property(e => e.CreatedAt)
                .ToJsonProperty("date");

            //builder.HasNoDiscriminator();




        }
    }
}
