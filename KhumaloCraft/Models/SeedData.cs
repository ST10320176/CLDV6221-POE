/*using KhumaloCraft.Data;
using Microsoft.EntityFrameworkCore;

namespace KhumaloCraft.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new KhumaloCraftContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<KhumaloCraftContext>>()))
            {
                // Look for any user
                /*if (context.User.Any())
                {
                    return;   // DB has been seeded
                }

                context.User.AddRange(
                    new User
                    {
                        Username = "Colin Beethe",
                        Email = "colin@example.com",
                        Password = "colin@123",
                        Cellnumber = "083 331 1967"
                    },
                    new User
                    {
                        Username = "Sibu Nkosi",
                        Email = "sibu@example.com",
                        Password = "Sibs123@",
                        Cellnumber = "079 710 4867"
                    },
                    new User
                    {
                        Username = "Cebo Thabethe",
                        Email = "cebo@example.com",
                        Password = "Thabethe@1",
                        Cellnumber = "082 332 3232"
                    },
                    new User
                    {
                        Username = "Nick Dwayne",
                        Email = "nick@example.com",
                        Password = "Nicki123",
                        Cellnumber = "067 721 7657"
                    }
                );
                //context.SaveChanges();*/
                // Look for any user
                /*if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }
                context.Product.AddRange(
                    new Product
                    {
                        Name = "Handcrafted Wooden Bowl.",
                        Destination = "Madadeni, KwaZulu-Natal",
                        Price = (decimal?)21.99
                        
                    },
                    new Product
                    {
                        Name = "Undercut Wood Bowl",
                        Destination = "Ballito, KwaZulu-Natal",
                        Price = (decimal?)29.99
                    },
                    new Product
                    {
                        Name = "Flecked Clay Cup",
                        Destination = "Durban North, KwaZulu-Natal",
                        Price = (decimal?)19.99
                    },
                    new Product
                    {
                        Name = "Candles",
                        Destination = "Pinetown, KwaZulu-Natal",
                        Price = (decimal?)9.99
                    }
                );
                context.SaveChanges();
            }

        }
    }
}*/