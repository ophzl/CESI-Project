namespace web.Models
{
    public class Product
    {
        public Product(long Id, string Name, double Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
        }

        public long Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }
        public double SellPrice { get; set; }

        public WineFamily WineFamily { get; set; }
    }
}