﻿// <auto-generated />
using System;
using DAB_Assignment_2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAB_Assignment_2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191107182603_ini67")]
    partial class ini67
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAB_Assignment_2.Models.Dish", b =>
                {
                    b.Property<int>("DishId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DishName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("RestaurantAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<string>("RestaurantName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DishId");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("DAB_Assignment_2.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("DAB_Assignment_2.Models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("AverageRating")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RestaurantId");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("DAB_Assignment_2.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfVisit")
                        .HasColumnType("datetime2");

                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<string>("DishName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GuestId")
                        .HasColumnType("int");

                    b.Property<string>("RestaurantAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<string>("RestaurantName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReviewerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReviewId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("DAB_Assignment_2.Models.Table", b =>
                {
                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int>("WaiterId")
                        .HasColumnType("int");

                    b.HasKey("TableId");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("WaiterId");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("DAB_Assignment_2.RelationshipClasses.GuestDish", b =>
                {
                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<int>("GuestId")
                        .HasColumnType("int");

                    b.HasKey("DishId", "GuestId");

                    b.HasIndex("GuestId");

                    b.ToTable("GuestDish");
                });

            modelBuilder.Entity("DAB_Assignment_2.RelationshipClasses.RestaurantDish", b =>
                {
                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("DishId", "RestaurantId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("RestaurantDishes");
                });

            modelBuilder.Entity("DAB_Assignment_2.RelationshipClasses.ReviewDish", b =>
                {
                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<int>("ReviewId")
                        .HasColumnType("int");

                    b.HasKey("DishId", "ReviewId");

                    b.HasIndex("ReviewId");

                    b.ToTable("ReviewDish");
                });

            modelBuilder.Entity("DAB_Assignment_2.RelationshipClasses.ReviewGuest", b =>
                {
                    b.Property<int>("GuestId")
                        .HasColumnType("int");

                    b.Property<int>("ReviewId")
                        .HasColumnType("int");

                    b.HasKey("GuestId", "ReviewId");

                    b.HasIndex("ReviewId");

                    b.ToTable("ReviewGuests");
                });

            modelBuilder.Entity("DAB_Assignment_2.Models.Guest", b =>
                {
                    b.HasBaseType("DAB_Assignment_2.Models.Person");

                    b.Property<DateTime>("DateOfVisit")
                        .HasColumnType("datetime2");

                    b.Property<int>("GuestId")
                        .HasColumnType("int");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.HasIndex("TableId");

                    b.HasDiscriminator().HasValue("Guest");
                });

            modelBuilder.Entity("DAB_Assignment_2.Models.Waiter", b =>
                {
                    b.HasBaseType("DAB_Assignment_2.Models.Person");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<int>("WaiterId")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Waiter");
                });

            modelBuilder.Entity("DAB_Assignment_2.Models.Review", b =>
                {
                    b.HasOne("DAB_Assignment_2.Models.Restaurant", "Restaurant")
                        .WithMany("Reviews")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DAB_Assignment_2.Models.Table", b =>
                {
                    b.HasOne("DAB_Assignment_2.Models.Restaurant", "Restaurant")
                        .WithMany("Tables")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DAB_Assignment_2.Models.Waiter", "Waiter")
                        .WithMany("Tables")
                        .HasForeignKey("WaiterId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DAB_Assignment_2.RelationshipClasses.GuestDish", b =>
                {
                    b.HasOne("DAB_Assignment_2.Models.Dish", "Dish")
                        .WithMany("GuestDishes")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAB_Assignment_2.Models.Guest", "Guest")
                        .WithMany("GuestDishes")
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAB_Assignment_2.RelationshipClasses.RestaurantDish", b =>
                {
                    b.HasOne("DAB_Assignment_2.Models.Dish", "Dish")
                        .WithMany("RestaurantDishes")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DAB_Assignment_2.Models.Restaurant", "Restaurant")
                        .WithMany("RestaurantDishes")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DAB_Assignment_2.RelationshipClasses.ReviewDish", b =>
                {
                    b.HasOne("DAB_Assignment_2.Models.Dish", "Dish")
                        .WithMany("ReviewDishes")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DAB_Assignment_2.Models.Review", "Review")
                        .WithMany("ReviewDishes")
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DAB_Assignment_2.RelationshipClasses.ReviewGuest", b =>
                {
                    b.HasOne("DAB_Assignment_2.Models.Guest", "Guest")
                        .WithMany("ReviewGuests")
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DAB_Assignment_2.Models.Review", "Review")
                        .WithMany("ReviewGuests")
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DAB_Assignment_2.Models.Guest", b =>
                {
                    b.HasOne("DAB_Assignment_2.Models.Table", "Table")
                        .WithMany("Guests")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
