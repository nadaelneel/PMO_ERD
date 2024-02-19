using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Models.Models
{
    public class Supplies
    {
         

        #region fieldes

        public Guid Id { get; set; }
        public bool IsCompleted { get; set; }
        public string Clause { get; set; }

        public string Specifications { get; set; }
        
        public string measruing_unit { get; set; }

        public int Quantity { get; set; }

        public bool Mandatory_list { get; set; }
        public string category_code { get; set; }
        #endregion
        #region relations
        public Guid MainId { get; set; }
        public Main Main { get; set; }


        #endregion
    }
}
