using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muchik.market.transaction.domain.interfaces
{
    public interface ITransactionSettings
    {
        string TransactionCollectionName { get; set; }
        string TransactionConnectionString { get; set; } 
        string DatabaseName { get; set; } 

    }
}
