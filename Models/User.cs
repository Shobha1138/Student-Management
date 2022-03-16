using System.ComponentModel.DataAnnotations;

namespace Student_Management.Models
{
    public class User
    {   [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string   UserName { get; set; }
        public string PassWord { get; set; }   
    }
}
