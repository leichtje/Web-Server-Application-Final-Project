using System.ComponentModel.DataAnnotations;

namespace Web_Server_Application_Final_Project.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        [Required(ErrorMessage = "Please Enter a Name.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please Enter a Valid City or State")]
        public string? Descriptor { get; set; }

        [Required(ErrorMessage = "Please Enter an Established Year")]
        [Range(1492, 2025, ErrorMessage = "Year must be after 1492.")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please Enter a Valid Description")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Please Enter a Rating")]
        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10.")]
        public int? Rating { get; set; }

        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + '-' +
                Year?.ToString();
    }
}
