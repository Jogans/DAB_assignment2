using DAB_Assignment_2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data;
using System.Linq;
using System.Text;

namespace DAB_Assignment_2.DAL
{
    public class ReviewRepository : IDisposable
    {
        private AppDbContext context;

        public ReviewRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Review> GetReviews()
        {
            return context.Reviews.ToList();
        }

        public Review GetReviewByID(int id)
        {
            return context.Reviews.Find(id);
        }

        public void InsertReview(Review recipe)
        {
            context.Reviews.Add(recipe);
        }

        public void DeleteReview(int ReviewId)
        {
            Review review = context.Reviews.Find(ReviewId);
            context.Reviews.Remove(review);
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
