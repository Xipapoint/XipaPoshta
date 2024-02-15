namespace Xipa_Poshta.Model
{
    public class Transaction
    {
        public int Id { get; set; }

        public int PaymentAmount { get; set; }

        public required string Status {  get; set; } 

        public required User User { get; set; }

        public required Order Order { get; set; }

        public required PaymentInfo PaymentInfo { get; set; }

        public required ICollection<Product> Products { get; set; }


    }
}
