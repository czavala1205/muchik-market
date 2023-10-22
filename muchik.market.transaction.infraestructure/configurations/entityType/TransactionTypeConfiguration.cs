using IoTSharp.EntityFrameworkCore.MongoDB.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MongoDB.Bson;
using muchik.market.transaction.domain.entities;
using System.Reflection.Emit;

namespace muchik.market.transaction.infrastructure.configurations.entityTypes
{
    public class TransactionTypeConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            var stringConverter = new ValueConverter<ObjectId, string>(
               v => v.ToString(),
               v => ObjectId.Parse(v)
           );

            //builder.ToContainer("transaction");
            //builder.Property(e => e._id)
            //    .ToJsonProperty("_id")
            //    .HasConversion(stringConverter);

            //builder.Property(e => e.id_transaction)
            //   .ToJsonProperty("id_transaction");

            //builder.Property(e => e.id_invoice)
            //     .ToJsonProperty("id_invoice");

            //builder.Property(e => e.amount)
            //    .ToJsonProperty("amount");

            //builder.Property(e => e.CreatedAt)
            //    .ToJsonProperty("date");

            //builder.HasNoDiscriminator();

            //builder.HasPartitionKey(e => e._id);

            //builder.UseETagConcurrency();
            //builder.ToBsonDocument();




        }
    }
    }
