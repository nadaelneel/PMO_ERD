using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Models.Models
{
    #region enums
    public enum Area { }
    public enum Activity { }
    #endregion
    public class Classification_field
    {
        #region fieldes

        public Guid Id { get; set; }
        public bool IsCompleted { get; set; }
        public bool Terms { get; set; }

        public string location { get; set; }

        public Area Area { get; set; }
        public Activity Activity { get; set; }
        #endregion
        #region relations
        public Guid MainId { get; set; }
        public Main Main { get; set; }


        #endregion
    }
}
