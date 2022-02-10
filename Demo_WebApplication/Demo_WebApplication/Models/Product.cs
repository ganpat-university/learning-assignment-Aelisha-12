using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Demo_WebApplication.Models
{
    [Table("Products")]
    public class Product
    {

        [Display(Name="Product ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set;}


        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [StringLength(50, ErrorMessage = "{0} cannot be more than {1} characters")]
        [MinLength(3, ErrorMessage = "{0} should have atleast {1} characters.")]
        public string ProductName { get; set;}



        [Display(Name ="Product Quantity")]
        [Required(ErrorMessage ="{0} cannot be empty")]
        [Range(1,100,ErrorMessage ="{0} must be between {1} to {2}")]

        public int ProductQuantity { get; set;}



        [Display(Name ="Product Price")]
        [Range(1, float.MaxValue,ErrorMessage ="please enter valid price value" )]

        public float ProductPrice { get; set;}
    }
}
