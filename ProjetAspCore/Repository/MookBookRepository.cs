﻿using ProjetAspCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAspCore.Repository
{
    public class MookBookRepository : IBookRepository
    {
        //Permet de récupérer l'objet categorie
        private readonly ICategoryRepository _category = new MookCategoryRepository();
        public IEnumerable<Book> GetAllBooks()
        {
            //liste des livres afficher manuellement
            return new List<Book>()
            {
                new Book{BookId=1,Name="HTML/CSS",
                    LongDescription="Vous rêvez d'apprendre à créer des sites web mais vous avez peur que ce soit compliqué car vous débutez ? Ce livre est fait pour vous ! Conçu pour les débutants, il vous permettra de découvrir HTML5 et CSS3, les dernières technologies en matière de création de sites web, de façon progressive et sans aucun pré-requis, à part savoir allumer son ordinateur ! Qu'allez-vous apprendre ? Qu'est-ce qu'un site web et comment font les pros pour en créer ? Installez les logiciels dont vous avez besoin, que vous soyez sous Windows, Mac ou Linux Découvrez les balises HTML5 afin de structurer votre site Habillez vos pages web grâce à CSS3 Réussissez la mise en page de votre site pas à pas à travers des travaux pratiques ! Insérez facilement des images et vidéos sur votre site web Hébergez votre site sur le Web",
                    ImageUrl="https://images-na.ssl-images-amazon.com/images/I/41mAlr%2B%2BiiL._SX352_BO1,204,203,200_.jpg",
                     Price = 49, CategoryId = 1, Category = _category.GetCategoryById(1)
                },

            
                new Book { BookId = 2, Name = "PHP/MYSQL", LongDescription = "Vous connaissez le HTML et vous avez toujours rêvé de créer un site web dynamique, avec votre propre blog, vos forums et votre espace membres ? Ne cherchez plus ! Découvrez dans ce livre dédié aux débutants comment utiliser les langages les plus célèbres du web dynamique : PHP et MySQL.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/31uSiQ%2BhtHL._SX352_BO1,204,203,200_.jpg", InStock = true, ShortDescription = "Vous connaissez le HTML et vous avez toujours rêvé de créer un site web dynamique, avec votre propre blog, vos forums et votre espace membres ? Ne cherchez plus ! Découvrez dans ce livre dédié aux débutants comment utiliser les langages les plus célèbres du web dynamique : PHP et MySQL.",
                    Price = 45, CategoryId = 1, Category = _category.GetCategoryById(1) 
            },
              
                new Book { BookId = 3, Name = "JAVASCRIPT", LongDescription = "Ce livre s’adresse à tous les développeurs web, qu’ils soient débutants ou avancés.Le JavaScript sert avant tout à rendre les pages web interactives  et dynamiques du côté de l’utilisateur, mais il est également de plus en plus souvent utilisé côté serveur.",
                    ImageUrl = "https://images-eu.ssl-images-amazon.com/images/I/41mb9WPKBJL._SY346_.jpg",
                    Price = 48, CategoryId = 2, Category = _category.GetCategoryById(2) 
            },
              
                new Book { BookId = 4, Name = "REACT",
                    LongDescription = "En tant que développeur, qui n'a pas encore entendu parler de React.js (ou React de façon raccourcie) ? Cette bibliothèque JavaScript, initialement écrite pour Facebook (en 2013), s'utilise maintenant couramment dans le monde de l'entreprise. Elle permet de structurer efficacement une application web, mais peut également s'utiliser dans une version dite native, pour écrire des applications mobiles à destination des iPhone ou Android.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/515oQ2Lv8tL._SX331_BO1,204,203,200_.jpg",
                    Price = 60, CategoryId = 2, Category = _category.GetCategoryById(2) 
            },
              
                new Book { BookId = 5, Name = "ANGULAR",
                    LongDescription = "e livre permet aux lecteurs de se lancer dans le développement d'applications web avec le framework Angular (en version 8 au moment de l'écriture). Pour une meilleure compréhension de son contenu, il est nécessaire d'avoir un minimum de connaissances sur le fonctionnement du web et sur les langages HTML et JavaScript. Les auteurs ont eu à coeur de rédiger un livre très pragmatique avec de nombreux exemples de code, commentés et expliqués, qui illustrent de façon très concrète les passages plus théoriques. ",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/41mKFVuZXBL._SX403_BO1,204,203,200_.jpg",
                    InStock = true,
                    ShortDescription = "Développeur passionné depuis de nombreuses années, Daniel DJORDJEVIC a toujours porté de l'intérêt aux technologies web. Aujourd'hui développeur Full Stack, il intervient sur toute la stack des nouveaux projets, notamment avec Angular et ASP.NET Core au sein du cloud Microsoft Azure.", 
                    Price = 29, CategoryId = 3, Category = _category.GetCategoryById(3) 
            },
              
                new Book { BookId = 6, Name = "ASP.NET CORE MVC",
                    LongDescription = "Ce livre s'adresse aux développeurs web désireux de maîtriser ASP.NET Core MVC, framework proposé par Microsoft, totalement Open source. L'auteur souhaite fournir au lecteur les bases techniques nécessaires à une utilisation optimale du framework pour construire des applications web riches et modernes. La connaissance de HTML, CSS et C# sont des prérequis indispensables pour tirer le meilleur profit du livre. ",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/41mpS6W5IzL._SX410_BO1,204,203,200_.jpg", 
                    InStock = true,
                    ShortDescription = "Ingénieur .NET depuis 2015 et reconnu MVP (Most Valuable Professional), Christophe GIGAX travaille avec ASP.NET Core depuis la sortie des premières versions. Il a suivi l'évolution de la technologie et a ainsi acquis une solide expertise sur le sujet, confortée par ses diverses réalisations. Au travers de ce livre il partage avec plaisir toute cette expérience avec les lecteurs.",
                    Price = 32, CategoryId = 3, Category = _category.GetCategoryById(3) 
            },
              
                new Book { BookId = 7, Name = "ASP.NET MVC",
                    LongDescription = "Préface de Julien CORIOLAND - Microsoft MVP ASP.NET / IIS - Windows Azure - Web Technical Lead Ce livre s'adresse à un large public de développeurs désireux de maîtriser ASP.NET MVC 4. Des connaissances de base sur le langage C# sont un prérequis indispensable pour tirer le meilleur parti possible de la lecture de ce livre. Il peut être lu chapitre après chapitre en suivant le fil conducteur prévu pour guider le lecteur des principes de base jusqu'à des considérations avancées. Il peut aussi être consulté pour approfondir un point précis du développement web avec ASP.NET MVC 4.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/41dCst-Km3L._SX422_BO1,204,203,200_.jpg",
                    ShortDescription = "Léonard LABAT est Consultant Formateur depuis plusieurs années. Spécialiste des technologies .NET, il est certifié MCSD Web Developer. Titulaire d'un master en Informatique et Architecture logicielle, Anna YAFI est Consultant / Développeur .", 
                    Price = 45, CategoryId = 4, Category = _category.GetCategoryById(4)
            },
                new Book { BookId = 8, Name = "C#",
                    LongDescription = "Ce livre s'adresse aux développeurs souhaitant maîtriser le développement d'applications .NET avec le langage C# dans sa version 7. Après un tour d'horizon de la plateforme .NET et une description des outils fournis par l'environnement Visual Studio 2017, le lecteur découvrira progressivement les éléments clés du langage C# et la programmation orientée objet, jusqu'à pouvoir appliquer ce concept au développement d'applications Windows avec WPF.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51izwuYTTnL._SX412_BO1,204,203,200_.jpg",
                    InStock = true,
                    ShortDescription = "Consultant et Formateur depuis plusieurs années, Sébastien PUTIER apporte son expertise dans la mise en oeuvre de solutions Windows, Web et mobiles avec la plateforme .NET depuis ses premières versions. Il est certifié techniquement (MCPD - MCSD) et pédagogiquement (MCT) par Microsoft.",
                    Price = 55, CategoryId = 4, Category = _category.GetCategoryById(4)
            },
        };
        }
        // récupère le book.id
        public Book GetBookById(int id)
        {
           return GetAllBooks().FirstOrDefault(b => b.BookId == id);
        }
    }
}
