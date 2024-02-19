using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Main
    {
        public Guid Id { get; set; }

        public bool IsCompleted { get; set; }

        public Address address { get; set; }
        public Classification_field classification_field { get; set; }
        public Dependencies dependencie { get; set; }
        public Feasibility_of_the_project feasibility_Of_The_Project { get; set; }

        public Introduction_and_Terms introduction_And_Terms { get; set; }

        public ProjectDetails projectDetails { get; set; }

        public ProjectInfo  projectInfo { get; set; }

        public Rules_and_Offer_Decumentation Rules_and_Offer { get; set; }

        public Services__Standards services__Standards { get; set; }

        public Supplies supplies { get; set; }
        public Work_Services work_Services { get; set; }
        public ICollection<Supplies> Supplies { get; set; }

        public ICollection<Offers_Evaluation_Standards> offers_Evaluations { get; set; }

        public ICollection<Technical_Definitions> technical_Definitions { get; set; }

        public ICollection<Team_Work_Standards> Work_Standards { get; set; }

        public ICollection<Fine_Mechanism> fine_Mechanisms { get; set; }
         public ICollection<Main_Criteria> main_Criterias { get; set; } 

        public ICollection<Attachments> attachments { get; set; }
    }

}
