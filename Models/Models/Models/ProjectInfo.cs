using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    #region enums
    public enum project_catogary
    {

    }
    public enum Project_mecanism_output
    {

    }

    public enum Dependance
    {

    }

    public enum Terms { }

    #endregion
    public class ProjectInfo
    {
        #region fildes
        public Guid Id { get; set; }


        public string ProjectName { get; set; }


        public bool IsCompleted { get; set; }

        public project_catogary catogary { get; set; }

        public int  Expected_Duration {get; set; } 


        public Project_mecanism_output _Mecanism_Output { get; set; }

        public Dependance Dependance { get; set; }
         
        public Terms Terms { get; set; }
        public string  Depended_Project {get; set; }

        #endregion
        #region relations
        public Guid MainId { get; set; }

        public Main Main { get; set; }
        public Guid Project_MangerId { get; set; }

        public Employee Project_Manger { get; set; }
        public Guid Project_OwnerId { get; set; }

        public Employee Project_Owner { get; set; }

        #endregion
    }

}
