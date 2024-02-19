using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Administration
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<Employee> employees { get; set; }

        public ICollection<ProjectAdministrations> projectAdministrations { get; set; }
    }
}
