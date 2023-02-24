namespace NaturalFarma.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string DetailedDescription { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public string ImageSmall {  get; set; }

        public bool ProductFavorite {  get; set; }  

        public bool Stock { get; set; }

        public int CategoryId { get; set; } 

        public virtual Category Category { get; set; }
    }
}
