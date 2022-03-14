using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardDotNetEventPattren
{
    internal class PriceChangedEventArgs:EventArgs
    {
        public readonly decimal LastPrice; 
        public readonly decimal NewPrice;

        public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
        {
            LastPrice = lastPrice;
            NewPrice = newPrice;
        }

    }
}
