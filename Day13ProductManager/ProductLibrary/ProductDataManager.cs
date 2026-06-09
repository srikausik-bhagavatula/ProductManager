

namespace ProductLibrary
{
    public class ProductDataManager
    {
        private List<Product> _products = new List<Product>();

        public void AddProduct(Product p)
        {
            _products.Add(p);
            Console.WriteLine("Product added successfully");
        }

        public void ShowProducts()
        {
            if(_products.Count > 0)
            {
                foreach(Product p in _products)
                {
                    Console.WriteLine(p);
                }
            }
            else
            {
                Console.WriteLine("No products available");
            }
        }

        public void EditProduct(int id, int units, decimal price)
        {
            Product product = GetProductById(id);
            if (product is not null)
            {
                product.UpdateProduct(units, price);
                Console.WriteLine("Product updated successfully");
            }
            else
            {
                Console.WriteLine("Product not found");
            }
        }

        public void DeleteProduct(int id)
        {
            Product product = GetProductById(id);
            if (product is not null)
            {
                _products.Remove(product);
                Console.WriteLine("Product deleted successfully");
            }
            else
            {
                Console.WriteLine("Product not found");
            }
        }

        private Product GetProductById(int id)
        {
            var product = _products.Where(p => p.Id == id).First();
            return product;
        }
    }
}
