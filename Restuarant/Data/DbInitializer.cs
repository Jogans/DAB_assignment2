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

            var restaurants = new RestaurantClass[]
            {
                new RestaurantClass{Name = "Bob's Place", Address = "Mordor Lane 35", AverageRating = 2, Type = "Dessert"},
                new RestaurantClass{Name = "The Golden Seagull", Address = "Fast Food Road 88", AverageRating = 4, Type = "Dinner"},
                new RestaurantClass{Name = "Jelle's Icecream Bar", Address = "Candy Way 15", AverageRating = 0.1, Type = "Dessert"},
                new RestaurantClass{Name = "Nicolo's Pizza", Address = "Growl Hill 32", AverageRating = 3, Type = "Lunch"},
                new RestaurantClass{Name = "Jogan's Fine Dining", Address = "Fancy Boulevard 1", AverageRating = 1, Type = "Dinner"},
                new RestaurantClass{Name = "Frederico's Breakfast", Address = "Early Bird 75", AverageRating = 3.5, Type = "Breakfast"},
                new RestaurantClass{Name = "Pregante's Sanwitch", Address = "Strange Green 2", AverageRating = 1, Type = "Lunch"},
                new RestaurantClass{Name = "Only Coffee", Address = "Sleepy Road 14", AverageRating = 5, Type = "Breakfast"},


            };
            foreach (RestaurantClass c in restaurants)
            {
                context.Restaurants.Add(c);
            }
            context.SaveChanges();

            var dishes = new Dish[]
            {
                new Dish{DishName = "Cheese Burger", Price = 14, Type = "Main Course"},
                new Dish{DishName = "Bananasplit", Price = 20, Type = "Dessert"},
                new Dish{DishName = "Breadsticks", Price = 10, Type = "Appetizer"},
                new Dish{DishName = "T-Bone", Price = 120, Type = "Main Course"},
                new Dish{DishName = "Sirloin Steak", Price = 110, Type = "Main Course"},
                new Dish{DishName = "Muffin", Price = 15, Type = "Dessert"},
                new Dish{DishName = "King Crabs", Price = 40, Type = "Appetizer"},
                new Dish{DishName = "Hamburger", Price = 12, Type = "Main Course"},
                new Dish{DishName = "Bacon Orionrings", Price = 33, Type = "Appetizer"},
                new Dish{DishName = "Hashbrowns", Price = 20, Type = "Appetizer"},
                new Dish{DishName = "Milkshake", Price = 30, Type = "Dessert"},
                new Dish{DishName = "Pizza Slice", Price = 20, Type = "Main Course"},
                new Dish{DishName = "Dates with Bacon", Price = 30, Type = "Appetizer"},
                new Dish{DishName = "Chilli Chesse Tops", Price = 8, Type = "Appetizer"},
                new Dish{DishName = "Pain au Chocolat", Price = 8, Type = "Appetizer"},
                new Dish{DishName = "Ice Cream", Price = 12, Type = "Dessert"},
                new Dish{DishName = "Coffee", Price = 15, Type = "Dessert"},

            };
            foreach (Dish d in dishes)
            {
                context.Dishes.Add(d);
            }
            context.SaveChanges();

            var restaurantDishes = new RestaurantDish[]
            {
                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Breadsticks").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Bob's Place").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Milkshake").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Bob's Place").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Pain au Chocolat").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Bob's Place").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Muffin").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Bob's Place").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Bacon Orionrings").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Cheese Burger").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Hamburger").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Milkshake").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Bananasplit").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Ice Cream").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Milkshake").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Muffin").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Breadsticks").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Pizza Slice").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Hamburger").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Milkshake").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Dates with Bacon").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "King Crabs").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "T-Bone").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Sirloin Steak").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Pain au Chocolat").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Hashbrowns").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Frederico's Breakfast").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Breadsticks").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Frederico's Breakfast").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Milkshake").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Frederico's Breakfast").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Cheese Burger").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Pregante's Sanwitch").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Hamburger").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Pregante's Sanwitch").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Coffee").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Only Coffee").RestaurantId
                },

            };

            

            var persons = new Person[]
            {
                new Person{Name = "Jens Jensen"},
                new Person{Name = "Anders Andersen"},
                new Person{Name = "Hanne Hansen"},
                new Person{Name = "Christiane Christiansen"},
                new Person{Name = "Trine Triger"},
                new Person{Name = "Charlotte Charlottenborg"},
                new Person{Name = "Rasmus Rasmussen"},
                new Person{Name = "Nicolai Nicolajsen"},
                new Person{Name = "Frederik Frederico"},
                new Person{Name = "Jesper Jespersen"},
                new Person{Name = "Mette Metz"},
                new Person{Name = "Anna Antonsen"},
                new Person{Name = "A. Nelprober"},
                new Person{Name = "A.S. Muncher"},
                new Person{Name = "Anita Dick"},
                new Person{Name = "Ben Derhover"},
                new Person{Name = "Dick Long"},
                new Person{Name = "Dixon B. Tweenerlegs"},
                new Person{Name = "Dixon Butts"},
                new Person{Name = "Harry Nutt"},
                new Person{Name = "Hugh Janus"},
                new Person{Name = "Ivana Fuccu"},
                new Person{Name = "Ivanna B. Spanked"},
                new Person{Name = "Mike Hunt"},
                new Person{Name = "Moe Lester"},
                new Person{Name = "Phil McAvity"},
                new Person{Name = "Wilma Dickfit"},
                new Person{Name = "Ho Lee Fuk"},
            };
            foreach (Person p in persons)
            {
                context.Persons.Add(p);
            }
            context.SaveChanges();

            //Tilføj ting her



            //Tilføj ting her

            context.SaveChanges();
        }
    }
}
