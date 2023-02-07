using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ApplicationMVC.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1 and 100")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
