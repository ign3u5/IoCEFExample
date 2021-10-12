using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp1.Models
{
    [Table("usersTbl")]
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Postcode { get; set; }
    }
}
