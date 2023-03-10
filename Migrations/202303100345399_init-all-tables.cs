namespace AppWinFormCRUD.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class initalltables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        IdNumber = c.String(nullable: false, maxLength: 2147483647,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "UniqueAttribute",
                                    new AnnotationValues(oldValue: null, newValue: "SQLite.CodeFirst.UniqueAttribute")
                                },
                            }),
                        Model = c.String(maxLength: 2147483647),
                        Mileage = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Crews",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        NamePerson = c.String(nullable: false, maxLength: 2147483647,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "UniqueAttribute",
                                    new AnnotationValues(oldValue: null, newValue: "SQLite.CodeFirst.UniqueAttribute")
                                },
                            }),
                        IdNumberCar = c.String(nullable: false, maxLength: 2147483647,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "UniqueAttribute",
                                    new AnnotationValues(oldValue: null, newValue: "SQLite.CodeFirst.UniqueAttribute")
                                },
                            }),
                        Transfer = c.String(maxLength: 2147483647),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Persons",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 2147483647,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "UniqueAttribute",
                                    new AnnotationValues(oldValue: null, newValue: "SQLite.CodeFirst.UniqueAttribute")
                                },
                            }),
                        Age = c.Int(),
                        ExperienceAge = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Persons",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Name",
                        new Dictionary<string, object>
                        {
                            { "UniqueAttribute", "SQLite.CodeFirst.UniqueAttribute" },
                        }
                    },
                });
            DropTable("dbo.Crews",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "IdNumberCar",
                        new Dictionary<string, object>
                        {
                            { "UniqueAttribute", "SQLite.CodeFirst.UniqueAttribute" },
                        }
                    },
                    {
                        "NamePerson",
                        new Dictionary<string, object>
                        {
                            { "UniqueAttribute", "SQLite.CodeFirst.UniqueAttribute" },
                        }
                    },
                });
            DropTable("dbo.Cars",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "IdNumber",
                        new Dictionary<string, object>
                        {
                            { "UniqueAttribute", "SQLite.CodeFirst.UniqueAttribute" },
                        }
                    },
                });
        }
    }
}
