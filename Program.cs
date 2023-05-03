namespace M3_VendingMachineTask_WithoutUserInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>(4) { new Product("Cola", 25), new Product("Pepsi", 20), new Product("Imsdal", 15) };

            
            var wallet = new Currency();
            var vendingMachine = new VendingMachine(products);

            vendingMachine.ShowProducts();
            vendingMachine.BuyProduct(1);
            vendingMachine.AddCoin(wallet.FemKrone());
            vendingMachine.AddCoin(wallet.TjueKrone());
            vendingMachine.AddCoin(wallet.FemtiLapp());
            vendingMachine.BuyProduct(0);

            vendingMachine.ShowTotalOnMachine();
        }
    }
}