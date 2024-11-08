using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using DemoExamVar4.Database.Models;

namespace DemoExamVar4.Database;

public partial class AppDbContext : DbContext
{
    public AppDbContext() {}

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Dish> Dishes { get; set; }

    public virtual DbSet<DishIngredient> DishIngredients { get; set; }

    public virtual DbSet<DishOrder> DishOrders { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Ingredient> Ingredients { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Table> Tables { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DemoExamVar4;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("category");

            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Dish>(entity =>
        {
            entity.ToTable("dish");

            entity.Property(e => e.DishId).HasColumnName("dish_id");
            entity.Property(e => e.Availability).HasColumnName("availability");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.VolumeWeight)
                .HasMaxLength(50)
                .HasColumnName("volume_weight");

            entity.HasOne(d => d.Category).WithMany(p => p.Dishes)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dish_category");
        });

        modelBuilder.Entity<DishIngredient>(entity =>
        {
            entity.ToTable("dish_ingredient");

            entity.Property(e => e.DishIngredientId)
                .ValueGeneratedNever()
                .HasColumnName("dish_ingredient_id");
            entity.Property(e => e.DishId).HasColumnName("dish_id");
            entity.Property(e => e.IngredientId).HasColumnName("ingredient_id");
            entity.Property(e => e.Quanitity).HasColumnName("quanitity");

            entity.HasOne(d => d.Dish).WithMany(p => p.DishIngredients)
                .HasForeignKey(d => d.DishId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dishIngredient_dish");

            entity.HasOne(d => d.Ingredient).WithMany(p => p.DishIngredients)
                .HasForeignKey(d => d.IngredientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dishIngredient_ingredient");
        });

        modelBuilder.Entity<DishOrder>(entity =>
        {
            entity.ToTable("dish_order");

            entity.Property(e => e.DishOrderId).HasColumnName("dish_order_id");
            entity.Property(e => e.DishId).HasColumnName("dish_id");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.StatusId).HasColumnName("status_id");

            entity.HasOne(d => d.Dish).WithMany(p => p.DishOrders)
                .HasForeignKey(d => d.DishId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dishOrder_dish");

            entity.HasOne(d => d.Order).WithMany(p => p.DishOrders)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dishOrder_order");

            entity.HasOne(d => d.Status).WithMany(p => p.DishOrders)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dishOrder_status");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable("employee");

            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .HasColumnName("lastname");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.Salary).HasColumnName("salary");
            entity.Property(e => e.Suname)
                .HasMaxLength(50)
                .HasColumnName("suname");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Role).WithMany(p => p.Employees)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_employee_role");

            entity.HasOne(d => d.User).WithMany(p => p.Employees)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_employee_user");
        });

        modelBuilder.Entity<Ingredient>(entity =>
        {
            entity.ToTable("ingredient");

            entity.Property(e => e.IngredientId).HasColumnName("ingredient_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Volume).HasColumnName("volume");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.ToTable("order");

            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.TableId).HasColumnName("table_id");

            entity.HasOne(d => d.Employee).WithMany(p => p.Orders)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_order_employee");

            entity.HasOne(d => d.Table).WithMany(p => p.Orders)
                .HasForeignKey(d => d.TableId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_order_table");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("role");

            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.ToTable("status");

            entity.Property(e => e.StatusId).HasColumnName("status_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Table>(entity =>
        {
            entity.ToTable("table");

            entity.Property(e => e.TableId).HasColumnName("table_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("user");

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
