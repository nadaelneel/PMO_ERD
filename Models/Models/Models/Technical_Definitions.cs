using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Models.Models
{
    public class Technical_Definitions
    {

        #region fieldes

        public Guid Id { get; set; }
        public bool IsCompleted { get; set; }

        public string Term { get; set; }

        public string Defination { get; set; }

        public string Project_Limitation { get; set; }

        #endregion
        #region relations
        public Guid MainId { get; set; }
        public Main Main { get; set; }


        #endregion
    }
}
