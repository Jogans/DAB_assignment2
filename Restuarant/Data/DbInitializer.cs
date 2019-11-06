using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurant.Data;
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
            PersonList[12].Name = "A. Nelprober";
            PersonList[13].Name = "A.S. Muncher";
            PersonList[14].Name = "Anita Dick";
            PersonList[15].Name = "Ben Derhover";
            PersonList[16].Name = "Dick Long";
            PersonList[17].Name = "Dixon B. Tweenerlegs";
            PersonList[18].Name = "Dixon Butts";
            PersonList[19].Name = "Harry Nutt";
            PersonList[20].Name = "Hugh Janus";
            PersonList[21].Name = "Ivana Fuccu";
            PersonList[22].Name = "Ivanna B. Spanked";
            PersonList[23].Name = "Mike Hunt";
            PersonList[24].Name = "Moe Lester";
            PersonList[25].Name = "Phil McAvity";
            PersonList[26].Name = "Wilma Dickfit";
            PersonList[27].Name = "Ho Lee Fuk";

            foreach (Person s in PersonList)
            {
                context.Persons.Add(s);
            }

            //Tilføj ting her

            var restaurants = new RestaurantClass[]
            {
                new RestaurantClass{Name = "Bob's Place", Address = "Mordor Lane 35", AverageRating = 2, Type = "Dessert"},
                new RestaurantClass{Name = "The Golden Seagull", Address = "Fast Food Road 88", AverageRating = 4, Type = "Dinner"},
                new RestaurantClass{Name = "Jelle's Icecream Bar", Address = "Candy Way 15", AverageRating = 5, Type = "Dessert"},
                new RestaurantClass{Name = "Nicolo's Pizza", Address = "Growl Hill 32", AverageRating = 3, Type = "Lunch"},
                new RestaurantClass{Name = "Jogan's Fine Dining", Address = "Fancy Boulevard 1", AverageRating = 1, Type = "Dinner"},
                new RestaurantClass{Name = "Frederico's Breakfast", Address = "Early Bird 75", AverageRating = 3, Type = "Breakfast"},
                new RestaurantClass{Name = "Pregante's Sanwitch", Address = "Strange Green 2", AverageRating = 1, Type = "Lunch"},
                new RestaurantClass{Name = "Only Coffee", Address = "Sleepy Road 14", AverageRating = 5, Type = "Breakfast"},


            };
            foreach (RestaurantClass c in restaurants)
            {
                context.Restaurants.Add(c);
            }
            context.SaveChanges();

            //Tilføj ting her

            context.SaveChanges();
        }
    }
}
