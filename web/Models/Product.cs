namespace web.Models
{
    public class Product
    {
        public Product(long Id, string Name, double SellPrice, string House, string Year, string WineFamily, double BoxPrice, long Quantity)
        {
            this.Id = Id;
            this.Name = Name;
            this.SellPrice = SellPrice;
            this.House = House;
            this.Year = Year;
            this.WineFamily = WineFamily;
            this.BoxPrice = BoxPrice;
            this.Quantity = Quantity;
        }

        public long Id { get; set; }

        public string Name { get; set; }

        public string House { get; set; }
        public string Year { get; set; }

        public double Price { get; set; }
        public double SellPrice { get; set; }
        public double BoxPrice { get; set; }

        public long Quantity { get; set; }

        public string WineFamily { get; set; }
        public long WineFamily_Id { get; set; }
    }
}