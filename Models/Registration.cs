using System.ComponentModel.DataAnnotations;


namespace Student_Management.Models
{
    public class Registration
    {  [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }   
        public string LastName { get; set; }
      
        public int Course_Id { get; set; }
        
        public int Batch_Id { get; set; }   
        public int PnoneNumber { get; set; }
    }
}
