using System.ComponentModel.DataAnnotations;

namespace siddiq_6thassessment.model
{
    public class Orders
    {
        [Key]
        public int orderid { get; set; }
        public Product? Product { get; set; }
        public int quantity {  get; set; }

        public float amount {  get; set; }
        public Customer? Customer { get; set; }
    }
}
