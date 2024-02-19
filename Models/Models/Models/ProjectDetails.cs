using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ProjectDetails
    {
        #region Fieldes
        public Guid Id { get; set; }
        public string CompetetionName { get; set; }
        public int  project_Duration { get; set; }
        public decimal Cost { get; set; }
        public string Technical_Department { get; set; }
        public int  Competetion_purpsue { get ; set; }
        public bool Recuire_Prototype {get; set; }

        public bool IsCompleted { get; set; }
        #endregion
        #region Relations
        public ICollection<ProjectAdministrations> Administration { get; set; }

        public Guid MainId { get; set; }
        public Main Main { get; set; }
        public Guid Project_OwnerId { get; set; }

        public Employee Project_Owner {get; set; }
        #endregion

    }
}
