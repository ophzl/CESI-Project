namespace web.Models
{
    public class Cart
    {
        public long Id { get; set; }
        public long Product_Id { get; set; }
        public Product Product { get; set; }
        public long Quantity { get; set; }
        public double PriceSubtotal { get; set; }
    }
}
