using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Models.Models
{
    public class Offers_Evaluation_Standards
    {

        #region fieldes

        public Guid Id { get; set; }
        public bool IsCompleted { get; set; }
        
        public int Percentage { get; set; }

        public string Standard_Name { get; set; }
        #endregion
        #region relations
        public Guid MainId { get; set; }
        public Main Main { get; set; }


        #endregion
    }
}
