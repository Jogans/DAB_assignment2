using DAB_Assignment_2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data;
using System.Linq;
using System.Text;

namespace DAB_Assignment_2.DAL
{
    public class PersonRepository : IDisposable
    {
        private AppDbContext context;

        public PersonRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Person> GetPersons()
        {
            return context.Persons.ToList();
        }

        public Person GetPersonByID(int id)
        {
            return context.Persons.Find(id);
        }

        public void InsertPerson(Person person)
        {
            context.Persons.Add(person);
        }

        public void DeletePerson(int PersonId)
        {
            Person person = context.Persons.Find(PersonId);
            context.Persons.Remove(person);
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
