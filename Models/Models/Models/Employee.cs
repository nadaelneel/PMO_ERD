using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Employee
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid AdministrationId { get; set; }
        public Administration Administration { get; set; }

        public ProjectInfo Project_Manger { get; set; }

        public ProjectInfo Project_Owner { get; set; }
        public ICollection<ProjectDetails>? projectDetails { get; set; }
    }
}
