using muchik.market.transaction.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muchik.market.transaction.infraestructure.settings
{
    public class TransactionSettings : ITransactionSettings
    {
        public string TransactionCollectionName { get; set; } = string.Empty;
        public string TransactionConnectionString { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;

    }
}
