using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace First_API.Data
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
    }
}
