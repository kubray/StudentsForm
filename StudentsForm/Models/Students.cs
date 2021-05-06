using System;
using System.ComponentModel;
namespace StudentsForm.Models
{
    public class Students
    {
        
        
        public int Id { get; set; }

        
        public string Name { get; set; }
        
        public string Surname { get; set; }

        public string Department { get; set; }

        public DateTime BirthDate { get; set; }


        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
       


    }
}
