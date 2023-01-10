using System.ComponentModel.DataAnnotations;

namespace BookStore.API.Dtos.Book
{
    public class BookAddDto
    {
        [Required(ErrorMessage = "This field {0} is required")]
        public int categoryId { get; set; }

        [Required(ErrorMessage = "This field {0} is required")]
        [StringLength(150, ErrorMessage = "This field {0} must be between {2} and {1} characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field {0} is required")]
        [StringLength(150, ErrorMessage = "This field {0} must be between {2} and {1} characters")]
        public string Author { get; set; }

        public string Description { get; set; }
        public double Value { get; set; }
        public DateTime PublishDate { get; set; }
    } 
}
