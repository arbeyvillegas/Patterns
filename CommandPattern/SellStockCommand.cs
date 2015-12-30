
namespace CommandPattern
{
    public class SellStockCommand : IOrderCommand
    {
        StockReciever stock;

        public SellStockCommand(StockReciever stock)
        {
            this.stock = stock;
        }


        public void Execute()
        {
            this.stock.Sell();
        }
    }
}
