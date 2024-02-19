using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Dependencies
    {
        #region fieldes

        public Guid Id { get; set; }
        public bool IsCompleted { get; set; }

        public string ProjectManager { get; set; }

        public string ManagerSign { get; set; }

        public string ProjectOwner { get; set; }

        public string ProjectOwnerSign { get; set; }

        #endregion
        #region relations
        public Guid MainId { get; set; }
        public Main Main { get; set; }


        #endregion
    }
}
