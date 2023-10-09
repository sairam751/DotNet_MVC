using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    public class Category
    {

        //If name of the primary key is ID only then we dont require Data Annotation to set the primary key or else even if name is CategoryId then also we dont reuire data annotations
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
