namespace _9_LINQ.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PurchasePrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Price { get; set; }

        public int Quantity { get; set; }

        [StringLength(20)]
        public string Vintage { get; set; }

        [Required]
        [StringLength(10)]
        public string CatalogyID { get; set; }

        [UIHint("ImageView")]
        [Column(TypeName = "text")]
        public string Image { get; set; }

        [Required]
        [StringLength(100)]
        public string Region { get; set; }

        public virtual Catalogy Catalogy { get; set; }
    }
}
