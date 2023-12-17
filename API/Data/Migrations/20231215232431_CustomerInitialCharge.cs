using CineVerse.API.Data;
using CineVerse.API.Models;

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class CustomerInitialCharge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new DataContext();

            context.Customer.AddRange(GetInitialCharge());
            context.SaveChanges();
        }

        private static IList<Customer> GetInitialCharge()
        {
            var password = "wW*8uuuu";
            var john = new string[2] { "John", "Locke" };
            var hugo = new string[2] { "Hugo", "Reyes" };
            var kate = new string[2] { "Kate", "Austen" };
            var jack = new string[2] { "Jack", "Shephard" };
            var james = new string[2] { "James", "Sawyer" };
            var sayid = new string[2] { "Sayid", "Jarrah" };
            var desmond = new string[2] { "Desmond", "Hume" };
            var benjamin = new string[2] { "Benjamin", "Linus" };

            return new List<Customer>()
            {
                new()
                {
                    Email = $"{john[1].ToLower()}{john[0].ToLower()}@lost.com",
                    UserName = $"{john[0].ToLower()}{john[1].ToLower()}",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    FirstName = john[0],
                    LastName = john[1],
                    Password = password,
                },
                new()
                {
                    Email = $"{hugo[1].ToLower()}{hugo[0].ToLower()}@lost.com",
                    UserName = $"{hugo[0].ToLower()}{hugo[1].ToLower()}",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    FirstName = hugo[0],
                    LastName = hugo[1],
                    Password = password,
                },
                new()
                {
                    Email = $"{kate[1].ToLower()}{kate[0].ToLower()}@lost.com",
                    UserName = $"{kate[0].ToLower()}{kate[1].ToLower()}",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    FirstName = kate[0],
                    LastName = kate[1],
                    Password = password,
                },
                new()
                {
                    Email = $"{james[1].ToLower()}{james[0].ToLower()}@lost.com",
                    UserName = $"{james[0].ToLower()}{james[1].ToLower()}",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    FirstName = james[0],
                    LastName = james[1],
                    Password = password,
                },
                new()
                {
                    Email = $"{sayid[1].ToLower()}{sayid[0].ToLower()}@lost.com",
                    UserName = $"{sayid[0].ToLower()}{sayid[1].ToLower()}",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    FirstName = sayid[0],
                    LastName = sayid[1],
                    Password = password,
                },
                new()
                {
                    Email = $"{jack[1].ToLower()}{jack[0].ToLower()}@lost.com",
                    UserName = $"{jack[0].ToLower()}{jack[1].ToLower()}",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    FirstName = jack[0],
                    LastName = jack[1],
                    Password = password,
                },
                new()
                {
                    Email = $"{desmond[1].ToLower()}{desmond[0].ToLower()}@lost.com",
                    UserName = $"{desmond[0].ToLower()}{desmond[1].ToLower()}",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    FirstName = desmond[0],
                    LastName = desmond[1],
                    Password = password,
                },
                new()
                {
                    Email = $"{benjamin[1].ToLower()}{benjamin[0].ToLower()}@lost.com",
                    UserName = $"{benjamin[0].ToLower()}{benjamin[1].ToLower()}",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    FirstName = benjamin[0],
                    LastName = benjamin[1],
                    Password = password,
                },
            };
        }
    }
}
