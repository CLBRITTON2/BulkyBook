namespace BulkyBookWeb.Models
{
    public class Category
    {
        // Building out what the DB table should look like
        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }

        // Setting the default create date time to DateTime.Now
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}
