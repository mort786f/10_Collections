using System;
using System.Collections.Generic;

namespace _10_Collections
{
    internal class Portfolio
    {
        private List<IAsset> listOfAssets;
        public Portfolio(List<IAsset> stocks)
        {
            listOfAssets = stocks;
        }
        public Portfolio()
        {
            listOfAssets = new List<IAsset>();
        }

        public void AddAsset(IAsset asset)
        {
            listOfAssets.Add(asset);
        }  

        internal double GetTotalValue()
        {
            double totalValue = 0;
            foreach(IAsset stock in listOfAssets)
            {
                totalValue = totalValue + stock.GetValue();
            }
            return totalValue;
        }

        internal IList<IAsset> GetAssets()
        {
            return listOfAssets.AsReadOnly();
        }

        internal IAsset GetAssetByName(string name)
        {
            IAsset element = null;
            foreach(IAsset stock in listOfAssets)
            {
                if (stock.GetName().Equals(name))
                {
                    element = stock;
                }
            }
            return element;
        }

        internal IList<IAsset> GetAssetsSortedByName()
        {
            listOfAssets.Sort(new StockNameComparator());
            return listOfAssets;
        }

        internal IList<IAsset> GetAssetsSortedByValue()
        {
            listOfAssets.Sort(new StockValueComarator());
            return listOfAssets;
        }
    }
}