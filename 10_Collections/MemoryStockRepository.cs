using System;
using System.Collections.Generic;

namespace _10_Collections
{
    internal class MemoryStockRepository : IStockRepository
    {
        private List<Stock> allStockObjs = new List<Stock>();
        public int Id { get; set; }

        public Stock LoadStock(long id)
        {
            throw new NotImplementedException();
        }

        public long NextId()
        {
            Id++;
            return Id;
        }

        public void SaveStock(Stock yhoo)
        {
            
        }
    }
}