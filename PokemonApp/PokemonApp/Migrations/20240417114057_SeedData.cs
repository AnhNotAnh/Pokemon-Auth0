using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PokemonApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Electric" },
                    { 2, "Water" },
                    { 3, "Leaf" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Kanto" },
                    { 2, "Saffron City" },
                    { 3, "Millet Town" }
                });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Country", "CountryId", "Gym", "Name" },
                values: new object[,]
                {
                    { 1, "VN", null, "Brocks Gym", "Jack" },
                    { 2, "Aus", null, "Mistys Gym", "Harry" },
                    { 3, "US", null, "Ashs Gym", "Ash" }
                });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "BirthDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1903, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Pikachu" },
                    { 2, new DateTime(1903, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Squirtle" },
                    { 3, new DateTime(1903, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Venasaur" }
                });

            migrationBuilder.InsertData(
                table: "Reviewers",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Teddy", "Smith" },
                    { 2, "Taylor", "Jones" },
                    { 3, "Jessica", "McGregor" }
                });

            migrationBuilder.InsertData(
                table: "PokemonCategories",
                columns: new[] { "CategoryId", "PokemonId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "PokemonOwners",
                columns: new[] { "OwnerId", "PokemonId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Country", "PokemonId", "ReviewerId", "Text", "Title" },
                values: new object[,]
                {
                    { 1, "VN", 1, 1, "Pikachu is the best pokemon, because it is electric", "Pikachu Review" },
                    { 2, "US", 1, 2, "Squirtle is great", "Squirtle Review" },
                    { 3, "VN", 1, 3, "Venasaur is strong", "Venasaur Review" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PokemonCategories",
                keyColumns: new[] { "CategoryId", "PokemonId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PokemonCategories",
                keyColumns: new[] { "CategoryId", "PokemonId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "PokemonCategories",
                keyColumns: new[] { "CategoryId", "PokemonId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "PokemonOwners",
                keyColumns: new[] { "OwnerId", "PokemonId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PokemonOwners",
                keyColumns: new[] { "OwnerId", "PokemonId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "PokemonOwners",
                keyColumns: new[] { "OwnerId", "PokemonId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
