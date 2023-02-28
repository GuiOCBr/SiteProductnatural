using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NaturalFarma.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Category(CategoryName, Description)" + "VALUES('nacionais','produto fabricado no Brasil')");

            migrationBuilder.Sql("INSERT INTO Category(CategoryName, Description)" + "VALUES('internacionais','produto fabricado na China')");
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Category");
        }
    }
}
