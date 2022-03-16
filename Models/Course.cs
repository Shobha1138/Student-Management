using System.ComponentModel.DataAnnotations;

namespace Student_Management.Models
{
    public class Course
    {   [Key]
        public int Id { get; set; }
        public string CourseName { get; set; }

        public int Duration { get; set; }   
            
    }
}
