﻿namespace _10_Collections
{
    internal interface IStockRepository
    {
        long NextId();
        void SaveStock(Stock yhoo);
        Stock LoadStock(long id);
    }
}