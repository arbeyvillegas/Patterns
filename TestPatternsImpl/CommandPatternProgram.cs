using CommandPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatternsImpl
{
    class CommandPatternProgram
    {
        static void Main(string[] args)
        {
            StockReciever stock = new StockReciever();

            IOrderCommand buyOrderCommand = new BuyStockCommand(stock);
            IOrderCommand sellOrderCommand = new SellStockCommand(stock);

            StockInvoker invoker = new StockInvoker();
            invoker.TakeOrder(buyOrderCommand);
            invoker.TakeOrder(sellOrderCommand);

            invoker.PlaceOrders();

            Console.ReadKey();
        }
    }
}
