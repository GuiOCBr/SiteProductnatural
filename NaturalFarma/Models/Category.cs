using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NaturalFarma.Models
{
    [Table("Category")]

    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [StringLength(100, ErrorMessage = "O TAMANHO MÁXIMO É 100 CARACTERES")]
        [Required(ErrorMessage = " INFORME O ERRO DA CATEGORIA")]
        [Display(Name = "NOME")]

        public string CategoryName { get; set; }

        [StringLength(200, ErrorMessage = "O TAMANHO MÁXIMO É 200 CARACTERES")]
        [Required(ErrorMessage = "INFORME A DESCRIÇÃO DA CATEGORIA")]
        [Display(Name = "DESCRIÇÃO")]

        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }
}
