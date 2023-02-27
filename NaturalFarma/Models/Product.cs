using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NaturalFarma.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "O NOME DO LANCHE DEVE SER INFORMADO")]
        [Display(Name = "NOME DO PRODUTO")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} DEVE TER NO MÍNIMO {1} E NO MAXIMO {2}")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A DESCRIÇÃO DO PRODUTO DEVE SER INFORMADA")]
        [Display(Name = "DESCRIÇÃO DO PRODUTO")]
        [MinLength(20, ErrorMessage = "DESCRIÇÃO DEVE TER NO MÍNIMO {1} CARACTERES")]
        [MaxLength(200, ErrorMessage = "DESCRIÇÃO PODE EXCEDER {1} CARACTERES")]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage = "A DESCRIÇÃO DO PRODUTO DEVE SER INFORMADA")]
        [Display(Name = "DESCRIÇÃO DO PRODUTO")]
        [MinLength(20, ErrorMessage = "DESCRIÇÃO DEVE TER NO MÍNIMO {1} CARACTERES")]
        [MaxLength(200, ErrorMessage = "DESCRIÇÃO PODE EXCEDER {1} CARACTERES")]
        public string DetailedDescription { get; set; }

        [Required(ErrorMessage = "INFORME O PREÇO DO PRODUTO")]
        [Display(Name = "PREÇO")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.99,ErrorMessage = "O PREÇO DEVE ESTAR ENTRE 1 E 999,99")]
        public decimal Price { get; set; }

        [Display(Name = "CAMINHO IMAGEM NORMAL")]
        [StringLength(200, ErrorMessage = "O {0} DEVE TER NO MÁXIMO {1} CARACTERES")]
        public string ImageUrl { get; set; }

        [Display(Name = "CAMINHO IMAGEM MINIATURA")]
        [StringLength(200, ErrorMessage = "O {0} DEVE TER NO MÁXIMO {1} CARACTERES")]

        public string ImageSmall {  get; set; }

        [Display(Name = "PREFERIDO?")]
        public bool ProductFavorite {  get; set; }

        [Display(Name = "ESTOQUE")]
        public bool Stock { get; set; }

        public int CategoryId { get; set; } 

        public virtual Category Category { get; set; }
    }
}
