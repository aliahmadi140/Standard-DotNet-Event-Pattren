using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardDotNetEventPattren
{
    internal class Stock
    {

        string symbol;
        public Stock(string symbol)
        {
            this.symbol = symbol;
        }


        decimal _price;
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price == value) return;
                decimal olPrice = _price;
                _price = value;
                OnPriceChanged(new PriceChangedEventArgs(olPrice,_price));
            }
        }

        public event EventHandler<PriceChangedEventArgs> PriceChanged;
        protected virtual void OnPriceChanged(PriceChangedEventArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }

    }
}
