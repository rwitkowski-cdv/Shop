using Bogus;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shop.Models;

namespace Shop.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
        public DbSet<OrderHeader> OrderHeader{ get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            Randomizer.Seed = new Random(123456);

            var fakeCategorySeed = new Faker<Category>()
                .RuleFor(c => c.Id, f => f.Random.Guid())
                .RuleFor(c => c.CreatedOn, f => DateTime.Now)
                .RuleFor(c => c.CreatedById, f => f.Random.Guid())
                .RuleFor(c => c.ModifiedOn, f => DateTime.Now)
                .RuleFor(c => c.ModifiedById, f => f.Random.Guid())
                .RuleFor(c => c.Name, f => f.Commerce.Categories(1)[0]);

            var fakeCategoriesGenerate = fakeCategorySeed.Generate(10);

            var fakeProductSeed = new Faker<Product>()
                .RuleFor(p => p.Id, f => f.Random.Guid())
                .RuleFor(p => p.CreatedOn, f => DateTime.Now)
                .RuleFor(p => p.CreatedById, f => f.Random.Guid())
                .RuleFor(p => p.ModifiedOn, f => DateTime.Now)
                .RuleFor(p => p.ModifiedById, f => f.Random.Guid())
                .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                .RuleFor(p => p.SKU, f => f.Commerce.Ean13())
                .RuleFor(p => p.ImageUrl, f => f.Image.PicsumUrl(640, 480))
                .RuleFor(p => p.GrossAmount, f => decimal.Parse(f.Commerce.Price(1, 1000)))
                .RuleFor(p => p.NetAmount, (f, p) => Math.Round(p.GrossAmount / 1.2m, 2))
                .RuleFor(p => p.TaxAmount, (f, p) => Math.Round(p.GrossAmount - p.NetAmount, 2))
                .RuleFor(p => p.Description, f => f.Commerce.ProductDescription())
                .RuleFor(p => p.IsAvailable, f => f.Random.Bool(0.8f))
                .RuleFor(p => p.Tag, f => f.Commerce.ProductAdjective())
                .RuleFor(p => p.CategoryId, f => f.PickRandom(fakeCategoriesGenerate).Id);

            var fakeProductGenerate = fakeProductSeed.Generate(50);

            builder.Entity<Category>().HasData(fakeCategoriesGenerate);
            builder.Entity<Product>().HasData(fakeProductGenerate);
            builder.Entity<ShoppingCart>().Ignore(c => c.Name);        

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(w =>
                w.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning));
        }
    }
}
