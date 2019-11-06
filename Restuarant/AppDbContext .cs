﻿using System;
using System.Collections.Generic;
using System.Text;
//using System.Data.EntityClient;
//using System.Data.Entity;
using DAB_Assignment_2.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using DAB_Assignment_2.RelationshipClasses;

namespace DAB_Assignment_2
{
    public class AppDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Waiter> Waiters { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=restaurant.db");
            //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=StoreDB;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Restaurant
            modelBuilder.Entity<Restaurant>()
                .HasKey(a => a.RestaurantId);

            // Persons
            modelBuilder.Entity<Person>()
                .HasKey(p => p.PersonId);

            // Waiters
            modelBuilder.Entity<Waiter>()
                .HasKey(t => t.WaiterId);

            modelBuilder.Entity<Person>()
                .HasOne(p => p.Waiter)
                .WithOne(w => w.Person)
                .HasForeignKey<Waiter>();

            // Guests
            modelBuilder.Entity<Guest>()
                .HasKey(a => a.GuestId);

            modelBuilder.Entity<Person>()
                .HasOne(p => p.Guest)
                .WithOne(g => g.Person)
                .HasForeignKey<Guest>();

            modelBuilder.Entity<Guest>()
                .HasOne(g => g.Table)
                .WithMany(t => t.Guests)
                .HasForeignKey(g => g.TableId);

            // Tables
            modelBuilder.Entity<Table>()
                .HasKey(a => a.TableId);

            modelBuilder.Entity<Table>()
                .HasOne(t => t.Waiter)
                .WithMany(w => w.Tables)
                .HasForeignKey(t => t.WaiterId);

            modelBuilder.Entity<Table>()
                .HasOne(r => r.Restaurant)
                .WithMany(w => w.Tables)
                .HasForeignKey(r => r.RestaurantId);

            // Dishes
            modelBuilder.Entity<Dish>()
                .HasKey(a => a.DishId);

            modelBuilder.Entity<GuestDish>()
                .HasKey(g => new { g.DishId, g.GuestId });

            modelBuilder.Entity<GuestDish>()
                .HasOne(gd => gd.Dish)
                .WithMany(d => d.GuestDishes)
                .HasForeignKey(gd => gd.DishId);

            modelBuilder.Entity<GuestDish>()
                .HasOne(gd => gd.Guest)
                .WithMany(g => g.GuestDishes)
                .HasForeignKey(gd => gd.GuestId);


            modelBuilder.Entity<RestaurantDish>()
                .HasKey(g => new { g.DishId, g.RestaurantId });

            modelBuilder.Entity<RestaurantDish>()
                .HasOne(gd => gd.Dish)
                .WithMany(d => d.RestaurantDishes)
                .HasForeignKey(gd => gd.DishId);

            modelBuilder.Entity<RestaurantDish>()
                .HasOne(gd => gd.Restaurant)
                .WithMany(g => g.RestaurantDishes)
                .HasForeignKey(gd => gd.RestaurantId);


            modelBuilder.Entity<ReviewDish>()
                .HasKey(g => new { g.DishId, g.ReviewId });

            modelBuilder.Entity<ReviewDish>()
                .HasOne(gd => gd.Dish)
                .WithMany(d => d.ReviewDishes)
                .HasForeignKey(gd => gd.DishId);

            modelBuilder.Entity<ReviewDish>()
                .HasOne(gd => gd.Review)
                .WithMany(g => g.ReviewDishes)
                .HasForeignKey(gd => gd.ReviewId);

            // Reviews
            modelBuilder.Entity<Review>()
                .HasKey(a => a.ReviewId);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Restaurant)
                .WithMany(r => r.Reviews)
                .HasForeignKey(r => r.RestaurantId);

            modelBuilder.Entity<ReviewGuest>()
                .HasKey(g => new { g.GuestId, g.ReviewId });

            modelBuilder.Entity<ReviewGuest>()
                .HasOne(gd => gd.Guest)
                .WithMany(d => d.ReviewGuests)
                .HasForeignKey(gd => gd.GuestId);

            modelBuilder.Entity<ReviewGuest>()
                .HasOne(gd => gd.Review)
                .WithMany(g => g.ReviewGuests)
                .HasForeignKey(gd => gd.ReviewId);
        }
    }
}