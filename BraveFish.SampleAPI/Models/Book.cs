using System.ComponentModel.DataAnnotations;

namespace BraveFish.SampleAPI.Models
{
    public class Book
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        public List<string> Genres { get; set; }

        [Required]
        public float Rating { get; set; }
    }

    public class BookCreateRequestModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public List<string> Genres { get; set; } = new List<string>();

        [Required]
        [Range(0.01, 10)]
        public float Rating { get; set; }
    }

    public class BookGetRequestModel
    {
        public Guid Id { get; set; }
    }
}
