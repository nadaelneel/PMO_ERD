using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Services__Standards
    {
        #region fieldes

        public Guid Id { get; set; }
        public bool IsCompleted { get; set; }
        public string Project_Rules { get; set; }

        public string Resource_Rules { get; set; }

        public string Machines_Rules { get; set; }

        public string Quality_Standards { get; set; }

        public string Safety_Standards { get; set; }

        public string Custom_Rules { get; set; }

        #endregion
        #region relations
        public Guid MainId { get; set; }
        public Main Main { get; set; }


        #endregion
    }
}
