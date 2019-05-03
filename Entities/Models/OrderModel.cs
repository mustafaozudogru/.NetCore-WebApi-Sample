
namespace Entities.Models
{
    public class OrderModel  
    {
        public int Id { get; set; }
        public string ContactName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Region { get; set; }

        public OrderModel() { }
    }
}
