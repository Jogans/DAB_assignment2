using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restuarant.Data;
using Restuarant.Models;

namespace Restaurant.Data
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            //Tilføj ting her
            
            context.SaveChanges();

            // Eksempel på indsættelse

            List<Person> PersonList = new List<Person>();
            for (int i = 0; i < 27; i++)
            {
                PersonList.Add(new Person());
            }

            PersonList[0].Name = "Jens Jensen";
            PersonList[1].Name = "Anders Andersen";
            PersonList[2].Name = "Hanne Hansen";
            PersonList[3].Name = "Christiane Christiansen";
            PersonList[4].Name = "Trine Triger";
            PersonList[5].Name = "Charlotte Charlottenborg";
            PersonList[6].Name = "Rasmus Rasmussen";
            PersonList[7].Name = "Nicolai Nicolajsen";
            PersonList[8].Name = "Frederik Frederico";
            PersonList[9].Name = "Jesper Jespersen";
            PersonList[10].Name = "Mette Metz";
            PersonList[11].Name = "Anna Antonsen";
            PersonList[2].Name = "A. Nelprober";
            PersonList[2].Name = "A.S. Muncher";
            PersonList[2].Name = "";
            PersonList[2].Name = "";
            PersonList[2].Name = "";
            PersonList[2].Name = "";
            PersonList[2].Name = "";
            PersonList[2].Name = "";
            PersonList[2].Name = "";
            PersonList[2].Name = "";
            PersonList[2].Name = "";



            //var person = new Person[]
            //{
            //    new Person{}
            //};



            //Tilføj ting her

            context.SaveChanges();

            //Tilføj ting her

            context.SaveChanges();
        }
    }
}
