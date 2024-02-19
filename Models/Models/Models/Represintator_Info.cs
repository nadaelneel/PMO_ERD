using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Represintator_Info
    {
        public Guid Id { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string EMail {get;set; }
        public string JobTitle { get; set; }

        public Introduction_and_Terms introduction_And_Terms { get; set; }

    }
}
