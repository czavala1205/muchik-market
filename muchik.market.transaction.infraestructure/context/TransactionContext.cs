using IoTSharp.EntityFrameworkCore.MongoDB.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MongoDB.Bson;
using muchik.market.transaction.infrastructure.configurations.entityTypes;
using Transaction = muchik.market.transaction.domain.entities.Transaction;

namespace muchik.market.transaction.infrastructure.context
{
    public partial class TransactionContext : DbContext
    {
        public TransactionContext(DbContextOptions<TransactionContext> options)
            : base(options)
        {
        }

        public DbSet<Transaction> Transaction { get; set; } = null!;

      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultContainer("transaction");
            modelBuilder.ApplyConfiguration(new TransactionTypeConfiguration());
            base.OnModelCreating(modelBuilder); 
        }


    }
}
