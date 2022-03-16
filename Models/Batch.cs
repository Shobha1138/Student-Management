using System.ComponentModel.DataAnnotations;

namespace Student_Management.Models
{
    public class Batch
    {    [Key]
        public int Id { get; set; } 
        public string BatchName { get; set; }
        public string year { get; set; }    
    }
}
