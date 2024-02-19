using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Models.Models
{
    public enum DeliveryTime { }
    public class Address
    {
        #region fieldes

        public Guid Id { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime date { get; set; }
        public string Department_Name { get; set; }

        public string DeliveryAddress { get; set; }
        public string Buliding  { get; set; }

        public string Floor { get; set; }
        public DeliveryTime Time { get; set; }
        #endregion
        #region relations
        public Guid MainId { get; set; }
        public Main Main { get; set; }

       
        #endregion
    }
}
