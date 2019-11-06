using DAB_Assignment_2.Models;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Data;
using System.Linq;
using System.Text;

namespace DAB_Assignment_2.DAL
{
    public class WaiterRepository : IDisposable
    {
        private AppDbContext context;

        public WaiterRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Waiter> GetWaiters()
        {
            return context.Waiters.ToList();
        }

        public Waiter GetWaiterByID(int id)
        {
            return context.Waiters.Find(id);
        }

        public void InsertWaiter(Waiter waiter)
        {
            context.Waiters.Add(waiter);
        }

        public void DeleteTable(int Id)
        {
            Waiter waiter = context.Waiters.Find(Id);
            context.Waiters.Remove(waiter);
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
