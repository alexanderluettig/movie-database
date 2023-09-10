using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieDatabase.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddRatingToMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Movies",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Brandon Aufderhar", 10, 5.7000130069683852, "Auto Loan Account extend paradigms", 2017 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Vernice Osinski", 1, 90.185274778216822, "bandwidth Handcrafted Rubber Chicken communities", 1945 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Ottis DuBuque", 5, 46.247155141828259, "Horizontal Accountability Generic", 1976 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Mollie Dietrich", 2, 86.172294844095745, "Savings Account Executive Chief", 1947 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Henry Kemmer", 0, 46.213798334251251, "blue violet Cotton", 1928 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "David Tromp", 21, 83.521155550162646, "Lead Honduras Rustic Steel Computer", 1953 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Zula Ebert", 10, 65.789654492539313, "local area network Platinum Ergonomic Fresh Bacon", 1989 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Caitlyn Beer", 18, 33.413215492684365, "Investment Account deposit orchid", 1951 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Piper Stiedemann", 12, 75.485306266379482, "hack Representative lavender", 2005 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Susie Harber", 17, 42.459751702638201, "Kentucky input Clothing, Outdoors & Health", 1984 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Angelina Metz", 0, 90.653550866085979, "Assistant Turnpike interface", 1993 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Director", "Rating", "Title", "Year" },
                values: new object[] { "Selina Beer", 2.0582340811053812, "blue Port Developer", 1941 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Eli Quigley", 17, 66.026363058234523, "Frozen Concrete metrics", 1962 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Ludie Muller", 20, 28.240530810353125, "Automated Electronics, Garden & Industrial Tasty", 1972 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Lora Effertz", 15, 29.44166664532445, "bus Checking Account FTP", 1910 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Thalia Feest", 18, 22.530755987057884, "deposit compressing supply-chains", 1977 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Vilma Wehner", 21, 70.064174769361827, "Stravenue matrix array", 2016 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Brandt Jacobson", 17, 34.192096166874144, "Frozen Markets Berkshire", 1943 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Chad Conn", 17, 49.723180622399966, "facilitate heuristic Metrics", 1940 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Beverly Schamberger", 2, 25.859627648553818, "Berkshire bricks-and-clicks Mali", 1903 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Vesta Lindgren", 8, 11.155811920421854, "Groves payment Delaware", 1963 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Scarlett Hoeger", 3, 87.550417981478319, "Regional Customer Bedfordshire", 1965 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Bertha Rippin", 16, 92.970352124701435, "wireless Intelligent Intelligent", 1920 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Lambert Littel", 5, 23.698351619698034, "Yemeni Rial Delaware niches", 1924 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Elisabeth Dickens", 13, 39.741665584905014, "leverage deposit EXE", 1920 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Joey Marks", 20, 31.13035772589755, "utilize Squares human-resource", 1939 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Alvera Tromp", 9, 10.71145459956676, "Outdoors & Jewelery Tasty Fundamental", 1972 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Director", "Rating", "Title", "Year" },
                values: new object[] { "Leta Johns", 33.762965006120368, "Puerto Rico GB Branding", 1908 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Mervin Macejkovic", 19, 69.670290696195366, "Borders Functionality payment", 1901 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Cleve Ondricka", 21, 23.712681681522994, "Manager B2C connecting", 1936 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Arnold Kemmer", 11, 65.945867669221428, "dot-com invoice Buckinghamshire", 1986 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Marilou Kerluke", 13, 45.584675142482823, "Associate vertical Avon", 1931 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Sincere Wisoky", 1, 84.353462775696869, "Bedfordshire Ergonomic Steel Shirt grow", 1907 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Millie Wuckert", 5, 50.932482507042295, "Bedfordshire Burgs maroon", 2020 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Nikita Rowe", 3, 12.445390554247016, "Chile deposit Fresh", 2019 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Monty Armstrong", 0, 79.725634361946291, "Curve Automotive & Health visionary", 1928 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Einar Nitzsche", 2, 45.724656321698845, "Metal directional e-business", 1919 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Wava Kuvalis", 20, 65.240034278006576, "RSS Street Virtual", 1993 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Dandre Larkin", 9, 29.983776855217315, "web-readiness Cuban Peso Convertible actuating", 1971 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Domenick Hackett", 10, 65.768371865683761, "payment Chief bandwidth", 1996 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Iliana Hirthe", 21, 26.026751929216474, "Handmade Rubber Shirt info-mediaries Brook", 1992 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Lesly Schmeler", 18, 75.44894308413393, "orchid Bedfordshire District", 1950 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Jakob Sanford", 5, 70.462869155039073, "e-commerce structure navigating", 1907 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Nakia Carroll", 14, 96.151257203119485, "Product Jewelery gold", 1937 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Antonette Stoltenberg", 16, 69.09190337180415, "protocol wireless Implementation", 1986 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Ryleigh Willms", 5, 24.690855393534772, "concept XML neural", 1940 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Ursula Murphy", 6, 17.988874540610322, "Unbranded driver payment", 1964 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Sharon Pacocha", 5, 22.679021512691445, "parsing Course Technician", 1914 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Adelbert Ankunding", 4, 50.117570825583904, "Administrator definition Lane", 1952 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Effie Rogahn", 6, 7.8523398069437755, "National Berkshire composite", 2016 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Rhoda Bernhard", 12, 24.164345978830916, "Guernsey Avon silver", 1979 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Jarvis Beier", 10, 41.824522885302585, "Pike Awesome Beauty", 1944 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Breanna Leannon", 2, 94.919404501792314, "Maine Analyst Frozen", 1950 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Kamille Harvey", 12, 81.752571103714018, "plug-and-play Analyst Manor", 1968 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Clay Welch", 17, 29.450353718069632, "Oman green Credit Card Account", 2010 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Frederic Ward", 8, 18.369108046977235, "cross-platform Books, Electronics & Beauty turquoise", 1971 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Haleigh Kling", 5, 28.896777617702764, "Facilitator Metal Credit Card Account", 1978 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Frederic Monahan", 15, 10.494731797757828, "deposit multi-byte Estates", 1914 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Abdullah Pouros", 9, 69.134581373676767, "indigo Motorway collaborative", 1922 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Taya Bradtke", 18, 30.393230355214428, "deploy brand Savings Account", 1952 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Lydia Balistreri", 18, 97.580948946586119, "indexing Ports Investment Account", 1948 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Harley Feil", 14, 20.587299008741255, "Berkshire Yen Zambian Kwacha", 2021 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Margot McCullough", 11, 75.269389049511375, "Coordinator Investment Account clear-thinking", 1927 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Lonny Blanda", 1, 82.227843696681617, "parsing input tan", 1908 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Aidan Kreiger", 13, 62.909238349507113, "Credit Card Account Pennsylvania Representative", 1982 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Anibal Leuschke", 6, 36.229028056921479, "Plastic schemas reintermediate", 1993 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Jarrod Frami", 19, 27.50115628811718, "yellow payment parsing", 1923 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Junior Klein", 0, 90.901878540230669, "connecting SMS Cayman Islands", 1995 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Jeramy King", 6, 4.2473184232661669, "Ergonomic Mobility maroon", 1908 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Jovani Hessel", 3, 91.099608165164696, "Operations Egyptian Pound markets", 1910 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Nicole Trantow", 2, 95.265166056952637, "Practical Soft Soap indigo Incredible", 1949 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Ceasar Lehner", 1, 56.059802780474321, "Forward Square Facilitator", 1904 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Wilfred Carroll", 14, 4.7391898972820918, "Planner Coordinator Cambridgeshire", 2018 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Eli Dietrich", 11, 74.431165290225849, "Arkansas Junctions Small Fresh Towels", 2016 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Toy Douglas", 10, 94.678001485118585, "AI Licensed Fresh Chair invoice", 1989 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Beth Paucek", 12, 62.619826711648564, "Central Plastic solid state", 1959 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Kaela Graham", 9, 97.545998858479336, "online Music, Computers & Clothing Fantastic", 1987 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Blanche Walter", 14, 50.314819381965947, "e-markets CSS West Virginia", 1913 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Lukas Abshire", 21, 42.869565780757789, "Chief Legacy CSS", 1929 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Kathryn Hickle", 17, 65.367847442256036, "enable Alaska Planner", 1977 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Eliza Haag", 4, 20.789575987133311, "payment Coves Sleek Metal Table", 1991 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Earl Gusikowski", 4, 43.534913566901913, "Product front-end THX", 1948 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Emiliano Berge", 8, 27.631074820362112, "leverage Concrete Saudi Riyal", 1953 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Erwin Romaguera", 10, 13.209366191634221, "open architecture next generation Saint Pierre and Miquelon", 1903 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Travon Fadel", 21, 67.105776879359496, "Loaf Paraguay Sharable", 1947 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Alvera Dickinson", 15, 68.027613125526727, "Toys & Health withdrawal Dale", 1927 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Lexus Hessel", 0, 98.037560447989833, "Gorgeous Rubber Table platforms Sleek", 1952 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Brice Tremblay", 9, 70.192190745187943, "Plains full-range Solutions", 1936 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Amir Feest", 14, 79.343761434648528, "Jewelery & Garden Intelligent Wooden Soap technologies", 2009 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Lucy Dibbert", 4, 25.991899735457547, "payment Ergonomic Rubber Cheese Integration", 1908 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Enrique Swaniawski", 12, 6.7312934887209241, "maroon Ergonomic Fresh Chicken Maine", 1984 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Thaddeus Kozey", 8, 18.79001258686873, "content-based Mississippi Human", 1964 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Dorothea Anderson", 1, 8.7089023661700899, "Arkansas pixel National", 1959 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Francisca Rosenbaum", 4, 60.053313107097871, "engage ROI SAS", 1955 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Braden Rolfson", 20, 87.723958345639886, "enterprise Inlet Implementation", 2015 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Orrin Parker", 17, 46.074621277080055, "Total Intelligent Metal Chicken actuating", 1995 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Kelley Upton", 17, 19.926816450982276, "Oregon mindshare Rubber", 1900 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Director", "Rating", "Title", "Year" },
                values: new object[] { "Grace Moen", 64.613521504757372, "California generate transmitter", 1912 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Director", "Rating", "Title", "Year" },
                values: new object[] { "Alec Marquardt", 92.671759779611591, "Underpass strategic Assistant", 1990 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Director", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "Alberta Schmeler", 15, 36.737206996201834, "system leverage Auto Loan Account", 1975 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Movies");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Bertrand Schoen", 19, "Massachusetts Berkshire card", 2008 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Uriel Langosh", 6, "Parkways Consultant Ergonomic Cotton Chips", 2005 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Derrick Gorczany", 7, "Rustic Engineer Neck", 1988 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Javonte Nitzsche", 18, "Cedi Creative dedicated", 1970 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Michale Keebler", 6, "holistic Handcrafted Fresh Bike supply-chains", 2005 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Dorothea Padberg", 18, "Analyst Awesome Metal Bike Intranet", 1948 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Missouri Cassin", 14, "Australia Identity models", 2004 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Kylie White", 20, "dynamic Global parse", 1914 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Maryjane Dach", 1, "Rustic Mandatory Silver", 2000 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Cynthia Becker", 10, "orchid Awesome Frozen Gloves wireless", 1964 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Anjali Rice", 12, "e-business Applications Executive", 1952 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Director", "Title", "Year" },
                values: new object[] { "Alfredo Price", "El Salvador Colon Beauty, Games & Games frictionless", 1983 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Ottilie Cummerata", 4, "haptic transmitter array", 2019 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Elwyn Stroman", 6, "next-generation Ranch AI", 2001 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Amelia Pouros", 12, "monitor Persevering Green", 1945 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Layla Schmeler", 7, "Secured Awesome Cambridgeshire", 1902 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Lois Koss", 20, "Intelligent Auto Loan Account bottom-line", 1926 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Alfred O'Conner", 11, "Investor monitor Incredible Plastic Towels", 1918 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Johan Collins", 0, "Ranch Well neural", 1959 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Reinhold Cruickshank", 4, "Algerian Dinar input Hungary", 1999 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Jaquelin West", 2, "architect Shoes, Health & Toys open-source", 1932 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Aditya Dooley", 17, "24/7 solution strategize", 1902 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Dewayne Johnson", 15, "Ergonomic dynamic South Dakota", 1913 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Maddison Stamm", 18, "analyzing Profound best-of-breed", 2006 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Orland Turner", 7, "Ergonomic Expanded mint green", 1917 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Akeem Becker", 0, "Nepalese Rupee 4th generation Grocery, Grocery & Electronics", 1909 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Sim Sanford", 15, "Representative Sleek Frozen Tuna Maine", 1927 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Director", "Title", "Year" },
                values: new object[] { "Celia Emmerich", "recontextualize South Africa Awesome Soft Cheese", 1928 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Dolly Kuphal", 4, "optimal orchid override", 1980 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Iva Wintheiser", 16, "bandwidth port HDD", 1926 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Cullen Erdman", 15, "Coordinator Unbranded Ferry", 1978 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Marilyne Runolfsson", 21, "paradigm parse Gorgeous Soft Computer", 1993 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Santa Rohan", 16, "sensor withdrawal withdrawal", 1962 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Cecelia Monahan", 12, "Delaware deposit Concrete", 2005 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Francisco Hilpert", 17, "Money Market Account portals best-of-breed", 1997 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Jacques McDermott", 11, "Borders global Forward", 2002 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Cierra Kuphal", 3, "artificial intelligence Crossroad Ergonomic Soft Tuna", 1901 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Amie White", 7, "Pines Romania SMTP", 1921 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Dejah Runolfsson", 10, "Nepal Innovative French Polynesia", 1912 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Coy Schneider", 13, "Checking Account red Rhode Island", 1904 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Chadd Sawayn", 2, "deliverables Falkland Islands (Malvinas) Bedfordshire", 2008 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Mae Schiller", 19, "Vermont relationships TCP", 1908 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Alicia Boehm", 7, "feed content SSL", 2018 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Wilfrid Kshlerin", 1, "Via Gibraltar Pound navigate", 1903 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Alanna Erdman", 20, "cross-platform Program Qatari Rial", 2018 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Yesenia Hessel", 6, "approach Auto Loan Account Som", 1927 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Anastasia Abernathy", 11, "Auto Loan Account Steel Data", 1989 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Stephany Greenfelder", 15, "Computers, Outdoors & Beauty transform Lead", 1988 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Brando Fadel", 3, "CSS Lead holistic", 1987 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Edna Dietrich", 20, "users Licensed Wooden Gloves composite", 1900 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Quincy Spencer", 21, "Plastic parsing e-commerce", 1988 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Makenna Barrows", 4, "turn-key Avon Automotive", 1938 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Arvid Turner", 14, "Product calculate Green", 2018 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Patsy Roob", 2, "facilitate Incredible Granite Keyboard Agent", 2003 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Elizabeth O'Kon", 12, "Paradigm Steel auxiliary", 1921 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Friedrich Kuhic", 1, "Configuration Inverse indexing", 1997 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Reagan Beatty", 21, "Borders ADP Bedfordshire", 1901 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Cynthia Grant", 19, "Auto Loan Account Minnesota Curve", 1989 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Ezequiel Pagac", 14, "Director solutions holistic", 1952 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Geo Turner", 4, "Future-proofed copying viral", 1944 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Lura Langosh", 0, "Handcrafted Soft Mouse Sleek Steel Hat Directives", 1957 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Karlee Wolff", 12, "Music, Kids & Grocery Qatar Frozen", 2001 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Magnolia Murazik", 1, "world-class Sleek Parkways", 1958 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Loma Prosacco", 2, "connecting attitude THX", 1970 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Mckayla Dooley", 18, "Somali Shilling Producer Movies, Computers & Outdoors", 1920 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Aurelio Padberg", 5, "Integration Tennessee Facilitator", 1910 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Jazmyne Grimes", 9, "hack 24 hour Generic Soft Bacon", 1962 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Lexus Rippin", 16, "payment array invoice", 1945 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Justina Kub", 2, "Qatari Rial HDD generate", 2004 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Myriam Goodwin", 4, "black Home Loan Account redundant", 1972 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Berry Botsford", 1, "Lari Rubber pink", 1967 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Hassan Klocko", 20, "Euro Plains Green", 1918 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Gloria Halvorson", 18, "Mongolia Auto Loan Account Throughway", 2013 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Dayton Kutch", 0, "Cuban Peso Future internet solution", 1948 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Aimee Strosin", 9, "Colombia Marketing utilize", 1962 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Arielle Prohaska", 6, "Ports Puerto Rico impactful", 1965 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Luisa Rosenbaum", 6, "Investment Account New York productivity", 1923 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Fabiola Barton", 7, "array Small Concrete Shoes Frozen", 1985 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Asa Murray", 19, "Toys, Beauty & Grocery Ergonomic generate", 1980 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Adaline Batz", 9, "primary Practical Granite Salad Monaco", 1915 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Meredith Reinger", 14, "Customer backing up Practical", 1925 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Hiram Lueilwitz", 16, "monitor Belize Dollar French Polynesia", 2008 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Sierra Walsh", 0, "payment CFA Franc BCEAO capacitor", 1927 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Buck Lindgren", 13, "olive benchmark Producer", 1935 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Marge Davis", 14, "Orchestrator Trafficway Garden, Toys & Toys", 1964 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Rodolfo Prosacco", 19, "Sports & Electronics Sleek Rubber Computer Zloty", 2006 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Ezra Mante", 13, "Kiribati parsing transmitting", 1996 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "German Beer", 15, "Yemeni Rial Operations Ridge", 1953 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Clement Crooks", 0, "Credit Card Account Global Usability", 1957 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Lucinda Legros", 6, "Mozambique Avon Tunnel", 1918 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "General Ernser", 7, "Investor Lead Investment Account", 1972 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Gennaro Nader", 13, "gold Forward black", 1987 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Chauncey Herzog", 16, "Seychelles Rupee Passage Refined Cotton Bike", 1956 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Ludie Ankunding", 10, "dot-com Sleek Lead", 1956 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Jermaine Mueller", 1, "Toys Handmade SDD", 2010 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Dolly Smitham", 5, "bypassing quantifying Internal", 1910 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Conner Steuber", 4, "SSL Forest auxiliary", 2004 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Director", "Title", "Year" },
                values: new object[] { "Eleazar Quitzon", "Jewelery Tools, Baby & Movies Checking Account", 1981 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Director", "Title", "Year" },
                values: new object[] { "Cortez Swaniawski", "solutions enhance compress", 1904 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Director", "Genre", "Title", "Year" },
                values: new object[] { "Titus Doyle", 11, "Kids, Movies & Outdoors Strategist feed", 1939 });
        }
    }
}
