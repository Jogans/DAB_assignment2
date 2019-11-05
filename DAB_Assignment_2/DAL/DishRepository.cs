using DAB_Assignment_2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data;
using System.Linq;
using System.Text;

namespace DAB_Assignment_2.DAL
{
    public class DishRepository : IDisposable
    {
        private AppDbContext context;

        public DishRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Dish> GetDishes()
        {
            return context.Dishes.ToList();
        }

        public Dish GetDishByID(int id)
        {
            return context.Dishes.Find(id);
        }

        public void InsertDish(Dish dish)
        {
            context.Dishes.Add(dish);
        }

        public void DeleteDish(int DishId)
        {
            Dish dish = context.Dishes.Find(DishId);
            context.Dishes.Remove(dish);
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
