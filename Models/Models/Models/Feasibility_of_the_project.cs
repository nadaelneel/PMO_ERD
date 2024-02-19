using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    #region enums
    public enum Linkage_to_strategic_pillars
    {

    }
    #endregion
    public class Feasibility_of_the_project
    {
        #region fildes
        public Guid Id { get; set; }
        public bool Requires_purchase { get; set; }
        public decimal Total_cost { get; set; }
        public string Challenge_Opportunities { get; set; }
        public string Work_Scope { get; set; }
        public string Main_output { get; set; }
        public string Benefits { get; set; }
        public Linkage_to_strategic_pillars Strategic_Pillars { get; set; }

        public bool IsCompleted { get; set; }

        #endregion
        #region relations
        public Guid MainId { get; set; }
        public Main Main { get; set; }
        #endregion

    }
}
