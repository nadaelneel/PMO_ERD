using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Attachments
    {
        #region fieldes

        public Guid Id { get; set; }
        public bool IsCompleted { get; set; }

        public string AttachmentName { get; set; }

        public string File { get; set; }

        #endregion
        #region relations
        public Guid MainId { get; set; }
        public Main Main { get; set; }


        #endregion
    }
}
