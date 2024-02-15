namespace Xipa_Poshta.Model
{
    public class PostOffice
    {
        public byte Id { get; set; }

        public required byte Number {  get; set; }
        
        public required string Address { get; set; }

        public required ICollection<Product> Products { get; set; }

        public required ICollection<Order> Orders { get; set; }
    }
}
