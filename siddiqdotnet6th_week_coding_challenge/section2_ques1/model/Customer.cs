using System.ComponentModel.DataAnnotations;

namespace siddiq_6thassessment.model
{
    public class Customer
    {
        [Key]
        public int customerid { get; set; }
        public string? customername { get; set; }
        public string? customeraddress { get; set;}
        public int? customerphone { get; set; }
        public string? email {  get; set; }
    }
}
