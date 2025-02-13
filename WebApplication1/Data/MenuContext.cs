using Microsoft.EntityFrameworkCore;
using Menu.Models;

namespace Menu.Data
{

    public class MenuContext:DbContext

    {
        public MenuContext(DbContextOptions<MenuContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishIngredient>().HasKey(di => new 
            { 
                di.DishId, 
                di.IngredientId
            }
            );
            modelBuilder.Entity<DishIngredient>().HasOne(d => d.Dish).WithMany(di => di.DishIngredients).HasForeignKey(d => d.DishId);
            modelBuilder.Entity<DishIngredient>().HasOne(i => i.Ingredient).WithMany(di => di.DishIngredients).HasForeignKey(i => i.IngredientId);

            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    Id = 1,
                    Name = "Pizza",
                    Description = "Cheese Pizza",
                    Price = 12.50,
                    ImageUrl = "https://images.unsplash.com/photo-1594007654729-407eedc4be65?q=80&w=1456&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
                    
                }
                );
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient
                {
                    Id = 1,
                    Name = "Cheese"
                },
                new Ingredient
                {
                    Id = 2,
                    Name = "Tomato Sauce"
                }
                );
            modelBuilder.Entity<DishIngredient>().HasData(
                new DishIngredient
                {
                    DishId = 1,
                    IngredientId = 1
                },
                new DishIngredient
                {
                    DishId = 1,
                    IngredientId = 2
                }
                );
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<DishIngredient> DishIngredients { get; set; }
    }
}
