﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAB_Assignment_2.Models;
using Microsoft.EntityFrameworkCore;

namespace DAB_Assignment_2.DAL
{
    public class Views
    {
        public IEnumerable<Restaurant> MethodA(string type)
        {
            AppDbContext context = new AppDbContext();
            //context.Restaurants.Find
            //context.Restaurants.Where(p => p.Type.StartsWith(type)).ToList();
            var restaurants = context.Restaurants
                .Where(p => p.Type.StartsWith(type))
                .Include(p => p.Name)
                .Include(p => p.AverageRating)
                .Include(p => p.Reviews.
                    Select(r => r.Text).Take(5))
                .ToList();
            return restaurants;
        }

        public IEnumerable<Restaurant> MethodB(string address)
        {
            AppDbContext context = new AppDbContext();
            var restaurant = context.Restaurants
                .Where(r => r.Address.StartsWith(address))
                .Include(r => r.RestaurantDishes
                    .Select(d => d.Dish)
                    .Select(d => new {d.DishName, d.Price}))
                .Include(r => r.AverageRating)
                .ToList();
            return restaurant;
        }

        public void MethodC(string address)
        {
            AppDbContext context = new AppDbContext();
            foreach (var rest in context.Restaurants.Where(r => r.Name.StartsWith(address)))
            {
                foreach (var table in context.Tables)
                {
                    if (table.RestaurantId == rest.RestaurantId)
                    {
                        Console.WriteLine($"Bord nr. {table.TableId}: ");
                        foreach (var review in context.Reviews)
                        {
                            if (review.TableId == table.TableId)
                            {
                                Console.WriteLine($"{review.DishName}, {review.Stars} \n {review.Text}");
                            }
                        }
                    }

                }
            }
        }

        //public IEnumerable<Restaurant> MethodD(string address)
        //{
        //    AppDbContext context = new AppDbContext();
        //    var restaurants = context.Restaurants
        //        .Join(context.Guests, cu => cu.RestaurantId, p => p.)
        //}
    }
}
