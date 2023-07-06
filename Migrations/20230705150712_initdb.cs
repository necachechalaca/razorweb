using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Bogus;

namespace webapp.Migrations
{
    public partial class initdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dulieu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Content = table.Column<string>(type: "ntext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dulieu", x => x.Id);
                });
                Randomizer.Seed = new Random(8675309);
        
                var fakerArticle = new Faker<Article>();
                fakerArticle.RuleFor(a=> a.Title, f => f.Lorem.Sentence(5,6));
                fakerArticle.RuleFor(a=>a.Created, f =>f.Date.Between(new DateTime(2023,3,3), new DateTime(2023,6,30)));
             
             for(int i=0; i<100;i++){
                Article article =  fakerArticle.Generate();

               migrationBuilder.InsertData( 
                table : "Dulieu",
                columns : new []{"Title","Created","Content"},
                values : new object[]{
                    article.Title,
                    article.Created,
                    "Noi dung 1"
                }
               );
             }
             
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dulieu");
        }
    }
}
