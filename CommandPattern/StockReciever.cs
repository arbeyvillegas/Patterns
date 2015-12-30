
namespace CommandPattern
{
    public class StockReciever
    {
        private string name;
        private int quantity;

        public StockReciever()
        {
            this.name = "SaludEPM";
            this.quantity = 10;
        }

        public void Buy()
        {
            System.Console.WriteLine("Stock [ Nombre: " + name + ", Cantidad: " + quantity + " ] comprado");
        }

        public void Sell()
        {
            System.Console.WriteLine("Stock [ Nombre: " + name + ", Cantidad: " + quantity + " ] vendido");
        }
    }
}
