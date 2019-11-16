using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using DAB_Assignment_2.Models;
using Microsoft.EntityFrameworkCore;
using DAB_Assignment_2.RelationshipClasses;

namespace DAB_Assignment_2.Data
{
    class InsertData
    {
        public void InsertRestaurant(AppDbContext context)
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Address");
            string address = Console.ReadLine(); 

            Console.WriteLine("Enter Type");
            string type = Console.ReadLine();

            var restaurants = new Restaurant[]
            {
                new Restaurant
                {
                    Name = name,
                    Address = address,
                    AverageRating = 0,
                    Type = type,
                },
            };
            foreach (Restaurant c in restaurants)
            {
                context.Restaurants.Add(c);
            }
            context.SaveChanges();
        }
    }
}
