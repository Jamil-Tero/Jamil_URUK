using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jamil_URUK.Models
{
    public enum productColor:byte
    {
        Red =0,
        Green =1,
    }
    public enum productSize : byte
    {
        Small=0,
        Medium=1,
        Large=2,
    }
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        [DisplayFormat(DataFormatString = "{0:0.00}")]
        public double Price { get; set; }
        
        public byte[]? Image { get; set; }

        [NotMapped]
        [DisplayName("Upload Image")]
        public IFormFile? ImageFile { get; set; }

        [Required]
        public productColor Color { get; set; }
        [Required]
        public productSize Size { get; set; }
        [Required]
        [Range(0,int.MaxValue)]
        public int InStock { get; set; }
    }
}
