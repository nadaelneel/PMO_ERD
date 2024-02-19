using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Models.Models
{
    public class Introduction_and_Terms
    {
        #region fieldes
        public Guid Id { get; set; }
        public bool IsCompleted { get; set; }
        public string Compition_definition { get; set; }
        #endregion
        #region relations
        public Guid MainId { get; set; }
        public Main Main { get; set; }

        public Guid Represintator_Info_Id { get; set; }

        public Represintator_Info Represintator_Info { get; set; }

        #endregion
    }
}
