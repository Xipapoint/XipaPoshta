namespace Xipa_Poshta.Model
{
    public class PaymentInfo
    {
        public int Id { get; set; }

        public required string PaymentName { get; set; }

        public required string PaymentType { get; set; }

        public required int CardNumber { get; set; }

        public required decimal PaymentPrice { get; set; }

        public required Order Order { get; set; }

        public required Transaction Transaction { get; set; }
    }
}
