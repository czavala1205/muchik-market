﻿using Microsoft.EntityFrameworkCore;
using muchik.market.invoice.domain.entities;
using muchik.market.invoice.infrastructure.configurations.entityTypes;

namespace muchik.market.invoice.infrastructure.context
{
    public partial class InvoiceContext : DbContext
    {
        public InvoiceContext(DbContextOptions<InvoiceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Invoice> Invoice { get; set; } = null!; 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new InvoiceTypeConfiguration());
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
