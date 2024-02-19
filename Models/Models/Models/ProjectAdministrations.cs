using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ProjectAdministrations
    {
        public Guid Id { get; set; }
        public Guid AdministrationId { get; set; }
        public Administration administration { get; set; }

        public Guid ProJectDetailsId { get; set; }

        public ProjectDetails projectDetails { get; set; }
    }
}
