using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetAspCore.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    InStock = table.Column<bool>(nullable: false),
                    Notes = table.Column<decimal>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    ShoppingCartSessionId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Big data ", "livre sur le big data" },
                    { 2, "Database ", "Base de donnée pour les nuls" },
                    { 3, "Front-End ", "front-end expert" },
                    { 4, "Back-End ", "l'art de l'animation" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "CategoryId", "ImageUrl", "InStock", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "https://images-na.ssl-images-amazon.com/images/I/41mAlr%2B%2BiiL._SX352_BO1,204,203,200_.jpg", true, "Vous rêvez d'apprendre à créer des sites web mais vous avez peur que ce soit compliqué car vous débutez ? Ce livre est fait pour vous ! Conçu pour les débutants, il vous permettra de découvrir HTML5 et CSS3, les dernières technologies en matière de création de sites web, de façon progressive et sans aucun pré-requis, à part savoir allumer son ordinateur ! Qu'allez-vous apprendre ? Qu'est-ce qu'un site web et comment font les pros pour en créer ? Installez les logiciels dont vous avez besoin, que vous soyez sous Windows, Mac ou Linux Découvrez les balises HTML5 afin de structurer votre site Habillez vos pages web grâce à CSS3 Réussissez la mise en page de votre site pas à pas à travers des travaux pratiques ! Insérez facilement des images et vidéos sur votre site web Hébergez votre site sur le Web", "HTML/CSS", 4m, 0m, "Vous rêvez d'apprendre à créer des sites web mais vous avez peur que ce soit compliqué car vous débutez ? Ce livre est fait pour vous ! Conçu pour les débutants, il vous permettra de découvrir HTML 5 et CSS 3, les dernières technologies en matière de création de sites web, de façon progressive et sans aucun prérequis, si ce n'est de savoir allumer son ordinateur !" },
                    { 2, 1, "https://images-na.ssl-images-amazon.com/images/I/31uSiQ%2BhtHL._SX352_BO1,204,203,200_.jpg", true, "Vous connaissez le HTML et vous avez toujours rêvé de créer un site web dynamique, avec votre propre blog, vos forums et votre espace membres ? Ne cherchez plus ! Découvrez dans ce livre dédié aux débutants comment utiliser les langages les plus célèbres du web dynamique : PHP et MySQL.", "PHP/MYSQL", 5m, 120.90m, "Vous connaissez le HTML et vous avez toujours rêvé de créer un site web dynamique, avec votre propre blog, vos forums et votre espace membres ? Ne cherchez plus ! Découvrez dans ce livre dédié aux débutants comment utiliser les langages les plus célèbres du web dynamique : PHP et MySQL." },
                    { 3, 2, "https://images-eu.ssl-images-amazon.com/images/I/41mb9WPKBJL._SY346_.jpg", true, "Ce livre s’adresse à tous les développeurs web, qu’ils soient débutants ou avancés.Le JavaScript sert avant tout à rendre les pages web interactives  et dynamiques du côté de l’utilisateur, mais il est également de plus en plus souvent utilisé côté serveur.", "JAVASCRIPT", 2m, 66m, "Développeur passionné depuis de nombreuses années, Daniel DJORDJEVIC a toujours porté de l'intérêt aux technologies web. Aujourd'hui développeur Full Stack, il intervient sur toute la stack des nouveaux projets, notamment avec Angular et ASP.NET Core au sein du cloud Microsoft Azure." },
                    { 4, 2, "https://images-na.ssl-images-amazon.com/images/I/515oQ2Lv8tL._SX331_BO1,204,203,200_.jpg", true, "En tant que développeur, qui n'a pas encore entendu parler de React.js (ou React de façon raccourcie) ? Cette bibliothèque JavaScript, initialement écrite pour Facebook (en 2013), s'utilise maintenant couramment dans le monde de l'entreprise. Elle permet de structurer efficacement une application web, mais peut également s'utiliser dans une version dite native, pour écrire des applications mobiles à destination des iPhone ou Android.", "REACT", 3m, 0m, "Cet ouvrage vous permettra entre autres de créer des applications web autonomes, mais également de les interfacer avec un serveur en utilisant Ajax. Et surtout, vous comprendrez comment augmenter la complexité de votre application tout en conservant un code bien structuré, ceci grâce à React mais aussi Redux, étudié dans les derniers chapitres de l'ouvrage." },
                    { 5, 3, " https://images-na.ssl-images-amazon.com/images/I/41mKFVuZXBL._SX403_BO1,204,203,200_.jpg", true, "e livre permet aux lecteurs de se lancer dans le développement d'applications web avec le framework Angular (en version 8 au moment de l'écriture). Pour une meilleure compréhension de son contenu, il est nécessaire d'avoir un minimum de connaissances sur le fonctionnement du web et sur les langages HTML et JavaScript. Les auteurs ont eu à coeur de rédiger un livre très pragmatique avec de nombreux exemples de code, commentés et expliqués, qui illustrent de façon très concrète les passages plus théoriques. ", "Angular", 5m, 66m, "Développeur passionné depuis de nombreuses années, Daniel DJORDJEVIC a toujours porté de l'intérêt aux technologies web. Aujourd'hui développeur Full Stack, il intervient sur toute la stack des nouveaux projets, notamment avec Angular et ASP.NET Core au sein du cloud Microsoft Azure." },
                    { 6, 3, "https://images-na.ssl-images-amazon.com/images/I/41mpS6W5IzL._SX410_BO1,204,203,200_.jpg", true, "Ce livre s'adresse aux développeurs web désireux de maîtriser ASP.NET Core MVC, framework proposé par Microsoft, totalement Open source. L'auteur souhaite fournir au lecteur les bases techniques nécessaires à une utilisation optimale du framework pour construire des applications web riches et modernes. La connaissance de HTML, CSS et C# sont des prérequis indispensables pour tirer le meilleur profit du livre. ", "ASP.NET CORE MVC", 5m, 89m, "Ingénieur .NET depuis 2015 et reconnu MVP (Most Valuable Professional), Christophe GIGAX travaille avec ASP.NET Core depuis la sortie des premières versions. Il a suivi l'évolution de la technologie et a ainsi acquis une solide expertise sur le sujet, confortée par ses diverses réalisations. Au travers de ce livre il partage avec plaisir toute cette expérience avec les lecteurs." },
                    { 7, 4, "https://images-na.ssl-images-amazon.com/images/I/41dCst-Km3L._SX422_BO1,204,203,200_.jpg", true, "Préface de Julien CORIOLAND - Microsoft MVP ASP.NET / IIS - Windows Azure - Web Technical Lead Ce livre s'adresse à un large public de développeurs désireux de maîtriser ASP.NET MVC 4. Des connaissances de base sur le langage C# sont un prérequis indispensable pour tirer le meilleur parti possible de la lecture de ce livre. Il peut être lu chapitre après chapitre en suivant le fil conducteur prévu pour guider le lecteur des principes de base jusqu'à des considérations avancées. Il peut aussi être consulté pour approfondir un point précis du développement web avec ASP.NET MVC 4.", "ASP.NET MVC", 4m, 55.60m, "Léonard LABAT est Consultant Formateur depuis plusieurs années. Spécialiste des technologies .NET, il est certifié MCSD Web Developer. Titulaire d'un master en Informatique et Architecture logicielle, Anna YAFI est Consultant / Développeur ." },
                    { 8, 4, "https://images-na.ssl-images-amazon.com/images/I/51izwuYTTnL._SX412_BO1,204,203,200_.jpg", true, "Ce livre s'adresse aux développeurs souhaitant maîtriser le développement d'applications .NET avec le langage C# dans sa version 7. Après un tour d'horizon de la plateforme .NET et une description des outils fournis par l'environnement Visual Studio 2017, le lecteur découvrira progressivement les éléments clés du langage C# et la programmation orientée objet, jusqu'à pouvoir appliquer ce concept au développement d'applications Windows avec WPF.", "C#", 2m, 98m, "Consultant et Formateur depuis plusieurs années, Sébastien PUTIER apporte son expertise dans la mise en oeuvre de solutions Windows, Web et mobiles avec la plateforme .NET depuis ses premières versions. Il est certifié techniquement (MCPD - MCSD) et pédagogiquement (MCT) par Microsoft." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_BookId",
                table: "ShoppingCartItems",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
