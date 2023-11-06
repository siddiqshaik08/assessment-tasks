using System.ComponentModel.DataAnnotations;

namespace siddiq_6thassessment.model
{
    public class Product
    {
        [Key]
        public int productid { get; set; }
        public string? productname {  get; set; }
        
        public float? price { get; set; }

        public int quantity { get; set; }
    }
}
