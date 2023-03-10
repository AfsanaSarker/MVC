using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public enum CreditCardType
    {
        Visa, MasterCard, Amex
    }
    public class Category
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Category is required!!!")]
        [StringLength(60)]
        [Display(Name ="Category Name")]
        public string CategoryName { get; set; }

    }
    public class Product
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Product Name is required!!!")]
        [StringLength(60)]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [Column(TypeName ="money")]
        [DisplayFormat(DataFormatString ="{0:00}",ApplyFormatInEditMode =true)]
        public decimal Price { get; set; }
        public string Picture { get; set; }
        public bool Discontinued { get; set; }

    }
    public class CartItem
    {

    }

}