using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Models.Models
{
    public class Rules_and_Offer_Decumentation
  { 
    #region fieldes

        public Guid Id { get; set; }
        public bool IsCompleted { get; set; }
        public string Definition { get; set; }

        public bool Apillity_to_partition { get; set; }
        public string Mechanesim_to_compitions { get; set; }

        public string Alternative_mail { get; set; }
        public string Financial_reules_List { get; set; }

        public string Technical_reules_list { get; set; }
        #endregion
        #region relations
        public Guid MainId { get; set; }
        public Main Main { get; set; }


        #endregion
    }
}
