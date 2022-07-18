using fb.Models.Entites;

namespace fb.Models.Entites
{
    public class Hr_Employee
    {
        public int Id { get; set; }
        public string NameEmp { get; set; }
        public string Job { get; set; }
        public int Age { get; set; } 
        public string Branch { get; set; }
        public string Job_Title { get; set; }
        public string Administration { get; set; }
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

    }
}
