using Xipa_Poshta.Utils;
namespace Xipa_Poshta.Model
{
    public class Order
    {
        private long _id;

        public long Id { 
            get { return _id; } 
            set { _id = value; }
        }

        public int AccessOrderNumber { get; set; }

        public required string Status {  get; set; }

        public DateTime DelieveryTime { get; set; }

        public required User User { get; set; }

        public required Transaction Transaction { get; set; }

        public required PostOffice PostOffice { get; set; }

        public required PaymentInfo PaymentInfo { get; set; }

        public required OrderDetails OrderDetail { get; set; }

        public required ICollection<Product> Products { get; set; }

        private IdGenerator _idGenerator = new IdGenerator();


        public Order()
        {
            Id = _idGenerator.SHA32bitGenerateId();
        }
    }
}
