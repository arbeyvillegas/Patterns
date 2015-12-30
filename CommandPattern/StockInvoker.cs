using System.Collections.Generic;
namespace CommandPattern
{
    public class StockInvoker
    {
        List<IOrderCommand> orders;

        public StockInvoker()
        {
            this.orders = new List<IOrderCommand>();
        }

        public void TakeOrder(IOrderCommand order)
        {
            this.orders.Add(order);
        }

        public void PlaceOrders()
        {
            foreach (IOrderCommand order in this.orders)
            {
                order.Execute();
            }
            this.orders.Clear();
        }
    }
}
