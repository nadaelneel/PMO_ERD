using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administration",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Main",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Main", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "represintator_Infos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_represintator_Infos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdministrationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Administration_AdministrationId",
                        column: x => x.AdministrationId,
                        principalTable: "Administration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartmentName = table.Column<string>(name: "Department_Name", type: "nvarchar(max)", nullable: false),
                    DeliveryAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Buliding = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Floor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<int>(type: "int", nullable: false),
                    MainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_Main_MainId",
                        column: x => x.MainId,
                        principalTable: "Main",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attachments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    AttachmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    File = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attachments_Main_MainId",
                        column: x => x.MainId,
                        principalTable: "Main",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Classification_field",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    Terms = table.Column<bool>(type: "bit", nullable: false),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<int>(type: "int", nullable: false),
                    Activity = table.Column<int>(type: "int", nullable: false),
                    MainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classification_field", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classification_field_Main_MainId",
                        column: x => x.MainId,
                        principalTable: "Main",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Dependencies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    ProjectManager = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManagerSign = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectOwner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectOwnerSign = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dependencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dependencies_Main_MainId",
                        column: x => x.MainId,
                        principalTable: "Main",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Feasibility_of_the_project",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Requirespurchase = table.Column<bool>(name: "Requires_purchase", type: "bit", nullable: false),
                    Totalcost = table.Column<decimal>(name: "Total_cost", type: "decimal(18,2)", nullable: false),
                    ChallengeOpportunities = table.Column<string>(name: "Challenge_Opportunities", type: "nvarchar(max)", nullable: false),
                    WorkScope = table.Column<string>(name: "Work_Scope", type: "nvarchar(max)", nullable: false),
                    Mainoutput = table.Column<string>(name: "Main_output", type: "nvarchar(max)", nullable: false),
                    Benefits = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrategicPillars = table.Column<int>(name: "Strategic_Pillars", type: "int", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    MainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feasibility_of_the_project", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feasibility_of_the_project_Main_MainId",
                        column: x => x.MainId,
                        principalTable: "Main",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "fine_Mechanisms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    FineMechanism = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Percentage = table.Column<int>(type: "int", nullable: false),
                    MainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fine_Mechanisms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_fine_Mechanisms_Main_MainId",
                        column: x => x.MainId,
                        principalTable: "Main",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "main_Criterias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    Criteria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveringDate = table.Column<DateTime>(name: "Delivering_Date", type: "datetime2", nullable: false),
                    MainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_main_Criterias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_main_Criterias_Main_MainId",
                        column: x => x.MainId,
                        principalTable: "Main",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Offers_Evaluation_Standards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    Percentage = table.Column<int>(type: "int", nullable: false),
                    StandardName = table.Column<string>(name: "Standard_Name", type: "nvarchar(max)", nullable: false),
                    MainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers_Evaluation_Standards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offers_Evaluation_Standards_Main_MainId",
                        column: x => x.MainId,
                        principalTable: "Main",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Rules_and_Offer_Decumentation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apillitytopartition = table.Column<bool>(name: "Apillity_to_partition", type: "bit", nullable: false),
                    Mechanesimtocompitions = table.Column<string>(name: "Mechanesim_to_compitions", type: "nvarchar(max)", nullable: false),
                    Alternativemail = table.Column<string>(name: "Alternative_mail", type: "nvarchar(max)", nullable: false),
                    FinancialreulesList = table.Column<string>(name: "Financial_reules_List", type: "nvarchar(max)", nullable: false),
                    Technicalreuleslist = table.Column<string>(name: "Technical_reules_list", type: "nvarchar(max)", nullable: false),
                    MainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rules_and_Offer_Decumentation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rules_and_Offer_Decumentation_Main_MainId",
                        column: x => x.MainId,
                        principalTable: "Main",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "services__Standards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    ProjectRules = table.Column<string>(name: "Project_Rules", type: "nvarchar(max)", nullable: false),
                    ResourceRules = table.Column<string>(name: "Resource_Rules", type: "nvarchar(max)", nullable: false),
                    MachinesRules = table.Column<string>(name: "Machines_Rules", type: "nvarchar(max)", nullable: false),
                    QualityStandards = table.Column<string>(name: "Quality_Standards", type: "nvarchar(max)", nullable: false),
                    SafetyStandards = table.Column<string>(name: "Safety_Standards", type: "nvarchar(max)", nullable: false),
                    CustomRules = table.Column<string>(name: "Custom_Rules", type: "nvarchar(max)", nullable: false),
                    MainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_services__Standards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_services__Standards_Main_MainId",
                        column: x => x.MainId,
                        principalTable: "Main",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "supplies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    Clause = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specifications = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    measruingunit = table.Column<string>(name: "measruing_unit", type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Mandatorylist = table.Column<bool>(name: "Mandatory_list", type: "bit", nullable: false),
                    categorycode = table.Column<string>(name: "category_code", type: "nvarchar(max)", nullable: false),
                    MainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MainId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supplies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_supplies_Main_MainId",
                        column: x => x.MainId,
                        principalTable: "Main",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_supplies_Main_MainId1",
                        column: x => x.MainId1,
                        principalTable: "Main",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Team_Work_Standards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    JobTitle = table.Column<string>(name: "Job_Title", type: "nvarchar(max)", nullable: false),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Minimumyearsexp = table.Column<int>(name: "Minimum_years_exp", type: "int", nullable: false),
                    MainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team_Work_Standards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Team_Work_Standards_Main_MainId",
                        column: x => x.MainId,
                        principalTable: "Main",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Technical_Definitions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    Term = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Defination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectLimitation = table.Column<string>(name: "Project_Limitation", type: "nvarchar(max)", nullable: false),
                    MainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technical_Definitions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Technical_Definitions_Main_MainId",
                        column: x => x.MainId,
                        principalTable: "Main",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Work_Services",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Howto = table.Column<string>(name: "How_to", type: "nvarchar(max)", nullable: false),
                    MainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Work_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Work_Services_Main_MainId",
                        column: x => x.MainId,
                        principalTable: "Main",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "introduction_And_Terms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    Compitiondefinition = table.Column<string>(name: "Compition_definition", type: "nvarchar(max)", nullable: false),
                    MainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RepresintatorInfoId = table.Column<Guid>(name: "Represintator_Info_Id", type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_introduction_And_Terms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_introduction_And_Terms_Main_MainId",
                        column: x => x.MainId,
                        principalTable: "Main",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_introduction_And_Terms_represintator_Infos_Represintator_Info_Id",
                        column: x => x.RepresintatorInfoId,
                        principalTable: "represintator_Infos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "projectDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompetetionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    projectDuration = table.Column<int>(name: "project_Duration", type: "int", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TechnicalDepartment = table.Column<string>(name: "Technical_Department", type: "nvarchar(max)", nullable: false),
                    Competetionpurpsue = table.Column<int>(name: "Competetion_purpsue", type: "int", nullable: false),
                    RecuirePrototype = table.Column<bool>(name: "Recuire_Prototype", type: "bit", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    MainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectOwnerId = table.Column<Guid>(name: "Project_OwnerId", type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projectDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_projectDetails_Employees_Project_OwnerId",
                        column: x => x.ProjectOwnerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_projectDetails_Main_MainId",
                        column: x => x.MainId,
                        principalTable: "Main",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "projectInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    catogary = table.Column<int>(type: "int", nullable: false),
                    ExpectedDuration = table.Column<int>(name: "Expected_Duration", type: "int", nullable: false),
                    MecanismOutput = table.Column<int>(name: "_Mecanism_Output", type: "int", nullable: false),
                    Dependance = table.Column<int>(type: "int", nullable: false),
                    Terms = table.Column<int>(type: "int", nullable: false),
                    DependedProject = table.Column<string>(name: "Depended_Project", type: "nvarchar(max)", nullable: false),
                    MainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectMangerId = table.Column<Guid>(name: "Project_MangerId", type: "uniqueidentifier", nullable: false),
                    ProjectOwnerId = table.Column<Guid>(name: "Project_OwnerId", type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projectInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_projectInfos_Employees_Project_MangerId",
                        column: x => x.ProjectMangerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_projectInfos_Employees_Project_OwnerId",
                        column: x => x.ProjectOwnerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_projectInfos_Main_MainId",
                        column: x => x.MainId,
                        principalTable: "Main",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "projectAdministrations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdministrationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProJectDetailsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projectAdministrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_projectAdministrations_Administration_AdministrationId",
                        column: x => x.AdministrationId,
                        principalTable: "Administration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_projectAdministrations_projectDetails_ProJectDetailsId",
                        column: x => x.ProJectDetailsId,
                        principalTable: "projectDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_MainId",
                table: "Address",
                column: "MainId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_MainId",
                table: "Attachments",
                column: "MainId");

            migrationBuilder.CreateIndex(
                name: "IX_Classification_field_MainId",
                table: "Classification_field",
                column: "MainId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dependencies_MainId",
                table: "Dependencies",
                column: "MainId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AdministrationId",
                table: "Employees",
                column: "AdministrationId");

            migrationBuilder.CreateIndex(
                name: "IX_Feasibility_of_the_project_MainId",
                table: "Feasibility_of_the_project",
                column: "MainId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_fine_Mechanisms_MainId",
                table: "fine_Mechanisms",
                column: "MainId");

            migrationBuilder.CreateIndex(
                name: "IX_introduction_And_Terms_MainId",
                table: "introduction_And_Terms",
                column: "MainId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_introduction_And_Terms_Represintator_Info_Id",
                table: "introduction_And_Terms",
                column: "Represintator_Info_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_main_Criterias_MainId",
                table: "main_Criterias",
                column: "MainId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_Evaluation_Standards_MainId",
                table: "Offers_Evaluation_Standards",
                column: "MainId");

            migrationBuilder.CreateIndex(
                name: "IX_projectAdministrations_AdministrationId",
                table: "projectAdministrations",
                column: "AdministrationId");

            migrationBuilder.CreateIndex(
                name: "IX_projectAdministrations_ProJectDetailsId",
                table: "projectAdministrations",
                column: "ProJectDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_projectDetails_MainId",
                table: "projectDetails",
                column: "MainId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_projectDetails_Project_OwnerId",
                table: "projectDetails",
                column: "Project_OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_projectInfos_MainId",
                table: "projectInfos",
                column: "MainId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_projectInfos_Project_MangerId",
                table: "projectInfos",
                column: "Project_MangerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_projectInfos_Project_OwnerId",
                table: "projectInfos",
                column: "Project_OwnerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rules_and_Offer_Decumentation_MainId",
                table: "Rules_and_Offer_Decumentation",
                column: "MainId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_services__Standards_MainId",
                table: "services__Standards",
                column: "MainId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_supplies_MainId",
                table: "supplies",
                column: "MainId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_supplies_MainId1",
                table: "supplies",
                column: "MainId1");

            migrationBuilder.CreateIndex(
                name: "IX_Team_Work_Standards_MainId",
                table: "Team_Work_Standards",
                column: "MainId");

            migrationBuilder.CreateIndex(
                name: "IX_Technical_Definitions_MainId",
                table: "Technical_Definitions",
                column: "MainId");

            migrationBuilder.CreateIndex(
                name: "IX_Work_Services_MainId",
                table: "Work_Services",
                column: "MainId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Attachments");

            migrationBuilder.DropTable(
                name: "Classification_field");

            migrationBuilder.DropTable(
                name: "Dependencies");

            migrationBuilder.DropTable(
                name: "Feasibility_of_the_project");

            migrationBuilder.DropTable(
                name: "fine_Mechanisms");

            migrationBuilder.DropTable(
                name: "introduction_And_Terms");

            migrationBuilder.DropTable(
                name: "main_Criterias");

            migrationBuilder.DropTable(
                name: "Offers_Evaluation_Standards");

            migrationBuilder.DropTable(
                name: "projectAdministrations");

            migrationBuilder.DropTable(
                name: "projectInfos");

            migrationBuilder.DropTable(
                name: "Rules_and_Offer_Decumentation");

            migrationBuilder.DropTable(
                name: "services__Standards");

            migrationBuilder.DropTable(
                name: "supplies");

            migrationBuilder.DropTable(
                name: "Team_Work_Standards");

            migrationBuilder.DropTable(
                name: "Technical_Definitions");

            migrationBuilder.DropTable(
                name: "Work_Services");

            migrationBuilder.DropTable(
                name: "represintator_Infos");

            migrationBuilder.DropTable(
                name: "projectDetails");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Main");

            migrationBuilder.DropTable(
                name: "Administration");
        }
    }
}
