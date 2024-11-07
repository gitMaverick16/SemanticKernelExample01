using Microsoft.EntityFrameworkCore;
using SemanticKernelExample01.Models;

namespace SemanticKernelExample01.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Premium Basmati Rice",
                    Description = "Long-grain rice with a light texture, ideal for curries and Asian cuisine. Its natural fragrance and fluffy grains make it perfect for side dishes and fresh salads.",
                    Price = 10.99M,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFB9BUTloCAxUTEZkX73j2cz7sp7nZFWx1KQ&s",
                    Category = "Food"
                },
                new Product
                {
                    Id = 2,
                    Name = "Artisanal Extra Virgin Olive Oil",
                    Description = "Cold-pressed olive oil with a smooth, fruity flavor. Ideal for dressings, marinades, and as a finishing touch for Mediterranean dishes. No additives, 100% natural.",
                    Price = 10.99M,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFB9BUTloCAxUTEZkX73j2cz7sp7nZFWx1KQ&s",
                    Category = "Food"
                },
                new Product
                {
                    Id = 3,
                    Name = "Low-Sodium Soy Sauce",
                    Description = "Soy sauce made with reduced salt for authentic flavor without excess sodium. Perfect for adding an Asian touch to stir-fries, marinades, and sauces.",
                    Price = 10.99M,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFB9BUTloCAxUTEZkX73j2cz7sp7nZFWx1KQ&s",
                    Category = "Food"
                },
                new Product
                {
                    Id = 4,
                    Name = "Angus Beef for Grilling",
                    Description = "Premium cut of Angus beef selected for its marbling and intense flavor. Ideal for grilling and barbecues, with a juicy cook and tender texture.",
                    Price = 10.99M,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFB9BUTloCAxUTEZkX73j2cz7sp7nZFWx1KQ&s",
                    Category = "Food"
                },
                new Product
                {
                    Id = 5,
                    Name = "Gourmet Mixed Nuts",
                    Description = "Blend of walnuts, almonds, cranberries, and raisins. A healthy snack option, ideal for pairing with yogurt or salads, with no added sugars.",
                    Price = 10.99M,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFB9BUTloCAxUTEZkX73j2cz7sp7nZFWx1KQ&s",
                    Category = "Food"
                },
                new Product
                {
                    Id = 6,
                    Name = "Parmigiano Reggiano Cheese",
                    Description = "Italian Parmesan aged for 24 months, with a strong flavor and crumbly texture. Perfect for grating over pasta, salads, and risottos.",
                    Price = 10.99M,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFB9BUTloCAxUTEZkX73j2cz7sp7nZFWx1KQ&s",
                    Category = "Food"
                },
                new Product
                {
                    Id = 7,
                    Name = "Premium Colombian Coffee Beans",
                    Description = "Colombian coffee with a medium roast, offering a balanced flavor with fruity notes. Ideal for French press or espresso preparations, delivering an authentic experience.",
                    Price = 10.99M,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFB9BUTloCAxUTEZkX73j2cz7sp7nZFWx1KQ&s",
                    Category = "Food"
                },
                new Product
                {
                    Id = 8,
                    Name = "Smoked Salmon Fillets",
                    Description = "Cold-smoked salmon with a delicate texture and flavor. Ideal for bagels, salads, or enjoying solo with a squeeze of lemon.",
                    Price = 10.99M,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFB9BUTloCAxUTEZkX73j2cz7sp7nZFWx1KQ&s",
                    Category = "Food"
                },
                new Product
                {
                    Id = 9,
                    Name = "Organic Honey",
                    Description = "Raw, unfiltered honey harvested from wildflowers. Rich in antioxidants, it’s ideal for sweetening drinks, dressings, and baking recipes.",
                    Price = 10.99M,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFB9BUTloCAxUTEZkX73j2cz7sp7nZFWx1KQ&s",
                    Category = "Food"
                },
                new Product
                {
                    Id = 10,
                    Name = "Malbec Reserva Red Wine",
                    Description = "Special vintage Malbec with intense flavor and notes of red fruits and spices. Ideal to pair with red meats, cheeses, and pasta.",
                    Price = 10.99M,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFB9BUTloCAxUTEZkX73j2cz7sp7nZFWx1KQ&s",
                    Category = "Food"
                },
                new Product
                {
                    Id = 11,
                    Name = "Organic Whole Wheat Flour",
                    Description = "Flour made from organically grown whole wheat, perfect for healthy baking and pastry recipes. Provides more fiber and flavor than traditional white flour.",
                    Price = 10.99M,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFB9BUTloCAxUTEZkX73j2cz7sp7nZFWx1KQ&s",
                    Category = "Food"
                },
                new Product
                {
                    Id = 12,
                    Name = "Matcha Green Tea Powder",
                    Description = "Japanese-origin matcha green tea powder, rich in antioxidants and perfect for preparing drinks, smoothies, or desserts with a natural energy boost.",
                    Price = 10.99M,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFB9BUTloCAxUTEZkX73j2cz7sp7nZFWx1KQ&s",
                    Category = "Food"
                }
            );
        }
    }
}
