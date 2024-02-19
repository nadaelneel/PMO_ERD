using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Team_Work_Standards
    {
        #region fieldes

        public Guid Id { get; set; }
        public bool IsCompleted { get; set; }

        public string Job_Title { get; set; }
        public string Qualification { get; set; }

        public int Minimum_years_exp { get; set; }


        #endregion
        #region relations
        public Guid MainId { get; set; }
        public Main Main { get; set; }


        #endregion
    }
}
