using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BulkyWebRazor_Temp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "En fazla 30 karakter olmalıdır")]
        [MinLength(3, ErrorMessage = "En az 3 karakter olmalıdır")]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "1 ile 100 arasında olmalıdır")]
        public int DisplayOrder { get; set; }
    }
}


