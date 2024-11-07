using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SemanticKernelExample01.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Food", "Long-grain rice with a light texture, ideal for curries and Asian cuisine. Its natural fragrance and fluffy grains make it perfect for side dishes and fresh salads.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFB9BUTloCAxUTEZkX73j2cz7sp7nZFWx1KQ&s", "Premium Basmati Rice", 10.99m },
                    { 2, "Food", "Cold-pressed olive oil with a smooth, fruity flavor. Ideal for dressings, marinades, and as a finishing touch for Mediterranean dishes. No additives, 100% natural.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFB9BUTloCAxUTEZkX73j2cz7sp7nZFWx1KQ&s", "Artisanal Extra Virgin Olive Oil", 10.99m },
                    { 3, "Food", "Soy sauce made with reduced salt for authentic flavor without excess sodium. Perfect for adding an Asian touch to stir-fries, marinades, and sauces.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFB9BUTloCAxUTEZkX73j2cz7sp7nZFWx1KQ&s", "Low-Sodium Soy Sauce", 10.99m },
                    { 4, "Food", "Premium cut of Angus beef selected for its marbling and intense flavor. Ideal for grilling and barbecues, with a juicy cook and tender texture.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFB9BUTloCAxUTEZkX73j2cz7sp7nZFWx1KQ&s", "Angus Beef for Grilling", 10.99m },
                    { 5, "Food", "Blend of walnuts, almonds, cranberries, and raisins. A healthy snack option, ideal for pairing with yogurt or salads, with no added sugars.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFB9BUTloCAxUTEZkX73j2cz7sp7nZFWx1KQ&s", "Gourmet Mixed Nuts", 10.99m },
                    { 6, "Food", "Italian Parmesan aged for 24 months, with a strong flavor and crumbly texture. Perfect for grating over pasta, salads, and risottos.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFB9BUTloCAxUTEZkX73j2cz7sp7nZFWx1KQ&s", "Parmigiano Reggiano Cheese", 10.99m },
                    { 7, "Food", "Colombian coffee with a medium roast, offering a balanced flavor with fruity notes. Ideal for French press or espresso preparations, delivering an authentic experience.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFB9BUTloCAxUTEZkX73j2cz7sp7nZFWx1KQ&s", "Premium Colombian Coffee Beans", 10.99m },
                    { 8, "Food", "Cold-smoked salmon with a delicate texture and flavor. Ideal for bagels, salads, or enjoying solo with a squeeze of lemon.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFB9BUTloCAxUTEZkX73j2cz7sp7nZFWx1KQ&s", "Smoked Salmon Fillets", 10.99m },
                    { 9, "Food", "Raw, unfiltered honey harvested from wildflowers. Rich in antioxidants, it’s ideal for sweetening drinks, dressings, and baking recipes.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFB9BUTloCAxUTEZkX73j2cz7sp7nZFWx1KQ&s", "Organic Honey", 10.99m },
                    { 10, "Food", "Special vintage Malbec with intense flavor and notes of red fruits and spices. Ideal to pair with red meats, cheeses, and pasta.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFB9BUTloCAxUTEZkX73j2cz7sp7nZFWx1KQ&s", "Malbec Reserva Red Wine", 10.99m },
                    { 11, "Food", "Flour made from organically grown whole wheat, perfect for healthy baking and pastry recipes. Provides more fiber and flavor than traditional white flour.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFB9BUTloCAxUTEZkX73j2cz7sp7nZFWx1KQ&s", "Organic Whole Wheat Flour", 10.99m },
                    { 12, "Food", "Japanese-origin matcha green tea powder, rich in antioxidants and perfect for preparing drinks, smoothies, or desserts with a natural energy boost.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFB9BUTloCAxUTEZkX73j2cz7sp7nZFWx1KQ&s", "Matcha Green Tea Powder", 10.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
