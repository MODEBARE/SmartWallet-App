using SmartWallet.Web.Data.Entities;

namespace SmartWallet.Web.Data
{
    public static class SeedHelper
    {
        public static async Task InitializeData(ApplicationDbContext context)
        {
            //1. check if customers contain data
            if (!context.Customers.Any())
            {
                //2. create sample data

                context.Customers.Add(new Customer
                {
                    FirstName = "Kola",
                    LastName = "Adeagbo",
                    BirthDate = DateTime.Now.AddYears(-20),
                    Gender = GenderEnum.Male,
                    Address = "Lagos Street",
                    PhoneNo = "08029518371",
                    Email = "koletipro@gmail.com",
                    Active = true
                });

                context.Customers.Add(new Customer
                {
                    FirstName = "Titi",
                    LastName = "Olabanjo",
                    BirthDate = DateTime.Now.AddYears(-10),
                    Gender = GenderEnum.Female,
                    Address = "Lagos Street 2",
                    PhoneNo = "08039518372",
                    Email = "titi@gmail.com",
                    Active = false
                });

                await context.SaveChangesAsync();
            }

            if (!context.Countries.Any())
            {
                //context.Countries.Add(new Country
                //{
                //    Name = "Afghanistan",
                //    IsoCode = "AFG",
                //    CallCode = "93"
                //});

                context.Countries.AddRange (new List<Country>
                {
                    new Country { Name = "Afghanistan", IsoCode = "AFG", CallCode = "93" },
                    new Country { Name = "Albania", IsoCode = "ALB", CallCode = "355" },
                    new Country { Name = "Algeria", IsoCode = "DZA", CallCode = "213" }
                });

                await context.SaveChangesAsync();
            }

            if (!context.Languages.Any())
            {
                context.Languages.AddRange(new List<Language>
                {
                    new Language { Name = "English" },
                    new Language { Name = "French" },
                });

                await context.SaveChangesAsync();
            }
        }
    }
}
