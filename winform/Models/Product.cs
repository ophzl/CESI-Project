namespace winform.Models
{
    public class Product
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }
        public double SellPrice { get; set; }

        public WineFamily WineFamily { get; set; }
    }
}