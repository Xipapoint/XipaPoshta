namespace Xipa_Poshta.Model
{
    public class Product
    {
        public int Id { get; set; }

        public uint Price { get; set; }

        public required string Location { get; set; }

        public required User User { get; set; }

        public required Order Order { get; set; }

        public required Transaction Transaction { get; set; }

        public required PostOffice PostOffice { get; set; }
        
        public required Discount Discount { get; set; }


    }
}
