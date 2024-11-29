using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shop_app.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = 0;
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Please enter Name(max lenth = 50, min = 2)")]
        [Required(ErrorMessage = "Please enter Name(max lenth = 50)")]
        public string? Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter Name( Precision(10,2) )")]
        [Range(0.01, 10000000.00)]
        public decimal Price { get; set; } = decimal.Zero;
        [StringLength(1024)]
        [Required(ErrorMessage = "Please enter Description(max lenth = 1024)")]
        public string? Description { get; set; } = string.Empty;
    }
}
