using System.ComponentModel.DataAnnotations.Schema;

namespace YumBlazor.Data
{
    public class ShopingCart
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser? User { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product? prodcut { get; set; }

        public int Count { get; set; }
    }

}
