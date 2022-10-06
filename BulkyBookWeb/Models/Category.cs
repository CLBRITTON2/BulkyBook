using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        // Building out what the DB table should look like
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }

        // Setting the default create date time to DateTime.Now
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}
