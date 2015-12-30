
namespace CommandPattern
{
    public class BuyStockCommand : IOrderCommand
    {
        private StockReciever stock;

        public BuyStockCommand(StockReciever stock)
        {
            this.stock = stock;
        }

        public void Execute()
        {
            this.stock.Buy();
        }


    }
}
