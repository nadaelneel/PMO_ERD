using Microsoft.EntityFrameworkCore;
using Models.Config;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Models.Context
{
    public class MyDbContext : DbContext
    {
        //public MyDbContext() { }
        public MyDbContext(DbContextOptions options) : base(options) { }
        #region dbset


        public DbSet<Technical_Definitions> Technical_Definitions { get; set; }
        public DbSet<Work_Services> Work_Services { get; set; }

        public DbSet<Team_Work_Standards> Team_Work_Standards { get; set; }

        public DbSet<Services__Standards> services__Standards { get; set; }

        public DbSet<Supplies> supplies {get; set; }    

        public DbSet<Rules_and_Offer_Decumentation> Rules_and_Offer_Decumentation { get; set; }

        public DbSet<Represintator_Info> represintator_Infos { get; set; }

        public DbSet<ProjectInfo> projectInfos { get; set; }

        public DbSet<ProjectDetails> projectDetails { get; set; }

        public DbSet<ProjectAdministrations> projectAdministrations { get; set; }

        public DbSet<Offers_Evaluation_Standards> Offers_Evaluation_Standards { get; set; }

        public DbSet<Main_Criteria> main_Criterias { get; set; }

        public DbSet<Main> Main { get; set; }

        public DbSet<Introduction_and_Terms> introduction_And_Terms { get; set; }

        public DbSet<Fine_Mechanism> fine_Mechanisms { get; set; }

        public DbSet<Feasibility_of_the_project> Feasibility_of_the_project { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Dependencies> Dependencies { get; set; }

        public DbSet<Classification_field> Classification_field { get; set; }

        public DbSet<Attachments> Attachments { get; set; }

        public DbSet<Administration> Administration { get; set; }

        public DbSet<Address> Address { get; set; }

        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region config apply
            modelBuilder.ApplyConfiguration<Work_Services>(new Work_ServicesConfiguration());
            modelBuilder.ApplyConfiguration<Technical_Definitions>(new Technical_DefinitionsConfiguration());
            modelBuilder.ApplyConfiguration<Team_Work_Standards>(new Team_Work_StandardsConfig());
            modelBuilder.ApplyConfiguration<Services__Standards>(new Services__StandardsConfiguration());
            modelBuilder.ApplyConfiguration< Supplies >(new SuppliesConfiguration());
            modelBuilder.ApplyConfiguration<Rules_and_Offer_Decumentation>(new Rules_and_Offer_DecumentationConfig());
            modelBuilder.ApplyConfiguration<ProjectInfo>(new ProjectInfoConfiguration());
            modelBuilder.ApplyConfiguration< ProjectDetails >(new ProjectDetailsConfiguration());
            modelBuilder.ApplyConfiguration< ProjectAdministrations >(new ProjectAdministrationsConfig());
            modelBuilder.ApplyConfiguration< Offers_Evaluation_Standards >(new Offers_Evaluation_StandardsConfig());
            modelBuilder.ApplyConfiguration< Main_Criteria >(new Main_CriteriaConfiguration());
            modelBuilder.ApplyConfiguration<Introduction_and_Terms>(new Introduction_and_TermsConfig());
            modelBuilder.ApplyConfiguration<Fine_Mechanism>(new Fine_MechanismConfiguration());
            modelBuilder.ApplyConfiguration<Feasibility_of_the_project>(new Feasibility_of_the_projectConfig());
            modelBuilder.ApplyConfiguration< Employee >(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration< Dependencies > (new DependenciesConfiguration());
            modelBuilder.ApplyConfiguration<Classification_field>(new Classification_fieldConfig());
            modelBuilder.ApplyConfiguration<Attachments>(new AttachmentsConfiguration());
            modelBuilder.ApplyConfiguration<Address>(new AddressConfiguration());
            modelBuilder.ApplyConfiguration<Administration>(new Administrationconfig());
            #endregion
          
            base.OnModelCreating(modelBuilder);
        }


    }
}
