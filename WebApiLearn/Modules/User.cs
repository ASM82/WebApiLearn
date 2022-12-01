using System.ComponentModel.DataAnnotations;

namespace WebApiLearn.Modules
{
    public class User
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        private decimal Salary{ get; set; }
        public int Age { get; set; }
        public decimal TotalSalary { get { return Salary - 100; } }
    }
}
