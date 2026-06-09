
namespace ProductLibrary
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Units { get; set; }
        public decimal Price { get; set; }

        public Product(int id, string name, int units, decimal price)
        {
            Id = id;
            Name = name;
            Units = units;
            Price = price;
        }

        public void UpdateProduct(int units, decimal price)
        {
            Units = units;
            Price = price;
        }

        public override string ToString()
        {
            return $"Id: {Id},\n Name: {Name},\n Units: {Units},\n, Price: {Price}";
        }


    }
}
