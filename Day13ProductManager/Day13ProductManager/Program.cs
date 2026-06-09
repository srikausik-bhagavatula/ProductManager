using ProductLibrary;

namespace Day13ProductManager
{
    internal class Program
    {
        private static readonly ProductDataManager _dataManager = new ProductDataManager();
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Welcome to the Product Management App!");
                Console.WriteLine("Menu");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Edit Product");
                Console.WriteLine("3. Delete Product");
                Console.WriteLine("4. View Products");

                Console.WriteLine("------------------------");

                Console.WriteLine("Please input a number from 1-4 to perform an operation: ");

                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        EditProduct();
                        break;
                    case 3:
                        DeleteProduct();
                        break;
                    case 4:
                        _dataManager.ShowProducts();
                        break;
                    default:
                        Console.WriteLine("Invalid Data");
                        break;
                }
            }
        }

        static void AddProduct()
        {
            Console.WriteLine("Please enter the ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter the units: ");
            int units = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Product product = new Product(id, name, units, price);
            _dataManager.AddProduct(product);
        }

        static void EditProduct()
        {
            Console.WriteLine("Please enter the ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the units: ");
            int units = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the price: ");
            decimal price = decimal.Parse(Console.ReadLine());
            _dataManager.EditProduct(id, units, price);
        }

        static void DeleteProduct()
        {
            Console.WriteLine("Please enter the ID: ");
            int id = int.Parse(Console.ReadLine());

            _dataManager.DeleteProduct(id);
        }
    }
}
