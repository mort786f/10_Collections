namespace _10_Collections
{
    internal class Stock: IAsset
    {
        
        public Stock(string symbol, double pricePerShare, int numShares)
        {
            Symbol = symbol;
            PricePerShare = pricePerShare;
            NumShare = numShares;
        }
        public string Symbol { get; set; }
        public double PricePerShare { get; set; }
        public int NumShare { get; set; }
    }

}