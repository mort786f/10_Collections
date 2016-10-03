﻿using System;
using System.Collections.Generic;

namespace _10_Collections
{
    internal class StockNameComparator : IComparer<IAsset>
    {
        public int Compare(IAsset first, IAsset second)
        {
            int result = 0;
            if (first.GetName().CompareTo(second.GetName()) > 0)
            {
                return 1;
            }
            else if (first.GetName().CompareTo(second.GetName()) < 0)
            {
                return -1;
            }
            return result;
        }
    }
}