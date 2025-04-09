using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMvc_oracle.Models
{
    [Table("tblProduto")]
    public class Product
    {
        [Column("Id")]
        [Display(Name = "Code")]
        private int Id { get; set; }

        [Column("Name")]
        [Display(Name = "Name")]
        private string? Name { get; set; }
    }
}
