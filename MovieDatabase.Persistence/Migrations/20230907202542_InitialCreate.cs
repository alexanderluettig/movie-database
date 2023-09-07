using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieDatabase.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Director = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Genre = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Genre", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "Bertrand Schoen", 19, "Massachusetts Berkshire card", 2008 },
                    { 2, "Uriel Langosh", 6, "Parkways Consultant Ergonomic Cotton Chips", 2005 },
                    { 3, "Derrick Gorczany", 7, "Rustic Engineer Neck", 1988 },
                    { 4, "Javonte Nitzsche", 18, "Cedi Creative dedicated", 1970 },
                    { 5, "Michale Keebler", 6, "holistic Handcrafted Fresh Bike supply-chains", 2005 },
                    { 6, "Dorothea Padberg", 18, "Analyst Awesome Metal Bike Intranet", 1948 },
                    { 7, "Missouri Cassin", 14, "Australia Identity models", 2004 },
                    { 8, "Kylie White", 20, "dynamic Global parse", 1914 },
                    { 9, "Maryjane Dach", 1, "Rustic Mandatory Silver", 2000 },
                    { 10, "Cynthia Becker", 10, "orchid Awesome Frozen Gloves wireless", 1964 },
                    { 11, "Anjali Rice", 12, "e-business Applications Executive", 1952 },
                    { 12, "Alfredo Price", 3, "El Salvador Colon Beauty, Games & Games frictionless", 1983 },
                    { 13, "Ottilie Cummerata", 4, "haptic transmitter array", 2019 },
                    { 14, "Elwyn Stroman", 6, "next-generation Ranch AI", 2001 },
                    { 15, "Amelia Pouros", 12, "monitor Persevering Green", 1945 },
                    { 16, "Layla Schmeler", 7, "Secured Awesome Cambridgeshire", 1902 },
                    { 17, "Lois Koss", 20, "Intelligent Auto Loan Account bottom-line", 1926 },
                    { 18, "Alfred O'Conner", 11, "Investor monitor Incredible Plastic Towels", 1918 },
                    { 19, "Johan Collins", 0, "Ranch Well neural", 1959 },
                    { 20, "Reinhold Cruickshank", 4, "Algerian Dinar input Hungary", 1999 },
                    { 21, "Jaquelin West", 2, "architect Shoes, Health & Toys open-source", 1932 },
                    { 22, "Aditya Dooley", 17, "24/7 solution strategize", 1902 },
                    { 23, "Dewayne Johnson", 15, "Ergonomic dynamic South Dakota", 1913 },
                    { 24, "Maddison Stamm", 18, "analyzing Profound best-of-breed", 2006 },
                    { 25, "Orland Turner", 7, "Ergonomic Expanded mint green", 1917 },
                    { 26, "Akeem Becker", 0, "Nepalese Rupee 4th generation Grocery, Grocery & Electronics", 1909 },
                    { 27, "Sim Sanford", 15, "Representative Sleek Frozen Tuna Maine", 1927 },
                    { 28, "Celia Emmerich", 9, "recontextualize South Africa Awesome Soft Cheese", 1928 },
                    { 29, "Dolly Kuphal", 4, "optimal orchid override", 1980 },
                    { 30, "Iva Wintheiser", 16, "bandwidth port HDD", 1926 },
                    { 31, "Cullen Erdman", 15, "Coordinator Unbranded Ferry", 1978 },
                    { 32, "Marilyne Runolfsson", 21, "paradigm parse Gorgeous Soft Computer", 1993 },
                    { 33, "Santa Rohan", 16, "sensor withdrawal withdrawal", 1962 },
                    { 34, "Cecelia Monahan", 12, "Delaware deposit Concrete", 2005 },
                    { 35, "Francisco Hilpert", 17, "Money Market Account portals best-of-breed", 1997 },
                    { 36, "Jacques McDermott", 11, "Borders global Forward", 2002 },
                    { 37, "Cierra Kuphal", 3, "artificial intelligence Crossroad Ergonomic Soft Tuna", 1901 },
                    { 38, "Amie White", 7, "Pines Romania SMTP", 1921 },
                    { 39, "Dejah Runolfsson", 10, "Nepal Innovative French Polynesia", 1912 },
                    { 40, "Coy Schneider", 13, "Checking Account red Rhode Island", 1904 },
                    { 41, "Chadd Sawayn", 2, "deliverables Falkland Islands (Malvinas) Bedfordshire", 2008 },
                    { 42, "Mae Schiller", 19, "Vermont relationships TCP", 1908 },
                    { 43, "Alicia Boehm", 7, "feed content SSL", 2018 },
                    { 44, "Wilfrid Kshlerin", 1, "Via Gibraltar Pound navigate", 1903 },
                    { 45, "Alanna Erdman", 20, "cross-platform Program Qatari Rial", 2018 },
                    { 46, "Yesenia Hessel", 6, "approach Auto Loan Account Som", 1927 },
                    { 47, "Anastasia Abernathy", 11, "Auto Loan Account Steel Data", 1989 },
                    { 48, "Stephany Greenfelder", 15, "Computers, Outdoors & Beauty transform Lead", 1988 },
                    { 49, "Brando Fadel", 3, "CSS Lead holistic", 1987 },
                    { 50, "Edna Dietrich", 20, "users Licensed Wooden Gloves composite", 1900 },
                    { 51, "Quincy Spencer", 21, "Plastic parsing e-commerce", 1988 },
                    { 52, "Makenna Barrows", 4, "turn-key Avon Automotive", 1938 },
                    { 53, "Arvid Turner", 14, "Product calculate Green", 2018 },
                    { 54, "Patsy Roob", 2, "facilitate Incredible Granite Keyboard Agent", 2003 },
                    { 55, "Elizabeth O'Kon", 12, "Paradigm Steel auxiliary", 1921 },
                    { 56, "Friedrich Kuhic", 1, "Configuration Inverse indexing", 1997 },
                    { 57, "Reagan Beatty", 21, "Borders ADP Bedfordshire", 1901 },
                    { 58, "Cynthia Grant", 19, "Auto Loan Account Minnesota Curve", 1989 },
                    { 59, "Ezequiel Pagac", 14, "Director solutions holistic", 1952 },
                    { 60, "Geo Turner", 4, "Future-proofed copying viral", 1944 },
                    { 61, "Lura Langosh", 0, "Handcrafted Soft Mouse Sleek Steel Hat Directives", 1957 },
                    { 62, "Karlee Wolff", 12, "Music, Kids & Grocery Qatar Frozen", 2001 },
                    { 63, "Magnolia Murazik", 1, "world-class Sleek Parkways", 1958 },
                    { 64, "Loma Prosacco", 2, "connecting attitude THX", 1970 },
                    { 65, "Mckayla Dooley", 18, "Somali Shilling Producer Movies, Computers & Outdoors", 1920 },
                    { 66, "Aurelio Padberg", 5, "Integration Tennessee Facilitator", 1910 },
                    { 67, "Jazmyne Grimes", 9, "hack 24 hour Generic Soft Bacon", 1962 },
                    { 68, "Lexus Rippin", 16, "payment array invoice", 1945 },
                    { 69, "Justina Kub", 2, "Qatari Rial HDD generate", 2004 },
                    { 70, "Myriam Goodwin", 4, "black Home Loan Account redundant", 1972 },
                    { 71, "Berry Botsford", 1, "Lari Rubber pink", 1967 },
                    { 72, "Hassan Klocko", 20, "Euro Plains Green", 1918 },
                    { 73, "Gloria Halvorson", 18, "Mongolia Auto Loan Account Throughway", 2013 },
                    { 74, "Dayton Kutch", 0, "Cuban Peso Future internet solution", 1948 },
                    { 75, "Aimee Strosin", 9, "Colombia Marketing utilize", 1962 },
                    { 76, "Arielle Prohaska", 6, "Ports Puerto Rico impactful", 1965 },
                    { 77, "Luisa Rosenbaum", 6, "Investment Account New York productivity", 1923 },
                    { 78, "Fabiola Barton", 7, "array Small Concrete Shoes Frozen", 1985 },
                    { 79, "Asa Murray", 19, "Toys, Beauty & Grocery Ergonomic generate", 1980 },
                    { 80, "Adaline Batz", 9, "primary Practical Granite Salad Monaco", 1915 },
                    { 81, "Meredith Reinger", 14, "Customer backing up Practical", 1925 },
                    { 82, "Hiram Lueilwitz", 16, "monitor Belize Dollar French Polynesia", 2008 },
                    { 83, "Sierra Walsh", 0, "payment CFA Franc BCEAO capacitor", 1927 },
                    { 84, "Buck Lindgren", 13, "olive benchmark Producer", 1935 },
                    { 85, "Marge Davis", 14, "Orchestrator Trafficway Garden, Toys & Toys", 1964 },
                    { 86, "Rodolfo Prosacco", 19, "Sports & Electronics Sleek Rubber Computer Zloty", 2006 },
                    { 87, "Ezra Mante", 13, "Kiribati parsing transmitting", 1996 },
                    { 88, "German Beer", 15, "Yemeni Rial Operations Ridge", 1953 },
                    { 89, "Clement Crooks", 0, "Credit Card Account Global Usability", 1957 },
                    { 90, "Lucinda Legros", 6, "Mozambique Avon Tunnel", 1918 },
                    { 91, "General Ernser", 7, "Investor Lead Investment Account", 1972 },
                    { 92, "Gennaro Nader", 13, "gold Forward black", 1987 },
                    { 93, "Chauncey Herzog", 16, "Seychelles Rupee Passage Refined Cotton Bike", 1956 },
                    { 94, "Ludie Ankunding", 10, "dot-com Sleek Lead", 1956 },
                    { 95, "Jermaine Mueller", 1, "Toys Handmade SDD", 2010 },
                    { 96, "Dolly Smitham", 5, "bypassing quantifying Internal", 1910 },
                    { 97, "Conner Steuber", 4, "SSL Forest auxiliary", 2004 },
                    { 98, "Eleazar Quitzon", 2, "Jewelery Tools, Baby & Movies Checking Account", 1981 },
                    { 99, "Cortez Swaniawski", 17, "solutions enhance compress", 1904 },
                    { 100, "Titus Doyle", 11, "Kids, Movies & Outdoors Strategist feed", 1939 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
