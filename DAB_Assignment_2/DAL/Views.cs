using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAB_Assignment_2.Models;
using DAB_Assignment_2.RelationshipClasses;
using Microsoft.EntityFrameworkCore;

namespace DAB_Assignment_2.DAL
{
    public class Views
    {
        public void MethodA(string type, AppDbContext context)
        {
            //context.Restaurants.Find
            //context.Restaurants.Where(p => p.Type.StartsWith(type)).ToList();
            //var restaurants = context.Restaurants
            //    .Where(p => p.Type.StartsWith(type))
            //    .Include(p => p.Name)
            //    .Include(p => p.AverageRating)
            //    .Include(p => p.Reviews.
            //        Select(r => r.Text).Take(5))
            //    .ToList();

            //foreach (var r in restaurants)
            //{
            //    Console.WriteLine($"Restaurants:\t {r}");
            //}
            foreach (var ting in context.Restaurants.Where(r => r.Type.Contains(type)))
            {
                var streng = context.Reviews.Where(r => r.RestaurantId == ting.RestaurantId).Select(r => r.Text).Take(5).AsNoTracking().ToList();
                Console.WriteLine($"{ting.Name} - Type: {ting.Type}");
                var rating =
                    from relevantRestaurant in context.Reviews
                    group relevantRestaurant by relevantRestaurant.RestaurantId into g
                    select new
                    {
                        g.Key,
                        arvgStar = g.Average(p => p.Stars)
                    };
                foreach (var rat in rating)
                {
                    if (ting.RestaurantId == rat.Key)
                    {
                        Console.Write("Average rating: {0}\n", rat.arvgStar);
                    }
                }
                Console.WriteLine($"Latest five reviews: ");
                for (int i = 0; i < streng.Count; i++)
                {
                    Console.WriteLine($"\t Review {i + 1}: {streng[i]}\n");
                }
            }
        }

        public void MethodB(string address, AppDbContext context)
        {
            foreach (var ting in context.Restaurants.Where(r => r.Address.Contains(address)))
            {
                Console.Write("Restaurant Name: {0}\n", ting.Name);

                Console.Write("The Menu consists of:");
                
                for (int i = 0; i < ting.RestaurantDishes.Count; i++)
                {
                    var streng = context.Reviews.Where(r => r.DishId == ting.RestaurantDishes[i].DishId).Select(r => r.Text).Take(5).AsNoTracking().ToList();

                    Console.Write("{$}", ting.RestaurantDishes[i].Dish.DishName);
                    
                    var rating =
                        from relevantRestaurant in context.Reviews 
                        group relevantRestaurant by relevantRestaurant.DishId into g
                        select new
                        {
                            g.Key,
                            arvgStar = g.Average(p => p.Stars)
                        };
                    foreach (var rat in rating)
                    {
                        if (ting.RestaurantDishes[i].DishId == rat.Key)
                        {
                            Console.Write("Average rating: {0}\n", rat.arvgStar);
                        }
                    }
                }
               
            }
        }

        public void MethodC(string address, AppDbContext context)
        {
            foreach (var rest in context.Restaurants.Where(r => r.Address.StartsWith(address)))
            {
                foreach (var table in context.Tables)
                {
                    if (table.RestaurantId == rest.RestaurantId)
                    {
                        Console.WriteLine($"Bord nr. {table.TableId}: ");
                        foreach (var review in context.Reviews)
                        {
                            if (review.RestaurantId == rest.RestaurantId)
                            {
                                Console.WriteLine($"Review by {review.ReviewerName} for dish {review.DishName} - Stars: {review.Stars} \n {review.Text} \n");
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
