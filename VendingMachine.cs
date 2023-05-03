namespace M3_VendingMachineTask_WithoutUserInterface
{
    internal class VendingMachine
    {
        private readonly List<Product> _inventory;

        private int _amountOfMoneyOnMachine;


        public VendingMachine(List<Product> aProducts)
        {
            _inventory = aProducts;
        }

        public void ShowProducts()
        {
            Console.WriteLine("Current items in inventory:");
            foreach (var product in _inventory)
            {
                product.Show();
            }
        }

        public void AddCoin(int aCoin)
        {
            if (aCoin <= 20)
            {
                _amountOfMoneyOnMachine += aCoin;
                Console.WriteLine($"Du har satt {aCoin}kr på maskinen");
            }
            else
            {
                Console.WriteLine("Maskinen tar ikke imot sedler. :P");
            }
        }


        private void ReturnChange()
        {
            //add that you can get the remaining amount in machine added to your wallet.
            Console.WriteLine($"Maskinen gir deg tilbake {_amountOfMoneyOnMachine}kr");
            _amountOfMoneyOnMachine = 0;
        }


        public void BuyProduct(int aProductIndex)
        {
            var product = _inventory[aProductIndex];
            var price = product.Price;
            var name = product.Name;
            if (_amountOfMoneyOnMachine >= price)
            {
                _amountOfMoneyOnMachine -= price;
                Console.WriteLine($"You Bought a {name} for {product.Price}kr.");

                if(_amountOfMoneyOnMachine > 0) ReturnChange();
            }
            else
            {
                Console.WriteLine($"You don't have enough for {name}.");
                ShowTotalOnMachine();
            }
        }

        public void ShowTotalOnMachine()
        {
            Console.WriteLine($"Total on machine is {_amountOfMoneyOnMachine}kr.");
        }
    }
}
