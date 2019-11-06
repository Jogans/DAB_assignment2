using DAB_Assignment_2.Models;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Data;
using System.Linq;
using System.Text;

namespace DAB_Assignment_2.DAL
{
    public class RestaurantRepository : IDisposable
    {
        private AppDbContext context;

        public RestaurantRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Restaurant> GetRestaurants()
        {
            return context.Restaurants.ToList();
        }

        public Restaurant GetRestaurantByID(int id)
        {
            return context.Restaurants.Find(id);
        }

        public void InsertRestaurant(Restaurant restaurant)
        {
            context.Restaurants.Add(restaurant);
        }

        public void DeleteRestaurant(int RestaurantId)
        {
            Restaurant restaurant = context.Restaurants.Find(RestaurantId);
            context.Restaurants.Remove(restaurant);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
