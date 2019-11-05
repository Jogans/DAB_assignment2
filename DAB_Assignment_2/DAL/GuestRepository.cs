using DAB_Assignment_2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data;
using System.Linq;
using System.Text;

namespace DAB_Assignment_2.DAL
{
    public class GuestRepository : IDisposable
    {
        private AppDbContext context;

        public GuestRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Guest> GetGuests()
        {
            return context.Guests.ToList();
        }

        public Guest GetGuestByID(int id)
        {
            return context.Guests.Find(id);
        }

        public void InsertGuest(Guest guest)
        {
            context.Guests.Add(guest);
        }

        public void DeleteGuest(int GuestId)
        {
            Guest guest = context.Guests.Find(GuestId);
            context.Guests.Remove(guest);
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
