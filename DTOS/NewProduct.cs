namespace WebApplication2.DTOS
{
    public class NewProduct
    {
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
    }
}
