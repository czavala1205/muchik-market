using IoTSharp.EntityFrameworkCore.MongoDB.Extensions;
using IoTSharp.EntityFrameworkCore.MongoDB.Query.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using MongoDB.Driver;
using muchik.market.transaction.domain.entities;
using muchik.market.transaction.infrastructure.configurations.entityTypes;
using System.Transactions;
using static System.Net.Mime.MediaTypeNames;
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
        //public virtual DbSet<OrderDetail> OrderDetail { get; set; } = null!;
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultContainer("transaction");
            modelBuilder.ApplyConfiguration(new TransactionTypeConfiguration());
            base.OnModelCreating(modelBuilder); 
        }


    }
}
