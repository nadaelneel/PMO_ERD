using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Fine_Mechanism
    {
        #region fieldes

        public Guid Id { get; set; }
        public bool IsCompleted { get; set; }
        public string FineMechanism { get; set; }

        public int Percentage { get; set; }

        #endregion
        #region relations
        public Guid MainId { get; set; }
        public Main Main { get; set; }


        #endregion
    }
}
