﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieDatabase.Persistence;

#nullable disable

namespace MovieDatabase.Persistence.Migrations
{
    [DbContext(typeof(MovieDBContext))]
    [Migration("20230910195122_AddRatingToMovie")]
    partial class AddRatingToMovie
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Genre")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Rating")
                        .HasColumnType("REAL");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Director = "Brandon Aufderhar",
                            Genre = 10,
                            Rating = 5.7000130069683852,
                            Title = "Auto Loan Account extend paradigms",
                            Year = 2017
                        },
                        new
                        {
                            Id = 2,
                            Director = "Vernice Osinski",
                            Genre = 1,
                            Rating = 90.185274778216822,
                            Title = "bandwidth Handcrafted Rubber Chicken communities",
                            Year = 1945
                        },
                        new
                        {
                            Id = 3,
                            Director = "Ottis DuBuque",
                            Genre = 5,
                            Rating = 46.247155141828259,
                            Title = "Horizontal Accountability Generic",
                            Year = 1976
                        },
                        new
                        {
                            Id = 4,
                            Director = "Mollie Dietrich",
                            Genre = 2,
                            Rating = 86.172294844095745,
                            Title = "Savings Account Executive Chief",
                            Year = 1947
                        },
                        new
                        {
                            Id = 5,
                            Director = "Henry Kemmer",
                            Genre = 0,
                            Rating = 46.213798334251251,
                            Title = "blue violet Cotton",
                            Year = 1928
                        },
                        new
                        {
                            Id = 6,
                            Director = "David Tromp",
                            Genre = 21,
                            Rating = 83.521155550162646,
                            Title = "Lead Honduras Rustic Steel Computer",
                            Year = 1953
                        },
                        new
                        {
                            Id = 7,
                            Director = "Zula Ebert",
                            Genre = 10,
                            Rating = 65.789654492539313,
                            Title = "local area network Platinum Ergonomic Fresh Bacon",
                            Year = 1989
                        },
                        new
                        {
                            Id = 8,
                            Director = "Caitlyn Beer",
                            Genre = 18,
                            Rating = 33.413215492684365,
                            Title = "Investment Account deposit orchid",
                            Year = 1951
                        },
                        new
                        {
                            Id = 9,
                            Director = "Piper Stiedemann",
                            Genre = 12,
                            Rating = 75.485306266379482,
                            Title = "hack Representative lavender",
                            Year = 2005
                        },
                        new
                        {
                            Id = 10,
                            Director = "Susie Harber",
                            Genre = 17,
                            Rating = 42.459751702638201,
                            Title = "Kentucky input Clothing, Outdoors & Health",
                            Year = 1984
                        },
                        new
                        {
                            Id = 11,
                            Director = "Angelina Metz",
                            Genre = 0,
                            Rating = 90.653550866085979,
                            Title = "Assistant Turnpike interface",
                            Year = 1993
                        },
                        new
                        {
                            Id = 12,
                            Director = "Selina Beer",
                            Genre = 3,
                            Rating = 2.0582340811053812,
                            Title = "blue Port Developer",
                            Year = 1941
                        },
                        new
                        {
                            Id = 13,
                            Director = "Eli Quigley",
                            Genre = 17,
                            Rating = 66.026363058234523,
                            Title = "Frozen Concrete metrics",
                            Year = 1962
                        },
                        new
                        {
                            Id = 14,
                            Director = "Ludie Muller",
                            Genre = 20,
                            Rating = 28.240530810353125,
                            Title = "Automated Electronics, Garden & Industrial Tasty",
                            Year = 1972
                        },
                        new
                        {
                            Id = 15,
                            Director = "Lora Effertz",
                            Genre = 15,
                            Rating = 29.44166664532445,
                            Title = "bus Checking Account FTP",
                            Year = 1910
                        },
                        new
                        {
                            Id = 16,
                            Director = "Thalia Feest",
                            Genre = 18,
                            Rating = 22.530755987057884,
                            Title = "deposit compressing supply-chains",
                            Year = 1977
                        },
                        new
                        {
                            Id = 17,
                            Director = "Vilma Wehner",
                            Genre = 21,
                            Rating = 70.064174769361827,
                            Title = "Stravenue matrix array",
                            Year = 2016
                        },
                        new
                        {
                            Id = 18,
                            Director = "Brandt Jacobson",
                            Genre = 17,
                            Rating = 34.192096166874144,
                            Title = "Frozen Markets Berkshire",
                            Year = 1943
                        },
                        new
                        {
                            Id = 19,
                            Director = "Chad Conn",
                            Genre = 17,
                            Rating = 49.723180622399966,
                            Title = "facilitate heuristic Metrics",
                            Year = 1940
                        },
                        new
                        {
                            Id = 20,
                            Director = "Beverly Schamberger",
                            Genre = 2,
                            Rating = 25.859627648553818,
                            Title = "Berkshire bricks-and-clicks Mali",
                            Year = 1903
                        },
                        new
                        {
                            Id = 21,
                            Director = "Vesta Lindgren",
                            Genre = 8,
                            Rating = 11.155811920421854,
                            Title = "Groves payment Delaware",
                            Year = 1963
                        },
                        new
                        {
                            Id = 22,
                            Director = "Scarlett Hoeger",
                            Genre = 3,
                            Rating = 87.550417981478319,
                            Title = "Regional Customer Bedfordshire",
                            Year = 1965
                        },
                        new
                        {
                            Id = 23,
                            Director = "Bertha Rippin",
                            Genre = 16,
                            Rating = 92.970352124701435,
                            Title = "wireless Intelligent Intelligent",
                            Year = 1920
                        },
                        new
                        {
                            Id = 24,
                            Director = "Lambert Littel",
                            Genre = 5,
                            Rating = 23.698351619698034,
                            Title = "Yemeni Rial Delaware niches",
                            Year = 1924
                        },
                        new
                        {
                            Id = 25,
                            Director = "Elisabeth Dickens",
                            Genre = 13,
                            Rating = 39.741665584905014,
                            Title = "leverage deposit EXE",
                            Year = 1920
                        },
                        new
                        {
                            Id = 26,
                            Director = "Joey Marks",
                            Genre = 20,
                            Rating = 31.13035772589755,
                            Title = "utilize Squares human-resource",
                            Year = 1939
                        },
                        new
                        {
                            Id = 27,
                            Director = "Alvera Tromp",
                            Genre = 9,
                            Rating = 10.71145459956676,
                            Title = "Outdoors & Jewelery Tasty Fundamental",
                            Year = 1972
                        },
                        new
                        {
                            Id = 28,
                            Director = "Leta Johns",
                            Genre = 9,
                            Rating = 33.762965006120368,
                            Title = "Puerto Rico GB Branding",
                            Year = 1908
                        },
                        new
                        {
                            Id = 29,
                            Director = "Mervin Macejkovic",
                            Genre = 19,
                            Rating = 69.670290696195366,
                            Title = "Borders Functionality payment",
                            Year = 1901
                        },
                        new
                        {
                            Id = 30,
                            Director = "Cleve Ondricka",
                            Genre = 21,
                            Rating = 23.712681681522994,
                            Title = "Manager B2C connecting",
                            Year = 1936
                        },
                        new
                        {
                            Id = 31,
                            Director = "Arnold Kemmer",
                            Genre = 11,
                            Rating = 65.945867669221428,
                            Title = "dot-com invoice Buckinghamshire",
                            Year = 1986
                        },
                        new
                        {
                            Id = 32,
                            Director = "Marilou Kerluke",
                            Genre = 13,
                            Rating = 45.584675142482823,
                            Title = "Associate vertical Avon",
                            Year = 1931
                        },
                        new
                        {
                            Id = 33,
                            Director = "Sincere Wisoky",
                            Genre = 1,
                            Rating = 84.353462775696869,
                            Title = "Bedfordshire Ergonomic Steel Shirt grow",
                            Year = 1907
                        },
                        new
                        {
                            Id = 34,
                            Director = "Millie Wuckert",
                            Genre = 5,
                            Rating = 50.932482507042295,
                            Title = "Bedfordshire Burgs maroon",
                            Year = 2020
                        },
                        new
                        {
                            Id = 35,
                            Director = "Nikita Rowe",
                            Genre = 3,
                            Rating = 12.445390554247016,
                            Title = "Chile deposit Fresh",
                            Year = 2019
                        },
                        new
                        {
                            Id = 36,
                            Director = "Monty Armstrong",
                            Genre = 0,
                            Rating = 79.725634361946291,
                            Title = "Curve Automotive & Health visionary",
                            Year = 1928
                        },
                        new
                        {
                            Id = 37,
                            Director = "Einar Nitzsche",
                            Genre = 2,
                            Rating = 45.724656321698845,
                            Title = "Metal directional e-business",
                            Year = 1919
                        },
                        new
                        {
                            Id = 38,
                            Director = "Wava Kuvalis",
                            Genre = 20,
                            Rating = 65.240034278006576,
                            Title = "RSS Street Virtual",
                            Year = 1993
                        },
                        new
                        {
                            Id = 39,
                            Director = "Dandre Larkin",
                            Genre = 9,
                            Rating = 29.983776855217315,
                            Title = "web-readiness Cuban Peso Convertible actuating",
                            Year = 1971
                        },
                        new
                        {
                            Id = 40,
                            Director = "Domenick Hackett",
                            Genre = 10,
                            Rating = 65.768371865683761,
                            Title = "payment Chief bandwidth",
                            Year = 1996
                        },
                        new
                        {
                            Id = 41,
                            Director = "Iliana Hirthe",
                            Genre = 21,
                            Rating = 26.026751929216474,
                            Title = "Handmade Rubber Shirt info-mediaries Brook",
                            Year = 1992
                        },
                        new
                        {
                            Id = 42,
                            Director = "Lesly Schmeler",
                            Genre = 18,
                            Rating = 75.44894308413393,
                            Title = "orchid Bedfordshire District",
                            Year = 1950
                        },
                        new
                        {
                            Id = 43,
                            Director = "Jakob Sanford",
                            Genre = 5,
                            Rating = 70.462869155039073,
                            Title = "e-commerce structure navigating",
                            Year = 1907
                        },
                        new
                        {
                            Id = 44,
                            Director = "Nakia Carroll",
                            Genre = 14,
                            Rating = 96.151257203119485,
                            Title = "Product Jewelery gold",
                            Year = 1937
                        },
                        new
                        {
                            Id = 45,
                            Director = "Antonette Stoltenberg",
                            Genre = 16,
                            Rating = 69.09190337180415,
                            Title = "protocol wireless Implementation",
                            Year = 1986
                        },
                        new
                        {
                            Id = 46,
                            Director = "Ryleigh Willms",
                            Genre = 5,
                            Rating = 24.690855393534772,
                            Title = "concept XML neural",
                            Year = 1940
                        },
                        new
                        {
                            Id = 47,
                            Director = "Ursula Murphy",
                            Genre = 6,
                            Rating = 17.988874540610322,
                            Title = "Unbranded driver payment",
                            Year = 1964
                        },
                        new
                        {
                            Id = 48,
                            Director = "Sharon Pacocha",
                            Genre = 5,
                            Rating = 22.679021512691445,
                            Title = "parsing Course Technician",
                            Year = 1914
                        },
                        new
                        {
                            Id = 49,
                            Director = "Adelbert Ankunding",
                            Genre = 4,
                            Rating = 50.117570825583904,
                            Title = "Administrator definition Lane",
                            Year = 1952
                        },
                        new
                        {
                            Id = 50,
                            Director = "Effie Rogahn",
                            Genre = 6,
                            Rating = 7.8523398069437755,
                            Title = "National Berkshire composite",
                            Year = 2016
                        },
                        new
                        {
                            Id = 51,
                            Director = "Rhoda Bernhard",
                            Genre = 12,
                            Rating = 24.164345978830916,
                            Title = "Guernsey Avon silver",
                            Year = 1979
                        },
                        new
                        {
                            Id = 52,
                            Director = "Jarvis Beier",
                            Genre = 10,
                            Rating = 41.824522885302585,
                            Title = "Pike Awesome Beauty",
                            Year = 1944
                        },
                        new
                        {
                            Id = 53,
                            Director = "Breanna Leannon",
                            Genre = 2,
                            Rating = 94.919404501792314,
                            Title = "Maine Analyst Frozen",
                            Year = 1950
                        },
                        new
                        {
                            Id = 54,
                            Director = "Kamille Harvey",
                            Genre = 12,
                            Rating = 81.752571103714018,
                            Title = "plug-and-play Analyst Manor",
                            Year = 1968
                        },
                        new
                        {
                            Id = 55,
                            Director = "Clay Welch",
                            Genre = 17,
                            Rating = 29.450353718069632,
                            Title = "Oman green Credit Card Account",
                            Year = 2010
                        },
                        new
                        {
                            Id = 56,
                            Director = "Frederic Ward",
                            Genre = 8,
                            Rating = 18.369108046977235,
                            Title = "cross-platform Books, Electronics & Beauty turquoise",
                            Year = 1971
                        },
                        new
                        {
                            Id = 57,
                            Director = "Haleigh Kling",
                            Genre = 5,
                            Rating = 28.896777617702764,
                            Title = "Facilitator Metal Credit Card Account",
                            Year = 1978
                        },
                        new
                        {
                            Id = 58,
                            Director = "Frederic Monahan",
                            Genre = 15,
                            Rating = 10.494731797757828,
                            Title = "deposit multi-byte Estates",
                            Year = 1914
                        },
                        new
                        {
                            Id = 59,
                            Director = "Abdullah Pouros",
                            Genre = 9,
                            Rating = 69.134581373676767,
                            Title = "indigo Motorway collaborative",
                            Year = 1922
                        },
                        new
                        {
                            Id = 60,
                            Director = "Taya Bradtke",
                            Genre = 18,
                            Rating = 30.393230355214428,
                            Title = "deploy brand Savings Account",
                            Year = 1952
                        },
                        new
                        {
                            Id = 61,
                            Director = "Lydia Balistreri",
                            Genre = 18,
                            Rating = 97.580948946586119,
                            Title = "indexing Ports Investment Account",
                            Year = 1948
                        },
                        new
                        {
                            Id = 62,
                            Director = "Harley Feil",
                            Genre = 14,
                            Rating = 20.587299008741255,
                            Title = "Berkshire Yen Zambian Kwacha",
                            Year = 2021
                        },
                        new
                        {
                            Id = 63,
                            Director = "Margot McCullough",
                            Genre = 11,
                            Rating = 75.269389049511375,
                            Title = "Coordinator Investment Account clear-thinking",
                            Year = 1927
                        },
                        new
                        {
                            Id = 64,
                            Director = "Lonny Blanda",
                            Genre = 1,
                            Rating = 82.227843696681617,
                            Title = "parsing input tan",
                            Year = 1908
                        },
                        new
                        {
                            Id = 65,
                            Director = "Aidan Kreiger",
                            Genre = 13,
                            Rating = 62.909238349507113,
                            Title = "Credit Card Account Pennsylvania Representative",
                            Year = 1982
                        },
                        new
                        {
                            Id = 66,
                            Director = "Anibal Leuschke",
                            Genre = 6,
                            Rating = 36.229028056921479,
                            Title = "Plastic schemas reintermediate",
                            Year = 1993
                        },
                        new
                        {
                            Id = 67,
                            Director = "Jarrod Frami",
                            Genre = 19,
                            Rating = 27.50115628811718,
                            Title = "yellow payment parsing",
                            Year = 1923
                        },
                        new
                        {
                            Id = 68,
                            Director = "Junior Klein",
                            Genre = 0,
                            Rating = 90.901878540230669,
                            Title = "connecting SMS Cayman Islands",
                            Year = 1995
                        },
                        new
                        {
                            Id = 69,
                            Director = "Jeramy King",
                            Genre = 6,
                            Rating = 4.2473184232661669,
                            Title = "Ergonomic Mobility maroon",
                            Year = 1908
                        },
                        new
                        {
                            Id = 70,
                            Director = "Jovani Hessel",
                            Genre = 3,
                            Rating = 91.099608165164696,
                            Title = "Operations Egyptian Pound markets",
                            Year = 1910
                        },
                        new
                        {
                            Id = 71,
                            Director = "Nicole Trantow",
                            Genre = 2,
                            Rating = 95.265166056952637,
                            Title = "Practical Soft Soap indigo Incredible",
                            Year = 1949
                        },
                        new
                        {
                            Id = 72,
                            Director = "Ceasar Lehner",
                            Genre = 1,
                            Rating = 56.059802780474321,
                            Title = "Forward Square Facilitator",
                            Year = 1904
                        },
                        new
                        {
                            Id = 73,
                            Director = "Wilfred Carroll",
                            Genre = 14,
                            Rating = 4.7391898972820918,
                            Title = "Planner Coordinator Cambridgeshire",
                            Year = 2018
                        },
                        new
                        {
                            Id = 74,
                            Director = "Eli Dietrich",
                            Genre = 11,
                            Rating = 74.431165290225849,
                            Title = "Arkansas Junctions Small Fresh Towels",
                            Year = 2016
                        },
                        new
                        {
                            Id = 75,
                            Director = "Toy Douglas",
                            Genre = 10,
                            Rating = 94.678001485118585,
                            Title = "AI Licensed Fresh Chair invoice",
                            Year = 1989
                        },
                        new
                        {
                            Id = 76,
                            Director = "Beth Paucek",
                            Genre = 12,
                            Rating = 62.619826711648564,
                            Title = "Central Plastic solid state",
                            Year = 1959
                        },
                        new
                        {
                            Id = 77,
                            Director = "Kaela Graham",
                            Genre = 9,
                            Rating = 97.545998858479336,
                            Title = "online Music, Computers & Clothing Fantastic",
                            Year = 1987
                        },
                        new
                        {
                            Id = 78,
                            Director = "Blanche Walter",
                            Genre = 14,
                            Rating = 50.314819381965947,
                            Title = "e-markets CSS West Virginia",
                            Year = 1913
                        },
                        new
                        {
                            Id = 79,
                            Director = "Lukas Abshire",
                            Genre = 21,
                            Rating = 42.869565780757789,
                            Title = "Chief Legacy CSS",
                            Year = 1929
                        },
                        new
                        {
                            Id = 80,
                            Director = "Kathryn Hickle",
                            Genre = 17,
                            Rating = 65.367847442256036,
                            Title = "enable Alaska Planner",
                            Year = 1977
                        },
                        new
                        {
                            Id = 81,
                            Director = "Eliza Haag",
                            Genre = 4,
                            Rating = 20.789575987133311,
                            Title = "payment Coves Sleek Metal Table",
                            Year = 1991
                        },
                        new
                        {
                            Id = 82,
                            Director = "Earl Gusikowski",
                            Genre = 4,
                            Rating = 43.534913566901913,
                            Title = "Product front-end THX",
                            Year = 1948
                        },
                        new
                        {
                            Id = 83,
                            Director = "Emiliano Berge",
                            Genre = 8,
                            Rating = 27.631074820362112,
                            Title = "leverage Concrete Saudi Riyal",
                            Year = 1953
                        },
                        new
                        {
                            Id = 84,
                            Director = "Erwin Romaguera",
                            Genre = 10,
                            Rating = 13.209366191634221,
                            Title = "open architecture next generation Saint Pierre and Miquelon",
                            Year = 1903
                        },
                        new
                        {
                            Id = 85,
                            Director = "Travon Fadel",
                            Genre = 21,
                            Rating = 67.105776879359496,
                            Title = "Loaf Paraguay Sharable",
                            Year = 1947
                        },
                        new
                        {
                            Id = 86,
                            Director = "Alvera Dickinson",
                            Genre = 15,
                            Rating = 68.027613125526727,
                            Title = "Toys & Health withdrawal Dale",
                            Year = 1927
                        },
                        new
                        {
                            Id = 87,
                            Director = "Lexus Hessel",
                            Genre = 0,
                            Rating = 98.037560447989833,
                            Title = "Gorgeous Rubber Table platforms Sleek",
                            Year = 1952
                        },
                        new
                        {
                            Id = 88,
                            Director = "Brice Tremblay",
                            Genre = 9,
                            Rating = 70.192190745187943,
                            Title = "Plains full-range Solutions",
                            Year = 1936
                        },
                        new
                        {
                            Id = 89,
                            Director = "Amir Feest",
                            Genre = 14,
                            Rating = 79.343761434648528,
                            Title = "Jewelery & Garden Intelligent Wooden Soap technologies",
                            Year = 2009
                        },
                        new
                        {
                            Id = 90,
                            Director = "Lucy Dibbert",
                            Genre = 4,
                            Rating = 25.991899735457547,
                            Title = "payment Ergonomic Rubber Cheese Integration",
                            Year = 1908
                        },
                        new
                        {
                            Id = 91,
                            Director = "Enrique Swaniawski",
                            Genre = 12,
                            Rating = 6.7312934887209241,
                            Title = "maroon Ergonomic Fresh Chicken Maine",
                            Year = 1984
                        },
                        new
                        {
                            Id = 92,
                            Director = "Thaddeus Kozey",
                            Genre = 8,
                            Rating = 18.79001258686873,
                            Title = "content-based Mississippi Human",
                            Year = 1964
                        },
                        new
                        {
                            Id = 93,
                            Director = "Dorothea Anderson",
                            Genre = 1,
                            Rating = 8.7089023661700899,
                            Title = "Arkansas pixel National",
                            Year = 1959
                        },
                        new
                        {
                            Id = 94,
                            Director = "Francisca Rosenbaum",
                            Genre = 4,
                            Rating = 60.053313107097871,
                            Title = "engage ROI SAS",
                            Year = 1955
                        },
                        new
                        {
                            Id = 95,
                            Director = "Braden Rolfson",
                            Genre = 20,
                            Rating = 87.723958345639886,
                            Title = "enterprise Inlet Implementation",
                            Year = 2015
                        },
                        new
                        {
                            Id = 96,
                            Director = "Orrin Parker",
                            Genre = 17,
                            Rating = 46.074621277080055,
                            Title = "Total Intelligent Metal Chicken actuating",
                            Year = 1995
                        },
                        new
                        {
                            Id = 97,
                            Director = "Kelley Upton",
                            Genre = 17,
                            Rating = 19.926816450982276,
                            Title = "Oregon mindshare Rubber",
                            Year = 1900
                        },
                        new
                        {
                            Id = 98,
                            Director = "Grace Moen",
                            Genre = 2,
                            Rating = 64.613521504757372,
                            Title = "California generate transmitter",
                            Year = 1912
                        },
                        new
                        {
                            Id = 99,
                            Director = "Alec Marquardt",
                            Genre = 17,
                            Rating = 92.671759779611591,
                            Title = "Underpass strategic Assistant",
                            Year = 1990
                        },
                        new
                        {
                            Id = 100,
                            Director = "Alberta Schmeler",
                            Genre = 15,
                            Rating = 36.737206996201834,
                            Title = "system leverage Auto Loan Account",
                            Year = 1975
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
