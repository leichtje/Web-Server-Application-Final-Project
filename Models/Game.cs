using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Web_Server_Application_Final_Project.Models
{
    public class Game
    {
        public int GameId { get; set; }
        [Required(ErrorMessage = "Please Enter a Name.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please Enter a Year")]
        [Range(1889, 2999, ErrorMessage = "Year must be after 1889.")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please Enter a Rating")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int? Rating { get; set; }

        [Required(ErrorMessage = "Please Enter a Genre.")]
        public string? TypesId { get; set; }

        public Types? Type { get; set; }

        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + '-' +
                Year?.ToString();
    }
}
