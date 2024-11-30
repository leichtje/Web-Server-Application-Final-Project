using System.ComponentModel.DataAnnotations;

namespace Web_Server_Application_Final_Project.Models
{
    public class Camera
    {
        public int CameraId { get; set; }
        [Required(ErrorMessage = "Please Enter a Make or Model.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please Enter a Year")]
        [Range(1900, 2500, ErrorMessage = "Year must be after 1900.")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please Enter a Sensor.")]
        public string? Sensor { get; set; }

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
