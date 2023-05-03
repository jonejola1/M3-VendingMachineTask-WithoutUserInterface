namespace M3_VendingMachineTask_WithoutUserInterface
{
    internal class Product
    {
        public string Name { get; }
        public int Price { get; }

        public Product(string aName, int aPrice)
        {
            Name = aName;
            Price = aPrice;
        }

        public void Show()
        {
            Console.WriteLine($"{this.Name} {this.Price}kr");
        }
    }
}
