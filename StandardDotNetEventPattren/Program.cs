using StandardDotNetEventPattren;

Stock Stock=new Stock("sss");
Stock.Price = 27.50M;
Stock.PriceChanged += stock_PriceChanged;
Stock.Price = 30M;


void stock_PriceChanged(object sender, PriceChangedEventArgs e)
{
    Console.WriteLine($"PriceChanged! old Price:{e.LastPrice} new Price {e.NewPrice}");
}