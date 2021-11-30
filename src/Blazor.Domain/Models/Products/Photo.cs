using System.ComponentModel.DataAnnotations;

namespace Blazor.Domain.Models.Products
{
    public class Photo
    {
        public int Id { get; set; }

  

        [Required]
        [StringLength(255)]
        public string PhotoFileName { get; set; }

     
        public int ProductSkuId { get; set; }
    }
}