namespace web.Models
{
    public class Product
    {
        public Product(long Id, string Name, double Price, string House, string Year)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.House = House;
            this.Year = Year;
        }

        public long Id { get; set; }

        public string Name { get; set; }

        public string House { get; set; }
        public string Year { get; set; }

        public double Price { get; set; }
        public double SellPrice { get; set; }

        public long Quantity { get; set; }

        public WineFamily WineFamily { get; set; }
        public long WineFamily_Id { get; set; }
    }
}