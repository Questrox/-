namespace Конструирование_ПО.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Class",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Hours_count = c.Int(nullable: false),
                        ID_Plan_discipline = c.Int(),
                        ID_Class_type = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Class_type", t => t.ID_Class_type)
                .ForeignKey("dbo.Plan_discipline", t => t.ID_Plan_discipline)
                .Index(t => t.ID_Plan_discipline)
                .Index(t => t.ID_Class_type);
            
            CreateTable(
                "dbo.Class_type",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Plan_discipline",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Volume = c.Int(nullable: false),
                        Exam_type = c.String(nullable: false, maxLength: 20, unicode: false),
                        Term = c.Int(nullable: false),
                        ID_Plan = c.Int(),
                        ID_Discipline = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Discipline", t => t.ID_Discipline)
                .ForeignKey("dbo.Plan", t => t.ID_Plan)
                .Index(t => t.ID_Plan)
                .Index(t => t.ID_Discipline);
            
            CreateTable(
                "dbo.Discipline",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Plan",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Admission_date = c.DateTime(nullable: false, storeType: "date"),
                        Specialty = c.String(nullable: false, maxLength: 50, unicode: false),
                        Form = c.String(nullable: false, maxLength: 20, unicode: false),
                        Duration = c.Int(nullable: false),
                        Qualification = c.String(nullable: false, maxLength: 50, unicode: false),
                        ID_Field_of_study = c.Int(),
                        ID_Department = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Department", t => t.ID_Department)
                .ForeignKey("dbo.Field_of_study", t => t.ID_Field_of_study)
                .Index(t => t.ID_Field_of_study)
                .Index(t => t.ID_Department);
            
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 70, unicode: false),
                        Abbreviation = c.String(nullable: false, maxLength: 10, unicode: false),
                        ID_Faculty = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Faculty", t => t.ID_Faculty)
                .Index(t => t.ID_Faculty);
            
            CreateTable(
                "dbo.Faculty",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 70, unicode: false),
                        Abbreviation = c.String(nullable: false, maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Field_of_study",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(nullable: false, maxLength: 10, unicode: false),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Plan_discipline", "ID_Plan", "dbo.Plan");
            DropForeignKey("dbo.Plan", "ID_Field_of_study", "dbo.Field_of_study");
            DropForeignKey("dbo.Plan", "ID_Department", "dbo.Department");
            DropForeignKey("dbo.Department", "ID_Faculty", "dbo.Faculty");
            DropForeignKey("dbo.Plan_discipline", "ID_Discipline", "dbo.Discipline");
            DropForeignKey("dbo.Class", "ID_Plan_discipline", "dbo.Plan_discipline");
            DropForeignKey("dbo.Class", "ID_Class_type", "dbo.Class_type");
            DropIndex("dbo.Department", new[] { "ID_Faculty" });
            DropIndex("dbo.Plan", new[] { "ID_Department" });
            DropIndex("dbo.Plan", new[] { "ID_Field_of_study" });
            DropIndex("dbo.Plan_discipline", new[] { "ID_Discipline" });
            DropIndex("dbo.Plan_discipline", new[] { "ID_Plan" });
            DropIndex("dbo.Class", new[] { "ID_Class_type" });
            DropIndex("dbo.Class", new[] { "ID_Plan_discipline" });
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.Field_of_study");
            DropTable("dbo.Faculty");
            DropTable("dbo.Department");
            DropTable("dbo.Plan");
            DropTable("dbo.Discipline");
            DropTable("dbo.Plan_discipline");
            DropTable("dbo.Class_type");
            DropTable("dbo.Class");
        }
    }
}
