using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Domain.Models.Products
{
    [Table("ProductSkus")]
    public class ProductSku
    {
        public int Id { get; set; }

        public int SkuValueId { get; set; }

       
        public decimal Price { get; set; }
        public DateTime LastUpdate { get; set; }

        public SkuValue SkuValue { get; set; }
        public ICollection<Photo> Photos { get; set; }

        public ProductSku()
        {
            
            Photos = new Collection<Photo>();
        }
    }
}
