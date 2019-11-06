using DAB_Assignment_2.Models;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Data;
using System.Linq;
using System.Text;

namespace DAB_Assignment_2.DAL
{
    public class TableRepository : IDisposable
    {
        private AppDbContext context;

        public TableRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Table> GetTables()
        {
            return context.Tables.ToList();
        }

        public Table GetTableByID(int id)
        {
            return context.Tables.Find(id);
        }

        public void InsertTable(Table table)
        {
            context.Tables.Add(table);
        }

        public void DeleteTable(int Id)
        {
            Table table = context.Tables.Find(Id);
            context.Tables.Remove(table);
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
