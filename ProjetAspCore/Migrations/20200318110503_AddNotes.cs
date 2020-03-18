using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetAspCore.Migrations
{
    public partial class AddNotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Books",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "Price", "ShortDescription" },
                values: new object[] { 0m, "Vous rêvez d'apprendre à créer des sites web mais vous avez peur que ce soit compliqué car vous débutez ? Ce livre est fait pour vous ! Conçu pour les débutants, il vous permettra de découvrir HTML 5 et CSS 3, les dernières technologies en matière de création de sites web, de façon progressive et sans aucun prérequis, si ce n'est de savoir allumer son ordinateur !" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "Price", "ShortDescription" },
                values: new object[] { 0m, "Cet ouvrage vous permettra entre autres de créer des applications web autonomes, mais également de les interfacer avec un serveur en utilisant Ajax. Et surtout, vous comprendrez comment augmenter la complexité de votre application tout en conservant un code bien structuré, ceci grâce à React mais aussi Redux, étudié dans les derniers chapitres de l'ouvrage." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "Price", "ShortDescription" },
                values: new object[] { 98m, "Développeur passionné depuis de nombreuses années, Daniel DJORDJEVIC a toujours porté de l'intérêt aux technologies web. Aujourd'hui développeur Full Stack, il intervient sur toute la stack des nouveaux projets, notamment avec Angular et ASP.NET Core au sein du cloud Microsoft Azure." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "Price", "ShortDescription" },
                values: new object[] { 66m, "Développeur passionné depuis de nombreuses années, Daniel DJORDJEVIC a toujours porté de l'intérêt aux technologies web. Aujourd'hui développeur Full Stack, il intervient sur toute la stack des nouveaux projets, notamment avec Angular et ASP.NET Core au sein du cloud Microsoft Azure." });
        }
    }
}
